<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefunds
    Inherits Kafeesa_Pharma.frmBaseform

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
        Me.btncheckout = New System.Windows.Forms.Button
        Me.btnlogout = New System.Windows.Forms.Button
        Me.btnclearsale = New System.Windows.Forms.Button
        Me.gb_details = New System.Windows.Forms.GroupBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.lblrefundamount = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblrefundstotal = New System.Windows.Forms.Label
        Me.btnremoveitem = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lblcashiername = New System.Windows.Forms.Label
        Me.lbl_cashier = New System.Windows.Forms.Label
        Me.txtinvoiceno = New System.Windows.Forms.TextBox
        Me.lbl_invoiceno = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.gb_details.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncheckout
        '
        Me.btncheckout.Location = New System.Drawing.Point(793, 395)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(79, 38)
        Me.btncheckout.TabIndex = 59
        Me.btncheckout.Text = "Make Refund"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(793, 490)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(79, 38)
        Me.btnlogout.TabIndex = 61
        Me.btnlogout.Text = "Close"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnclearsale
        '
        Me.btnclearsale.Location = New System.Drawing.Point(793, 442)
        Me.btnclearsale.Name = "btnclearsale"
        Me.btnclearsale.Size = New System.Drawing.Size(79, 38)
        Me.btnclearsale.TabIndex = 60
        Me.btnclearsale.Text = "Clear Refund"
        Me.btnclearsale.UseVisualStyleBackColor = True
        '
        'gb_details
        '
        Me.gb_details.Controls.Add(Me.TextBox7)
        Me.gb_details.Controls.Add(Me.TextBox4)
        Me.gb_details.Controls.Add(Me.TextBox3)
        Me.gb_details.Controls.Add(Me.lblrefundamount)
        Me.gb_details.Controls.Add(Me.Label4)
        Me.gb_details.Controls.Add(Me.Label3)
        Me.gb_details.Location = New System.Drawing.Point(514, 395)
        Me.gb_details.Name = "gb_details"
        Me.gb_details.Size = New System.Drawing.Size(273, 126)
        Me.gb_details.TabIndex = 58
        Me.gb_details.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(104, 82)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(151, 20)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(104, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(151, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox3.Location = New System.Drawing.Point(104, 17)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(151, 20)
        Me.TextBox3.TabIndex = 3
        '
        'lblrefundamount
        '
        Me.lblrefundamount.AutoSize = True
        Me.lblrefundamount.Location = New System.Drawing.Point(19, 85)
        Me.lblrefundamount.Name = "lblrefundamount"
        Me.lblrefundamount.Size = New System.Drawing.Size(87, 13)
        Me.lblrefundamount.TabIndex = 3
        Me.lblrefundamount.Text = "Refund Amount :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NHIL :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "VAT :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(612, 301)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 49)
        Me.TextBox1.TabIndex = 64
        Me.TextBox1.Text = "GHC0.00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblrefundstotal
        '
        Me.lblrefundstotal.AutoSize = True
        Me.lblrefundstotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrefundstotal.Location = New System.Drawing.Point(540, 301)
        Me.lblrefundstotal.Name = "lblrefundstotal"
        Me.lblrefundstotal.Size = New System.Drawing.Size(49, 18)
        Me.lblrefundstotal.TabIndex = 63
        Me.lblrefundstotal.Text = "Total :"
        '
        'btnremoveitem
        '
        Me.btnremoveitem.Location = New System.Drawing.Point(133, 301)
        Me.btnremoveitem.Name = "btnremoveitem"
        Me.btnremoveitem.Size = New System.Drawing.Size(124, 31)
        Me.btnremoveitem.TabIndex = 62
        Me.btnremoveitem.Text = "Remove Item"
        Me.btnremoveitem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(133, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 169)
        Me.DataGridView1.TabIndex = 65
        '
        'lblcashiername
        '
        Me.lblcashiername.AutoSize = True
        Me.lblcashiername.Location = New System.Drawing.Point(770, 64)
        Me.lblcashiername.Name = "lblcashiername"
        Me.lblcashiername.Size = New System.Drawing.Size(102, 13)
        Me.lblcashiername.TabIndex = 69
        Me.lblcashiername.Text = "Cashier's name here"
        '
        'lbl_cashier
        '
        Me.lbl_cashier.AutoSize = True
        Me.lbl_cashier.Location = New System.Drawing.Point(716, 64)
        Me.lbl_cashier.Name = "lbl_cashier"
        Me.lbl_cashier.Size = New System.Drawing.Size(48, 13)
        Me.lbl_cashier.TabIndex = 68
        Me.lbl_cashier.Text = "Cashier :"
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.Location = New System.Drawing.Point(200, 61)
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.Size = New System.Drawing.Size(79, 20)
        Me.txtinvoiceno.TabIndex = 67
        '
        'lbl_invoiceno
        '
        Me.lbl_invoiceno.AutoSize = True
        Me.lbl_invoiceno.Location = New System.Drawing.Point(126, 61)
        Me.lbl_invoiceno.Name = "lbl_invoiceno"
        Me.lbl_invoiceno.Size = New System.Drawing.Size(68, 13)
        Me.lbl_invoiceno.TabIndex = 66
        Me.lbl_invoiceno.Text = "Invoice No. :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(429, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 16)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "REFUNDS SCREEN"
        '
        'frmRefunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 694)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblcashiername)
        Me.Controls.Add(Me.lbl_cashier)
        Me.Controls.Add(Me.txtinvoiceno)
        Me.Controls.Add(Me.lbl_invoiceno)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblrefundstotal)
        Me.Controls.Add(Me.btnremoveitem)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnclearsale)
        Me.Controls.Add(Me.gb_details)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmRefunds"
        Me.Text = "Refunds"
        Me.Controls.SetChildIndex(Me.gb_details, 0)
        Me.Controls.SetChildIndex(Me.btnclearsale, 0)
        Me.Controls.SetChildIndex(Me.btnlogout, 0)
        Me.Controls.SetChildIndex(Me.btncheckout, 0)
        Me.Controls.SetChildIndex(Me.btnremoveitem, 0)
        Me.Controls.SetChildIndex(Me.lblrefundstotal, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.lbl_invoiceno, 0)
        Me.Controls.SetChildIndex(Me.txtinvoiceno, 0)
        Me.Controls.SetChildIndex(Me.lbl_cashier, 0)
        Me.Controls.SetChildIndex(Me.lblcashiername, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.gb_details.ResumeLayout(False)
        Me.gb_details.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncheckout As System.Windows.Forms.Button
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnclearsale As System.Windows.Forms.Button
    Friend WithEvents gb_details As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblrefundamount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblrefundstotal As System.Windows.Forms.Label
    Friend WithEvents btnremoveitem As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblcashiername As System.Windows.Forms.Label
    Friend WithEvents lbl_cashier As System.Windows.Forms.Label
    Friend WithEvents txtinvoiceno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_invoiceno As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
