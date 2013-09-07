Module Module1
    Sub ShowValue(ByVal Butt As Button)
        Form1.TextBox1.Text = Val(Form1.TextBox1.Text & Butt.Text)
    End Sub


    Sub arithmetic(ByVal butt As Button)
        Form1.Value1 = Val(Form1.TextBox1.Text)
        Form1.oper = butt.Text
        Form1.TextBox1.Text = " "
    End Sub


    Sub Calculate()
        Select Case Form1.oper
            Case "+"
                Form1.TextBox1.Text = Form1.Value1 + Val(Form1.TextBox1.Text)
            Case "-"
                Form1.TextBox1.Text = Form1.Value1 - Val(Form1.TextBox1.Text)
            Case "x"
                Form1.TextBox1.Text = Form1.Value1 * Val(Form1.TextBox1.Text)
            Case "/"
                Form1.TextBox1.Text = Form1.Value1 / Val(Form1.TextBox1.Text)
        End Select

    End Sub

End Module
