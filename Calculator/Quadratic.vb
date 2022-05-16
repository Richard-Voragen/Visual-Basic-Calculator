Public Class Quadratic
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Decimal = Decimal.Parse(TextBox1.Text)
        Dim b As Decimal = Decimal.Parse(TextBox2.Text)
        Dim c As Decimal = Decimal.Parse(TextBox3.Text)

        Dim X1 As Decimal
        Dim X2 As Decimal
        Dim i As Boolean = False
        Dim root As Decimal = b ^ 2
        Dim root2 As Decimal = -4 * a
        root2 *= c
        root += root2
        Try
            If root < 0 Then
                root *= -1
                i = True
            End If
            If CheckBox3.Checked = False Then
                root ^= 0.5
            End If
            If CheckBox2.Checked = True And CheckBox3.Checked = False Then
                root = Math.Round(root, 2)
            End If
            a *= 2
            b *= -1
            X1 = b + root
            X2 = b - root
            If CheckBox1.Checked = False Then
                X1 /= a
                X2 /= a
            End If
        Catch ex As Exception
        End Try
        If CheckBox1.Checked = True Then
            If i Then
                TextBox4.Text = b.ToString + " + " + root.ToString + "i" + "/" + a.ToString
                TextBox5.Text = b.ToString + " - " + root.ToString + "i" + "/" + a.ToString
            Else
                TextBox4.Text = X1.ToString + "/" + a.ToString
                TextBox5.Text = X2.ToString + "/" + a.ToString
            End If
        ElseIf CheckBox3.Checked = True Then
            If i Then
                TextBox4.Text = "(" + b.ToString + " + √" + root.ToString + "i)/" + a.ToString
                TextBox5.Text = "(" + b.ToString + " - √" + root.ToString + "i)/" + a.ToString
            Else
                TextBox4.Text = "(" + b.ToString + " + √" + root.ToString + ")/" + a.ToString
                TextBox5.Text = "(" + b.ToString + " - √" + root.ToString + ")/" + a.ToString
            End If
        Else
            If i Then
                TextBox4.Text = b.ToString + " + " + root.ToString + "i"
                TextBox5.Text = b.ToString + " - " + root.ToString + "i"
            Else
                TextBox4.Text = X1.ToString
                TextBox5.Text = X2.ToString
            End If
        End If
        i = False
    End Sub
End Class