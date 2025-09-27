<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_11))
        Me.picQrM = New System.Windows.Forms.PictureBox()
        Me.btnCompletePayment = New payment_OMC.roundCornerButton()
        CType(Me.picQrM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picQrM
        '
        Me.picQrM.Image = CType(resources.GetObject("picQrM.Image"), System.Drawing.Image)
        Me.picQrM.Location = New System.Drawing.Point(23, 98)
        Me.picQrM.Name = "picQrM"
        Me.picQrM.Size = New System.Drawing.Size(324, 467)
        Me.picQrM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQrM.TabIndex = 0
        Me.picQrM.TabStop = False
        '
        'btnCompletePayment
        '
        Me.btnCompletePayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCompletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompletePayment.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompletePayment.ForeColor = System.Drawing.Color.Black
        Me.btnCompletePayment.Location = New System.Drawing.Point(23, 618)
        Me.btnCompletePayment.Name = "btnCompletePayment"
        Me.btnCompletePayment.Size = New System.Drawing.Size(330, 53)
        Me.btnCompletePayment.TabIndex = 9
        Me.btnCompletePayment.Text = "Complete Payment"
        Me.btnCompletePayment.UseVisualStyleBackColor = False
        '
        'frm_11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(375, 805)
        Me.Controls.Add(Me.btnCompletePayment)
        Me.Controls.Add(Me.picQrM)
        Me.Name = "frm_11"
        Me.Text = "frm_11"
        CType(Me.picQrM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picQrM As PictureBox
    Friend WithEvents btnCompletePayment As roundCornerButton
End Class
