Public Class form1

    ' Swaps views inside pnlContent and updates the header text dynamically

    Private Sub LoadView(uc As UserControl, pageTitle As String)
        ' Updates the text inside your header label
        lblTitle.Text = pageTitle

        PnlContent.Controls.Clear()
        uc.Dock = DockStyle.Fill
        PnlContent.Controls.Add(uc)
    End Sub
    Private Sub SetACtiveButton(activeBtn As Button)
        btnInquiry.BackColor = Color.White
        btnInquiry.ForeColor = Color.Black

        btnRecords.BackColor = Color.White
        btnRecords.ForeColor = Color.Black

        ' Highlight the selected button with your Canva bright green
        activeBtn.BackColor = Color.FromArgb(50, 205, 50) ' Lime / Green accent
        activeBtn.ForeColor = Color.White
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetACtiveButton(btnInquiry)
        LoadView(New ucConsultationInquiry(), "Student Consultation")
    End Sub

    Private Sub btnInquiry_Click(sender As Object, e As EventArgs) Handles btnInquiry.Click
        SetACtiveButton(btnInquiry)
        LoadView(New ucConsultationInquiry(), "Student Consultation")
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        SetACtiveButton(btnRecords)
        LoadView(New ucConsultationRecords(), "Consultation History")
    End Sub

    Private Sub PnlContent_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PnlContent_Paint_1(sender As Object, e As PaintEventArgs) Handles PnlContent.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblTitle_Paint(sender As Object, e As PaintEventArgs) Handles lblTitle.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class