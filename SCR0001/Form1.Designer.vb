<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_Excel_Akte = New System.Windows.Forms.Button()
        Me.TextBox_Excel_Akte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button_Zielverzeichnis_sw = New System.Windows.Forms.Button()
        Me.TextBox_Zielverzeichnis_sw = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_Hauptverzeichnis_sw = New System.Windows.Forms.Button()
        Me.TextBox_Hauptverzeichnis_sw = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_Backupverzeichnis = New System.Windows.Forms.Button()
        Me.TextBox_Backupverzeichnis = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button_Anzahl = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Protokollverzeichnis = New System.Windows.Forms.Button()
        Me.TextBox_Protokollverzeichnis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Hauptverzeichnis_Farbe = New System.Windows.Forms.Button()
        Me.TextBox_Hauptverzeichnis_Farbe = New System.Windows.Forms.TextBox()
        Me.Hauptverzeichnis_wählen = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(284, 484)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 49
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(284, 446)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(367, 54)
        Me.ProgressBar1.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 80)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 17)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Excel Aktentabelle"
        '
        'Button_Excel_Akte
        '
        Me.Button_Excel_Akte.Location = New System.Drawing.Point(617, 76)
        Me.Button_Excel_Akte.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Excel_Akte.Name = "Button_Excel_Akte"
        Me.Button_Excel_Akte.Size = New System.Drawing.Size(33, 25)
        Me.Button_Excel_Akte.TabIndex = 46
        Me.Button_Excel_Akte.Text = "..."
        Me.Button_Excel_Akte.UseVisualStyleBackColor = True
        '
        'TextBox_Excel_Akte
        '
        Me.TextBox_Excel_Akte.Location = New System.Drawing.Point(176, 77)
        Me.TextBox_Excel_Akte.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Excel_Akte.Name = "TextBox_Excel_Akte"
        Me.TextBox_Excel_Akte.Size = New System.Drawing.Size(432, 22)
        Me.TextBox_Excel_Akte.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Zielverzeichnis sw:"
        '
        'Button_Zielverzeichnis_sw
        '
        Me.Button_Zielverzeichnis_sw.Location = New System.Drawing.Point(617, 183)
        Me.Button_Zielverzeichnis_sw.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Zielverzeichnis_sw.Name = "Button_Zielverzeichnis_sw"
        Me.Button_Zielverzeichnis_sw.Size = New System.Drawing.Size(33, 25)
        Me.Button_Zielverzeichnis_sw.TabIndex = 43
        Me.Button_Zielverzeichnis_sw.Text = "..."
        Me.Button_Zielverzeichnis_sw.UseVisualStyleBackColor = True
        '
        'TextBox_Zielverzeichnis_sw
        '
        Me.TextBox_Zielverzeichnis_sw.Location = New System.Drawing.Point(176, 184)
        Me.TextBox_Zielverzeichnis_sw.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Zielverzeichnis_sw.Name = "TextBox_Zielverzeichnis_sw"
        Me.TextBox_Zielverzeichnis_sw.Size = New System.Drawing.Size(432, 22)
        Me.TextBox_Zielverzeichnis_sw.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Hauptverzeichnis s/w:"
        '
        'Button_Hauptverzeichnis_sw
        '
        Me.Button_Hauptverzeichnis_sw.Location = New System.Drawing.Point(617, 140)
        Me.Button_Hauptverzeichnis_sw.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Hauptverzeichnis_sw.Name = "Button_Hauptverzeichnis_sw"
        Me.Button_Hauptverzeichnis_sw.Size = New System.Drawing.Size(33, 25)
        Me.Button_Hauptverzeichnis_sw.TabIndex = 40
        Me.Button_Hauptverzeichnis_sw.Text = "..."
        Me.Button_Hauptverzeichnis_sw.UseVisualStyleBackColor = True
        '
        'TextBox_Hauptverzeichnis_sw
        '
        Me.TextBox_Hauptverzeichnis_sw.Location = New System.Drawing.Point(176, 141)
        Me.TextBox_Hauptverzeichnis_sw.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Hauptverzeichnis_sw.Name = "TextBox_Hauptverzeichnis_sw"
        Me.TextBox_Hauptverzeichnis_sw.Size = New System.Drawing.Size(432, 22)
        Me.TextBox_Hauptverzeichnis_sw.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 220)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Backupverzeichnis"
        '
        'Button_Backupverzeichnis
        '
        Me.Button_Backupverzeichnis.Location = New System.Drawing.Point(617, 215)
        Me.Button_Backupverzeichnis.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Backupverzeichnis.Name = "Button_Backupverzeichnis"
        Me.Button_Backupverzeichnis.Size = New System.Drawing.Size(33, 25)
        Me.Button_Backupverzeichnis.TabIndex = 37
        Me.Button_Backupverzeichnis.Text = "..."
        Me.Button_Backupverzeichnis.UseVisualStyleBackColor = True
        '
        'TextBox_Backupverzeichnis
        '
        Me.TextBox_Backupverzeichnis.Location = New System.Drawing.Point(176, 216)
        Me.TextBox_Backupverzeichnis.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Backupverzeichnis.Name = "TextBox_Backupverzeichnis"
        Me.TextBox_Backupverzeichnis.Size = New System.Drawing.Size(432, 22)
        Me.TextBox_Backupverzeichnis.TabIndex = 36
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(176, 508)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 47)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Programm beenden"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button_Anzahl
        '
        Me.Button_Anzahl.Location = New System.Drawing.Point(176, 446)
        Me.Button_Anzahl.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Anzahl.Name = "Button_Anzahl"
        Me.Button_Anzahl.Size = New System.Drawing.Size(100, 54)
        Me.Button_Anzahl.TabIndex = 34
        Me.Button_Anzahl.Text = "Anzahl ermitteln"
        Me.Button_Anzahl.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(176, 316)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(475, 123)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Protokollverzeichnis:"
        '
        'Button_Protokollverzeichnis
        '
        Me.Button_Protokollverzeichnis.Location = New System.Drawing.Point(617, 247)
        Me.Button_Protokollverzeichnis.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Protokollverzeichnis.Name = "Button_Protokollverzeichnis"
        Me.Button_Protokollverzeichnis.Size = New System.Drawing.Size(33, 25)
        Me.Button_Protokollverzeichnis.TabIndex = 31
        Me.Button_Protokollverzeichnis.Text = "..."
        Me.Button_Protokollverzeichnis.UseVisualStyleBackColor = True
        '
        'TextBox_Protokollverzeichnis
        '
        Me.TextBox_Protokollverzeichnis.Location = New System.Drawing.Point(176, 248)
        Me.TextBox_Protokollverzeichnis.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Protokollverzeichnis.Name = "TextBox_Protokollverzeichnis"
        Me.TextBox_Protokollverzeichnis.Size = New System.Drawing.Size(432, 22)
        Me.TextBox_Protokollverzeichnis.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Hauptverzeichnis Farbe:"
        '
        'Button_Hauptverzeichnis_Farbe
        '
        Me.Button_Hauptverzeichnis_Farbe.Location = New System.Drawing.Point(617, 108)
        Me.Button_Hauptverzeichnis_Farbe.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Hauptverzeichnis_Farbe.Name = "Button_Hauptverzeichnis_Farbe"
        Me.Button_Hauptverzeichnis_Farbe.Size = New System.Drawing.Size(33, 25)
        Me.Button_Hauptverzeichnis_Farbe.TabIndex = 28
        Me.Button_Hauptverzeichnis_Farbe.Text = "..."
        Me.Button_Hauptverzeichnis_Farbe.UseVisualStyleBackColor = True
        '
        'TextBox_Hauptverzeichnis_Farbe
        '
        Me.TextBox_Hauptverzeichnis_Farbe.Location = New System.Drawing.Point(176, 109)
        Me.TextBox_Hauptverzeichnis_Farbe.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_Hauptverzeichnis_Farbe.Name = "TextBox_Hauptverzeichnis_Farbe"
        Me.TextBox_Hauptverzeichnis_Farbe.Size = New System.Drawing.Size(432, 22)
        Me.TextBox_Hauptverzeichnis_Farbe.TabIndex = 27
        '
        'Hauptverzeichnis_wählen
        '
        Me.Hauptverzeichnis_wählen.FileName = "Hauptverzeichnis"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(674, 58)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Location = New System.Drawing.Point(13, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "P001 - Witten"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(676, 571)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button_Excel_Akte)
        Me.Controls.Add(Me.TextBox_Excel_Akte)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button_Zielverzeichnis_sw)
        Me.Controls.Add(Me.TextBox_Zielverzeichnis_sw)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_Hauptverzeichnis_sw)
        Me.Controls.Add(Me.TextBox_Hauptverzeichnis_sw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button_Backupverzeichnis)
        Me.Controls.Add(Me.TextBox_Backupverzeichnis)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button_Anzahl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_Protokollverzeichnis)
        Me.Controls.Add(Me.TextBox_Protokollverzeichnis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Hauptverzeichnis_Farbe)
        Me.Controls.Add(Me.TextBox_Hauptverzeichnis_Farbe)
        Me.Name = "Form1"
        Me.Text = "SCR-P001"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_Excel_Akte As Button
    Friend WithEvents TextBox_Excel_Akte As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button_Zielverzeichnis_sw As Button
    Friend WithEvents TextBox_Zielverzeichnis_sw As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button_Hauptverzeichnis_sw As Button
    Friend WithEvents TextBox_Hauptverzeichnis_sw As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_Backupverzeichnis As Button
    Friend WithEvents TextBox_Backupverzeichnis As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button_Anzahl As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Protokollverzeichnis As Button
    Friend WithEvents TextBox_Protokollverzeichnis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Hauptverzeichnis_Farbe As Button
    Friend WithEvents TextBox_Hauptverzeichnis_Farbe As TextBox
    Friend WithEvents Hauptverzeichnis_wählen As OpenFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
