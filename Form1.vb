Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaration of variable
        Dim height, weight, bmi As Double
        weight = Val(TextBox1.Text)
        height = Val(TextBox2.Text)
        bmi = weight / (height) ^ 2
        TextBox3.Text = bmi
        If bmi < 18 Then
            TextBox4.Text = "You are underweight"

        ElseIf 18 <= bmi And bmi < 26 Then
            TextBox4.Text = "You are Normal"
        Else
            TextBox4.Text = "You are Overweight"
        End If


    End Sub
End Class
