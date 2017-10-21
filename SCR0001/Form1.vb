Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        TextBox_Hauptverzeichnis_Farbe.Text = My.Settings.Hauptverzeichnis_Farbe
        TextBox_Hauptverzeichnis_sw.Text = My.Settings.Hauptverzeichnis_sw
        TextBox_Zielverzeichnis_sw.Text = My.Settings.Zielverzeichnis_sw
        TextBox_Protokollverzeichnis.Text = My.Settings.Protokollverzeichnis
        TextBox_Backupverzeichnis.Text = My.Settings.Backupverzeichnis
        TextBox_Excel_Akte.Text = My.Settings.Excel_Akte
        'MessageBox.Show("Load erfolgreich", "Information", MessageBoxButtons.OK)
    End Sub

    'Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Hauptverzeichnis_wählen.FileOk
    'End Sub
    Private Sub Hauptverzeichnis_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Hauptverzeichnis_Farbe.TextChanged
        My.Settings.Hauptverzeichnis_Farbe = TextBox_Hauptverzeichnis_Farbe.Text
        My.Settings.Save()
    End Sub
    Private Sub TextBox_Hauptverzeichnis_sw_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Hauptverzeichnis_sw.TextChanged
        My.Settings.Hauptverzeichnis_sw = TextBox_Hauptverzeichnis_sw.Text
        My.Settings.Save()
    End Sub
    Private Sub TextBox_Zielverzeichnis_sw_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Zielverzeichnis_sw.TextChanged
        My.Settings.Zielverzeichnis_sw = TextBox_Zielverzeichnis_sw.Text
        My.Settings.Save()
    End Sub
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_Excel_Akte.TextChanged
        My.Settings.Excel_Akte = TextBox_Excel_Akte.Text
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button_Excel_Akte.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox_Excel_Akte.Text = OpenFileDialog1.FileName
        End If
        My.Settings.Excel_Akte = TextBox_Excel_Akte.Text
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Hauptverzeichnis_Farbe.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox_Hauptverzeichnis_Farbe.Text = FolderBrowserDialog.SelectedPath
        End If
        My.Settings.Hauptverzeichnis_Farbe = TextBox_Hauptverzeichnis_Farbe.Text
        My.Settings.Save()
    End Sub

    Private Sub Button_Hauptverzeichnis_sw_Click(sender As Object, e As EventArgs) Handles Button_Hauptverzeichnis_sw.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox_Hauptverzeichnis_sw.Text = FolderBrowserDialog.SelectedPath
        End If
        My.Settings.Hauptverzeichnis_sw = TextBox_Hauptverzeichnis_sw.Text
        My.Settings.Save()
    End Sub
    Private Sub Button_Zielverzeichnis_sw_Click(sender As Object, e As EventArgs) Handles Button_Zielverzeichnis_sw.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox_Zielverzeichnis_sw.Text = FolderBrowserDialog.SelectedPath
        End If
        My.Settings.Zielverzeichnis_sw = TextBox_Zielverzeichnis_sw.Text
        My.Settings.Save()
    End Sub

    Private Sub Button_Protokollverzeichnis_Click(sender As Object, e As EventArgs) Handles Button_Protokollverzeichnis.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox_Protokollverzeichnis.Text = FolderBrowserDialog.SelectedPath
        End If
        My.Settings.Protokollverzeichnis = TextBox_Protokollverzeichnis.Text
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Anzahl.Click
        ' Exeldatei mit den Metadaten je Akte öffenen und einlesen
        Dim connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 8.0;", TextBox_Excel_Akte.Text) 'Datenbankverbindung angeben'
        Dim adapter = New OleDbDataAdapter("SELECT * FROM [Tabelle1$]", connectionString) 'Verbindung zur Tabelle aufbauen'
        Dim ds = New DataSet()
        adapter.Fill(ds, "Tabelle1") 'DataSet auslesen'
        Dim ExcelDaten As DataTable = ds.Tables("Tabelle1")
        '--
        Dim pfad_sw As String
        Dim searchPatternList As New List(Of String)
        'Dim Message As String
        Dim fileList As New List(Of String)
        Dim Anzahl_Dateien, Anzahl_Verzeichnisse As Integer
        Anzahl_Dateien = 0
        '- welche Muster sollen gesucht werden
        searchPatternList.Add("*.jpg")
        searchPatternList.Add("*.tif")
        searchPatternList.Add("*.rue")
        pfad_sw = TextBox_Hauptverzeichnis_sw.Text
        pfad_sw = pfad_sw.Trim()
        If pfad_sw.Length = 0 Then
            Throw New ArgumentException("pfad_sw")
        End If
        Dim verzeichnis_anzahl_dateien As New Dictionary(Of String, Integer)
        '-- Anzahl Daten lt. Suchmuster in den Unterverzeichnissen ermitteln un in ein Dictonary eintragen zur weiteren Abarbeitung
        'Dim listBox1 As New ListBox()
        'listBox1.Size = New System.Drawing.Size(300, 100)
        'listBox1.Location = New System.Drawing.Point(170, 300)
        ' Add the ListBox to the form.
        ' Me.Controls.Add(listBox1)
        Dim directoryStack As New Stack(Of String)
        directoryStack.Push(pfad_sw)
        ' Verzeichnisse rekursiv (via Stack) durchlaufen
        Do While directoryStack.Count > 0
            Dim directory As String = directoryStack.Pop()
            'MsgBox("dir:" & directory)
            ' Einfügen der Unterverzeichnisse in den Stack
            Try
                For Each subDirectory As String In System.IO.Directory.GetDirectories(directory)
                    directoryStack.Push(subDirectory)
                    ' Dim Anzahl_jpg = My.Computer.FileSystem.GetFiles(subDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg").Count
                    Dim Anzahl_tif = My.Computer.FileSystem.GetFiles(subDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*.tif").Count
                    Dim Anzahl_rue = My.Computer.FileSystem.GetFiles(subDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*.rue").Count
                    Dim Anzahl_gesamt As Integer = Anzahl_tif + Anzahl_rue
                    verzeichnis_anzahl_dateien.Add(subDirectory, Anzahl_gesamt)
                    Anzahl_Dateien += Anzahl_gesamt
                Next
                'Me.Controls.Add(listBox1)
            Catch ex As UnauthorizedAccessException
                ' Kein Zugriff
                System.Diagnostics.Debug.WriteLine("No Directory Access " & directory)
            End Try
        Loop
        '--
        '


        '--
        Dim IndexZeileOutputTeil1, IndexZeileOutputTeil2, Namensteil(), Aktenname, NeuerName_sw, BackupName_Quelle, BackupName_Ziel, IndexDateiName, PfadnameBarcode As String
        Dim foundRows() As DataRow '- DAtenzeile aus Excel in der die Informationen für die Indexdatei einthalten sind je BArcode/Akte
        Dim pair As KeyValuePair(Of String, Integer)
        Dim counter, lfdSeitenNr As Long
        Aktenname = ""
        IndexZeileOutputTeil1 = ""
        Anzahl_Verzeichnisse = 0
        Using Protokolldatei As New IO.StreamWriter(TextBox_Protokollverzeichnis.Text & Convert.ToString("\Leseprotokoll.txt"))
            Protokolldatei.WriteLine("--------------------------------------------------------------")
            Protokolldatei.Write("Protokolldatei - Verzeichnisstruktur für Datenpaket s/w (*.tif): {0}", TextBox_Hauptverzeichnis_sw.Text)
            Protokolldatei.WriteLine(vbCrLf + "Erstellt am: {1} um {0}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString())
            Protokolldatei.WriteLine("--------------------------------------------------------------")
            Using Protokoll_Umbenennung As New IO.StreamWriter(TextBox_Protokollverzeichnis.Text & Convert.ToString("\Protokoll_Umbenennung_und_Copy.txt"))
                Using Protokoll_Fehler As New IO.StreamWriter(TextBox_Protokollverzeichnis.Text & Convert.ToString("\Protokoll_Fehler.txt"))
                    Using Protokoll_Index As New IO.StreamWriter(TextBox_Protokollverzeichnis.Text & Convert.ToString("\Index.txt"))
                        For Each pair In verzeichnis_anzahl_dateien
                            ' key = Subdirectoryname / Value = Anzahl ermittelter Dateien im Verzeichnis inkl aller Unterverzeichnisse
                            '- Protokolleintrag
                            PfadnameBarcode = Split(pair.Key, "\").Last
                            Protokolldatei.WriteLine("{0}, Anzahl Seiten: {1}", PfadnameBarcode, pair.Value)
                            Anzahl_Verzeichnisse += 1
                            ' Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
                            ' Masterprotokoll - alle gefundenen Einträge protokollieren
                            ' Write the string array to a new file named "WriteLines.txt".
                            ' zu jedem Unterordner (pair.key) nun alle Dateien analysieren
                            For Each foundFile In My.Computer.FileSystem.GetFiles(pair.Key, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                '- NAmen zerlegen, um die Endung zu erkennen und später umbenenn zu können
                                Namensteil = Split(IO.Path.GetFileName(foundFile), ".")
                                If Namensteil(1) = "tif" Or Namensteil(1) = "rue" Then
                                    counter = counter + 1 ' counter entspricht der Seite im Vorgang
                                    '- Fortschrit anzeigen 
                                    ProgressBar1.Value = (100 / Anzahl_Dateien) * counter
                                    Label9.Text = "... verarbeitet " & counter & " Dateien"
                                    '- Protokollzeile schreiben, wenn gewünscht
                                    ' Protokolldatei.WriteLine("{0} - {1}", counter, foundFile)
                                    ' - 
                                    If Aktenname <> Split(pair.Key, "\").Last Then
                                        Aktenname = Split(pair.Key, "\").Last
                                        '-- Zu dem Aktennamen gibt es eine Referenzzeile in der Exeltabelle, die zur Erzeugung der Indexdatei aller gefundenen DAteien dieser Akte verwendet werden muss.
                                        foundRows = ExcelDaten.Select("Barcode = '" & Aktenname & "'")
                                        If FieldValue(foundRows(0), "Barcode") <> ";" Then
                                            IndexZeileOutputTeil1 = FieldValue(foundRows(0), "Name")
                                            IndexZeileOutputTeil1 += FieldValue(foundRows(0), "Lage")
                                            IndexZeileOutputTeil1 += FieldValue(foundRows(0), "Personennummer")
                                            IndexZeileOutputTeil1 += FieldValue(foundRows(0), "Aktenbe-zeichnung")
                                            IndexZeileOutputTeil1 += FieldValue(foundRows(0), "Registerbe-zeichnung")
                                            '- Wenn kein Wert vorhanden ist NULL, sonst 2 Stellen mit Null auffüllen: 2; -> 02; 
                                            If FieldValue(foundRows(0), "Band") = ";" Then
                                                IndexZeileOutputTeil1 += ";"
                                            Else
                                                IndexZeileOutputTeil1 += CStr(FieldValue(foundRows(0), "Band")).PadLeft(3, "0")
                                            End If
                                            lfdSeitenNr = 0 '- Achtung die lfd Seitennummer beginnt pro Ordner(Barcode) bei 1 und ist muss pro Eintrag in der Indexdatei hochgezählt werden
                                            '   0 "Barcode"
                                            '1 "Kontrolle doppelte Barcode"
                                            '2 "Name"
                                            '3 "Lage"
                                            '4 "Personennummer"
                                            '5 "Aktenbe-zeichnung"
                                            '6 "Registerbe-zeichnung"
                                            '7 "Band"
                                            '8 "lfd. Seiten Nr."
                                            '9 "Zimmer-Nr"
                                            '10 "Aktentyp"
                                            '11 "Bilddateiname"
                                            '12 "Kistenn-Nr"
                                            '13 "Abholdatum()"
                                        Else
                                            IndexZeileOutputTeil1 = ""
                                            Protokoll_Fehler.WriteLine("Für Akte {0}' ist keine Zeile in der Exceltabelle '{1}' enthalten", Aktenname, TextBox_Excel_Akte.Text)
                                        End If
                                    End If
                                    '--

                                    '- kopieren aller Dateien in das Backupverzeichnis
                                    '- Es wurde zwar die Datei aus S/W Verzeichnis gelesen, in das Backupverzeichnis soll aber die synonyme Datei aus dem Farbverzeichnis kopiert werden
                                    BackupName_Quelle = TextBox_Hauptverzeichnis_Farbe.Text & "\" & PfadnameBarcode & "\" & Namensteil(0) & ".jpg"
                                    '- kopieren aller Dateien außer .rue in das Zielverzeichnis
                                    If Namensteil(1) <> "rue" Then
                                        '-- umbenennen : fortlaufende nummer + originale Endung
                                        NeuerName_sw = TextBox_Zielverzeichnis_sw.Text & "\" & CStr(counter).PadLeft(10, "0") & "." & Namensteil(1)
                                        Protokoll_Umbenennung.WriteLine("Kopiere: '{0}' als '{1}'", foundFile, NeuerName_sw)

                                        '-- umbenennen : fortlaufende nummer + pdf für die Indesdatei
                                        IndexDateiName = CStr(counter).PadLeft(10, "0") & ".pdf"
                                        '- Idexzeile vervollständigen
                                        lfdSeitenNr += 1 '- die lfd Seitennummer beginnt pro Ordner(Barcode) bei 1 und ist muss pro Eintrag in der Indexdatei hochgezählt werden
                                        IndexZeileOutputTeil2 = IndexZeileOutputTeil1 & CStr(lfdSeitenNr).PadLeft(4, "0") & ";"
                                        IndexZeileOutputTeil2 += CStr(FieldValue(foundRows(0), "Zimmer-Nr")).PadLeft(4, "0")
                                        IndexZeileOutputTeil2 += FieldValue(foundRows(0), "Aktentyp")
                                        Protokoll_Index.WriteLine(IndexZeileOutputTeil2 & IndexDateiName)

                                        My.Computer.FileSystem.CopyFile(foundFile, NeuerName_sw, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                                        '-- Kopie von Farbverzeichnis nach Backup
                                        BackupName_Ziel = TextBox_Backupverzeichnis.Text & "\" & CStr(counter).PadLeft(10, "0") & ".jpg"
                                        My.Computer.FileSystem.CopyFile(BackupName_Quelle, BackupName_Ziel, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                                    Else
                                        '-- Kopie von Farbverzeichnis nach Backup, aber wenn eine Datei in .rue umbenannt wurde, soll auch die Farbdatei umbenannt werden
                                        BackupName_Ziel = TextBox_Backupverzeichnis.Text & "\" & CStr(counter).PadLeft(10, "0") & "." & Namensteil(1)
                                        My.Computer.FileSystem.CopyFile(BackupName_Quelle, BackupName_Ziel, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                                    End If
                                End If
                            Next
                        Next
                    End Using
                End Using
                Protokolldatei.WriteLine("-------------------------------------------------------------------")
                Protokolldatei.WriteLine("Es wurden insgesamt {0} Verzeichnisse und {1} Dateien gelesen", Anzahl_Verzeichnisse, Anzahl_Dateien)
            End Using
        End Using




        'Dim verzeichnis_anzahl_dateien As New Dictionary(Of String, String)
        ' verzeichnisname, Anzahl Dateien, 
        ' Unterverzeichnisse in dict übergeben und Anzahl Dateien je unterverzeichnis ermitteln
        'Try
        'For Each subDirectory As String In System.IO.Directory.GetDirectories(pfad)
        ' Wiveiele Dateien sind enthalten
        'Dim Anzahl_Dateien = My.Computer.FileSystem.GetFiles(TextBox_Hauptverzeichnis.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg; *.tif")
        'verzeichnis_anzahl_dateien.Add(subDirectory, Anzahl_Dateien)

        'For Each foundFile In My.Computer.FileSystem.GetFiles(TextBox_Hauptverzeichnis.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg; *.tif")
        '
        '   listBox1.Items.Add(foundFile)
        '  listBox1.EndUpdate()
        ' verzeichnis_anzahl_dateien.Add(subDirectory, foundFile)
        'Next

        'Next
        'Catch ex As UnauthorizedAccessException
        '        ' Kein Zugriff
        '       System.Diagnostics.Debug.WriteLine("No Directory Access " & pfad)
        'End Try
        ' Loop over entries.
        'Dim pair As KeyValuePair(Of String, String)
        'For Each pair In verzeichnis_anzahl_dateien
        ' Display Key and Value.
        '        Console.WriteLine("{0}, {1}", pair.Key, pair.Value)
        '       Next
        '---



        '- Anzahl je Muster ermittelndurchsuchen der Muster
        '      Try
        'For Each pattern As String In searchPatternList
        '' ... und zur Dateiliste hinzufügen
        'Dim Anzahl = My.Computer.FileSystem.GetFiles(TextBox_Hauptverzeichnis.Text, FileIO.SearchOption.SearchTopLevelOnly, pattern)
        ''MsgBox("pattern:" & pattern & " Anzahl:" & CStr(Anzahl.Count))
        'Next
        'Catch ex As UnauthorizedAccessException
        '        System.Diagnostics.Debug.WriteLine("No File Access " & TextBox_Hauptverzeichnis.Text)
        '' Kein Zugriff
        'End Try
        'Loop
        ' Sortiert die Dateinamen
        'fileList.Sort(StringComparer.OrdinalIgnoreCase)
        ' quellpfad = System.IO.Path.GetFullPath(TextBox_Hauptverzeichnis.Text)
        'MsgBox("Quellpfad" & quellpfad)

        'Dim counter = My.Computer.FileSystem.GetFiles(TextBox_Hauptverzeichnis.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
        'MsgBox("number of files in " & TextBox_Hauptverzeichnis.Text & " : " & CStr(counter.Count))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Backupverzeichnis.TextChanged
        My.Settings.Backupverzeichnis = TextBox_Backupverzeichnis.Text
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_Backupverzeichnis.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox_Backupverzeichnis.Text = FolderBrowserDialog.SelectedPath
        End If
        My.Settings.Backupverzeichnis = TextBox_Backupverzeichnis.Text
        My.Settings.Save()
    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox_Protokollverzeichnis_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Protokollverzeichnis.TextChanged
        My.Settings.Protokollverzeichnis = TextBox_Protokollverzeichnis.Text
        My.Settings.Save()
    End Sub

    Private Function FieldValue(row As DataRow,
                          fieldName As String) As String
        If Not DBNull.Value.Equals(row.Item(fieldName)) Then
            Return CStr(row.Item(fieldName)) & ";"


        Else
            Return ";"
        End If
    End Function


    'For i As Integer from 1 to 14
    '     TextBox_Excel_Akte.Text = foundRows.(0) (0)
    'TextBox_Excel_Akte.Text = ExcelDaten.Rows(0)(0).ToString() 'Ließt Zelle A2 aus, da A1 als Spaltenkopf betrachtet wird'
    'TextBox_Excel_Akte.Text = ExcelDaten.Columns(0).ColumnName 'Den Spaltentitel aus A1 auslesennext'
    '       Next


    'For each table in the DataSet, print the values of each row.
    'Dim thisTable As DataTable
    'For Each thisTable In ExcelDaten.Tables
    ' For each row, print the values of each column.
    'Dim row As DataRow
    'For Each row In thisTable.Rows
    'Dim column As DataColumn
    'For Each column In thisTable.Columns
    'Console.WriteLine(row(column))
    'Next column
    'Next row
    'Next thisTable


    'For Each pair In ExcelDaten
    ' Dim ersteZelle As String = ExcelDaten.Rows(0)(0).ToString() 'Ließt Zelle A2 aus, da A1 als Spaltenkopf betrachtet wird'
    'Dim ersteZeile As String = ExcelDaten.Row(0).ToString()
    'TextBox_Excel_Akte.Text = data.Columns(0).ColumnName 'Den Spaltentitel aus A1 auslesen'

    'table ist ein DataTable, siehe die verlinkten Seiten'
    'var row = table.Row(0) '1. Zeile abfragen'
    'var cell = row(0) '1. Zelle Abfragen'
    'TextBox_Excel_Akte.Text = cell.ToString() 'Zelleninhalt in String umwandeln und in Textbox ausgeben
    'Next


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class




' https://www.youtube.com/watch?v=Es0w2yBwyNw
' My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")
