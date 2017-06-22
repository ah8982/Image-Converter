<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnOpenImage = New System.Windows.Forms.Button()
        Me.btnConvertTo = New System.Windows.Forms.Button()
        Me.cboxConvertTo = New System.Windows.Forms.ComboBox()
        Me.grpPreview = New System.Windows.Forms.GroupBox()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.grpPreview.SuspendLayout()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenImage
        '
        Me.btnOpenImage.Location = New System.Drawing.Point(12, 12)
        Me.btnOpenImage.Name = "btnOpenImage"
        Me.btnOpenImage.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenImage.TabIndex = 0
        Me.btnOpenImage.Text = "Open Image"
        Me.btnOpenImage.UseVisualStyleBackColor = True
        '
        'btnConvertTo
        '
        Me.btnConvertTo.Location = New System.Drawing.Point(93, 12)
        Me.btnConvertTo.Name = "btnConvertTo"
        Me.btnConvertTo.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertTo.TabIndex = 1
        Me.btnConvertTo.Text = "Convert to"
        Me.btnConvertTo.UseVisualStyleBackColor = True
        '
        'cboxConvertTo
        '
        Me.cboxConvertTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxConvertTo.FormattingEnabled = True
        Me.cboxConvertTo.Items.AddRange(New Object() {"PNG", "JPEG", "GIF", "BMP"})
        Me.cboxConvertTo.Location = New System.Drawing.Point(174, 12)
        Me.cboxConvertTo.Name = "cboxConvertTo"
        Me.cboxConvertTo.Size = New System.Drawing.Size(160, 21)
        Me.cboxConvertTo.TabIndex = 2
        '
        'grpPreview
        '
        Me.grpPreview.Controls.Add(Me.picPreview)
        Me.grpPreview.Location = New System.Drawing.Point(12, 41)
        Me.grpPreview.Name = "grpPreview"
        Me.grpPreview.Size = New System.Drawing.Size(322, 191)
        Me.grpPreview.TabIndex = 3
        Me.grpPreview.TabStop = False
        Me.grpPreview.Text = "Preview"
        '
        'picPreview
        '
        Me.picPreview.Location = New System.Drawing.Point(6, 19)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(310, 166)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPreview.TabIndex = 0
        Me.picPreview.TabStop = False
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.Filter = "All Files|*.*"
        Me.ofdOpenFile.Title = "Open Image"
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.Title = "Save converted Image"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 244)
        Me.Controls.Add(Me.grpPreview)
        Me.Controls.Add(Me.cboxConvertTo)
        Me.Controls.Add(Me.btnConvertTo)
        Me.Controls.Add(Me.btnOpenImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Converter"
        Me.grpPreview.ResumeLayout(False)
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpenImage As System.Windows.Forms.Button
    Friend WithEvents btnConvertTo As System.Windows.Forms.Button
    Friend WithEvents cboxConvertTo As System.Windows.Forms.ComboBox
    Friend WithEvents grpPreview As System.Windows.Forms.GroupBox
    Friend WithEvents picPreview As System.Windows.Forms.PictureBox
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog

End Class
