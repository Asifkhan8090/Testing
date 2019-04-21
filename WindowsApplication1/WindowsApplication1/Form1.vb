Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, num4, num5, num6, Total, Obtain, Grade, p1, p2, p3, p4, p5, p6 As Integer


        num1 = Convert.ToInt32(txtAI.Text)
        num2 = Convert.ToInt32(txtSE.Text)
        num3 = Convert.ToInt32(txtDB.Text)
        num4 = Convert.ToInt32(txtEC.Text)
        num5 = Convert.ToInt32(txtNet.Text)
        num6 = Convert.ToInt32(txtFIT.Text)

        'For Total Marks
        Total = 100 + 100 + 100 + 100 + 100 + 100
        lblTotal.Text = Total

        'For Obtained Marks
        Obtain = num1 + num2 + num3 + num4 + num5 + num6
        lblObtain.Text = Obtain


        'For Individual Course Grade
        Dim A As Integer

        A = Convert.ToInt32(txtAI.Text)
        If A >= 80 And A <= 100 Then
            lblAI.Text = “A+”
        ElseIf A >= 70 And A <= 79
            lblAI.Text = “A”
        ElseIf A >= 60 And A <= 69
            lblAI.Text = “B”
        ElseIf A >= 50 And A <= 59
            lblAI.Text = “C”
        ElseIf A >= 40 And A <= 49
            lblAI.Text = “Improve”
        Else
            lblAI.Text = “Fail”
        End If


        Dim B As Integer
        B = Convert.ToInt32(txtSE.Text)
        If B >= 80 And B <= 100 Then
            lblSE.Text = “A+”
        ElseIf B >= 70 And B <= 79
            lblSE.Text = “A”
        ElseIf B >= 60 And B <= 69
            lblSE.Text = “B”
        ElseIf B >= 50 And B <= 59
            lblSE.Text = “C”
        ElseIf B >= 40 And B <= 49
            lblSE.Text = “Improve”
        Else
            lblSE.Text = “Fail”
        End If


        Dim C As Integer
        C = Convert.ToInt32(txtDB.Text)
        If C >= 80 And C <= 100 Then
            lblDB.Text = “A+”
        ElseIf C >= 70 And C <= 79
            lblDB.Text = “A”
        ElseIf C >= 60 And C <= 69
            lblDB.Text = “B”
        ElseIf C >= 50 And C <= 59
            lblDB.Text = “C”
        ElseIf C >= 40 And C <= 49
            lblDB.Text = “Improve”
        Else
            lblDB.Text = “Fail”
        End If



        Dim D As Integer
        D = Convert.ToInt32(txtEC.Text)

        If D >= 80 And D <= 100 Then
            lblEC.Text = “A+”
        ElseIf D >= 70 And D <= 79
            lblEC.Text = “A”
        ElseIf D >= 60 And D <= 69
            lblEC.Text = “B”
        ElseIf D >= 50 And D <= 59
            lblEC.Text = “C”
        ElseIf D >= 40 And D <= 49
            lblEC.Text = “Improve”
        Else
            lblEC.Text = “Fail”
        End If

        Dim G As Integer
        G = Convert.ToInt32(txtNet.Text)
        If G >= 80 And G <= 100 Then
            lblNet.Text = “A+”
        ElseIf G >= 70 And G <= 79
            lblNet.Text = “A”
        ElseIf G >= 60 And G <= 59
            lblNet.Text = “B”
        ElseIf G >= 50 And G <= 59
            lblNet.Text = “C”
        ElseIf G >= 40 And G <= 49
            lblNet.Text = “Improve”
        Else
            lblNet.Text = “Fail”
        End If


        Dim F As Integer
        F = Convert.ToInt32(txtFIT.Text)
        If F >= 80 And F <= 100 Then
            lblFIT.Text = “A+”
        ElseIf F >= 70 And F <= 79
            lblFIT.Text = “A”
        ElseIf F >= 60 And F <= 69
            lblFIT.Text = “B”
        ElseIf F >= 50 And F <= 59
            lblFIT.Text = “C”
        ElseIf F >= 40 And F <= 49
            lblFIT.Text = “Improve”
        Else
            lblFIT.Text = “Fail”
        End If

        'For All Courses Grade
        Obtain = Convert.ToInt32(lblObtain.Text)
        If Obtain >= 480 And Obtain <= 600 Then
            lblGrade.Text = “A+”
        ElseIf Obtain >= 420 And Obtain <= 479
            lblGrade.Text = “A”
        ElseIf Obtain >= 360 And Obtain <= 419
            lblGrade.Text = “B”
        ElseIf Obtain >= 300 And Obtain <= 359
            lblGrade.Text = “C”
        ElseIf Obtain >= 1 And Obtain <= 299
            lblGrade.Text = “Fail”
        End If

        'For Individual Course Percentage
        'p1 = num1 * 100 / 100
        'lblPerAI.Text = p1
        'p1 = num2 * 100 / 100
        'lblPerSE.Text = p2
        'p1 = num3 * 100 / 100
        'lblPerDB.Text = p3
        'p1 = num4 * 100 / 100
        'lblPerEC.Text = p4
        'p1 = num5 * 100 / 100
        'lblPerNet.Text = p5
        'p1 = num6 * 100 / 100
        'lblPerFIT.Text = p6


        'For All Courses Percentage
        Dim per As Integer
        per = Obtain / 6
        lblPercentage.Text = per

        'For All Courses GPA
        per = Convert.ToInt32(lblPercentage.Text)
        If Per >= 85 And Per <= 100 Then
            lblGPA.Text = “4.0”
        ElseIf Per >= 80 And Per <= 84
            lblGPA.Text = “3.7”
        ElseIf Per >= 75 And Per <= 79
            lblGPA.Text = “3.3”
        ElseIf Per >= 70 And Per <= 74
            lblGPA.Text = “3.0”
        ElseIf Per >= 65 And Per <= 69
            lblGPA.Text = “2.7”
        ElseIf Per >= 61 And Per <= 64
            lblGPA.Text = “2.3”
        ElseIf Per >= 58 And Per <= 60
            lblGPA.Text = “2.0”
        ElseIf Per >= 55 And Per <= 57
            lblGPA.Text = “1.7”
        ElseIf Per >= 50 And Per <= 54
            lblGPA.Text = “1.0”
        ElseIf Per >= 0 And Per <= 49
            lblGPA.Text = “0.0”
        End If




    End Sub
End Class
