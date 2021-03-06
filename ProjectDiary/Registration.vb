﻿Public Class Registration
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Change Background Image According to Current Time'
        Dim current As Date = Date.Now
        Dim morning As New Date(current.Year, current.Month, current.Day, 6, 0, 0)
        Dim afternoon As New Date(current.Year, current.Month, current.Day, 15, 0, 0)
        Dim evening As New Date(current.Year, current.Month, current.Day, 18, 0, 0, 0)
        If (current >= morning) And (current <= afternoon) Then
            Me.BackgroundImage = My.Resources.early_bg
        ElseIf (current > afternoon) And (current <= evening) Then
            Me.BackgroundImage = My.Resources.afternoon_bg
        ElseIf (current > evening) And (current < morning) Then
            Me.BackgroundImage = My.Resources.projectDiaryBG
        End If
    End Sub
    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        With btnClose
            .BackgroundImage = My.Resources.close_hover
        End With
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        With btnClose
            .BackgroundImage = My.Resources.Close
        End With
    End Sub

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        With btnClose
            .BackgroundImage = My.Resources.close_clicked1
        End With
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        With btnClose
            .BackgroundImage = My.Resources.close_hover
        End With
    End Sub

    Private Sub btnMinimize_MouseHover(sender As Object, e As EventArgs) Handles btnMinimize.MouseHover
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_hover
        End With
    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        With btnMinimize
            .BackgroundImage = My.Resources.Minimize
        End With
    End Sub

    Private Sub btnMinimize_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMinimize.MouseDown
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_clicked
        End With
    End Sub

    Private Sub btnMinimize_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMinimize.MouseUp
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_hover
        End With
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub tboxUsername_Enter(sender As Object, e As EventArgs) Handles tboxUsername.Enter
        If tboxUsername.Text = "Username" Then
            tboxUsername.Text = ""
        End If
    End Sub

    Private Sub tboxUsername_Leave(sender As Object, e As EventArgs) Handles tboxUsername.Leave
        If tboxUsername.Text = "" Then
            tboxUsername.Text = "Username"
        End If
    End Sub
    Private Sub tboxPassword_Enter(sender As Object, e As EventArgs) Handles tboxPassword.Enter
        If tboxPassword.Text = "Password" Then
            tboxPassword.Text = ""
            tboxPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub tboxPassword_Leave(sender As Object, e As EventArgs) Handles tboxPassword.Leave
        If tboxPassword.Text = "" Then
            tboxPassword.Text = "Password"
            tboxPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub tboxConfPassword_Enter(sender As Object, e As EventArgs) Handles tboxConfPassword.Enter
        If tboxConfPassword.Text = "Confirm Password" Then
            tboxConfPassword.Text = ""
            tboxConfPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub tboxConfPassword_Leave(sender As Object, e As EventArgs) Handles tboxConfPassword.Leave
        If tboxConfPassword.Text = "" Then
            tboxConfPassword.Text = "Confirm Password"
            tboxConfPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnRegister_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRegister.MouseDown
        With btnRegister
            .BackgroundImage = My.Resources.long_button_clicked
        End With
    End Sub

    Private Sub btnRegister_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRegister.MouseUp
        With btnRegister
            .BackgroundImage = My.Resources.long_button
        End With
    End Sub
End Class