<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.lblchange = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnezwich = New System.Windows.Forms.Button
        Me.btnnhis = New System.Windows.Forms.Button
        Me.btnclearsale = New System.Windows.Forms.Button
        Me.btncashpayment = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Lime
        Me.txttotal.Location = New System.Drawing.Point(86, 12)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(171, 43)
        Me.txttotal.TabIndex = 65
        Me.txttotal.Text = "GHC0.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.Location = New System.Drawing.Point(12, 21)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(67, 18)
        Me.lblchange.TabIndex = 64
        Me.lblchange.Text = "Change :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 38)
        Me.Button1.TabIndex = 63
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 38)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnezwich
        '
        Me.btnezwich.Location = New System.Drawing.Point(147, 83)
        Me.btnezwich.Name = "btnezwich"
        Me.btnezwich.Size = New System.Drawing.Size(79, 38)
        Me.btnezwich.TabIndex = 61
        Me.btnezwich.Text = "E-ZWICH"
        Me.btnezwich.UseVisualStyleBackColor = True
        '
        'btnnhis
        '
        Me.btnnhis.Location = New System.Drawing.Point(27, 142)
        Me.btnnhis.Name = "btnnhis"
        Me.btnnhis.Size = New System.Drawing.Size(79, 38)
        Me.btnnhis.TabIndex = 60
        Me.btnnhis.Text = "NHIS"
        Me.btnnhis.UseVisualStyleBackColor = True
        '
        'btnclearsale
        '
        Me.btnclearsale.Location = New System.Drawing.Point(27, 197)
        Me.btnclearsale.Name = "btnclearsale"
        Me.btnclearsale.Size = New System.Drawing.Size(79, 38)
        Me.btnclearsale.TabIndex = 59
        Me.btnclearsale.UseVisualStyleBackColor = True
        '
        'btncashpayment
        '
        Me.btncashpayment.Location = New System.Drawing.Point(27, 83)
        Me.btncashpayment.Name = "btncashpayment"
        Me.btncashpayment.Size = New System.Drawing.Size(79, 38)
        Me.btncashpayment.TabIndex = 58
        Me.btncashpayment.Text = "CASH"
        Me.btncashpayment.UseVisualStyleBackColor = True
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 317)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnezwich)
        Me.Controls.Add(Me.btnnhis)
        Me.Controls.Add(Me.btnclearsale)
        Me.Controls.Add(Me.btncashpayment)
        Me.Name = "frmCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents lblchange As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnezwich As System.Windows.Forms.Button
    Friend WithEvents btnnhis As System.Windows.Forms.Button
    Friend WithEvents btnclearsale As System.Windows.Forms.Button
    Friend WithEvents btncashpayment As System.Windows.Forms.Button
End Class
