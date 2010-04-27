Imports System.Data.SqlClient

Public Class frmAdministration

    'Create instance of classes
    Private objClsPerson As New clsPersons
    Private objClsCompany As New clsCompany
    Private objClsStock As New clsStocks
    Private objfrmLogin As New frmlogin


    Private strPhotoPath As String = ""

    'declare objects
    Public blnFirstUse As Boolean = False
    Private intEmployeeID As String
    Private strCompanyname As String
    Private strSupplierID As String
    Private strProductname As String
    Private strCompaniesID As String
    Private strCustomerID As String
    Private strPaymentname As String
    Private strCategoryname As String

    'on form load
    Private Sub frmAdministration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Populating for Employees
        Me.GetEmployeeID()

        'Populating for stocks/suppliers
        Me.SelectProductName()
        Me.SelectSupplierID()
        Me.SelectCategoryID()

        'Populating for companies
        Me.SelectCompaniesID()

        'Populating for customers
        Me.SelectCompanyId()

        'Populating for companyinfo
        SelectCompanyname()
    End Sub

    Private Sub btnrefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click

        'Populating for Employees
        Me.GetEmployeeID()

        'Populating for stocks/suppliers
        Me.SelectProductName()
        Me.SelectSuppliersID()
        Me.SelectCategoryID()

        'Populating for companies
        Me.SelectCompaniesID()

        'Populating for customers
        Me.SelectCustomerId()
        Me.SelectCompanyId()
        'Populating for companyinfo
        Me.SelectCompanyname()

        'Populating for paymentmethods
        Me.SelectPaymentname()
        Me.SelectCategoryID()
        Me.SelectSupplierID()
    End Sub

    '------------------------------------------ EMPLOYEE --------------------------------------'

    Public Sub SelectEmployeeId()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Employee_ID FROM Employees"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cboemployeeid.Items.Clear()

            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cboemployeeid.Items.Add(dReader.Item("Employee_ID"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadEmployeeFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM Employees WHERE Employee_ID = '" & Me.cboemployeeid.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.txttitle.Text = dReader.Item("Title")
                    Me.txtemployeelastname.Text = dReader.Item("Last_name")
                    Me.txtemployeefirstname.Text = dReader.Item("First_name")
                    Me.txtemployeeaddress.Text = dReader.Item("Employee_address")
                    Me.txtemployeeposition.Text = dReader.Item("Employee_Position")
                    Me.txtemployeephone.Text = dReader.Item("Employee_phone")
                    Me.txtemployeeemail.Text = dReader.Item("Employee_email")
                    Me.dtpemployeedob.Value = dReader.Item("DateOfBirth")
                    Me.dtpemployeestartdate.Value = dReader.Item("StartDate")
                    Me.dtpemployeeenddate.Value = dReader.Item("EndDate")
                    Me.txtusername.Text = dReader.Item("Username")
                    Me.txtpass.Text = dReader.Item("Pass")
                    Me.txtactivestatus.Text = dReader.Item("Active_Status")

                    Try
                        Me.pbemployeephoto.Image = Image.FromFile(dReader.Item("Photo"))
                    Catch ex As Exception
                        Me.pbemployeephoto.Image = Nothing
                    End Try
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetEmployeeID()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Employee_ID) as Employee_ID FROM Employees"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.intEmployeeID = dReader.Item("Employee_ID")
                End If
            Else
                Me.intEmployeeID = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GenerateEmployeeID()

        Dim RandomObj As New Random
        Dim RandomNumber As Integer = 0
        Dim Output As String = ""

        RandomNumber = RandomObj.Next(10000, 90000)
        Output = Me.txtemployeefirstname.Text.Substring(0, 2) & Me.txtemployeelastname.Text.Substring(0, 2) & "\" & RandomNumber
        Me.lblemployeeid.Text = Output


        ''Get the first 2 letters of firstname
        '    Me.lblemployeeid.Text = Me.txtemployeefirstname.Text.Substring(0, 3)

        ''Get the first 2 letters of lastname
        '    Me.lblemployeeid.Text &= Me.txtemployeelastname.Text.Substring(0, 2)

        ''Add the last 2 digits of current year
        '    Me.lblemployeeid.Text &= Now.Year.ToString.Substring(2, 2)

        ''Add the EmployeeID 
        '    Me.lblemployeeid.Text &= Me.intEmployeeID + 1

        'End Sub
    End Sub

    Private Sub InsertEmployee()

        'Assign form values to class properties

        Me.objClsPerson.EmployeeID = Me.lblemployeeid.Text
        Me.objClsPerson.Title = Me.txttitle.Text
        Me.objClsPerson.LastName = Me.txtemployeelastname.Text
        Me.objClsPerson.FirstName = Me.txtemployeefirstname.Text
        Me.objClsPerson.Address = Me.txtemployeeaddress.Text
        Me.objClsPerson.Employeeposition = Me.txtemployeeposition.Text
        Me.objClsPerson.Photo = Me.strPhotoPath
        Me.objClsPerson.Phone1 = Me.txtemployeephone.Text
        Me.objClsPerson.Email = Me.txtemployeeemail.Text
        Me.objClsPerson.DOB = Me.dtpemployeedob.Value
        Me.objClsPerson.StartDate = Me.dtpemployeestartdate.Value
        Me.objClsPerson.EndDate = Me.dtpemployeeenddate.Value
        Me.objClsPerson.UserName = Me.txtusername.Text
        Me.objClsPerson.Pass = Me.txtpass.Text
        Me.objClsPerson.ActiveStatus = Me.txtactivestatus.Text

        'Call Procedure
        Me.objClsPerson.InsertEmployees()

    End Sub

    Private Sub UpdateEmployee()
        'Assign form values to class properties

        With objClsPerson
            .EmployeeID = Me.cboemployeeid.Text
            .EmployeeID = Me.cboemployeeid.Text
            .Title = Me.txttitle.Text
            .LastName = Me.txtemployeelastname.Text
            .FirstName = Me.txtemployeefirstname.Text
            .Address = Me.txtemployeeaddress.Text
            .Employeeposition = Me.txtemployeeposition.Text
            .Photo = Me.strPhotoPath
            .Phone1 = Me.txtemployeephone.Text
            .Email = Me.txtemployeeemail.Text
            .DOB = Me.dtpemployeedob.Value
            .StartDate = Me.dtpemployeestartdate.Value
            .EndDate = Me.dtpemployeeenddate.Value
            .UserName = Me.txtusername.Text
            .Pass = Me.txtpass.Text
            .ActiveStatus = Me.txtactivestatus.Text
        End With

        'Call Procedure
        Me.objClsPerson.UpdateEmployees()

        'Raise Error if employee Active status is No

        If (txtactivestatus.Text = "No") Then
            WriteStatusMessage("The Employee selected is no more Active....")
        End If

    End Sub

    Private Sub DeleteEmployees()
        'Assign form values to class properties
        Me.objClsPerson.EmployeeID = Me.cboemployeeid.Text


        'Call Procedure
        Me.objClsPerson.DeleteEmployees()
    End Sub

    Private Sub btngetemployeephoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetemployeephoto.Click

        'declares an object of the open file dialog
        Dim ofdPhoto As New OpenFileDialog

        'checks to see if text of button btngetemployeephoto is Get Photo
        If (Me.btngetemployeephoto.Text = "&Get Photo") Then
            'checks to see if Ok button was clicked
            If ((ofdPhoto.ShowDialog) = Windows.Forms.DialogResult.OK) Then

                'path name assigned or put in the global level variable 
                Me.strPhotoPath = ofdPhoto.FileName

                'image from file displayed in the picture box
                Me.pbemployeephoto.Image = Image.FromFile(Me.strPhotoPath)

                'Get the network path
                Me.strPhotoPath = Me.strPhotoPath

                'set text property of button btngetemployeephoto to Delete Photo
                Me.btngetemployeephoto.Text = "&Remove Photo"

            End If

            'checks to see if text of button btngetemployeephoto is Delete Photo
        ElseIf (Me.btngetemployeephoto.Text = "&Remove Photo") Then

            'removes image 
            Me.pbemployeephoto.Image = Nothing

            'set text property of button btngetemployeephoto to Get Photo
            Me.btngetemployeephoto.Text = "&Get Photo"


            'set the picture path to nothing
            Me.strPhotoPath = ""
        End If
    End Sub

    Private Sub btnsaveemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveemployee.Click

        'Check for empty and invalid fields(Validation)
        If Me.txtemployeelastname.Text = "" Then
            Me.txtemployeelastname.Focus()

        Else
            If Me.btnsaveemployee.Text = "&Save" Then

                Try
                    Me.InsertEmployee()

                Catch ex As Exception
                Finally
                    WriteStatusMessage("Employee details Saved Successfully....")
                End Try
            ElseIf Me.btnsaveemployee.Text = "&Update" Then

                Try
                    Me.UpdateEmployee()

                Catch ex As Exception
                Finally
                    WriteStatusMessage("Employee details Updated Successfully....")
                End Try

            ElseIf Me.btnsaveemployee.Text = "&Delete" Then

                Try
                    Me.DeleteEmployees()

                Catch ex As Exception
                Finally
                    WriteStatusMessage("Employee details Deleted Successfully....")
                End Try
            End If


            If Me.objClsPerson.blnQuerySuccessful = True Then

                'Clear fields
                Me.ClearFields()
                Me.GetEmployeeID()

            End If
        End If

    End Sub

    Public Sub ClearFields()

        Me.cboemployeeid.Text = ""
        Me.lblemployeeid.Text = ""
        Me.txtemployeelastname.Text = ""
        Me.txtemployeefirstname.Text = ""
        Me.txttitle.Text = ""
        Me.txtemployeeaddress.Text = ""
        Me.txtemployeeposition.Text = ""
        Me.txtemployeephone.Text = ""
        Me.txtemployeeemail.Text = ""
        Me.dtpemployeedob.Value = Now
        Me.dtpemployeestartdate.Value = Now
        Me.dtpemployeeenddate.Value = Now
        Me.txtusername.Text = ""
        Me.txtpass.Text = ""
        Me.txtactivestatus.Text = ""
        Me.pbemployeephoto.Image = Nothing


    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.lblemployeeid.Visible = False
        Me.cboemployeeid.Visible = True
        Me.btnsaveemployee.Text = "&Update"
        Me.SelectEmployeeId()
        'Clear fields
        Me.ClearFields()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.lblemployeeid.Visible = False
        Me.cboemployeeid.Visible = True
        Me.btnsaveemployee.Text = "&Delete"
        Me.SelectEmployeeId()
        'Clear fields
        Me.ClearFields()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem.Click
        Me.lblemployeeid.Visible = True
        Me.cboemployeeid.Visible = False
        Me.btnsaveemployee.Text = "&Save"
        'Clear fields
        Me.ClearFields()
    End Sub

    Private Sub txtemployeelastname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemployeelastname.TextChanged
        If (Me.txtemployeelastname.Text.Length >= 2 And Me.btnsaveemployee.Text = "&Save") Then
            Me.GenerateEmployeeID()
        End If
    End Sub

    Private Sub cboemployeeid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboemployeeid.SelectedIndexChanged
        LoadEmployeeFields()
    End Sub

    Private Sub btnclearemployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclearemployee.Click
        Me.ClearFields()
    End Sub


    '--------------------------------------------CompanyInfo------------------------------------------------

    Public Sub SelectCompanyname()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Company_Name FROM CompanyInfo"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbocompanyname.Items.Clear()

            'Fills the combobox whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbocompanyname.Items.Add(dReader.Item("Company_Name"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadCompanyinfoFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM CompanyInfo WHERE Company_Name = '" & Me.cbocompanyname.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else

                    Me.txtcompanyaddress.Text = dReader.Item("Company_Address")
                    Me.txtcompanycity.Text = dReader.Item("City")
                    Me.txtcompanyinfophone.Text = dReader.Item("Phone")
                    Me.txtcompanyfax.Text = dReader.Item("Fax")
                    Me.txtcompanyemail.Text = dReader.Item("Email")
                    Me.txtcompanyweb.Text = dReader.Item("Web")
                    Me.txtcompanysalestaxrate.Text = dReader.Item("Tax_rate")
                    Me.txtcompanynhilrate.Text = dReader.Item("Nhil_rate")
                    Me.txtcompanyvatregno.Text = dReader.Item("Vat_Registration_No")

                    Try
                        Me.pbcompanylogo.Image = Image.FromFile(dReader.Item("Logo"))
                    Catch ex As Exception
                        Me.pbcompanylogo.Image = Nothing
                    End Try
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetCompanyname()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Company_Name) as Company_Name FROM CompanyInfo"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.strCompanyname = dReader.Item("Company_Name")
                End If
            Else
                Me.strCompanyname = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub InsertCompanyInfo()

        'Check for empty and invalid fields(Validation)

        If (Me.txtcompanyname.Text = "") Then
            WriteStatusMessage("Company name cannot be empty")
            Me.txtcompanyname.Focus()
            WriteStatusMessage("Company name cannot be empty")
        ElseIf IsNumeric(Me.txtcompanyname.Text) Then
            WriteStatusMessage("Company name cannot be numeric")
            Me.txtcompanyname.Text = ""
            Me.txtcompanyname.Focus()
            WriteStatusMessage("Company name cannot be numeric")
        ElseIf (Me.txtcompanyaddress.Text = "") Then
            WriteStatusMessage("Company Address cannot be empty")
            Me.txtcompanyaddress.Focus()
            WriteStatusMessage("Company Address cannot be empty")
        ElseIf IsNumeric(Me.txtcompanyaddress.Text) Then
            WriteStatusMessage("Company Address cannot be numeric")
            Me.txtcompanyaddress.Text = ""
            Me.txtcompanyaddress.Focus()
            WriteStatusMessage("Company Address cannot be numeric")
        ElseIf (Me.txtcompanycity.Text = "") Then
            MessageBox.Show("City cannot be empty")
            Me.txtcompanycity.Focus()
            WriteStatusMessage("City cannot be empty")
        ElseIf IsNumeric(Me.txtcompanycity.Text) Then
            WriteStatusMessage("City cannot be numeric")
            Me.txtcompanycity.Text = ""
            Me.txtcompanycity.Focus()
            WriteStatusMessage("City cannot be numeric")
        ElseIf IsInputChar(Me.txtcompanyinfophone.Text) Then
            WriteStatusMessage("Phone number must be numeric")
            Me.txtcompanyinfophone.Text = ""
            Me.txtcompanyinfophone.Focus()
            WriteStatusMessage("Phone number must be numeric")
        ElseIf (Me.strPhotoPath = "") Then
            WriteStatusMessage("Please select a logo")
            Me.btngetcompanylogo.Focus()
            WriteStatusMessage("Please select a logo")
        Else


            'Assign form values to class properties
            Me.objClsCompany.CompanyName = Me.txtcompanyname.Text
            Me.objClsCompany.Address = Me.txtcompanyaddress.Text
            Me.objClsCompany.City = Me.txtcompanycity.Text
            Me.objClsCompany.Phone1 = Me.txtcompanyinfophone.Text
            Me.objClsCompany.Fax = Me.txtcompanyfax.Text
            Me.objClsCompany.Email = Me.txtcompanyemail.Text
            Me.objClsCompany.Web = Me.txtcompanyweb.Text
            Me.objClsCompany.Taxrate = Me.txtcompanysalestaxrate.Text()
            Me.objClsCompany.Nhilrate = Me.txtcompanynhilrate.Text
            Me.objClsCompany.Logo = Me.strPhotoPath
            Me.objClsCompany.Vat_Registration_No = Me.txtcompanyvatregno.Text

            'Call Procedure
            Me.objClsCompany.InsertCompanyInfo()

            'Clear(fields)
            Me.CompanyinfoClearFields()

            ''Show the employee form to register
            'Me.tcadmin.SelectTab(tpemployees)
            'Me.txtemployeeposition.Text = "Manager"
            'Me.txtemployeeposition.Enabled = False
            'Me.blnFirstUse = True

            ''Close current form and display logon form
            ' ''Me.Hide()
            ' ''Me.objfrmLogin.Show()

        End If
    End Sub

    Private Sub UpdateCompanyInfo()

        If (Me.cbocompanyname.Text = "") Then
            WriteStatusMessage("Company name cannot be empty")
            Me.cbocompanyname.Focus()
            WriteStatusMessage("Company name cannot be empty")
        ElseIf IsNumeric(Me.cbocompanyname.Text) Then
            WriteStatusMessage("Company name cannot be numeric")
            Me.cbocompanyname.Text = ""
            Me.cbocompanyname.Focus()
            WriteStatusMessage("Company name cannot be numeric")
        ElseIf (Me.txtcompanyaddress.Text = "") Then
            WriteStatusMessage("Company Address cannot be empty")
            Me.txtcompanyaddress.Focus()
            WriteStatusMessage("Company Address cannot be empty")
        ElseIf IsNumeric(Me.txtcompanyaddress.Text) Then
            WriteStatusMessage("Company Address cannot be numeric")
            Me.txtcompanyaddress.Text = ""
            Me.txtcompanyaddress.Focus()
            WriteStatusMessage("Company Address cannot be numeric")
        ElseIf (Me.txtcompanycity.Text = "") Then
            MessageBox.Show("City cannot be empty")
            Me.txtcompanycity.Focus()
            WriteStatusMessage("City cannot be empty")
        ElseIf IsNumeric(Me.txtcompanycity.Text) Then
            WriteStatusMessage("City cannot be numeric")
            Me.txtcompanycity.Text = ""
            Me.txtcompanycity.Focus()
            WriteStatusMessage("City cannot be numeric")
        ElseIf IsInputChar(Me.txtcompanyinfophone.Text) Then
            WriteStatusMessage("Phone number must be numeric")
            Me.txtcompanyinfophone.Text = ""
            Me.txtcompanyinfophone.Focus()
            WriteStatusMessage("Phone number must be numeric")
        ElseIf (Me.strPhotoPath = "") Then
            WriteStatusMessage("Please select a logo")
            Me.btngetcompanylogo.Focus()
        Else


            'Assign form values to class properties
            Me.objClsCompany.CompanyName = Me.cbocompanyname.Text
            Me.objClsCompany.Address = Me.txtcompanyaddress.Text
            Me.objClsCompany.City = Me.txtcompanycity.Text
            Me.objClsCompany.Phone1 = Me.txtcompanyinfophone.Text
            Me.objClsCompany.Fax = Me.txtcompanyfax.Text
            Me.objClsCompany.Email = Me.txtcompanyemail.Text
            Me.objClsCompany.Web = Me.txtcompanyweb.Text
            Me.objClsCompany.Taxrate = Me.txtcompanysalestaxrate.Text()
            Me.objClsCompany.Nhilrate = Me.txtcompanynhilrate.Text
            Me.objClsCompany.Logo = Me.strPhotoPath
            Me.objClsCompany.Vat_Registration_No = Me.txtcompanyvatregno.Text

            'Call Procedure
            Me.objClsCompany.UpdateCompanyInfo()

            'Clear(fields)
            Me.CompanyinfoClearFields()

        End If
    End Sub

    Private Sub DeleteCompanyInfo()
        'Assign form values to class properties

        Me.objClsCompany.CompanyName = Me.cbocompanyname.Text

        'Call Procedure
        Me.objClsCompany.DeleteCompanyInfo()

        'Clear(fields)
        Me.CompanyinfoClearFields()

    End Sub

    Private Sub btnsavecompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavecompany.Click


        If Me.btnsavecompany.Text = "&Save" Then

            Try
                Me.InsertCompanyInfo()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Company Information Saved Successfully....")
            End Try
        ElseIf Me.btnsavecompany.Text = "&Update" Then

            Try
                Me.UpdateCompanyInfo()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Company Information Updated Successfully....")
            End Try

        ElseIf Me.btnsavecompany.Text = "&Delete" Then

            Try
                Me.DeleteCompanyInfo()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Company Information Deleted Successfully....")
            End Try
        End If


        If Me.objClsPerson.blnQuerySuccessful = True Then

            'Clear fields
            Me.CompanyinfoClearFields()

        End If

    End Sub

    Public Sub CompanyinfoClearFields()

        Me.cbocompanyname.Text = ""
        Me.txtcompanyname.Text = ""
        Me.txtcompanyaddress.Text = ""
        Me.txtcompanycity.Text = ""
        Me.txtcompanyinfophone.Text = ""
        Me.txtcompanyfax.Text = ""
        Me.txtcompanyemail.Text = ""
        Me.txtcompanyemail.Text = ""
        Me.txtcompanysalestaxrate.Text = ""
        Me.txtcompanynhilrate.Text = ""
        Me.pbcompanylogo.Image = Nothing
        Me.txtcompanyvatregno.Text = ""

    End Sub

    Private Sub InsertToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem1.Click
        Me.txtcompanyname.Visible = True
        Me.cbocompanyname.Visible = False
        Me.btnsavecompany.Text = "&Save"
        Me.CompanyinfoClearFields()
    End Sub

    Private Sub UpdateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem1.Click
        Me.txtcompanyname.Visible = False
        Me.cbocompanyname.Visible = True
        Me.btnsavecompany.Text = "&Update"
        Me.SelectCompanyname()
        Me.CompanyinfoClearFields()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Me.txtcompanyname.Visible = False
        Me.cbocompanyname.Visible = True
        Me.btnsavecompany.Text = "&Delete"
        Me.SelectCompanyname()
        Me.CompanyinfoClearFields()
    End Sub

    Private Sub btngetcompanylogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetcompanylogo.Click
        'declares an object of the open file dialog
        Dim ofdPhoto As New OpenFileDialog

        'checks to see if text of button btngetemployeephoto is Get Photo
        If (Me.btngetcompanylogo.Text = "&Get Logo") Then
            'checks to see if Ok button was clicked
            If ((ofdPhoto.ShowDialog) = Windows.Forms.DialogResult.OK) Then

                'path name assigned or put in the global level variable 
                Me.strPhotoPath = ofdPhoto.FileName

                'image from file displayed in the picture box
                Me.pbcompanylogo.Image = Image.FromFile(Me.strPhotoPath)

                'Get the network path
                Me.strPhotoPath = Me.strPhotoPath

                'set text property of button btngetemployeephoto to Delete Photo
                Me.btngetcompanylogo.Text = "&Remove Logo"

            End If

            'checks to see if text of button btngetemployeephoto is Delete Photo
        ElseIf (Me.btngetcompanylogo.Text = "&Remove Logo") Then

            'removes image 
            Me.pbcompanylogo.Image = Nothing

            'set text property of button btngetemployeephoto to Get Photo
            Me.btngetcompanylogo.Text = "&Get Logo"


            'set the picture path to nothing
            Me.strPhotoPath = ""
        End If
    End Sub

    Private Sub btnadminmakesales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadminmakesales.Click
        frmSalesCashier.Show()
    End Sub

    Private Sub cbocompanyname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocompanyname.SelectedIndexChanged
        LoadCompanyinfoFields()
    End Sub

    Private Sub btnclearcompanyinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclearcompanyinfo.Click
        Me.CompanyinfoClearFields()
    End Sub



    '--------------------------------------------Suppliers------------------------------------------------'

    Public Sub SelectSuppliersID()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Supplier_ID FROM Suppliers"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbosupplierid.Items.Clear()

            'Fills the combobox whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbosupplierid.Items.Add(dReader.Item("Supplier_ID"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadSupplierFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM Suppliers WHERE Supplier_ID = '" & Me.cbosupplierid.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else

                    Me.txtsuppliername.Text = dReader.Item("Supplier_name")
                    Me.txtsuppliercontactperson.Text = dReader.Item("Contact_person")
                    Me.txtsupplieraddress.Text = dReader.Item("Supplier_address")
                    Me.txtsupplieremail.Text = dReader.Item("Supplier_email")
                    Me.txtsupplierphone1.Text = dReader.Item("Supplier_land_phone1")
                    Me.txtsupplierphone2.Text = dReader.Item("Supplier_land_phone2")
                    Me.txtsuppliermobilephone.Text = dReader.Item("Supplier_mobile_phone")

                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetSupplierID()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Supplier_ID) as Supplier_ID FROM Suppliers"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.strSupplierID = dReader.Item("Supplier_ID")
                End If
            Else
                Me.strSupplierID = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GenerateSupplierID()

        Dim RandomObj As New Random
        Dim RandomNumber As Integer = 0
        Dim Output As String = ""

        RandomNumber = RandomObj.Next(10000, 90000)
        Output = Me.txtsuppliername.Text.Substring(0, 3) & "\" & RandomNumber
        Me.lblsupplierid.Text = Output

        ''Get the first 3 letters of suppliername
        'Me.lblsupplierid.Text = Me.txtsuppliername.Text.Substring(0, 3)

        ''Get the first 2 letters of lastname
        ''Me.lblemployeeid.Text &= Me.txtemployeelastname.Text.Substring(0, 2)

        ''Add the last 2 digits of current year
        'Me.lblsupplierid.Text &= Now.Year.ToString.Substring(2, 2)

        ''Add the EmployeeID 
        'Me.lblsupplierid.Text &= Me.strSupplierID + 1

    End Sub

    Private Sub InsertSuppliers()

        'Assign form values to class properties

        Me.objClsPerson.SupplierID = Me.lblsupplierid.Text
        Me.objClsPerson.FirstName = Me.txtsuppliername.Text
        Me.objClsPerson.Contactperson = Me.txtsuppliercontactperson.Text
        Me.objClsPerson.Address = Me.txtsupplieraddress.Text
        Me.objClsPerson.Phone1 = Me.txtsupplierphone1.Text
        Me.objClsPerson.Phone2 = Me.txtsupplierphone2.Text
        Me.objClsPerson.MobileNumber = Me.txtsuppliermobilephone.Text
        Me.objClsPerson.Email = Me.txtsupplieremail.Text

        'Call Procedure
        Me.objClsPerson.InsertSuppliers()

    End Sub

    Private Sub UpdateSuppliers()

        'Assign form values to class properties

        Me.objClsPerson.SupplierID = Me.cbosupplierid.Text
        Me.objClsPerson.FirstName = Me.txtsuppliername.Text
        Me.objClsPerson.Contactperson = Me.txtsuppliercontactperson.Text
        Me.objClsPerson.Address = Me.txtsupplieraddress.Text
        Me.objClsPerson.Phone1 = Me.txtsupplierphone1.Text
        Me.objClsPerson.Phone2 = Me.txtsupplierphone2.Text
        Me.objClsPerson.MobileNumber = Me.txtsuppliermobilephone.Text
        Me.objClsPerson.Email = Me.txtsupplieremail.Text

        'Call Procedure
        Me.objClsPerson.UpdateSuppliers()

    End Sub

    Private Sub DeleteSuppliers()

        'Assign form values to class properties

        Me.objClsPerson.SupplierID = Me.cbosupplierid.Text

        'Call Procedure
        Me.objClsPerson.DeleteSuppliers()
        Me.GetSupplierID()
    End Sub

    Private Sub btnsavesuppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavesuppliers.Click


        If Me.btnsavesuppliers.Text = "&Save" Then

            Try
                Me.InsertSuppliers()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Supplier Information Saved Successfully....")
            End Try

        ElseIf Me.btnsavesuppliers.Text = "&Update" Then

            Try
                Me.UpdateSuppliers()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Supplier Information Updated Successfully....")
            End Try

        ElseIf Me.btnsavesuppliers.Text = "&Delete" Then

            Try
                Me.DeleteSuppliers()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Supplier Information Deleted Successfully....")
            End Try
        End If


        If Me.objClsPerson.blnQuerySuccessful = True Then

            'Clear fields
            Me.SupplierClearFields()

        End If

    End Sub

    Public Sub SupplierClearFields()

        Me.cbosupplierid.Text = ""
        Me.lblsupplierid.Text = ""
        Me.txtsuppliername.Text = ""
        Me.txtsuppliercontactperson.Text = ""
        Me.txtsupplieraddress.Text = ""
        Me.txtsupplieremail.Text = ""
        Me.txtsupplierphone1.Text = ""
        Me.txtsupplierphone2.Text = ""
        Me.txtsuppliermobilephone.Text = ""

    End Sub

    Private Sub InsertToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem2.Click
        Me.lblsupplierid.Visible = True
        Me.cbosupplierid.Visible = False
        Me.btnsavesuppliers.Text = "&Save"
    End Sub

    Private Sub UpdateToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem2.Click
        Me.lblsupplierid.Visible = False
        Me.cbosupplierid.Visible = True
        Me.btnsavesuppliers.Text = "&Update"
        Me.SelectSuppliersID()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem2.Click
        Me.lblsupplierid.Visible = False
        Me.cbosupplierid.Visible = True
        Me.btnsavesuppliers.Text = "&Delete"
        Me.SelectSuppliersID()
    End Sub

    Private Sub cbosupplierid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosupplierid.SelectedIndexChanged
        LoadSupplierFields()
    End Sub

    Private Sub txtsuppliername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsuppliername.TextChanged
        If (Me.txtsuppliername.Text.Length >= 4 And Me.btnsavesuppliers.Text = "&Save") Then
            Me.GenerateSupplierID()
        End If
    End Sub

    Private Sub btnclear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear2.Click
        SupplierClearFields()
    End Sub



    '--------------------------------------------Stocks------------------------------------------------'

    Public Sub SelectProductName()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Product_name FROM Stock"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbostockproductname.Items.Clear()

            'Fills the combobox whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbostockproductname.Items.Add(dReader.Item("Product_name"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub SelectSupplierID()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Supplier_ID FROM Suppliers"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbostocksupplierid.Items.Clear()

            'Fills the combobox whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbostocksupplierid.Items.Add(dReader.Item("Supplier_ID"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub SelectCategoryID()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Category_ID, Category_name FROM Category"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbostockcategoryID.Items.Clear()

            'Fills the combobox whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbostockcategoryID.Items.Add(dReader.Item("Category_ID"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetProductname()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Product_name) as Product_name FROM Stock"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.strProductname = dReader.Item("Product_name")
                End If
            Else
                Me.strProductname = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadProductFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM Stock WHERE Product_name = '" & Me.cbostockproductname.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.lblproductid.Text = dReader.Item("Product_ID")
                    Me.cbostockproductname.Text = dReader.Item("Product_name")
                    Me.cbostocksupplierid.Text = dReader.Item("Supplier_ID")
                    Me.txtstockproductdescription.Text = dReader.Item("Product_description")
                    Me.txtstockquantity.Text = dReader.Item("Quantity")
                    Me.txtstockreorderpoint.Text = dReader.Item("Reorder_point")
                    Me.txtstockcostprice.Text = dReader.Item("Cost_price")
                    Me.txtstockmarkup.Text = dReader.Item("Markup")
                    Me.txtsellingprice.Text = dReader.Item("Unit_price")
                    Me.dtpstockproducedate.Value = dReader.Item("Produce_date")
                    Me.dtpstockexpirationdate.Value = dReader.Item("Expiration_date")
                    Me.txtstockinstock.Text = dReader.Item("In_Stock")
                    Me.cbostockcategoryID.Text = dReader.Item("Category_ID")

                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub StockClearFields()

        Me.lblproductid.Text = ""
        Me.cbostockproductname.Text = ""
        Me.cbostockcategoryID.Text = ""
        Me.cbostocksupplierid.Text = ""
        Me.txtsupplieraddress.Text = ""
        Me.txtstockproductdescription.Text = ""
        Me.txtstockquantity.Text = ""
        Me.txtstockreorderpoint.Text = ""
        Me.txtstockcostprice.Text = ""
        Me.txtstockmarkup.Text = ""
        Me.txtsellingprice.Text = ""
        Me.dtpstockproducedate.Value = Now
        Me.dtpstockexpirationdate.Value = Now
        Me.txtstockinstock.Text = ""
        Me.cbostockcategoryID.Text = ""

    End Sub

    Private Sub InsertStock()

        'Assign form values to class properties

        Me.objClsStock.Productname = Me.cbostockproductname.Text
        Me.objClsStock.SupplierID = Me.cbostocksupplierid.Text
        Me.objClsStock.Productdescription = Me.txtstockproductdescription.Text
        Me.objClsStock.Quantity = Me.txtstockquantity.Text
        Me.objClsStock.Reorder_point = Me.txtstockreorderpoint.Text
        Me.objClsStock.UnitCostprice = Me.txtstockcostprice.Text
        Me.objClsStock.Markup = Me.txtstockmarkup.Text
        Me.objClsStock.Unitsellingprice = Me.txtsellingprice.Text
        Me.objClsStock.Producedate = Me.dtpstockproducedate.Value
        Me.objClsStock.Expirationdate = Me.dtpstockexpirationdate.Value
        Me.objClsStock.InStock = Me.txtstockinstock.Text
        Me.objClsStock.CategoryID = Me.cbostockcategoryID.Text

        'Call Procedure
        Me.objClsStock.InsertStocks()

    End Sub

    Private Sub UpdateStock()

        'Assign form values to class properties

        Me.objClsStock.ProductID = Me.lblproductid.Text
        Me.objClsStock.Productname = Me.cbostockproductname.Text
        Me.objClsStock.SupplierID = Me.cbostocksupplierid.Text
        Me.objClsStock.Productdescription = Me.txtstockproductdescription.Text
        Me.objClsStock.Quantity = Me.txtstockquantity.Text
        Me.objClsStock.Reorder_point = Me.txtstockreorderpoint.Text
        Me.objClsStock.UnitCostprice = Me.txtstockcostprice.Text
        Me.objClsStock.Markup = Me.txtstockmarkup.Text
        Me.objClsStock.Unitsellingprice = Me.txtsellingprice.Text
        Me.objClsStock.Producedate = Me.dtpstockproducedate.Value
        Me.objClsStock.Expirationdate = Me.dtpstockexpirationdate.Value
        Me.objClsStock.InStock = Me.txtstockinstock.Text
        Me.objClsStock.CategoryID = Me.cbostockcategoryID.Text

        'Call Procedure
        Me.objClsStock.UpdateStock()

    End Sub

    Private Sub DeleteStock()

        'Assign form values to class properties

        Me.objClsStock.Productname = Me.cbostockproductname.Text()

        'Call Procedure
        Me.objClsStock.DeleteStock()

    End Sub

    Private Sub btnsavestock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavestock.Click

        If Me.btnsavestock.Text = "&Save" Then

            Try
                Me.InsertStock()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Stocks Information Saved Successfully....")
            End Try

        ElseIf Me.btnsavestock.Text = "&Update" Then

            Try
                Me.UpdateStock()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Stocks Information Updated Successfully....")
            End Try

        ElseIf Me.btnsavestock.Text = "&Delete" Then

            Try
                Me.DeleteStock()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Stocks Information Deleted Successfully....")
            End Try
        End If


        If Me.objClsStock.blnQuerySuccessful = True Then

            'Clear fields
            Me.StockClearFields()

        End If

    End Sub

    Private Sub InsertToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem3.Click
        'Clear fields
        Me.StockClearFields()
        Me.btnsavestock.Text = "&Save"
    End Sub

    Private Sub UpdateToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem3.Click
        'Clear fields
        Me.StockClearFields()
        Me.btnsavestock.Text = "&Update"
        Me.SelectProductName()
    End Sub

    Private Sub DeleteToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem3.Click
        'Clear fields
        Me.StockClearFields()
        Me.btnsavestock.Text = "&Delete"
        Me.SelectProductName()
    End Sub

    Private Sub cbostockproductname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbostockproductname.SelectedIndexChanged
        Me.LoadProductFields()
    End Sub

    Private Sub btnclearstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclearstock.Click
        StockClearFields()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        frmlogin.Show()
        frmlogin.BringToFront()
        frmlogin.txtusername.Focus()
    End Sub


    '------------------------------------------ COMPANIES --------------------------------------'

    Public Sub SelectCompaniesId()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Company_ID FROM Company"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbocompaniesID.Items.Clear()

            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbocompaniesID.Items.Add(dReader.Item("Company_ID"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadCompanyFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM Company WHERE Company_ID = '" & Me.cbocompaniesID.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.lblpermcompanyid.Text = dReader.Item("Company_ID")
                    Me.txtpermcompanyname.Text = dReader.Item("Company_name")
                    Me.txtpermcompanycontactperson.Text = dReader.Item("Contact_person")
                    Me.txtpermcompanyaddress.Text = dReader.Item("Company_address")
                    Me.txtpermcompanyphone1.Text = dReader.Item("Company_land_phone1")
                    Me.txtpermcompanyphone2.Text = dReader.Item("Company_land_phone2")
                    Me.txtpermcompanymobilephone.Text = dReader.Item("Company_mobile_phone")
                    Me.txtpermcompanyemail.Text = dReader.Item("Company_email")
                    Me.txtpermcompanydebit.Text = dReader.Item("Company_debit")

                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetCompaniesID()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Company_ID) as Company_ID FROM Company"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.strCompaniesID = dReader.Item("Company_ID")
                End If
            Else
                Me.strCompaniesID = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GenerateCompanyID()

        Dim RandomObj As New Random
        Dim RandomNumber As Integer = 0
        Dim Output As String = ""

        RandomNumber = RandomObj.Next(10000, 90000)
        Output = Me.txtpermcompanyname.Text.Substring(0, 3) & "\" & RandomNumber
        Me.lblpermcompanyid.Text = Output

        ''Get the first 2 letters of firstname
        'Me.lblpermcompanyid.Text = Me.txtpermcompanyname.Text.Substring(0, 3)


        ''Add the last 2 digits of current year
        'Me.lblpermcompanyid.Text &= Now.Year.ToString.Substring(2, 2)

        ''Add the CompanyID 
        'Me.lblpermcompanyid.Text &= Me.strCompaniesID + 1

    End Sub

    Private Sub InsertCompanies()

        'Assign form values to class properties

        With objClsCompany

            .CompanyID = Me.lblpermcompanyid.Text
            .CompanyName = Me.txtpermcompanyname.Text
            .Contactperson = Me.txtpermcompanycontactperson.Text
            .Address = Me.txtpermcompanyaddress.Text
            .Phone1 = Me.txtpermcompanyphone1.Text
            .Phone2 = Me.txtpermcompanyphone2.Text
            .Mobile = Me.txtpermcompanymobilephone.Text
            .Email = Me.txtpermcompanyemail.Text
            .Companydebit = Me.txtpermcompanydebit.Text

        End With

        'Call Procedure
        Me.objClsCompany.InsertCompanies()

    End Sub

    Private Sub UpdateCompanies()

        'Assign form values to class properties

        With objClsCompany

            .CompanyID = Me.lblpermcompanyid.Text
            .CompanyName = Me.txtpermcompanyname.Text
            .Contactperson = Me.txtpermcompanycontactperson.Text
            .Address = Me.txtpermcompanyaddress.Text
            .Phone1 = Me.txtpermcompanyphone1.Text
            .Phone2 = Me.txtpermcompanyphone2.Text
            .Mobile = Me.txtpermcompanymobilephone.Text
            .Email = Me.txtpermcompanyemail.Text
            .Companydebit = Me.txtpermcompanydebit.Text

        End With

        'Call Procedure
        Me.objClsCompany.UpdateCompanies()

    End Sub

    Private Sub DeleteCompanies()
        'Assign form values to class properties
        Me.objClsCompany.CompanyID = Me.cbocompaniesID.Text


        'Call Procedure
        Me.objClsCompany.DeleteCompanies()
    End Sub

    Private Sub btnsavecompanies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavecompanies.Click
        If Me.btnsavecompanies.Text = "&Save" Then

            Try
                Me.InsertCompanies()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Company details Saved Successfully....")
            End Try
        ElseIf Me.btnsavecompanies.Text = "&Update" Then

            Try
                Me.UpdateCompanies()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Company details Updated Successfully....")
            End Try

        ElseIf Me.btnsavecompanies.Text = "&Delete" Then

            Try
                Me.DeleteCompanies()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Company details Deleted Successfully....")
            End Try
        End If


        If Me.objClsCompany.blnQuerySuccessful = True Then

            'Clear fields
            Me.CompaniesClearFields()
            Me.GetCompaniesID()

        End If

    End Sub

    Public Sub CompaniesClearFields()

        Me.cbocompaniesID.Text = ""
        Me.lblpermcompanyid.Text = ""
        Me.txtpermcompanyname.Text = ""
        Me.txtpermcompanycontactperson.Text = ""
        Me.txtpermcompanyaddress.Text = ""
        Me.txtpermcompanyphone1.Text = ""
        Me.txtpermcompanyphone2.Text = ""
        Me.txtpermcompanymobilephone.Text = ""
        Me.txtpermcompanyemail.Text = ""
        Me.txtpermcompanydebit.Text = ""


    End Sub

    Private Sub InsertToolStripMenuItemcompanies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItemcompanies.Click
        Me.lblpermcompanyid.Visible = True
        Me.cbocompaniesID.Visible = False
        Me.btnsavecompanies.Text = "&Save"
        Me.CompaniesClearFields()
    End Sub

    Private Sub UpdateToolStripMenuItemcompanies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItemcompanies.Click
        Me.lblpermcompanyid.Visible = False
        Me.cbocompaniesID.Visible = True
        Me.btnsavecompanies.Text = "&Update"
        Me.SelectCompaniesId()
        Me.CompaniesClearFields()
    End Sub

    Private Sub DeleteToolStripMenuItemcompanies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItemcompanies.Click
        Me.lblpermcompanyid.Visible = False
        Me.cbocompaniesID.Visible = True
        Me.btnsavecompanies.Text = "&Delete"
        Me.SelectCompaniesId()
        Me.CompaniesClearFields()
    End Sub

    Private Sub txtpermcompanyname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpermcompanyname.TextChanged
        If (Me.txtpermcompanyname.Text.Length >= 3 And Me.btnsavecompanies.Text = "&Save") Then
            Me.GenerateCompanyID()
        End If
    End Sub

    Private Sub cbocompaniesID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocompaniesID.SelectedIndexChanged
        Me.LoadCompanyFields()
    End Sub

    Private Sub btnclearcompanies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclearcompanies.Click
        Me.CompaniesClearFields()
    End Sub


    '------------------------------------------ CUSTOMERS --------------------------------------'

    Public Sub SelectCustomerId()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Customer_ID FROM Customers"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbocustomerid.Items.Clear()

            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbocustomerid.Items.Add(dReader.Item("Customer_ID"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub SelectCompanyId()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Company_ID FROM Company"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbocompanyid.Items.Clear()

            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbocompanyid.Items.Add(dReader.Item("Company_ID"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadCustomersFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM Customers WHERE Customer_ID = '" & Me.cbocustomerid.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.txtcustomertitle.Text = dReader.Item("Title")
                    Me.txtcustomerfirstname.Text = dReader.Item("First_name")
                    Me.txtcustomerlastname.Text = dReader.Item("Last_name")
                    Me.cbocompanyid.Text = dReader.Item("Company_ID")
                    Me.txtcustomeraddress.Text = dReader.Item("Customer_address")
                    Me.txtcustomerphone.Text = dReader.Item("Customer_phone")
                    Me.txtcustomeremail.Text = dReader.Item("Customer_email")

                    Try
                        Me.pbcustomerphoto.Image = Image.FromFile(dReader.Item("Photo"))
                    Catch ex As Exception
                        Me.pbcustomerphoto.Image = Nothing
                    End Try
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetCustomerID()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Customer_ID) as Customer_ID FROM Customers"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.strCustomerID = dReader.Item("Customer_ID")
                End If
            Else
                Me.strCustomerID = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GenerateCustomerID()

        Dim RandomObj As New Random
        Dim RandomNumber As Integer = 0
        Dim Output As String = ""

        RandomNumber = RandomObj.Next(10000, 90000)
        Output = Me.txtcustomerfirstname.Text.Substring(0, 2) & Me.txtcustomerlastname.Text.Substring(0, 2) & "\" & RandomNumber
        Me.lblcustomerid.Text = Output

        ''Get the first 2 letters of firstname
        'Me.lblcustomerid.Text = Me.txtcustomerfirstname.Text.Substring(0, 3)

        ''Get the first 2 letters of lastname
        'Me.lblcustomerid.Text &= Me.txtcustomerlastname.Text.Substring(0, 2)

        ''Add the last 2 digits of current year
        'Me.lblcustomerid.Text &= Now.Year.ToString.Substring(2, 2)

        ''Add the EmployeeID 
        'Me.lblcustomerid.Text &= Me.strCustomerID + 1

    End Sub

    Private Sub InsertCustomers()

        'Assign form values to class properties

        Me.objClsPerson.CustomerID = Me.lblcustomerid.Text
        Me.objClsPerson.Title = Me.txtcustomertitle.Text
        Me.objClsPerson.FirstName = Me.txtcustomerfirstname.Text
        Me.objClsPerson.LastName = Me.txtcustomerlastname.Text
        Me.objClsPerson.CompanyID = Me.cbocompanyid.Text
        Me.objClsPerson.Address = Me.txtcustomeraddress.Text
        Me.objClsPerson.Photo = Me.strPhotoPath
        Me.objClsPerson.Phone1 = Me.txtcustomerphone.Text
        Me.objClsPerson.Email = Me.txtcustomeremail.Text

        'Call Procedure
        Me.objClsPerson.InsertCustomers()

    End Sub

    Private Sub UpdateCustomers()
        'Assign form values to class properties

        Me.objClsPerson.CustomerID = Me.cbocustomerid.Text
        Me.objClsPerson.Title = Me.txtcustomertitle.Text
        Me.objClsPerson.FirstName = Me.txtcustomerfirstname.Text
        Me.objClsPerson.LastName = Me.txtcustomerlastname.Text
        Me.objClsPerson.CompanyID = Me.cbocompanyid.Text
        Me.objClsPerson.Address = Me.txtcustomeraddress.Text
        Me.objClsPerson.Photo = Me.strPhotoPath
        Me.objClsPerson.Phone1 = Me.txtcustomerphone.Text
        Me.objClsPerson.Email = Me.txtcustomeremail.Text

        'Call Procedure
        Me.objClsPerson.UpdateCustomers()

    End Sub

    Private Sub DeleteCustomers()
        'Assign form values to class properties
        Me.objClsPerson.CustomerID = Me.cbocustomerid.Text


        'Call Procedure
        Me.objClsPerson.DeleteCustomers()
    End Sub

    Private Sub btncustomerphoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncustomerphoto.Click
        'declares an object of the open file dialog
        Dim ofdPhoto As New OpenFileDialog

        'checks to see if text of button btngetCustomerphoto is Get Photo
        If (Me.btncustomerphoto.Text = "&Get Photo") Then
            'checks to see if Ok button was clicked
            If ((ofdPhoto.ShowDialog) = Windows.Forms.DialogResult.OK) Then

                'path name assigned or put in the global level variable 
                Me.strPhotoPath = ofdPhoto.FileName

                'image from file displayed in the picture box
                Me.pbcustomerphoto.Image = Image.FromFile(Me.strPhotoPath)

                'Get the network path
                Me.strPhotoPath = Me.strPhotoPath

                'set text property of button btngetCustomerphoto to Delete Photo
                Me.btncustomerphoto.Text = "&Remove Photo"

            End If

            'checks to see if text of button btngetCustomerphoto is Delete Photo
        ElseIf (Me.btncustomerphoto.Text = "&Remove Photo") Then

            'removes image 
            Me.pbcustomerphoto.Image = Nothing

            'set text property of button btngetCustomerphoto to Get Photo
            Me.btncustomerphoto.Text = "&Get Photo"


            'set the picture path to nothing
            Me.strPhotoPath = ""
        End If
    End Sub

    Private Sub btncreatecustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreatecustomer.Click

        If Me.btncreatecustomer.Text = "&Create" Then

            Try
                Me.InsertCustomers()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Customers details Saved Successfully....")
            End Try
        ElseIf Me.btncreatecustomer.Text = "&Update" Then

            Try
                Me.UpdateCustomers()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Customers details Updated Successfully....")
            End Try

        ElseIf Me.btncreatecustomer.Text = "&Delete" Then

            Try
                Me.DeleteCustomers()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Customers details Deleted Successfully....")
            End Try
        End If


        If Me.objClsPerson.blnQuerySuccessful = True Then

            'Clear fields
            Me.CustomersClearFields()
            Me.GetCustomerID()

        End If
    End Sub

    Public Sub CustomersClearFields()

        Me.cbocustomerid.Text = ""
        Me.lblcustomerid.Text = ""
        Me.txtcustomertitle.Text = ""
        Me.txtcustomerfirstname.Text = ""
        Me.txtcustomerlastname.Text = ""
        Me.cbocompanyid.Text = ""
        Me.txtcustomeraddress.Text = ""
        Me.pbcustomerphoto.Image = Nothing
        Me.txtcustomerphone.Text = ""
        Me.txtcustomeremail.Text = ""

    End Sub

    Private Sub InsertToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem5.Click
        Me.lblcustomerid.Visible = True
        Me.cbocustomerid.Visible = False
        Me.btncreatecustomer.Text = "&Create"
        Me.CustomersClearFields()
    End Sub

    Private Sub UpdateToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem5.Click
        Me.lblcustomerid.Visible = False
        Me.cbocustomerid.Visible = True
        Me.btncreatecustomer.Text = "&Update"
        Me.SelectCustomerId()
        Me.CustomersClearFields()
    End Sub

    Private Sub DeleteToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem5.Click
        Me.lblcustomerid.Visible = False
        Me.cbocustomerid.Visible = True
        Me.btncreatecustomer.Text = "&Delete"
        Me.SelectCustomerId()
        Me.CustomersClearFields()
    End Sub

    Private Sub txtcustomerlastname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcustomerlastname.TextChanged
        If (Me.txtcustomerlastname.Text.Length >= 3 And Me.btncreatecustomer.Text = "&Create") Then
            Me.GenerateCustomerID()
        End If
    End Sub

    Private Sub cbocustomerid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocustomerid.SelectedIndexChanged
        LoadCustomersFields()
    End Sub

    Private Sub btnclearcustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclearcustomer.Click
        Me.CustomersClearFields()
    End Sub


    '------------------------------------------ Payment Methods --------------------------------------'

    Public Sub SelectPaymentname()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Payment_name FROM Payment_Methods"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbopaymentname.Items.Clear()

            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbopaymentname.Items.Add(dReader.Item("Payment_name"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadPaymentMethodsFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM Payment_Methods WHERE Payment_name = '" & Me.cbopaymentname.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.lblpaymentid.Text = dReader.Item("Payment_method_ID")
                    Me.cbopaymentname.Text = dReader.Item("Payment_name")

                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetPaymentname()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Payment_name) as Payment_name FROM Payment_Methods"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.strPaymentname = dReader.Item("Payment_name")
                End If
            Else
                Me.strPaymentname = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub InsertPaymentMethod()

        'Assign form values to class properties

        With objClsStock

            .Paymentmethodname = Me.cbopaymentname.Text

        End With

        'Call Procedure
        Me.objClsStock.InsertPaymentmethod()

    End Sub

    Private Sub UpdatePaymentmethod()
        'Assign form values to class properties

        With objClsStock

            .Paymentmethodid = Me.lblpaymentid.Text
            .Paymentmethodname = Me.cbopaymentname.Text

        End With


        'Call Procedure
        Me.objClsStock.UpdatePaymentmethod()

    End Sub

    Private Sub DeletePaymentmethod()

        'Assign form values to class properties
        Me.objClsStock.Paymentmethodname = Me.cbopaymentname.Text

        'Call Procedure
        Me.objClsStock.DeletePaymentmethod()
    End Sub

    Private Sub btnpaymentmethodsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaymentmethodsave.Click

        If Me.btnpaymentmethodsave.Text = "&Save" Then

            Try
                Me.InsertPaymentMethod()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Payment details Saved Successfully....")
            End Try
        ElseIf Me.btnpaymentmethodsave.Text = "&Update" Then

            Try
                Me.UpdatePaymentmethod()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Payment details Updated Successfully....")
            End Try

        ElseIf Me.btnpaymentmethodsave.Text = "&Delete" Then

            Try
                Me.DeletePaymentmethod()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Payment details Deleted Successfully....")
            End Try
        End If


        If Me.objClsStock.blnQuerySuccessful = True Then

            'Clear fields
            Me.PaymentMethodClearFields()
            Me.GetPaymentname()

        End If
    End Sub

    Public Sub PaymentMethodClearFields()

        Me.lblpaymentid.Text = ""
        Me.cbopaymentname.Text = ""


    End Sub

    Private Sub InsertPMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertPMToolStripMenuItem.Click
        Me.lblpaymentid.Visible = True
        Me.cbopaymentname.Visible = True
        Me.btnpaymentmethodsave.Text = "&Save"
        Me.PaymentMethodClearFields()
    End Sub

    Private Sub UpdatePMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePMToolStripMenuItem.Click
        Me.lblpaymentid.Visible = True
        Me.cbopaymentname.Visible = True
        Me.btnpaymentmethodsave.Text = "&Update"
        Me.SelectPaymentname()
        Me.PaymentMethodClearFields()
    End Sub

    Private Sub DeletePMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePMToolStripMenuItem.Click
        Me.lblpaymentid.Visible = True
        Me.cbopaymentname.Visible = True
        Me.btnpaymentmethodsave.Text = "&Delete"
        Me.SelectPaymentname()
        Me.PaymentMethodClearFields()
    End Sub

    Private Sub cbopaymentname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbopaymentname.SelectedIndexChanged
        LoadPaymentMethodsFields()
    End Sub

    Private Sub btnpaymentmethodclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaymentmethodclear.Click
        Me.PaymentMethodClearFields()
    End Sub




    '------------------------------------------ Categories --------------------------------------'

    Public Sub SelectCategoryname()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Category_name FROM Category"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader

            Me.cbocategoryname.Items.Clear()

            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.cbocategoryname.Items.Add(dReader.Item("Category_name"))
                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Public Sub LoadCategoryFields()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT * FROM Category WHERE Category_name = '" & Me.cbocategoryname.Text & "'"
            commObject.Connection = connString
            connString.Open()

            dReader = commObject.ExecuteReader


            'Fills the comboboxes whiles there is data to read
            Do While dReader.Read
                If dReader.IsDBNull(0) Then
                Else
                    Me.lblcategoryid.Text = dReader.Item("Category_ID")
                    Me.cbocategoryname.Text = dReader.Item("Category_name")
                    Me.txtcategoryreturnable.Text = dReader.Item("Returnable")

                End If
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub GetCategoryname()

        'close all connections before opening new one (especially if comboboxes are supposed to be filled)
        connString.Close()

        commObject = New SqlCommand

        Try
            commObject.CommandText = "SELECT Count(Category_name) as Category_name FROM Category"
            commObject.Connection = connString
            connString.Open()

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            If (dReader.Read) Then
                If Not (dReader.IsDBNull(0)) Then
                    Me.strCategoryname = dReader.Item("Category_name")
                End If
            Else
                Me.strCategoryname = 0
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub InsertCategory()

        'Assign form values to class properties

        With objClsStock

            .Categoryname = Me.cbocategoryname.Text
            .Returnable = Me.txtcategoryreturnable.Text

        End With

        'Call Procedure
        Me.objClsStock.InsertCategory()

    End Sub

    Private Sub UpdateCategory()
        'Assign form values to class properties

        With objClsStock

            .Categoryname = Me.cbocategoryname.Text
            .Returnable = Me.txtcategoryreturnable.Text

        End With


        'Call Procedure
        Me.objClsStock.UpdateCategory()

    End Sub

    Private Sub DeleteCategory()

        'Assign form values to class properties
        Me.objClsStock.Categoryname = Me.cbocategoryname.Text

        'Call Procedure
        Me.objClsStock.DeleteCategory()
    End Sub

    Private Sub btnsavecategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavecategories.Click

        If Me.btnsavecategories.Text = "&Save" Then

            Try
                Me.InsertCategory()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Category details Saved Successfully....")
            End Try
        ElseIf Me.btnsavecategories.Text = "&Update" Then

            Try
                Me.UpdateCategory()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Category details Updated Successfully....")
            End Try

        ElseIf Me.btnsavecategories.Text = "&Delete" Then

            Try
                Me.DeleteCategory()

            Catch ex As Exception
            Finally
                WriteStatusMessage("Category details Deleted Successfully....")
            End Try
        End If


        If Me.objClsStock.blnQuerySuccessful = True Then

            'Clear fields
            Me.CategoryClearFields()
            Me.GetCategoryname()

        End If
    End Sub

    Public Sub CategoryClearFields()

        Me.lblcategoryid.Text = ""
        Me.cbocategoryname.Text = ""
        Me.txtcategoryreturnable.Text = ""

    End Sub

    Private Sub InsertCategoryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertCategoryToolStripMenuItem2.Click
        Me.lblcategoryid.Visible = True
        Me.cbocategoryname.Visible = True
        Me.txtcategoryreturnable.Visible = True
        Me.btnsavecategories.Text = "&Save"
    End Sub
  
    Private Sub UpdateCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCategoryToolStripMenuItem.Click
        Me.lblcategoryid.Visible = True
        Me.cbocategoryname.Visible = True
        Me.txtcategoryreturnable.Visible = True
        Me.btnsavecategories.Text = "&Update"
        Me.SelectCategoryname()
    End Sub

    Private Sub DeleteCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCategoryToolStripMenuItem.Click
        Me.lblcategoryid.Visible = True
        Me.cbocategoryname.Visible = True
        Me.txtcategoryreturnable.Visible = True
        Me.btnsavecategories.Text = "&Delete"
        Me.SelectCategoryname()
    End Sub
    
    Private Sub cbocategoryname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocategoryname.SelectedIndexChanged
        LoadCategoryFields()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        CategoryClearFields()
    End Sub




    Private Sub RefreshToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripButton.Click
        'Populating for Employees
        Me.GetEmployeeID()

        'Populating for stocks/suppliers
        Me.SelectProductName()
        Me.SelectSuppliersID()
        Me.SelectCategoryID()

        'Populating for companies
        Me.SelectCompaniesId()

        'Populating for customers
        Me.SelectCustomerId()
        Me.SelectCompanyId()
        'Populating for companyinfo
        Me.SelectCompanyname()

        'Populating for paymentmethods
        Me.SelectPaymentname()
        Me.SelectCategoryID()
        Me.SelectSupplierID()
    End Sub



End Class