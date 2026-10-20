<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        PnlContent = New Panel()
        lblTitle = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        btnInquiry = New Button()
        btnRecords = New Button()
        PictureBox1 = New PictureBox()
        lblTitle.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlContent
        ' 
        PnlContent.Anchor = AnchorStyles.None
        PnlContent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PnlContent.BackColor = SystemColors.Control
        PnlContent.Location = New Point(380, 69)
        PnlContent.Name = "PnlContent"
        PnlContent.Size = New Size(984, 645)
        PnlContent.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = SystemColors.ButtonHighlight
        lblTitle.Controls.Add(Label2)
        lblTitle.Controls.Add(Label1)
        lblTitle.Dock = DockStyle.Top
        lblTitle.Location = New Point(374, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(990, 63)
        lblTitle.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(806, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 48)
        Label2.TabIndex = 1
        Label2.Text = "PLPortal"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(397, 48)
        Label1.TabIndex = 0
        Label1.Text = "Student Consultation"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(btnInquiry)
        Panel3.Controls.Add(btnRecords)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(374, 714)
        Panel3.TabIndex = 0
        ' 
        ' btnInquiry
        ' 
        btnInquiry.Location = New Point(56, 169)
        btnInquiry.Name = "btnInquiry"
        btnInquiry.Size = New Size(258, 34)
        btnInquiry.TabIndex = 1
        btnInquiry.Text = "CONSULTATION INQUIRY"
        btnInquiry.UseVisualStyleBackColor = True
        ' 
        ' btnRecords
        ' 
        btnRecords.Location = New Point(56, 224)
        btnRecords.Name = "btnRecords"
        btnRecords.Size = New Size(258, 34)
        btnRecords.TabIndex = 1
        btnRecords.Text = "CONSULTATION RECORDS"
        btnRecords.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(130, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 112)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1364, 714)
        Controls.Add(lblTitle)
        Controls.Add(Panel3)
        Controls.Add(PnlContent)
        Name = "form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        lblTitle.ResumeLayout(False)
        lblTitle.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlContent As Panel
    Friend WithEvents lblTitle As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnInquiry As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
