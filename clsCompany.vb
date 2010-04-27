
Imports System.Data.SqlClient

Public Class clsCompany

    'Attributes for company
    Private strCompanyID As String
    Private strCompanyName As String
    Private strContactperson As String
    Private strAddress As String
    Private strCity As String
    Private strPhone1 As String
    Private strPhone2 As String
    Private strmobile As String
    Private strFax As String
    Private strEmail As String
    Private strWeb As String
    Private decTaxrate As Decimal
    Private decNhilrate As Decimal
    Private strLogo As String
    Private strVat_Registration_No As String
    Private decCompanydebit As Decimal

    Public blnQuerySuccessful As Boolean

    'Properties for Company

    Public Property CompanyID() As String
        Get
            Return Me.strCompanyID
        End Get
        Set(ByVal value As String)
            Me.strCompanyID = value
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
    Public Property Contactperson() As String
        Get
            Return Me.strContactperson
        End Get
        Set(ByVal value As String)
            Me.strContactperson = value
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
    Public Property City() As String
        Get
            Return Me.strCity
        End Get
        Set(ByVal value As String)
            Me.strCity = value
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
    Public Property Mobile() As String
        Get
            Return Me.strmobile
        End Get
        Set(ByVal value As String)
            Me.strmobile = value
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
    Public Property Email() As String
        Get
            Return Me.strEmail
        End Get
        Set(ByVal value As String)
            Me.strEmail = value
        End Set
    End Property
    Public Property Web() As String
        Get
            Return Me.strWeb
        End Get
        Set(ByVal value As String)
            Me.strWeb = value
        End Set
    End Property
    Public Property Logo() As String
        Get
            Return Me.strLogo
        End Get
        Set(ByVal value As String)
            Me.strLogo = value
        End Set
    End Property
    Public Property Taxrate() As Decimal
        Get
            Return Me.decTaxrate
        End Get
        Set(ByVal value As Decimal)
            Me.decTaxrate = value
        End Set
    End Property
    Public Property Nhilrate() As Decimal
        Get
            Return Me.decNhilrate
        End Get
        Set(ByVal value As Decimal)
            Me.decNhilrate = value
        End Set
    End Property
    Public Property Vat_Registration_No() As String
        Get
            Return Me.strVat_Registration_No
        End Get
        Set(ByVal value As String)
            Me.strVat_Registration_No = value
        End Set
    End Property
    Public Property Companydebit() As Decimal
        Get
            Return Me.decCompanydebit
        End Get
        Set(ByVal value As Decimal)
            Me.decCompanydebit = value
        End Set
    End Property


    'Procedures for Employees
    Public Sub InsertCompanyInfo()
        blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertCompanyInfo"
            commObject.Parameters.Add("@strCompanyName", SqlDbType.NVarChar, 50).Value = Me.CompanyName.Trim
            commObject.Parameters.Add("@strCompanyAddress", SqlDbType.NVarChar, 60).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strCity", SqlDbType.NVarChar, 20).Value = Me.City.Trim
            commObject.Parameters.Add("@strPhone", SqlDbType.NVarChar, 13).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strFax", SqlDbType.NVarChar, 10).Value = Me.strFax.Trim
            commObject.Parameters.Add("@strEmail", SqlDbType.NVarChar, 30).Value = Me.strEmail.Trim
            commObject.Parameters.Add("@strWeb", SqlDbType.NVarChar, 30).Value = Me.strWeb.Trim
            commObject.Parameters.Add("@strTaxRate", SqlDbType.Decimal).Value = Me.decTaxrate
            commObject.Parameters.Add("@strNhilRate", SqlDbType.Decimal).Value = Me.decNhilrate
            commObject.Parameters.Add("@picLogo", SqlDbType.NVarChar, 500).Value = Me.strLogo
            commObject.Parameters.Add("@strVatRegistrationNumber", SqlDbType.NVarChar, 30).Value = Me.strVat_Registration_No.Trim

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True
            MessageBox.Show("Registration successful" & vbCrLf & "Please register Employees and Login")

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")
        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub UpdateCompanyInfo()
        blnQuerySuccessful = True
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspUpdateCompanyInfo"
            commObject.Parameters.Add("@strCompanyName", SqlDbType.NVarChar, 100).Value = Me.CompanyName.Trim
            commObject.Parameters.Add("@strCompanyAddress", SqlDbType.NVarChar, 50).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strCity", SqlDbType.NVarChar, 50).Value = Me.City.Trim
            commObject.Parameters.Add("@strPhone", SqlDbType.NVarChar, 50).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strFax", SqlDbType.NVarChar, 50).Value = Me.strFax.Trim
            commObject.Parameters.Add("@strEmail", SqlDbType.NVarChar, 50).Value = Me.strEmail.Trim
            commObject.Parameters.Add("@strWeb", SqlDbType.NVarChar, 50).Value = Me.strWeb.Trim
            commObject.Parameters.Add("@strTaxRate", SqlDbType.Decimal).Value = Me.decTaxrate
            commObject.Parameters.Add("@strNhilRate", SqlDbType.Decimal).Value = Me.decNhilrate
            commObject.Parameters.Add("@picLogo", SqlDbType.NVarChar, 500).Value = Me.strLogo
            commObject.Parameters.Add("@strVatRegistrationNumber", SqlDbType.NVarChar, 30).Value = Me.strVat_Registration_No.Trim

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True
            MessageBox.Show("Update successful")

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")
        Finally
            connString.Close()
        End Try
    End Sub
    Public Sub DeleteCompanyInfo()
        Me.blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try

            commObject.CommandText = "uspDeleteCompanyInfo"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strCompanyname", SqlDbType.NVarChar, 10).Value = strCompanyName


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




    Public Sub InsertCompanies()
        blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try

            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertCompanies"
            commObject.Parameters.Add("@strCompanyID", SqlDbType.NVarChar, 10).Value = Me.strCompanyID.Trim
            commObject.Parameters.Add("@strCompanyName", SqlDbType.NVarChar, 50).Value = Me.strCompanyName.Trim
            commObject.Parameters.Add("@strContactperson", SqlDbType.NVarChar, 20).Value = Me.strContactperson.Trim
            commObject.Parameters.Add("@strCompanyAddress", SqlDbType.NVarChar, 100).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strCompanylandphone1", SqlDbType.NVarChar, 13).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strCompanylandphone2", SqlDbType.NVarChar, 13).Value = Me.strPhone2.Trim
            commObject.Parameters.Add("@strCompanymobilephone", SqlDbType.NVarChar, 13).Value = Me.strmobile.Trim
            commObject.Parameters.Add("@strCompanyemail", SqlDbType.NVarChar, 30).Value = Me.strEmail.Trim
            commObject.Parameters.Add("@intCompanydebit", SqlDbType.Money).Value = Me.decCompanydebit

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True
            MessageBox.Show("Registration successful" & vbCrLf & "Please register Permanent Customers for this company")

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")
        Finally
            connString.Close()
        End Try
    End Sub

    Public Sub UpdateCompanies()

        blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspUpdateCompanies"
            commObject.Parameters.Add("@strCompanyID", SqlDbType.NVarChar, 10).Value = Me.strCompanyID.Trim
            commObject.Parameters.Add("@strCompanyName", SqlDbType.NVarChar, 50).Value = Me.strCompanyName.Trim
            commObject.Parameters.Add("@strContactperson", SqlDbType.NVarChar, 20).Value = Me.strContactperson.Trim
            commObject.Parameters.Add("@strCompanyAddress", SqlDbType.NVarChar, 60).Value = Me.strAddress.Trim
            commObject.Parameters.Add("@strCompanylandphone1", SqlDbType.NVarChar, 13).Value = Me.strPhone1.Trim
            commObject.Parameters.Add("@strCompanylandphone2", SqlDbType.NVarChar, 13).Value = Me.strPhone2.Trim
            commObject.Parameters.Add("@strCompanymobilephone", SqlDbType.NVarChar, 13).Value = Me.strmobile.Trim
            commObject.Parameters.Add("@strCompanyemail", SqlDbType.NVarChar, 30).Value = Me.strEmail.Trim
            commObject.Parameters.Add("@intCompanydebit", SqlDbType.Money).Value = Me.decCompanydebit


            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()

            Me.blnQuerySuccessful = True
            MessageBox.Show("Update successful")

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")
        Finally
            connString.Close()
        End Try
    End Sub

    Public Sub DeleteCompanies()
        blnQuerySuccessful = False
        'clear the sql command object of any previous
        commObject = New SqlCommand
        Try

            commObject.CommandText = "uspDeleteCompanies"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strCompanyID", SqlDbType.NVarChar, 10).Value = strCompanyID


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

