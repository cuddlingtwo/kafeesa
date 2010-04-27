Imports System.Data.SqlClient

Public Class frmSalesCashier


    Private objClsPerson As New clsPersons

    Private blnSearchCellSelected As Boolean
    Private intSearchItemSelected As Integer
    Private blnRepeatItem As Boolean
    Private intLoop As Integer
    Private intCartCnt As Integer
    Private blnCartCellSelected As Boolean = False
    Private intCartItemSelected As Integer


    Public Sub Search()

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try

            'Generate query depending on number of un-empty fields
            commObject.CommandText = "SELECT Product_name, Unit_price, Product_description, Quantity FROM Stock WHERE Product_name LIKE '%" & Me.txtsearchbyproductname.Text & "%'"
            commObject.Connection = connString
            connString.Open()

            dAdapter.SelectCommand = commObject
            dAdapter.Fill(dSet)

            dgproductsearchlist.DataSource = dSet.Tables(0)


        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try

    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        frmlogin.Show()
        frmlogin.BringToFront()
        frmlogin.txtusername.Focus()
    End Sub

    Private Sub txtsearchbyproductname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearchbyproductname.TextChanged
        Me.Search()
        dgproductsearchlist.BringToFront()
        dgproductsearchlist.Show()
        If txtsearchbyproductname.Text = "" Then
            dgproductsearchlist.Hide()
        End If
    End Sub

    Private Sub dgproductsearchlist_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgproductsearchlist.Click

        If Me.dgproductsearchlist.RowCount > 1 Then
            'Gets the row index of cell clicked
            intSearchItemSelected = Me.dgproductsearchlist.CurrentCell.RowIndex

            'Set the cell selected to true to be able to add  to cart
            Me.blnSearchCellSelected = True

        End If
    End Sub

    Private Sub dgproductsearchlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgproductsearchlist.DoubleClick
        If (blnSearchCellSelected = True) Then

            'Make Cart datagrid visible
            Me.dgcart.Visible = True

            'Check if items are not repeated in cart
            For Me.intLoop = 0 To Me.intCartCnt - 1
                If (Me.dgproductsearchlist.Item("Product_name", intSearchItemSelected).Value = Me.dgcart.Item("colproductname", Me.intLoop).Value) Then
                    MessageBox.Show("Product already exist in cart")
                    Me.blnRepeatItem = True
                End If
            Next

            If (Me.blnRepeatItem = False) Then
                'Add new row to dgCart
                Me.dgcart.Rows.Add()


                
                'Add selected item in dgSearch to dgCart
                'Add Productname
                Me.dgcart.Item("colproductname", Me.intCartCnt).Value = Me.dgproductsearchlist.Item("Product_name", intSearchItemSelected).Value

                Me.dgcart.Item("colquantity", Me.intCartCnt).Value = Me.dgproductsearchlist.Item("Quantity", intSearchItemSelected).Value

                Me.dgcart.Item("colUnitprice", Me.intCartCnt).Value = Me.dgproductsearchlist.Item("Unit_price", intSearchItemSelected).Value

                Me.dgcart.Item("coldescription", Me.intCartCnt).Value = Me.dgproductsearchlist.Item("Product_description", intSearchItemSelected).Value


                'Store Productid
                'Me.dgcart.Item("colproductid", Me.intCartCnt).Value = Me.dgproductsearchlist.Item("Product_ID", Me.intSearchItemSelected).Value

                'increase count to add new items to cart
                Me.intCartCnt += 1
                Me.dgproductsearchlist.ClearSelection()
                Me.dgproductsearchlist.Hide()
                Me.txtsearchbyproductname.Clear()

            End If

        Else
            MessageBox.Show("Please select item before adding to cart")
        End If

        'Set to false to enable user to choose another cell
        blnSearchCellSelected = False
        Me.blnRepeatItem = False

        'remove  annoying zero from last empty row
        Me.dgcart.Item("colquantity", Me.dgcart.RowCount - 1).Value = ""

    End Sub

    Public Sub CheckForDefaultCustomer()

        Dim blnDefaultFound As Boolean = False

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try
            commObject.CommandText = "SELECT Customer_ID FROM Customers WHERE Customer_ID = 'EX01'"
            commObject.Connection = connString
            connString.Open()

            dAdapter.SelectCommand = commObject
            dAdapter.Fill(dSet)

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            'Fill item stock details in respective fields on form
            If (dReader.Read) Then
                blnDefaultFound = True
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()

            'If default customer is deleted accidentally then insert
            If blnDefaultFound = False Then

                Me.objClsPerson.CustomerID = "EX01"
                Me.objClsPerson.Title = "Express"
                Me.objClsPerson.FirstName = "Express"
                Me.objClsPerson.LastName = "Express"
                Me.objClsPerson.CompanyID = "fff101"
                Me.objClsPerson.Address = "Express"
                Me.objClsPerson.Photo = "Express"
                Me.objClsPerson.Phone1 = "Express"
                Me.objClsPerson.Email = "Express"

                'Call Procedure
                Me.objClsPerson.InsertCustomers()

            End If
        End Try
    End Sub

    Private Sub btnrefunds_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefunds.Click
        frmRefunds.Show()
    End Sub

    Private Sub btncheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheckout.Click
        frmCheckout.Show()
    End Sub

    Private Sub btnclearsale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclearsale.Click
        If (MessageBox.Show("Are you sure you want to completely clear all items and relatated information", "KAFEESA PHARMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            'MessageBox.Show("Do you want to clear the current sale items?")
            Me.dgcart.Rows.Clear()

            'Reset Cart counter
            Me.intCartCnt = 0
        End If
    End Sub

    Private Sub frmSalesCashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If default customer is deleted accidentally, then insert
        Me.CheckForDefaultCustomer()

    End Sub

    Private Sub btncartremoveitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncartremoveitem.Click
        'Check if cell is selected
        If (Me.blnCartCellSelected = True) Then
            MessageBox.Show("Please select item first")

        Else

            'Verify if User really wants to remove row
            If (MessageBox.Show("Do You Really Want To Remove Item", "BranIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then

                'used in loop for remove
                Dim intRemoveRow As Integer
                'get the total number of rows
                Dim intRowTotal As Integer = Me.dgcart.Rows.Count - 2
                'Check if the datatable is empty
                If (intRowTotal = -1) Then
                    MessageBox.Show("Cannot Remove From Empty Table")
                Else
                    'intRowTake gets the index of selected row (starts from 0)
                    'loop to remove selected row and move all rows up one step
                    For intRemoveRow = intCartItemSelected To intRowTotal
                        Me.dgcart.Item("colproductname", intRemoveRow).Value = Me.dgcart.Item("colproductname", intRemoveRow + 1).Value
                        Me.dgcart.Item("colquantity", intRemoveRow).Value = Me.dgcart.Item("colquantity", intRemoveRow + 1).Value
                        Me.dgcart.Item("colUnitprice", intRemoveRow).Value = Me.dgcart.Item("colUnitprice", intRemoveRow + 1).Value
                        Me.dgcart.Item("coldescription", intRemoveRow).Value = Me.dgcart.Item("coldescription", intRemoveRow + 1).Value
                        Me.dgcart.Item("colextendedprice", intRemoveRow).Value = Me.dgcart.Item("colextendedprice", intRemoveRow + 1).Value
                    Next


                    'Removes the last row from table to allow new rows to be added
                    Me.dgcart.Rows.RemoveAt(intRowTotal)

                    'Decreases intCntRow to make the add command possible
                    Me.intCartCnt -= 1

                End If

            End If

        End If

        'Set to false to enable user to choose another cell
        Me.blnCartCellSelected = False
    End Sub



End Class