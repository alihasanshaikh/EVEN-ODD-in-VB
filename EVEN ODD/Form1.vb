﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text) Mod 2 = 0 Then
            Label1.Text = "even"
        Else
            Label1.Text = "odd"

        End If
    End Sub
End Class
