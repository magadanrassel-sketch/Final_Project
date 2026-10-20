Imports System.Drawing.Text

Public Class ucConsultationRecords
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ucConsultationRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center-align headers and row text
        dgvRecords.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvRecords.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Add sample rows matching your Canva mockup
        dgvRecords.Rows.Add("25-00781", "BSIT-2C", "REGULAR", "09-16-2026", "8:00am - 9:00am", "Grade related Concerns")
        dgvRecords.Rows.Add("25-00781", "BSIT-2C", "REGULAR", "10-11-2026", "1:00pm - 2:00pm", "Classroom Bullying")
        dgvRecords.Rows.Add("..........", ".............", "..........", "..........", "............", ".......")
    End Sub

End Class
