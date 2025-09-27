<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_10))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.lblPrevious = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNext = New payment_OMC.roundCornerButton()
        Me.pnlTNG = New payment_OMC.roundCornerPanel()
        Me.chkTNG = New System.Windows.Forms.CheckBox()
        Me.picTng = New System.Windows.Forms.PictureBox()
        Me.pnlOnlineBanking = New payment_OMC.roundCornerPanel()
        Me.pnlMaybank = New payment_OMC.roundCornerPanel()
        Me.chkMaybank = New System.Windows.Forms.CheckBox()
        Me.picMaybank = New System.Windows.Forms.PictureBox()
        Me.chkOnlineBanking = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlTNG.SuspendLayout()
        CType(Me.picTng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOnlineBanking.SuspendLayout()
        Me.pnlMaybank.SuspendLayout()
        CType(Me.picMaybank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picUser)
        Me.Panel1.Controls.Add(Me.lblPrevious)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 61)
        Me.Panel1.TabIndex = 1
        '
        'picUser
        '
        Me.picUser.Image = CType(resources.GetObject("picUser.Image"), System.Drawing.Image)
        Me.picUser.Location = New System.Drawing.Point(304, 3)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(59, 55)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser.TabIndex = 7
        Me.picUser.TabStop = False
        '
        'lblPrevious
        '
        Me.lblPrevious.AutoSize = True
        Me.lblPrevious.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevious.ForeColor = System.Drawing.Color.White
        Me.lblPrevious.Location = New System.Drawing.Point(13, 21)
        Me.lblPrevious.Name = "lblPrevious"
        Me.lblPrevious.Size = New System.Drawing.Size(61, 17)
        Me.lblPrevious.TabIndex = 5
        Me.lblPrevious.Text = "<Student"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(263, 21)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(35, 17)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "User"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 716)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 91)
        Me.Panel2.TabIndex = 7
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(22, 616)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(330, 53)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pnlTNG
        '
        Me.pnlTNG.BackColor = System.Drawing.Color.White
        Me.pnlTNG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTNG.Controls.Add(Me.chkTNG)
        Me.pnlTNG.Controls.Add(Me.picTng)
        Me.pnlTNG.Location = New System.Drawing.Point(15, 226)
        Me.pnlTNG.Name = "pnlTNG"
        Me.pnlTNG.Size = New System.Drawing.Size(341, 124)
        Me.pnlTNG.TabIndex = 6
        '
        'chkTNG
        '
        Me.chkTNG.AutoSize = True
        Me.chkTNG.Location = New System.Drawing.Point(12, 7)
        Me.chkTNG.Name = "chkTNG"
        Me.chkTNG.Size = New System.Drawing.Size(101, 20)
        Me.chkTNG.TabIndex = 10
        Me.chkTNG.Text = "Touch N Go"
        Me.chkTNG.UseVisualStyleBackColor = True
        '
        'picTng
        '
        Me.picTng.BackColor = System.Drawing.Color.Transparent
        Me.picTng.Image = CType(resources.GetObject("picTng.Image"), System.Drawing.Image)
        Me.picTng.Location = New System.Drawing.Point(12, 33)
        Me.picTng.Name = "picTng"
        Me.picTng.Size = New System.Drawing.Size(218, 65)
        Me.picTng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTng.TabIndex = 10
        Me.picTng.TabStop = False
        '
        'pnlOnlineBanking
        '
        Me.pnlOnlineBanking.BackColor = System.Drawing.Color.White
        Me.pnlOnlineBanking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOnlineBanking.Controls.Add(Me.pnlMaybank)
        Me.pnlOnlineBanking.Controls.Add(Me.chkOnlineBanking)
        Me.pnlOnlineBanking.Location = New System.Drawing.Point(15, 84)
        Me.pnlOnlineBanking.Name = "pnlOnlineBanking"
        Me.pnlOnlineBanking.Size = New System.Drawing.Size(341, 124)
        Me.pnlOnlineBanking.TabIndex = 4
        '
        'pnlMaybank
        '
        Me.pnlMaybank.BackColor = System.Drawing.Color.White
        Me.pnlMaybank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMaybank.Controls.Add(Me.chkMaybank)
        Me.pnlMaybank.Controls.Add(Me.picMaybank)
        Me.pnlMaybank.Location = New System.Drawing.Point(-2, -2)
        Me.pnlMaybank.Name = "pnlMaybank"
        Me.pnlMaybank.Size = New System.Drawing.Size(341, 124)
        Me.pnlMaybank.TabIndex = 5
        '
        'chkMaybank
        '
        Me.chkMaybank.AutoSize = True
        Me.chkMaybank.Location = New System.Drawing.Point(9, 8)
        Me.chkMaybank.Name = "chkMaybank"
        Me.chkMaybank.Size = New System.Drawing.Size(85, 20)
        Me.chkMaybank.TabIndex = 9
        Me.chkMaybank.Text = "Maybank"
        Me.chkMaybank.UseVisualStyleBackColor = True
        '
        'picMaybank
        '
        Me.picMaybank.BackColor = System.Drawing.Color.Transparent
        Me.picMaybank.Image = CType(resources.GetObject("picMaybank.Image"), System.Drawing.Image)
        Me.picMaybank.Location = New System.Drawing.Point(3, 14)
        Me.picMaybank.Name = "picMaybank"
        Me.picMaybank.Size = New System.Drawing.Size(227, 94)
        Me.picMaybank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMaybank.TabIndex = 7
        Me.picMaybank.TabStop = False
        '
        'chkOnlineBanking
        '
        Me.chkOnlineBanking.AutoSize = True
        Me.chkOnlineBanking.Location = New System.Drawing.Point(9, 8)
        Me.chkOnlineBanking.Name = "chkOnlineBanking"
        Me.chkOnlineBanking.Size = New System.Drawing.Size(119, 20)
        Me.chkOnlineBanking.TabIndex = 3
        Me.chkOnlineBanking.Text = "Online Banking"
        Me.chkOnlineBanking.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(156, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(294, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'frm_10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(375, 805)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pnlTNG)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlOnlineBanking)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_10"
        Me.Text = "Payment Method"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlTNG.ResumeLayout(False)
        Me.pnlTNG.PerformLayout()
        CType(Me.picTng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOnlineBanking.ResumeLayout(False)
        Me.pnlOnlineBanking.PerformLayout()
        Me.pnlMaybank.ResumeLayout(False)
        Me.pnlMaybank.PerformLayout()
        CType(Me.picMaybank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPrevious As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents chkOnlineBanking As CheckBox
    Friend WithEvents pnlOnlineBanking As roundCornerPanel
    Friend WithEvents pnlMaybank As roundCornerPanel
    Friend WithEvents pnlTNG As roundCornerPanel
    Friend WithEvents chkTNG As CheckBox
    Friend WithEvents chkMaybank As CheckBox
    Friend WithEvents picUser As PictureBox
    Friend WithEvents picMaybank As PictureBox
    Friend WithEvents picTng As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNext As roundCornerButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
