<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSelect = New System.Windows.Forms.ComboBox()
        Me.btmRSelect = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnFine = New System.Windows.Forms.Button()
        Me.txtdue = New System.Windows.Forms.TextBox()
        Me.txtled = New System.Windows.Forms.TextBox()
        Me.txtmem = New System.Windows.Forms.TextBox()
        Me.txtmat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 170)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(974, 10)
        Me.Panel6.TabIndex = 26
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.txtSelect)
        Me.Panel9.Controls.Add(Me.btmRSelect)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 113)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(974, 57)
        Me.Panel9.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(605, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Please note that Lend IDs are non-returnable until the due date"
        '
        'txtSelect
        '
        Me.txtSelect.FormattingEnabled = True
        Me.txtSelect.Location = New System.Drawing.Point(478, 21)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(121, 21)
        Me.txtSelect.TabIndex = 12
        '
        'btmRSelect
        '
        Me.btmRSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btmRSelect.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmRSelect.Image = Global.LMS.My.Resources.Resources.selection
        Me.btmRSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btmRSelect.Location = New System.Drawing.Point(377, 8)
        Me.btmRSelect.Name = "btmRSelect"
        Me.btmRSelect.Size = New System.Drawing.Size(86, 43)
        Me.btmRSelect.TabIndex = 11
        Me.btmRSelect.Text = "SELECT"
        Me.btmRSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btmRSelect.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 103)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(974, 10)
        Me.Panel10.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(974, 103)
        Me.Panel4.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(796, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Live Date and time"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Uighur", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(108, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(629, 83)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Library Managment System -Fine"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.LMS.My.Resources.Resources.books
        Me.PictureBox1.Location = New System.Drawing.Point(31, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 577)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(974, 10)
        Me.Panel11.TabIndex = 35
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.Label16)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 587)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(974, 30)
        Me.Panel12.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(402, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(171, 23)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "© All Rights Reserved by Janiskanth"
        '
        'btnFine
        '
        Me.btnFine.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFine.Image = Global.LMS.My.Resources.Resources.fine__1_
        Me.btnFine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFine.Location = New System.Drawing.Point(425, 499)
        Me.btnFine.Name = "btnFine"
        Me.btnFine.Size = New System.Drawing.Size(103, 47)
        Me.btnFine.TabIndex = 39
        Me.btnFine.Text = "FINE"
        Me.btnFine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFine.UseVisualStyleBackColor = True
        '
        'txtdue
        '
        Me.txtdue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdue.BackColor = System.Drawing.Color.FloralWhite
        Me.txtdue.Location = New System.Drawing.Point(403, 361)
        Me.txtdue.Name = "txtdue"
        Me.txtdue.ReadOnly = True
        Me.txtdue.Size = New System.Drawing.Size(307, 20)
        Me.txtdue.TabIndex = 44
        '
        'txtled
        '
        Me.txtled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtled.BackColor = System.Drawing.Color.FloralWhite
        Me.txtled.Location = New System.Drawing.Point(403, 319)
        Me.txtled.Name = "txtled"
        Me.txtled.ReadOnly = True
        Me.txtled.Size = New System.Drawing.Size(307, 20)
        Me.txtled.TabIndex = 45
        '
        'txtmem
        '
        Me.txtmem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmem.BackColor = System.Drawing.Color.FloralWhite
        Me.txtmem.Location = New System.Drawing.Point(403, 277)
        Me.txtmem.Name = "txtmem"
        Me.txtmem.ReadOnly = True
        Me.txtmem.Size = New System.Drawing.Size(307, 20)
        Me.txtmem.TabIndex = 46
        '
        'txtmat
        '
        Me.txtmat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmat.BackColor = System.Drawing.Color.FloralWhite
        Me.txtmat.Location = New System.Drawing.Point(403, 235)
        Me.txtmat.Name = "txtmat"
        Me.txtmat.ReadOnly = True
        Me.txtmat.Size = New System.Drawing.Size(307, 20)
        Me.txtmat.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Image = Global.LMS.My.Resources.Resources.calendar__1_
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(265, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 17)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "     LEND DATE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Image = Global.LMS.My.Resources.Resources.id_card__1_
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(265, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "     MEMBER ID"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Image = Global.LMS.My.Resources.Resources.calendar__1_
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Location = New System.Drawing.Point(265, 365)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "     DUE DATE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Image = Global.LMS.My.Resources.Resources.book__1_
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(265, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "     MATERIAL ID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = Global.LMS.My.Resources.Resources.receive_amount
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(179, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "     ENTER THE FINE AMOUNT "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmount.BackColor = System.Drawing.Color.FloralWhite
        Me.txtAmount.Location = New System.Drawing.Point(403, 402)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(307, 20)
        Me.txtAmount.TabIndex = 44
        '
        'frmFine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 617)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtdue)
        Me.Controls.Add(Me.txtled)
        Me.Controls.Add(Me.txtmem)
        Me.Controls.Add(Me.txtmat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnFine)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LMS - Fine"
        Me.Panel9.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btmRSelect As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFine As System.Windows.Forms.Button
    Friend WithEvents txtdue As System.Windows.Forms.TextBox
    Friend WithEvents txtled As System.Windows.Forms.TextBox
    Friend WithEvents txtmem As System.Windows.Forms.TextBox
    Friend WithEvents txtmat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
End Class
