Public Class Form1

    Dim Num01 As Decimal
    Dim Num02 As Decimal
    Dim Answer As Decimal
    Dim Symbol As String
    Dim x As Double
    Dim y As Double
    Dim Adv As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Num01 = TextBox2.Text
        Num02 = TextBox3.Text
        Answer = Num01 + Num02
        TextBox1.Text = Answer
        Symbol = "+"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Num01 = TextBox2.Text
        Num02 = TextBox3.Text
        Answer = Num01 / Num02
        TextBox1.Text = Answer
        Symbol = "/"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Num01 = TextBox2.Text
        Num02 = TextBox3.Text
        Answer = Num01 - Num02
        TextBox1.Text = Answer
        Symbol = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Num01 = TextBox2.Text
        Num02 = TextBox3.Text
        Answer = Num01 * Num02
        TextBox1.Text = Answer
        Symbol = "*"
    End Sub

    Private Sub TextBox2_DoubleClick(sender As Object, e As EventArgs) Handles TextBox2.DoubleClick
        TextBox2.Text = TextBox1.Text
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter All Boxes")
        ElseIf My.Settings.Number = 1 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S1 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label1.Text = My.Settings.S1
            My.Settings.Height = 55
        ElseIf My.Settings.Number = 2 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S2 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label2.Text = My.Settings.S2
            My.Settings.Height = 68
        ElseIf My.Settings.Number = 3 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S3 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label3.Text = My.Settings.S3
            My.Settings.Height = 81
        ElseIf My.Settings.Number = 4 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S4 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label4.Text = My.Settings.S4
            My.Settings.Height = 94
        ElseIf My.Settings.Number = 5 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S5 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label5.Text = My.Settings.S5
            My.Settings.Height = 107
        ElseIf My.Settings.Number = 6 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S6 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label6.Text = My.Settings.S6
            My.Settings.Height = 120
        ElseIf My.Settings.Number = 7 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S7 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label7.Text = My.Settings.S7
            My.Settings.Height = 133
        ElseIf My.Settings.Number = 8 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S8 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label8.Text = My.Settings.S8
            My.Settings.Height = 146
        ElseIf My.Settings.Number = 9 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S9 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label9.Text = My.Settings.S9
            My.Settings.Height = 159
        ElseIf My.Settings.Number = 10 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S10 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label10.Text = My.Settings.S10
            My.Settings.Height = 172
        ElseIf My.Settings.Number = 11 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S11 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label11.Text = My.Settings.S11
            My.Settings.Height = 185
        ElseIf My.Settings.Number = 12 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S12 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label12.Text = My.Settings.S12
            My.Settings.Height = 198
        ElseIf My.Settings.Number = 13 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S13 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label13.Text = My.Settings.S13
            My.Settings.Height = 211
        ElseIf My.Settings.Number = 14 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S14 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label14.Text = My.Settings.S14
            My.Settings.Height = 224
        ElseIf My.Settings.Number = 15 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S15 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label15.Text = My.Settings.S15
            My.Settings.Height = 237
        ElseIf My.Settings.Number = 16 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S16 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label16.Text = My.Settings.S16
            My.Settings.Height = 250
        ElseIf My.Settings.Number = 17 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S17 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label17.Text = My.Settings.S17
            My.Settings.Height = 263
        ElseIf My.Settings.Number = 18 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S18 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label18.Text = My.Settings.S18
            My.Settings.Height = 276
        ElseIf My.Settings.Number = 19 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S19 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label19.Text = My.Settings.S19
            My.Settings.Height = 289
        ElseIf My.Settings.Number = 20 Then
            My.Settings.Number = My.Settings.Number + 1
            My.Settings.S20 = TextBox2.Text + " " + Symbol + " " + TextBox3.Text + " = " + TextBox1.Text
            Saves.Label20.Text = My.Settings.S20
            My.Settings.Height = 302
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Saves.Height = Saves.Height + 13
    End Sub

    Private Sub ShowSavesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowSavesToolStripMenuItem.Click
        My.Forms.Saves.Show()
        Saves.Height = My.Settings.Height
    End Sub

    Private Sub ClearSavesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSavesToolStripMenuItem.Click
        Saves.Height = 42
        My.Settings.Height = 42
        My.Settings.Number = 1
        My.Settings.S1 = Nothing
        My.Settings.S2 = Nothing
        My.Settings.S3 = Nothing
        My.Settings.S4 = Nothing
        My.Settings.S5 = Nothing
        My.Settings.S6 = Nothing
        My.Settings.S7 = Nothing
        My.Settings.S8 = Nothing
        My.Settings.S9 = Nothing
        My.Settings.S10 = Nothing
        My.Settings.S11 = Nothing
        My.Settings.S12 = Nothing
        My.Settings.S13 = Nothing
        My.Settings.S14 = Nothing
        My.Settings.S15 = Nothing
        My.Settings.S16 = Nothing
        My.Settings.S17 = Nothing
        My.Settings.S18 = Nothing
        My.Settings.S19 = Nothing
        My.Settings.S20 = Nothing
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub MenuStrip1_DoubleClick(sender As Object, e As EventArgs) Handles MenuStrip1.DoubleClick
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim Num03 As String
        Dim Number As Char = TextBox2.Text
        Num03 = Asc(Number)
        If Num03 >= "48" And Num03 <= "57" Then

        Else
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim Num03 As String
        Dim Number As Char = TextBox3.Text
        Num03 = Asc(Number)
        If Num03 >= "48" And Num03 <= "57" Then

        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Num03 As String
        Dim Number As Char = TextBox1.Text
        Num03 = Asc(Number)
        If Num03 >= "48" And Num03 <= "57" Then

        Else
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        If Adv = False Then
            Me.Size = New Size(386, 203)
            Adv = True
        Else
            Me.Size = New Size(226, 203)
            Adv = False
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Answer = TextBox2.Text
        TextBox1.Text = Answer ^ 2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        x = TextBox3.Text
        Answer = TextBox2.Text
        TextBox1.Text = Answer ^ x
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Answer = TextBox2.Text
        TextBox1.Text = Answer ^ 0.5
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        x = TextBox3.Text
        Answer = TextBox2.Text
        y = 1 / x
        TextBox1.Text = Answer ^ y
    End Sub

    Private Sub TextBox3_DoubleClick(sender As Object, e As EventArgs) Handles TextBox3.DoubleClick
        TextBox3.Text = TextBox1.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Forms.Funct.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Forms.Quadratic.Show()
    End Sub
End Class
