Imports System.Data.SqlClient

Public Class clsSales

    'Declare objects
    Private objClsItems As New clsSales

    'Variable Declarations for both Sales and Sales_details
    Private intSales_ID As Integer

    'Variable Declarations for Sales
    Private intCustomer_ID As Integer
    Private intQuantity As Integer
    Private decVat As Decimal
    Private decDiscount As Decimal
    Private decNHIL As Decimal
    Private intNHIS_ID As Integer
    Private decAmount_Paid As Decimal
    Private decChange As Decimal
    Private decTotal_Amount As Decimal
    Private decPayment_MethodID As Decimal
    Private dteModified_date As Date

    'Variable Declarations for Sales_details
    Private intProduct_ID As Integer
    Private intEmployee_ID As Integer


    Public blnQuerySuccessful As Boolean

    'Class Attributes for Sales
    Public Property Sales_ID() As Integer
        Get
            Return Me.intSales_ID
        End Get
        Set(ByVal value As Integer)
            Me.intSales_ID = value
        End Set
    End Property
    Public Property Customer_ID() As Integer
        Get
            Return Me.intCustomer_ID
        End Get
        Set(ByVal value As Integer)
            Me.intCustomer_ID = value
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
    Public Property Vat() As Decimal
        Get
            Return Me.decVat
        End Get
        Set(ByVal value As Decimal)
            Me.decVat = value
        End Set
    End Property
    Public Property Discount() As Decimal
        Get
            Return Me.decDiscount
        End Get
        Set(ByVal value As Decimal)
            Me.decDiscount = value
        End Set
    End Property
    Public Property NHIL() As Decimal
        Get
            Return Me.decNHIL
        End Get
        Set(ByVal value As Decimal)
            Me.decNHIL = value
        End Set
    End Property
    Public Property NHIS_ID() As Integer
        Get
            Return Me.intNHIS_ID
        End Get
        Set(ByVal value As Integer)
            Me.intNHIS_ID = value
        End Set
    End Property
    Public Property Amount_Paid() As Decimal
        Get
            Return Me.decAmount_Paid
        End Get
        Set(ByVal value As Decimal)
            Me.decAmount_Paid = value
        End Set
    End Property
    Public Property Change() As Decimal
        Get
            Return Me.decChange
        End Get
        Set(ByVal value As Decimal)
            Me.decChange = value
        End Set
    End Property
    Public Property Total_Amount() As Decimal
        Get
            Return Me.decTotal_Amount
        End Get
        Set(ByVal value As Decimal)
            Me.decTotal_Amount = value
        End Set
    End Property

    Public Property Payment_MethodID() As Decimal
        Get
            Return Me.decPayment_MethodID
        End Get
        Set(ByVal value As Decimal)
            Me.decPayment_MethodID = value
        End Set
    End Property
    Public Property Modified_date() As Date
        Get
            Return Me.dteModified_date
        End Get
        Set(ByVal value As Date)
            Me.dteModified_date = value
        End Set
    End Property
    Public Property Product_ID() As Integer
        Get
            Return Me.intProduct_ID
        End Get
        Set(ByVal value As Integer)
            Me.intProduct_ID = value
        End Set
    End Property
    Public Property Employee_ID() As Integer
        Get
            Return Me.intEmployee_ID
        End Get
        Set(ByVal value As Integer)
            Me.intEmployee_ID = value
        End Set
    End Property

    'Methods to use Stored Procedures

    Public Sub InsertIntoSales()

        blnQuerySuccessful = False

        'Create new instance of sqlcommand to prevent overloaded parameters

        commObject = New SqlCommand

        Try
            commObject.CommandText = "uspInsertSales"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@intSaleID", SqlDbType.Int).Value = Me.Sales_ID
            commObject.Parameters.Add("@strCustomerID", SqlDbType.NVarChar, 25).Value = Me.Customer_ID
            commObject.Parameters.Add("@intQuantity", SqlDbType.SmallInt).Value = Me.Quantity
            commObject.Parameters.Add("@monVat", SqlDbType.Money).Value = Me.Vat
            commObject.Parameters.Add("@monDiscount", SqlDbType.Money).Value = Me.Discount
            commObject.Parameters.Add("@monNhil", SqlDbType.Money).Value = Me.NHIL
            commObject.Parameters.Add("@strNhisID", SqlDbType.NVarChar, 20).Value = Me.NHIS_ID
            commObject.Parameters.Add("@monAmountPaid", SqlDbType.Money).Value = Me.Amount_Paid
            commObject.Parameters.Add("@monChange", SqlDbType.Money).Value = Me.Change
            commObject.Parameters.Add("@monTotalAmount", SqlDbType.Money).Value = Me.Total_Amount
            commObject.Parameters.Add("@intPaymentMethodID", SqlDbType.TinyInt).Value = Me.Payment_MethodID

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


    Public Sub InsertIntoSalesDetails()
        blnQuerySuccessful = False
        'Create new instance of sqlcommand to prevent overloaded parameters
        commObject = New SqlCommand

        Try
            commObject.CommandText = "USPInsertSalesDetails"
            commObject.CommandType = CommandType.StoredProcedure
            commObject.Parameters.Add("@intSaleID", SqlDbType.Int).Value = Me.Sales_ID
            commObject.Parameters.Add("@intProductID", SqlDbType.Int).Value = Me.Product_ID
            commObject.Parameters.Add("@intEmployeeID", SqlDbType.VarChar, 10).Value = Me.Employee_ID


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

    Public Sub SelectSaleID()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Count(Sale_ID) as SaleID FROM Sales"
            commObject.Connection = connString
            connString.Open()

            dAdapter.SelectCommand = commObject
            dAdapter.Fill(dSet)

            'Associate data reader with command object
            dReader = commObject.ExecuteReader



            'Fill item stock details in respective fields on form
            If (dReader.Read) Then
                If dReader.IsDBNull(0) Then
                    'Set to one to prevent NULL value being assigned
                    Me.Sales_ID = 1
                Else
                    Me.Sales_ID = dReader.Item("Sale_ID") + 1
                End If
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub
End Class


