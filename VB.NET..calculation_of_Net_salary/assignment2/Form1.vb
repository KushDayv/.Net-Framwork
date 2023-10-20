Public Class Form1
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
    'The source code for the compute button 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hoursworked As Integer = Convert.ToInt32(TextBox1.Text)
        Dim hourlyRate As Integer = Convert.ToInt32(TextBox4.Text)
        Dim daysWorked As Integer = Convert.ToInt32(TextBox3.Text)
        Dim grosspay As Integer
        Dim dailySalary As Integer
        Dim paye As Integer
        Dim nssf As Integer
        Dim nhif As Integer
        Dim others As Integer
        Dim allowances As Integer = Convert.ToInt32(TextBox14.Text)
        Dim totalDeductions As Integer
        Dim netSalary As Integer


        If Integer.Parse(hoursworked) AndAlso
            Integer.Parse(hourlyRate) AndAlso
            Integer.Parse(daysWorked) Then
            If hoursworked <= 8 AndAlso hourlyRate <= 5000 AndAlso daysWorked <= 30 Then
                'Calculating the gross pay 
                'dailysalary = hoursworked * hourlyrate
                'Grosspay = dailysalary * daysworked
                dailySalary = (hoursworked * hourlyRate)
                grosspay = dailySalary * daysWorked
                TextBox5.Text = grosspay

                paye = 0.07 * grosspay
                nssf = 0.03 * grosspay
                nhif = 0.05 * grosspay
                totalDeductions = paye + nssf + nhif + others
                netSalary = (grosspay + allowances) - totalDeductions
                others = 0
                TextBox12.Text = others


                'Outputs
                TextBox10.Text = paye
                TextBox9.Text = nssf
                TextBox11.Text = nhif
                TextBox13.Text = totalDeductions
                TextBox7.Text = totalDeductions
                TextBox8.Text = netSalary
                TextBox6.Text = grosspay

                If grosspay > 100000 Then
                    others = 0.015 * grosspay
                    TextBox12.Text = others
                End If
            Else
                MessageBox.Show("The Hours Worked must be less than 8!!")
                MessageBox.Show("The Hourly Rate must be less than 5000!!")
                MessageBox.Show("The Days Worked should be less than 30!!")
            End If
        End If

    End Sub

    'The source code for the Reset Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox5.Text = String.Empty
        TextBox10.Text = String.Empty
        TextBox9.Text = String.Empty
        TextBox11.Text = String.Empty
        TextBox13.Text = String.Empty
        TextBox7.Text = String.Empty
        TextBox8.Text = String.Empty
        TextBox12.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox14.Clear()


    End Sub

    'The source code for the Exit button 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
