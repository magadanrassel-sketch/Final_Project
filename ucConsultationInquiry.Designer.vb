<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucConsultationInquiry
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        txtStudentID = New TextBox()
        txtYearProgram = New TextBox()
        txtStudentName = New TextBox()
        cmbStatus = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cmbPersonnel = New ComboBox()
        Label8 = New Label()
        dtpDate = New DateTimePicker()
        cmbTime = New ComboBox()
        Label9 = New Label()
        Label10 = New Label()
        cmbReason = New ComboBox()
        Button1 = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label1.Location = New Point(102, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 30)
        Label1.TabIndex = 0
        Label1.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.Location = New Point(102, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 30)
        Label2.TabIndex = 1
        Label2.Text = "Student Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.Location = New Point(102, 338)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 30)
        Label3.TabIndex = 2
        Label3.Text = "Year and Program"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label4.Location = New Point(102, 422)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 30)
        Label4.TabIndex = 3
        Label4.Text = "Status"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Location = New Point(442, 67)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2, 522)
        Panel1.TabIndex = 4
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(112, 209)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(150, 31)
        txtStudentID.TabIndex = 5
        ' 
        ' txtYearProgram
        ' 
        txtYearProgram.Location = New Point(113, 371)
        txtYearProgram.Name = "txtYearProgram"
        txtYearProgram.Size = New Size(150, 31)
        txtYearProgram.TabIndex = 7
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Location = New Point(113, 292)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(256, 31)
        txtStudentName.TabIndex = 8
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Regular", "Irregular"})
        cmbStatus.Location = New Point(112, 457)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(182, 33)
        cmbStatus.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(43, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 54)
        Label5.TabIndex = 11
        Label5.Text = "Student "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(542, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(242, 54)
        Label6.TabIndex = 12
        Label6.Text = "Counselling"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label7.Location = New Point(542, 173)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 30)
        Label7.TabIndex = 13
        Label7.Text = "Personnel"
        ' 
        ' cmbPersonnel
        ' 
        cmbPersonnel.FormattingEnabled = True
        cmbPersonnel.Location = New Point(554, 209)
        cmbPersonnel.Name = "cmbPersonnel"
        cmbPersonnel.Size = New Size(182, 33)
        cmbPersonnel.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label8.Location = New Point(534, 256)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 30)
        Label8.TabIndex = 15
        Label8.Text = " Date"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(555, 292)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(300, 31)
        dtpDate.TabIndex = 16
        ' 
        ' cmbTime
        ' 
        cmbTime.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTime.FormattingEnabled = True
        cmbTime.Items.AddRange(New Object() {"9:00 - 10:00"})
        cmbTime.Location = New Point(555, 369)
        cmbTime.Name = "cmbTime"
        cmbTime.Size = New Size(182, 33)
        cmbTime.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label9.Location = New Point(542, 338)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 30)
        Label9.TabIndex = 18
        Label9.Text = "Time"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.FlatStyle = FlatStyle.System
        Label10.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label10.Location = New Point(550, 422)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 30)
        Label10.TabIndex = 19
        Label10.Text = "Concern"
        ' 
        ' cmbReason
        ' 
        cmbReason.DropDownStyle = ComboBoxStyle.DropDownList
        cmbReason.FormattingEnabled = True
        cmbReason.Items.AddRange(New Object() {"Regular", "Irregular"})
        cmbReason.Location = New Point(555, 457)
        cmbReason.Name = "cmbReason"
        cmbReason.Size = New Size(316, 33)
        cmbReason.TabIndex = 20
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(693, 522)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 34)
        Button1.TabIndex = 21
        Button1.Text = "Confirm Booking"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.Font = New Font("Segoe UI", 7F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(729, 555)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(111, 34)
        btnCancel.TabIndex = 22
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' ucConsultationInquiry
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnCancel)
        Controls.Add(Button1)
        Controls.Add(cmbReason)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(cmbTime)
        Controls.Add(dtpDate)
        Controls.Add(Label8)
        Controls.Add(cmbPersonnel)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(cmbStatus)
        Controls.Add(txtStudentName)
        Controls.Add(txtYearProgram)
        Controls.Add(txtStudentID)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ucConsultationInquiry"
        Size = New Size(953, 619)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtYearProgram As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPersonnel As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbTime As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbReason As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button

End Class
