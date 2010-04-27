Imports System.Data.SqlClient

Public Class clsPersons
    'Attributes for all
    Private strLastName As String
    Private strFirstName As String
    Private strTitle As String

    'Attributes for Employees

    Private strUserName As String
    Private strPass As String
    Private strEmployeeposition As String
    Private strActiveStatus As String
    Private dteLogintime As Date
    Private dteLogouttime As Date

    'Attributes for Employee/Suppliers/Customers
    Private strSupplierID As String
    Private strCustomerID As String
    Private strEmployeeID As String
    Private strAddress As String
    Private strPhone1 As String
    Private strPhone2 As String
    Private strPhoto As String
    Private strFax As String
    Private strEmail As String
    Private dteDOB As Date
    Private dteStartDate As Date
    Private dteEndDate As Date

    'Attributes for Company
    Private strCompanyID As String
    Private strCompanyName As String
    Private strContactperson As String
    Private strMobileNumber As String


    'Private strBolen As String = "False"
    Public blnQuerySuccessful As Boolean

    'Properties for all
    Public Property LastName() As String
        Get
            Return Me.strLastName
        End Get
        Set(ByVal value As String)
            Me.strLastName = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return Me.strFirstName
        End Get
        Set(ByVal value As String)
            Me.strFirstName = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return Me.strTitle
        End Get
        Set(ByVal value As String)
            Me.strTitle = value
        End Set
    End Property

    'Properties for Employees
    Public Property ActiveStatus() As String
        Get
            Return Me.strActiveStatus
        End Get
        Set(ByVal value As String)
            Me.strActiveStatus = value
        End Set
    End Property
    'Properties for Employees
    Public Property EmployeeID() As String
        Get
            Return Me.strEmployeeID
        End Get
        Set(ByVal value As String)
            Me.strEmployeeID = value
        End Set
    End Property
    Public Property Employeeposition() As String
        Get
            Return Me.strEmployeeposition
        End Get
        Set(ByVal value As String)
            Me.strEmployeeposition = value
        End Set
    End Property
    Public Property Photo() As String
        Get
            Return Me.strPhoto
        End Get
        Set(ByVal value As String)
            Me.strPhoto = value
        End Set
    End Property
    Public Property UserName() As String
        Get
            Return Me.strUserName
        End Get
        Set(ByVal value As String)
            Me.strUserName = value
        End Set
    End Property

    Public Property Pass() As String
        Get
            Return Me.strPass
        End Get
        Set(ByVal value As String)
            Me.strPass = value
        End Set
    End Property

    Public Property Logintime()
        Get
            Return Me.dteLogintime
        End Get
        Set(ByVal value)
            Me.dteLogintime = value
        End Set
    End Property
    Public Property Logouttime() As String
        Get
            Return Me.dteLogouttime
        End Get
        Set(ByVal value As String)
            Me.dteLogouttime = value
        End Set
    End Property
    Public Property CompanyID() As String
        Get
            Return Me.strCompanyID
        End Get
        Set(ByVal value As String)
            Me.strCompanyID = value
        End Set
    End Property
    Public Property SupplierID() As String
        Get
            Return Me.strSupplierID
        End Get
        Set(ByVal value As String)
            Me.strSupplierID = value
        End Set
    End Property
    Public Property CustomerID() As String
        Get
            Return Me.strCustomerID
        End Get
        Set(ByVal value As String)
            Me.strCustomerID = value
        End Set
    End Property

    Public Property Contactperson() As String
        Get
            Return Me.strContactperson
        End Get
        Set(ByVal value As String)
            Me.strContactperson = value
        End Set
    End Property
    Public Property CompanyName() As String
        Get
            Return Me.strCompanyName
        End Get
        Set(ByVal value As String)
            Me.strCompanyName = value
        End Set
    End Property
    Public Property MobileNumber() As String
        Get
            Return Me.strMobileNumber
        End Get
        Set(ByVal value As String)
            Me.strMobileNumber = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return Me.strAddress
        End Get
        Set(ByVal value As String)
            Me.strAddress = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return Me.strFax
        End Get
        Set(ByVal value As String)
            Me.strFax = value
        End Set
    End Property
    Public Property DOB() As String
        Get
            Return Me.dteDOB
        End Get
        Set(ByVal value As String)
            Me.dteDOB = value
        End Set
    End Property
    Public Property Phone1() As String
        Get
            Return Me.strPhone1
        End Get
        Set(ByVal value As String)
            Me.strPhone1 = value
        End Set
    End Property

    Public Property Phone2() As String
        Get
            Return Me.strPhone2
        End Get
        Set(ByVal value As String)
            Me.strPhone2 = value
        End Set
    End Property
    Public Property StartDate() As String
        Get
            Return Me.dteStartDate
        End Get
        Set(ByVal value As String)
            Me.dteStartDate = value
        End Set
    End Property
    Public Property EndDate() As String
        Get
            Return Me.dteEndDate
        End Get
        Set(ByVal value As String)
            Me.dteEndDate = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return Me.strEmail
        End Get
        Set(ByVal value As String)
            Me.strEmail = value
        End Set
    End Property

    'Procedure for All
    Public Sub InsertPersonAttributes()
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "bniInsertPersonAttributes"
            commObject.Parameters.Add("@strTitle", SqlDbType.NVarChar, 50).Value = Me.strTitle.Trim
            commObject.Parameters.Add("@strEmployeeposition", SqlDbType.NVarChar, 50).Value = Me.strEmployeeposition.Trim

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            MessageBox.Show("Insert successful")

        Catch mes As SqlException
            MsgBox(mes.Message, MsgBoxStyle.OkOnly)
        Finally
            connString.Close()
        End Try
    End Sub
    'Procedures for Employees
    Public Sub InsertEmployees()
        Me.blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertEmployees"
            commObject.Parameters.Add("@strEmployeeID", SqlDbType.NVarChar, 10).Value = Me.strEmployeeID
            commObject.Parameters.Add("@strTitle", SqlDbType.NVarChar, 5).Value = Me.strTitle.Trim
            commObject.Parameters.Add("@strlastName", SqlDbType.NVarChar, 50).Value = Me.strLastName.Trim
            commObject.Parameters.Add("@strFirstName", SqlDbType.NVarChar, 50).Value = Me.strFirstName.Trim
            commObject.Parameters.Add("@strEmployeeaddress", SqlDbType.NVarChar, 50).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strEmployeeposition", SqlDbType.NVarChar, 50).Value = Me.strEmployeeposition.Trim
            commObject.Parameters.Add("@strPhoto", SqlDbType.NVarChar, 500).Value = Me.strPhoto.Trim
            commObject.Parameters.Add("@strEmployeephone", SqlDbType.NVarChar, 50).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strEmployeeemail", SqlDbType.NVarChar, 500).Value = Me.strEmail.Trim
            commObject.Parameters.Add("@dteDOB", SqlDbType.NVarChar, 25).Value = Me.dteDOB
            commObject.Parameters.Add("@dteStartDate", SqlDbType.DateTime2, 25).Value = Me.dteStartDate
            commObject.Parameters.Add("@dteEndDate", SqlDbType.DateTime2, 25).Value = Me.dteEndDate
            commObject.Parameters.Add("@strUsername", SqlDbType.NVarChar, 25).Value = Me.strUserName.Trim
            commObject.Parameters.Add("@strPass", SqlDbType.NVarChar, 30).Value = Me.strPass.Trim
            commObject.Parameters.Add("@strActiveStatus", SqlDbType.NVarChar, 3).Value = Me.strActiveStatus.Trim


            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True

        Catch mes As SqlException
            MsgBox(mes.Message, MsgBoxStyle.OkOnly)
        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub UpdateEmployees()
        Me.blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspUpdateEmployees"
            commObject.Parameters.Add("@strEmployeeID", SqlDbType.NVarChar, 10).Value = Me.strEmployeeID
            commObject.Parameters.Add("@strTitle", SqlDbType.NVarChar, 5).Value = Me.strTitle.Trim
            commObject.Parameters.Add("@strlastName", SqlDbType.NVarChar, 50).Value = Me.strLastName.Trim
            commObject.Parameters.Add("@strFirstName", SqlDbType.NVarChar, 50).Value = Me.strFirstName.Trim
            commObject.Parameters.Add("@strEmployeeaddress", SqlDbType.NVarChar, 50).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strEmployeeposition", SqlDbType.NVarChar, 50).Value = Me.strEmployeeposition.Trim
            commObject.Parameters.Add("@strPhoto", SqlDbType.NVarChar, 500).Value = Me.strPhoto.Trim
            commObject.Parameters.Add("@strEmployeephone", SqlDbType.NVarChar, 50).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strEmployeeemail", SqlDbType.NVarChar, 500).Value = Me.strEmail.Trim
            commObject.Parameters.Add("@dteDOB", SqlDbType.DateTime2).Value = Me.dteDOB
            commObject.Parameters.Add("@dteStartDate", SqlDbType.DateTime2, 25).Value = Me.dteStartDate
            commObject.Parameters.Add("@dteEndDate", SqlDbType.DateTime2, 25).Value = Me.dteEndDate
            commObject.Parameters.Add("@strUsername", SqlDbType.NVarChar, 25).Value = Me.strUserName.Trim
            commObject.Parameters.Add("@strPass", SqlDbType.NVarChar, 30).Value = Me.strPass.Trim
            commObject.Parameters.Add("@strActiveStatus", SqlDbType.NVarChar, 3).Value = Me.strActiveStatus

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True

        Catch mes As SqlException
            MsgBox(mes.Message, MsgBoxStyle.OkOnly)
        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub DeleteEmployees()
        Me.blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspDeleteEmployees"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strEmployeeID", SqlDbType.NVarChar, 10).Value = strEmployeeID

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub
    'Public Sub UpdateUsers()
    '    Me.blnQuerySuccessful = False
    '    'create instance of the Sqlcommands to prevent overloaded parameters
    '    commObject = New SqlCommand
    '    Try
    '        commObject.CommandText = "bniUpdateUsers"
    '        commObject.CommandType = CommandType.StoredProcedure
    '        commObject.Parameters.Add("@intUserID", SqlDbType.SmallInt).Value = Me.UserID
    '        commObject.Parameters.Add("@strUserName", SqlDbType.NVarChar, 50).Value = Me.UserName
    '        commObject.Parameters.Add("@strPassword", SqlDbType.NVarChar, 30).Value = Me.Pass
    '        commObject.Connection = connString
    '        connString.Open()
    '        commObject.ExecuteNonQuery()

    '        Me.blnQuerySuccessful = True

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error Message")
    '    Finally
    '        connString.Close()
    '    End Try

    'End Sub
    'Procedures for Customers


    Public Sub InsertCustomers()
        Me.blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertCustomers"
            commObject.Parameters.Add("@strCustomerID", SqlDbType.NVarChar, 25).Value = Me.strCustomerID.Trim
            commObject.Parameters.Add("@strTitle", SqlDbType.NVarChar, 5).Value = Me.strTitle.Trim
            commObject.Parameters.Add("@strFirstName", SqlDbType.NVarChar, 50).Value = Me.strFirstName.Trim
            commObject.Parameters.Add("@strLastName", SqlDbType.NVarChar, 50).Value = Me.strLastName.Trim
            commObject.Parameters.Add("@strCompanyID", SqlDbType.NVarChar, 10).Value = Me.strCompanyID
            commObject.Parameters.Add("@strAddress", SqlDbType.NVarChar, 50).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strPhoto", SqlDbType.NVarChar, 500).Value = Me.strPhoto
            commObject.Parameters.Add("@strPhone", SqlDbType.NVarChar, 15).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strEmailAddress", SqlDbType.NVarChar, 30).Value = Me.strEmail.Trim


            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True

        Catch mes As SqlException
            MsgBox(mes.Message, MsgBoxStyle.OkOnly)
        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub UpdateCustomers()

        Me.blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspUpdateCustomers"
            commObject.Parameters.Add("@strCustomerID", SqlDbType.NVarChar, 10).Value = Me.strCustomerID.Trim
            commObject.Parameters.Add("@strTitle", SqlDbType.NVarChar, 5).Value = Me.strTitle.Trim
            commObject.Parameters.Add("@strFirstName", SqlDbType.NVarChar, 50).Value = Me.strFirstName.Trim
            commObject.Parameters.Add("@strLastName", SqlDbType.NVarChar, 50).Value = Me.strLastName.Trim
            commObject.Parameters.Add("@strCompanyID", SqlDbType.NVarChar, 10).Value = Me.strCompanyID
            commObject.Parameters.Add("@strAddress", SqlDbType.NVarChar, 50).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strPhoto", SqlDbType.NVarChar, 500).Value = Me.strPhoto
            commObject.Parameters.Add("@strPhone", SqlDbType.NVarChar, 15).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strEmailAddress", SqlDbType.NVarChar, 30).Value = Me.strEmail.Trim


            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True
            MessageBox.Show("Update successful")

        Catch mes As SqlException
            MsgBox(mes.Message, MsgBoxStyle.OkOnly)
        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub DeleteCustomers()
        Me.blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspDeleteCustomers"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strCustomerID", SqlDbType.NVarChar, 10).Value = strCustomerID

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub

    'Procedures for Suppliers
    Public Sub InsertSuppliers()
        Me.blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertSuppliers"
            commObject.Parameters.Add("@strSupplierID", SqlDbType.NVarChar, 10).Value = Me.strSupplierID.Trim
            commObject.Parameters.Add("@strSupplierName", SqlDbType.NVarChar, 50).Value = Me.strFirstName.Trim
            commObject.Parameters.Add("@strContactperson", SqlDbType.NVarChar, 100).Value = Me.strContactperson.Trim
            commObject.Parameters.Add("@strSupplieraddress", SqlDbType.NVarChar, 50).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strSupplierlandline1", SqlDbType.NVarChar, 13).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strSupplierlandline2", SqlDbType.NVarChar, 13).Value = Me.strPhone2.Trim
            commObject.Parameters.Add("@strSuppliermobile", SqlDbType.NVarChar, 13).Value = Me.strMobileNumber.Trim
            commObject.Parameters.Add("@strSupplieremail", SqlDbType.NVarChar, 30).Value = Me.strEmail.Trim


            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True

        Catch mes As SqlException

            MsgBox(mes.Message, MsgBoxStyle.OkOnly)

        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub UpdateSuppliers()

        Me.blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspUpdateSuppliers"
            commObject.Parameters.Add("@strSupplierID", SqlDbType.NVarChar, 10).Value = Me.strSupplierID.Trim
            commObject.Parameters.Add("@strSupplierName", SqlDbType.NVarChar, 50).Value = Me.strFirstName.Trim
            commObject.Parameters.Add("@strContactperson", SqlDbType.NVarChar, 100).Value = Me.strContactperson.Trim
            commObject.Parameters.Add("@strSupplieraddress", SqlDbType.NVarChar, 50).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strSupplierlandline1", SqlDbType.NVarChar, 13).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strSupplierlandline2", SqlDbType.NVarChar, 13).Value = Me.strPhone2.Trim
            commObject.Parameters.Add("@strSuppliermobile", SqlDbType.NVarChar, 13).Value = Me.strMobileNumber.Trim
            commObject.Parameters.Add("@strSupplieremail", SqlDbType.NVarChar, 30).Value = Me.strEmail.Trim


            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()



            Me.blnQuerySuccessful = True

        Catch mes As SqlException
            MsgBox(mes.Message, MsgBoxStyle.OkOnly)
        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub DeleteSuppliers()
        Me.blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspDeleteSuppliers"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strSupplierID", SqlDbType.NVarChar, 10).Value = strSupplierID

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub


End Class

