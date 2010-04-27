Public Class frmBaseform

    Private Sub frmBaseform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'user interface displaying messages

    Friend Sub WriteStatusMessage(ByRef Message As String)
        Try
            tsplblmessage.Text = Message
        Catch ex As Exception

        End Try
    End Sub

End Class