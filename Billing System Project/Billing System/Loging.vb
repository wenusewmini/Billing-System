Public Class Loging

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PbxClose.Click

        Application.Exit()

    End Sub

    Private Sub L4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L4.Click

        Dim obj = New Billing
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub btnloging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloging.Click

        If txtbxuName.Text = "" Or txtbxpwd.Text = "" Then
            MsgBox("Please Enter User Name and Password", MsgBoxStyle.Critical, "Error")

        ElseIf txtbxuName.Text = "Sameera" And txtbxpwd.Text = "1234" Then
            Dim obj1 = New Item
            obj1.Show()
            Me.Hide()
        Else
            MsgBox("Invalid User Name or Password", MsgBoxStyle.OkCancel, "Message")
            txtbxuName.Text = ""
            txtbxpwd.Text = ""
        End If

    End Sub

    Private Sub checkbx1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbx1.CheckedChanged

        If checkbx1.Checked = True Then
            txtbxpwd.PasswordChar = ""
        Else
            txtbxpwd.PasswordChar = "*"
        End If

    End Sub
End Class