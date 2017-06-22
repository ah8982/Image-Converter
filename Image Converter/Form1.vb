Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With Me
            .cboxConvertTo.SelectedItem = "PNG"
        End With
    End Sub

    Private Sub btnOpenImage_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenImage.Click
        Try
            If ofdOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.picPreview.Image = System.Drawing.Image.FromFile(ofdOpenFile.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbOKOnly)
        End Try
    End Sub

    Private Sub btnConvertTo_Click(sender As System.Object, e As System.EventArgs) Handles btnConvertTo.Click
        If cboxConvertTo.SelectedItem = "JPEG" Then
            Try
                sfdSaveFile.Filter = "JPEG|*.jpeg"
                If sfdSaveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.picPreview.Image.Save(sfdSaveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, vbOKOnly)
            End Try
        End If

        If cboxConvertTo.SelectedItem = "PNG" Then
            Try
                sfdSaveFile.Filter = "PNG|*.png"
                If sfdSaveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.picPreview.Image.Save(sfdSaveFile.FileName, System.Drawing.Imaging.ImageFormat.Png)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, vbOKOnly)
            End Try
        End If

        If cboxConvertTo.SelectedItem = "GIF" Then
            Try
                sfdSaveFile.Filter = "GIF|*.gif"
                If sfdSaveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.picPreview.Image.Save(sfdSaveFile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, vbOKOnly)
            End Try
        End If

        If cboxConvertTo.SelectedItem = "BMP" Then
            Try
                sfdSaveFile.Filter = "BMP|*.bmp"
                If sfdSaveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.picPreview.Image.Save(sfdSaveFile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, vbOKOnly)
            End Try
        End If
    End Sub
End Class
