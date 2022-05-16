Public Class Funct
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Integer1 As Decimal = Decimal.Parse(Int.Text)
        Dim Maximum1 As Decimal = Decimal.Parse(Max.Text)
        Dim Minimum1 As Decimal = Decimal.Parse(Min.Text)

        Dim f As String = TextBox1.Text
        Dim function1 As String = Nothing
        If f.Contains("x") = False Then
            MsgBox("Not a function")
        End If
        Dim i As Decimal = 0
        Dim a As Integer = 0
        Dim q As Integer = 0
        If f.Contains("(") And f.Contains(")") Then

            Do Until i = f.Length
                If f.Substring(i, 1) = ")" Then
                    function1 = f.Substring(a, q)
                ElseIf f.Substring(i, 1) = "(" Then
                    a = i + 1
                    q = -1
                End If
                i += 1
                q += 1
            Loop
            i = 0
            a = 0
            q = 0
        Else
            function1 = f
        End If

        Dim num1 As String
        Dim num1a As Decimal
        Dim num1b As Decimal
        Dim num2 As String
        Dim answer As Decimal
        Dim Symbol As String = Nothing
        Dim r As Integer = function1.Length() - 1

        If function1.Contains("+") Then
            Symbol = "+"
        ElseIf function1.Contains("-") Then
            Symbol = "-"
        ElseIf function1.Contains("*") Then
            Symbol = "*"
        ElseIf function1.Contains("/") Then
            Symbol = "/"
        ElseIf function1.Contains("^") Then
            Symbol = "^"
        End If

        Do Until i = function1.Length
            If function1.Substring(i, 1) = Symbol Then
                Dim n As Integer = i + 1
                r = function1.Length - n
                num1 = function1.Substring(a, i)
                num2 = function1.Substring(i + 1, r)
            End If
            i += 1
        Loop

        i = 0
        Dim switch As Boolean = False

        If num1 = "x" Then
            num1a = Minimum1
            num2 = Double.Parse(num2)
            switch = False
        ElseIf num2 = "x" Then
            num1a = Minimum1
            num1b = Double.Parse(num1)
            switch = True
        End If

        Try
            Do Until i >= Maximum1 + Integer1
                If switch = False Then
                    If Symbol = "+" Then
                        answer = num1a + num2
                    ElseIf Symbol = "-" Then
                        answer = num1a - num2
                    ElseIf Symbol = "*" Then
                        answer = num1a * num2
                    ElseIf Symbol = "/" Then
                        answer = num1a / num2
                    ElseIf Symbol = "^" Then
                        answer = num1a ^ num2
                    End If
                ElseIf switch = True Then
                    If Symbol = "+" Then
                        answer = num1b + num1a
                    ElseIf Symbol = "-" Then
                        answer = num1b - num1a
                    ElseIf Symbol = "*" Then
                        answer = num1b * num1a
                    ElseIf Symbol = "/" Then
                        answer = num1b / num1a
                    ElseIf Symbol = "^" Then
                        answer = num1b ^ num1a
                    End If
                End If
                Dim root As Decimal
                If f.Contains("^") = True And function1.Contains("^") = False Or f.Contains("√") = True And function1.Contains("√") = False Then
                    If f.Contains("√") Then
                        If f.Substring(0, 1) = "√" Then
                            root = 2
                        Else
                            root = Decimal.Parse(f.Substring(0, 1))
                        End If
                        root = 1 / root
                        answer ^= root
                    ElseIf f.Contains("^") Then
                        root = Decimal.Parse(f.Substring(f.Length() - 1, 1))
                        answer ^= root
                    End If
                ElseIf f.Contains("+") And function1.Contains("+") = False Or f.Contains("-") And function1.Contains("-") = False Or f.Contains("*") And function1.Contains("*") = False Or f.Contains("/") And function1.Contains("/") = False Then
                    If f.Contains("+") Then
                        root = Decimal.Parse(f.Substring(f.Length() - 1, 1))
                        answer += root
                    ElseIf f.Contains("-") Then
                        root = Decimal.Parse(f.Substring(f.Length() - 1, 1))
                        answer -= root
                    ElseIf f.Contains("*") Then
                        root = Decimal.Parse(f.Substring(f.Length() - 1, 1))
                        answer = answer * root
                    ElseIf f.Contains("/") Then
                        root = Decimal.Parse(f.Substring(f.Length() - 1, 1))
                        answer /= root
                    End If
                End If
                ListBox1.Items.Add(answer)
                num1a += Integer1
                i += Integer1
            Loop
        Catch ex As Exception
        End Try
        i = 0
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class