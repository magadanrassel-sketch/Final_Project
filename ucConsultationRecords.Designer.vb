Partial Class ucConsultationRecords
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dtpFilterDate = New DateTimePicker()
        dgvRecords = New DataGridView()
        colStudentID = New DataGridViewTextBoxColumn()
        colYearProgram = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colTime = New DataGridViewTextBoxColumn()
        colReason = New DataGridViewTextBoxColumn()
        CType(dgvRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpFilterDate
        ' 
        dtpFilterDate.Location = New Point(25, 35)
        dtpFilterDate.Name = "dtpFilterDate"
        dtpFilterDate.Size = New Size(300, 31)
        dtpFilterDate.TabIndex = 0
        ' 
        ' dgvRecords
        ' 
        dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecords.BackgroundColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecords.Columns.AddRange(New DataGridViewColumn() {colStudentID, colYearProgram, colStatus, colDate, colTime, colReason})
        dgvRecords.EnableHeadersVisualStyles = False
        dgvRecords.GridColor = SystemColors.InfoText
        dgvRecords.Location = New Point(25, 89)
        dgvRecords.Name = "dgvRecords"
        dgvRecords.RowHeadersWidth = 62
        dgvRecords.Size = New Size(824, 380)
        dgvRecords.TabIndex = 1
        ' 
        ' colStudentID
        ' 
        colStudentID.HeaderText = "STUDENT_ID"
        colStudentID.MinimumWidth = 8
        colStudentID.Name = "colStudentID"
        ' 
        ' colYearProgram
        ' 
        colYearProgram.HeaderText = "YEAR & PROGRAM"
        colYearProgram.MinimumWidth = 8
        colYearProgram.Name = "colYearProgram"
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "STATUS"
        colStatus.MinimumWidth = 8
        colStatus.Name = "colStatus"
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "DATE"
        colDate.MinimumWidth = 8
        colDate.Name = "colDate"
        ' 
        ' colTime
        ' 
        colTime.HeaderText = "TIME"
        colTime.MinimumWidth = 8
        colTime.Name = "colTime"
        ' 
        ' colReason
        ' 
        colReason.HeaderText = "REASON"
        colReason.MinimumWidth = 8
        colReason.Name = "colReason"
        ' 
        ' ucConsultationRecords
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvRecords)
        Controls.Add(dtpFilterDate)
        Name = "ucConsultationRecords"
        Size = New Size(939, 612)
        CType(dgvRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtpFilterDate As DateTimePicker
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colYearProgram As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents colReason As DataGridViewTextBoxColumn

End Class
