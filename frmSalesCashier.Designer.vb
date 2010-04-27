<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesCashier
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
        Me.txtcashiertotalsale = New System.Windows.Forms.TextBox
        Me.txtsearchbyproductname = New System.Windows.Forms.TextBox
        Me.btncheckout = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtcashieramountpaid = New System.Windows.Forms.TextBox
        Me.dgcart = New System.Windows.Forms.DataGridView
        Me.colproductname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colquantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colproductid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUnitprice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coldescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colextendedprice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gb_details = New System.Windows.Forms.GroupBox
        Me.txtcashierdiscount = New System.Windows.Forms.TextBox
        Me.txtcashiernhil = New System.Windows.Forms.TextBox
        Me.txtcashiervat = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbluser = New System.Windows.Forms.Label
        Me.txtcashiersaleid = New System.Windows.Forms.TextBox
        Me.lblemployeename1 = New System.Windows.Forms.Label
        Me.lbl_invoiceno = New System.Windows.Forms.Label
        Me.dgproductsearchlist = New System.Windows.Forms.DataGridView
        Me.btnclearsale = New System.Windows.Forms.Button
        Me.gb_perm_Customers = New System.Windows.Forms.GroupBox
        Me.btncustumeridsearch = New System.Windows.Forms.Button
        Me.txtcustomer_id = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnlogout = New System.Windows.Forms.Button
        Me.btnvalidatenhisid = New System.Windows.Forms.Button
        Me.gb_nhis = New System.Windows.Forms.GroupBox
        Me.txt_nhis_id = New System.Windows.Forms.TextBox
        Me.lbl_nhisid = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.btnrefunds = New System.Windows.Forms.Button
        Me.lbl_total = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblquicksearch = New System.Windows.Forms.Label
        Me.btncartremoveitem = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        CType(Me.dgcart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_details.SuspendLayout()
        CType(Me.dgproductsearchlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_perm_Customers.SuspendLayout()
        Me.gb_nhis.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcashiertotalsale
        '
        Me.txtcashiertotalsale.Location = New System.Drawing.Point(104, 147)
        Me.txtcashiertotalsale.Name = "txtcashiertotalsale"
        Me.txtcashiertotalsale.ReadOnly = True
        Me.txtcashiertotalsale.Size = New System.Drawing.Size(151, 20)
        Me.txtcashiertotalsale.TabIndex = 8
        '
        'txtsearchbyproductname
        '
        Me.txtsearchbyproductname.Location = New System.Drawing.Point(54, 137)
        Me.txtsearchbyproductname.Name = "txtsearchbyproductname"
        Me.txtsearchbyproductname.Size = New System.Drawing.Size(315, 20)
        Me.txtsearchbyproductname.TabIndex = 58
        '
        'btncheckout
        '
        Me.btncheckout.Location = New System.Drawing.Point(799, 451)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(79, 38)
        Me.btncheckout.TabIndex = 59
        Me.btncheckout.Text = "Checkout"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(406, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 16)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "SALES CASHIER SCREEN"
        '
        'txtcashieramountpaid
        '
        Me.txtcashieramountpaid.Location = New System.Drawing.Point(104, 111)
        Me.txtcashieramountpaid.Name = "txtcashieramountpaid"
        Me.txtcashieramountpaid.Size = New System.Drawing.Size(151, 20)
        Me.txtcashieramountpaid.TabIndex = 3
        '
        'dgcart
        '
        Me.dgcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colproductname, Me.colquantity, Me.colproductid, Me.colUnitprice, Me.coldescription, Me.colextendedprice})
        Me.dgcart.Location = New System.Drawing.Point(127, 194)
        Me.dgcart.Name = "dgcart"
        Me.dgcart.Size = New System.Drawing.Size(752, 180)
        Me.dgcart.TabIndex = 78
        '
        'colproductname
        '
        Me.colproductname.HeaderText = "Product name"
        Me.colproductname.Name = "colproductname"
        Me.colproductname.Width = 170
        '
        'colquantity
        '
        Me.colquantity.HeaderText = "Quantity"
        Me.colquantity.Name = "colquantity"
        Me.colquantity.Width = 50
        '
        'colproductid
        '
        Me.colproductid.HeaderText = "Product_ID"
        Me.colproductid.Name = "colproductid"
        Me.colproductid.Visible = False
        '
        'colUnitprice
        '
        Me.colUnitprice.HeaderText = "Unit price"
        Me.colUnitprice.Name = "colUnitprice"
        Me.colUnitprice.ReadOnly = True
        Me.colUnitprice.Width = 50
        '
        'coldescription
        '
        Me.coldescription.HeaderText = "Description"
        Me.coldescription.Name = "coldescription"
        Me.coldescription.ReadOnly = True
        Me.coldescription.Width = 260
        '
        'colextendedprice
        '
        Me.colextendedprice.HeaderText = "Extended price"
        Me.colextendedprice.Name = "colextendedprice"
        Me.colextendedprice.ReadOnly = True
        Me.colextendedprice.Width = 178
        '
        'gb_details
        '
        Me.gb_details.Controls.Add(Me.txtcashiertotalsale)
        Me.gb_details.Controls.Add(Me.txtcashieramountpaid)
        Me.gb_details.Controls.Add(Me.txtcashierdiscount)
        Me.gb_details.Controls.Add(Me.txtcashiernhil)
        Me.gb_details.Controls.Add(Me.txtcashiervat)
        Me.gb_details.Controls.Add(Me.Label7)
        Me.gb_details.Controls.Add(Me.Label6)
        Me.gb_details.Controls.Add(Me.Label5)
        Me.gb_details.Controls.Add(Me.Label4)
        Me.gb_details.Controls.Add(Me.Label3)
        Me.gb_details.Location = New System.Drawing.Point(405, 451)
        Me.gb_details.Name = "gb_details"
        Me.gb_details.Size = New System.Drawing.Size(273, 188)
        Me.gb_details.TabIndex = 69
        Me.gb_details.TabStop = False
        '
        'txtcashierdiscount
        '
        Me.txtcashierdiscount.Location = New System.Drawing.Point(104, 78)
        Me.txtcashierdiscount.Name = "txtcashierdiscount"
        Me.txtcashierdiscount.Size = New System.Drawing.Size(151, 20)
        Me.txtcashierdiscount.TabIndex = 2
        '
        'txtcashiernhil
        '
        Me.txtcashiernhil.Location = New System.Drawing.Point(104, 48)
        Me.txtcashiernhil.Name = "txtcashiernhil"
        Me.txtcashiernhil.ReadOnly = True
        Me.txtcashiernhil.Size = New System.Drawing.Size(151, 20)
        Me.txtcashiernhil.TabIndex = 5
        '
        'txtcashiervat
        '
        Me.txtcashiervat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtcashiervat.Location = New System.Drawing.Point(104, 17)
        Me.txtcashiervat.Name = "txtcashiervat"
        Me.txtcashiervat.ReadOnly = True
        Me.txtcashiervat.Size = New System.Drawing.Size(151, 20)
        Me.txtcashiervat.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Amount Paid :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total Sale :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Discount :"
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
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(737, 60)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(35, 13)
        Me.lbluser.TabIndex = 62
        Me.lbluser.Text = "User :"
        '
        'txtcashiersaleid
        '
        Me.txtcashiersaleid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtcashiersaleid.Location = New System.Drawing.Point(152, 64)
        Me.txtcashiersaleid.Name = "txtcashiersaleid"
        Me.txtcashiersaleid.ReadOnly = True
        Me.txtcashiersaleid.Size = New System.Drawing.Size(125, 20)
        Me.txtcashiersaleid.TabIndex = 61
        '
        'lblemployeename1
        '
        Me.lblemployeename1.AutoSize = True
        Me.lblemployeename1.Location = New System.Drawing.Point(776, 61)
        Me.lblemployeename1.Name = "lblemployeename1"
        Me.lblemployeename1.Size = New System.Drawing.Size(102, 13)
        Me.lblemployeename1.TabIndex = 63
        Me.lblemployeename1.Text = "Cashier's name here"
        '
        'lbl_invoiceno
        '
        Me.lbl_invoiceno.AutoSize = True
        Me.lbl_invoiceno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invoiceno.Location = New System.Drawing.Point(54, 67)
        Me.lbl_invoiceno.Name = "lbl_invoiceno"
        Me.lbl_invoiceno.Size = New System.Drawing.Size(94, 16)
        Me.lbl_invoiceno.TabIndex = 60
        Me.lbl_invoiceno.Text = "Invoice No. :"
        '
        'dgproductsearchlist
        '
        Me.dgproductsearchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgproductsearchlist.Location = New System.Drawing.Point(54, 160)
        Me.dgproductsearchlist.Name = "dgproductsearchlist"
        Me.dgproductsearchlist.Size = New System.Drawing.Size(556, 179)
        Me.dgproductsearchlist.TabIndex = 64
        Me.dgproductsearchlist.VirtualMode = True
        Me.dgproductsearchlist.Visible = False
        '
        'btnclearsale
        '
        Me.btnclearsale.Location = New System.Drawing.Point(799, 498)
        Me.btnclearsale.Name = "btnclearsale"
        Me.btnclearsale.Size = New System.Drawing.Size(79, 38)
        Me.btnclearsale.TabIndex = 70
        Me.btnclearsale.Text = "Clear Sale"
        Me.btnclearsale.UseVisualStyleBackColor = True
        '
        'gb_perm_Customers
        '
        Me.gb_perm_Customers.Controls.Add(Me.btncustumeridsearch)
        Me.gb_perm_Customers.Controls.Add(Me.txtcustomer_id)
        Me.gb_perm_Customers.Controls.Add(Me.Label2)
        Me.gb_perm_Customers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_perm_Customers.Location = New System.Drawing.Point(127, 451)
        Me.gb_perm_Customers.Name = "gb_perm_Customers"
        Me.gb_perm_Customers.Size = New System.Drawing.Size(261, 78)
        Me.gb_perm_Customers.TabIndex = 67
        Me.gb_perm_Customers.TabStop = False
        Me.gb_perm_Customers.Text = "<<Pamanent Customers>>"
        '
        'btncustumeridsearch
        '
        Me.btncustumeridsearch.Location = New System.Drawing.Point(144, 43)
        Me.btncustumeridsearch.Name = "btncustumeridsearch"
        Me.btncustumeridsearch.Size = New System.Drawing.Size(98, 23)
        Me.btncustumeridsearch.TabIndex = 2
        Me.btncustumeridsearch.Text = "Search Customer"
        Me.btncustumeridsearch.UseVisualStyleBackColor = True
        '
        'txtcustomer_id
        '
        Me.txtcustomer_id.Location = New System.Drawing.Point(86, 17)
        Me.txtcustomer_id.Name = "txtcustomer_id"
        Me.txtcustomer_id.Size = New System.Drawing.Size(169, 20)
        Me.txtcustomer_id.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer ID :"
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(800, 597)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(79, 38)
        Me.btnlogout.TabIndex = 71
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnvalidatenhisid
        '
        Me.btnvalidatenhisid.Location = New System.Drawing.Point(144, 43)
        Me.btnvalidatenhisid.Name = "btnvalidatenhisid"
        Me.btnvalidatenhisid.Size = New System.Drawing.Size(98, 23)
        Me.btnvalidatenhisid.TabIndex = 2
        Me.btnvalidatenhisid.Text = "Validate ID..."
        Me.btnvalidatenhisid.UseVisualStyleBackColor = True
        '
        'gb_nhis
        '
        Me.gb_nhis.Controls.Add(Me.btnvalidatenhisid)
        Me.gb_nhis.Controls.Add(Me.txt_nhis_id)
        Me.gb_nhis.Controls.Add(Me.lbl_nhisid)
        Me.gb_nhis.Location = New System.Drawing.Point(127, 532)
        Me.gb_nhis.Name = "gb_nhis"
        Me.gb_nhis.Size = New System.Drawing.Size(261, 78)
        Me.gb_nhis.TabIndex = 68
        Me.gb_nhis.TabStop = False
        Me.gb_nhis.Text = "<<NHIS>>"
        '
        'txt_nhis_id
        '
        Me.txt_nhis_id.Location = New System.Drawing.Point(86, 17)
        Me.txt_nhis_id.Name = "txt_nhis_id"
        Me.txt_nhis_id.Size = New System.Drawing.Size(169, 20)
        Me.txt_nhis_id.TabIndex = 1
        '
        'lbl_nhisid
        '
        Me.lbl_nhisid.AutoSize = True
        Me.lbl_nhisid.Location = New System.Drawing.Point(9, 20)
        Me.lbl_nhisid.Name = "lbl_nhisid"
        Me.lbl_nhisid.Size = New System.Drawing.Size(53, 13)
        Me.lbl_nhisid.TabIndex = 0
        Me.lbl_nhisid.Text = "NHIS ID :"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(124, 614)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(36, 13)
        Me.lbltime.TabIndex = 74
        Me.lbltime.Text = "Time :"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Lime
        Me.txttotal.Location = New System.Drawing.Point(618, 380)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(260, 49)
        Me.txttotal.TabIndex = 73
        Me.txttotal.Text = "GHC0.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnrefunds
        '
        Me.btnrefunds.Location = New System.Drawing.Point(800, 545)
        Me.btnrefunds.Name = "btnrefunds"
        Me.btnrefunds.Size = New System.Drawing.Size(79, 38)
        Me.btnrefunds.TabIndex = 72
        Me.btnrefunds.Text = "Refund"
        Me.btnrefunds.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(549, 380)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(49, 18)
        Me.lbl_total.TabIndex = 66
        Me.lbl_total.Text = "Total :"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(124, 637)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(36, 13)
        Me.lbldate.TabIndex = 75
        Me.lbldate.Text = "Date :"
        '
        'lblquicksearch
        '
        Me.lblquicksearch.AutoSize = True
        Me.lblquicksearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquicksearch.Location = New System.Drawing.Point(51, 114)
        Me.lblquicksearch.Name = "lblquicksearch"
        Me.lblquicksearch.Size = New System.Drawing.Size(108, 16)
        Me.lblquicksearch.TabIndex = 79
        Me.lblquicksearch.Text = "Quick Search :"
        '
        'btncartremoveitem
        '
        Me.btncartremoveitem.Location = New System.Drawing.Point(127, 380)
        Me.btncartremoveitem.Name = "btncartremoveitem"
        Me.btncartremoveitem.Size = New System.Drawing.Size(98, 23)
        Me.btncartremoveitem.TabIndex = 80
        Me.btncartremoveitem.Text = "Remove Item"
        Me.btncartremoveitem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(402, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Quantity :"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(480, 137)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown1.TabIndex = 83
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSalesCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 694)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncartremoveitem)
        Me.Controls.Add(Me.lblquicksearch)
        Me.Controls.Add(Me.txtsearchbyproductname)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgcart)
        Me.Controls.Add(Me.gb_details)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.txtcashiersaleid)
        Me.Controls.Add(Me.lblemployeename1)
        Me.Controls.Add(Me.lbl_invoiceno)
        Me.Controls.Add(Me.dgproductsearchlist)
        Me.Controls.Add(Me.btnclearsale)
        Me.Controls.Add(Me.gb_perm_Customers)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.gb_nhis)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnrefunds)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbldate)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmSalesCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesCashier"
        Me.Controls.SetChildIndex(Me.lbldate, 0)
        Me.Controls.SetChildIndex(Me.lbl_total, 0)
        Me.Controls.SetChildIndex(Me.btnrefunds, 0)
        Me.Controls.SetChildIndex(Me.txttotal, 0)
        Me.Controls.SetChildIndex(Me.lbltime, 0)
        Me.Controls.SetChildIndex(Me.gb_nhis, 0)
        Me.Controls.SetChildIndex(Me.btnlogout, 0)
        Me.Controls.SetChildIndex(Me.gb_perm_Customers, 0)
        Me.Controls.SetChildIndex(Me.btnclearsale, 0)
        Me.Controls.SetChildIndex(Me.dgproductsearchlist, 0)
        Me.Controls.SetChildIndex(Me.lbl_invoiceno, 0)
        Me.Controls.SetChildIndex(Me.lblemployeename1, 0)
        Me.Controls.SetChildIndex(Me.txtcashiersaleid, 0)
        Me.Controls.SetChildIndex(Me.lbluser, 0)
        Me.Controls.SetChildIndex(Me.gb_details, 0)
        Me.Controls.SetChildIndex(Me.dgcart, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.btncheckout, 0)
        Me.Controls.SetChildIndex(Me.txtsearchbyproductname, 0)
        Me.Controls.SetChildIndex(Me.lblquicksearch, 0)
        Me.Controls.SetChildIndex(Me.btncartremoveitem, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.NumericUpDown1, 0)
        CType(Me.dgcart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_details.ResumeLayout(False)
        Me.gb_details.PerformLayout()
        CType(Me.dgproductsearchlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_perm_Customers.ResumeLayout(False)
        Me.gb_perm_Customers.PerformLayout()
        Me.gb_nhis.ResumeLayout(False)
        Me.gb_nhis.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcashiertotalsale As System.Windows.Forms.TextBox
    Friend WithEvents txtsearchbyproductname As System.Windows.Forms.TextBox
    Friend WithEvents btncheckout As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcashieramountpaid As System.Windows.Forms.TextBox
    Friend WithEvents dgcart As System.Windows.Forms.DataGridView
    Friend WithEvents gb_details As System.Windows.Forms.GroupBox
    Friend WithEvents txtcashierdiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtcashiernhil As System.Windows.Forms.TextBox
    Friend WithEvents txtcashiervat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents txtcashiersaleid As System.Windows.Forms.TextBox
    Friend WithEvents lblemployeename1 As System.Windows.Forms.Label
    Friend WithEvents lbl_invoiceno As System.Windows.Forms.Label
    Friend WithEvents dgproductsearchlist As System.Windows.Forms.DataGridView
    Friend WithEvents btnclearsale As System.Windows.Forms.Button
    Friend WithEvents gb_perm_Customers As System.Windows.Forms.GroupBox
    Friend WithEvents btncustumeridsearch As System.Windows.Forms.Button
    Friend WithEvents txtcustomer_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnvalidatenhisid As System.Windows.Forms.Button
    Friend WithEvents gb_nhis As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nhis_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nhisid As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btnrefunds As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblquicksearch As System.Windows.Forms.Label
    Friend WithEvents colproductname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colquantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colproductid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnitprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colextendedprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncartremoveitem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
