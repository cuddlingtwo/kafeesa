Imports System.Data.SqlClient

Public Class clsStocks

    'Private intProductID As Integer
    Private strSupplierID As String
    Private intProductID As Integer
    Private strProductname As String
    Private strProductdescription As String
    Private intQuantity As Integer
    Private decUnitCostprice As Decimal
    Private decMarkup As Decimal
    Private decUnitsellingprice As Decimal
    Private decTotalAmount As Decimal
    Private dteProducedate As Date
    Private dteExpirationdate As Date
    Private strInstock As String
    Private intCategoryID As Integer
    Private intCategoriesID As Integer
    Private strCategoryname As String
    Private strReturnable As String
    Private intReorder_point As Integer
    Private intPaymentmethodid As Integer
    Private strPaymentmethodname As String

    Public blnQuerySuccessful As Boolean


    'Class Attributes for stock

    Public Property SupplierID() As String
        Get
            Return Me.strSupplierID
        End Get
        Set(ByVal value As String)
            Me.strSupplierID = value
        End Set
    End Property
    Public Property ProductID() As Integer
        Get
            Return Me.intProductID
        End Get
        Set(ByVal value As Integer)
            Me.intProductID = value
        End Set
    End Property
    Public Property Paymentmethodid() As Integer
        Get
            Return Me.intpaymentmethodid
        End Get
        Set(ByVal value As Integer)
            Me.intpaymentmethodid = value
        End Set
    End Property
    Public Property Paymentmethodname() As String
        Get
            Return Me.strPaymentmethodname
        End Get
        Set(ByVal value As String)
            Me.strPaymentmethodname = value
        End Set
    End Property
    Public Property Productname() As String
        Get
            Return Me.strProductname
        End Get
        Set(ByVal value As String)
            Me.strProductname = value
        End Set
    End Property
    Public Property Productdescription() As String
        Get
            Return Me.strProductdescription
        End Get
        Set(ByVal value As String)
            Me.strProductdescription = value
        End Set
    End Property
    Public Property Quantity() As Integer
        Get
            Return Me.intQuantity
        End Get
        Set(ByVal value As Integer)
            Me.intQuantity = value
        End Set
    End Property
    Public Property UnitCostprice() As Decimal
        Get
            Return Me.decUnitCostprice
        End Get
        Set(ByVal value As Decimal)
            Me.decUnitCostprice = value
        End Set
    End Property
    Public Property Markup() As Decimal
        Get
            Return Me.decMarkup
        End Get
        Set(ByVal value As Decimal)
            Me.decMarkup = value
        End Set
    End Property
    Public Property Unitsellingprice() As Decimal
        Get
            Return Me.decUnitsellingprice
        End Get
        Set(ByVal value As Decimal)
            Me.decUnitsellingprice = value
        End Set
    End Property
    Public Property TotalAmount() As Decimal
        Get
            Return Me.decTotalAmount
        End Get
        Set(ByVal value As Decimal)
            Me.decTotalAmount = value
        End Set
    End Property
    Public Property Producedate() As Date
        Get
            Return Me.dteProducedate
        End Get
        Set(ByVal value As Date)
            Me.dteProducedate = value
        End Set
    End Property
    Public Property Expirationdate() As Date
        Get
            Return Me.dteExpirationdate
        End Get
        Set(ByVal value As Date)
            Me.dteExpirationdate = value
        End Set
    End Property
    Public Property InStock() As String
        Get
            Return Me.strInstock
        End Get
        Set(ByVal value As String)
            Me.strInstock = value
        End Set
    End Property
    Public Property CategoryID() As Integer
        Get
            Return Me.intCategoryID
        End Get
        Set(ByVal value As Integer)
            Me.intCategoryID = value
        End Set
    End Property
    Public Property CategoriesID() As Integer
        Get
            Return Me.intCategoriesID
        End Get
        Set(ByVal value As Integer)
            Me.intCategoriesID = value
        End Set
    End Property
    Public Property Categoryname() As String
        Get
            Return Me.strCategoryname
        End Get
        Set(ByVal value As String)
            Me.strCategoryname = value
        End Set
    End Property
    Public Property Returnable() As String
        Get
            Return Me.strReturnable
        End Get
        Set(ByVal value As String)
            Me.strReturnable = value
        End Set
    End Property
    Public Property Reorder_point() As Integer
        Get
            Return Me.intReorder_point
        End Get
        Set(ByVal value As Integer)
            Me.intReorder_point = value
        End Set
    End Property


    'Methods to use Stored Procedures
    Public Sub InsertStocks()

        Me.blnQuerySuccessful = False

        'Create new instance of sqlcommand to prevent overloaded parameters

        commObject = New SqlCommand

        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertStocks"
            commObject.Parameters.Add("@strProductname", SqlDbType.NVarChar, 50).Value = Me.strProductname.Trim
            commObject.Parameters.Add("@strSupplierID", SqlDbType.NVarChar, 10).Value = Me.strSupplierID.Trim
            commObject.Parameters.Add("@strProductdescription", SqlDbType.NVarChar, 500).Value = Me.strProductdescription.Trim
            commObject.Parameters.Add("@intReorderpoint", SqlDbType.Int).Value = Me.intReorder_point
            commObject.Parameters.Add("@intQuantity", SqlDbType.SmallInt).Value = Me.intQuantity
            commObject.Parameters.Add("monCostprice", SqlDbType.Money).Value = Me.decUnitCostprice
            commObject.Parameters.Add("@monMarkup", SqlDbType.Money).Value = Me.decMarkup
            commObject.Parameters.Add("@monUnitprice", SqlDbType.Money).Value = Me.decUnitsellingprice
            commObject.Parameters.Add("@dteProducedate", SqlDbType.DateTime2).Value = Me.dteProducedate
            commObject.Parameters.Add("@dteExpirationdate", SqlDbType.DateTime2).Value = Me.dteExpirationdate
            commObject.Parameters.Add("@strInstock", SqlDbType.NVarChar, 3).Value = Me.strInstock.Trim
            commObject.Parameters.Add("@intCategoryID", SqlDbType.TinyInt).Value = Me.intCategoryID

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

    Public Sub UpdateStock()

        blnQuerySuccessful = False

        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspUpdateStocks"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@intProductID", SqlDbType.Int).Value = Me.intProductID
            commObject.Parameters.Add("@strProductname", SqlDbType.NVarChar, 50).Value = Me.strProductname.Trim
            commObject.Parameters.Add("@strSupplierID", SqlDbType.NVarChar, 10).Value = Me.strSupplierID.Trim
            commObject.Parameters.Add("@strProductdescription", SqlDbType.NVarChar, 500).Value = Me.strProductdescription.Trim
            commObject.Parameters.Add("@intReorderpoint", SqlDbType.Int).Value = Me.intReorder_point
            commObject.Parameters.Add("@intQuantity", SqlDbType.SmallInt).Value = Me.intQuantity
            commObject.Parameters.Add("@monCostprice", SqlDbType.Money).Value = Me.decUnitCostprice
            commObject.Parameters.Add("@monMarkup", SqlDbType.Money).Value = Me.decMarkup
            commObject.Parameters.Add("@monUnitprice", SqlDbType.Money).Value = Me.decUnitsellingprice
            commObject.Parameters.Add("@dteProducedate", SqlDbType.DateTime2).Value = Me.dteProducedate
            commObject.Parameters.Add("@dteExpirationdate", SqlDbType.DateTime2).Value = Me.dteExpirationdate
            commObject.Parameters.Add("@strInstock", SqlDbType.NVarChar, 3).Value = Me.strInstock.Trim
            commObject.Parameters.Add("@intCategoryID", SqlDbType.TinyInt).Value = Me.intCategoryID

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()
            blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub

    Public Sub UpdateQuantityInStock()
        blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspUpdateQuantityInStock"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@intProductID", SqlDbType.NVarChar, 10).Value = Me.strProductname
            commObject.Parameters.Add("@intQuantity", SqlDbType.Int).Value = Me.intQuantity
            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()
            blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub

    Public Sub DeleteStock()
        blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspDeleteStock"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strProductname", SqlDbType.NVarChar, 15).Value = strProductname

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()
            blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub

    'Methods to use Stored Procedures
    Public Sub InsertPaymentmethod()

        Me.blnQuerySuccessful = False

        'Create new instance of sqlcommand to prevent overloaded parameters

        commObject = New SqlCommand

        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertPaymentmethod"
            'commObject.Parameters.Add("@intPaymentmethodID", SqlDbType.Int).Value = Me.intPaymentmethodid
            commObject.Parameters.Add("@strPaymentmethodname", SqlDbType.NVarChar, 50).Value = Me.strPaymentmethodname.Trim

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


    Public Sub UpdatePaymentmethod()

        Me.blnQuerySuccessful = False

        'Create new instance of sqlcommand to prevent overloaded parameters

        commObject = New SqlCommand

        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspUpdatePaymentmethod"
            commObject.Parameters.Add("@intPaymentmethodID", SqlDbType.Int).Value = Me.intPaymentmethodid
            commObject.Parameters.Add("@strPaymentmethodname", SqlDbType.NVarChar, 50).Value = Me.strPaymentmethodname.Trim

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


    Public Sub DeletePaymentmethod()
        blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspDeletePaymentmethod"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strPaymentmethodname", SqlDbType.NVarChar, 50).Value = strPaymentmethodname

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()
            blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub



    'Methods to use Stored Procedures
    Public Sub InsertCategory()

        Me.blnQuerySuccessful = False

        'Create new instance of sqlcommand to prevent overloaded parameters

        commObject = New SqlCommand

        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspInsertCategory"
            'commObject.Parameters.Add("@intCategoryID", SqlDbType.Int).Value = Me.intPaymentmethodid
            commObject.Parameters.Add("@strCategoryname", SqlDbType.NVarChar, 50).Value = Me.strCategoryname.Trim
            commObject.Parameters.Add("@strReturnable", SqlDbType.NVarChar, 5).Value = Me.strReturnable.Trim

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


    Public Sub UpdateCategory()

        Me.blnQuerySuccessful = False

        'Create new instance of sqlcommand to prevent overloaded parameters

        commObject = New SqlCommand

        Try
            commObject.CommandType = CommandType.StoredProcedure
            commObject.CommandText = "uspUpdateCategory"
            commObject.Parameters.Add("@strCategoryname", SqlDbType.NVarChar, 50).Value = Me.strCategoryname.Trim
            commObject.Parameters.Add("@strReturnable", SqlDbType.NVarChar, 5).Value = Me.strReturnable.Trim

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


    Public Sub DeleteCategory()
        blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspDeleteCategory"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@strCategoryname", SqlDbType.NVarChar, 50).Value = strCategoryname

            commObject.Connection = connString
            connString.Open()
            commObject.ExecuteNonQuery()
            blnQuerySuccessful = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally
            connString.Close()

        End Try
    End Sub

End Class


