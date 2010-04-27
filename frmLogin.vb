Imports System.Data.SqlClient

Public Class frmlogin

    'Private objClsPerson As New clsPersons

    'Declare collections
    'Private clnUserid As New Collection
    Private clnEmployeeid As New Collection
    Private clnUsername As New Collection
    Private clnPassword As New Collection
    Private clnEmployeePosition As New Collection
    Private clnFirstname As New Collection
    'Private clnEmployeePhoto As New Collection

    'Declare variables
    Private intCollectionCnt As Integer
    Private intLoop As Integer
    Private blnLoginInfoFound As Boolean
    Private strTempUsername As String
    Private intloginCnt As Integer

    Public Sub SelectAllUsers()

        clnEmployeeid = New Collection
        clnUsername = New Collection
        clnPassword = New Collection
        clnEmployeePosition = New Collection
        clnFirstname = New Collection

        'refresh collection counter
        Me.intCollectionCnt = 1

        commObject = New SqlCommand
        dAdapter = New SqlDataAdapter
        dSet = New DataSet

        Try

            commObject.CommandText = "SELECT * FROM Employees"
            commObject.Connection = connString
            connString.Open()

            dAdapter.SelectCommand = commObject
            dAdapter.Fill(dSet)

            'Associate data reader with command object
            dReader = commObject.ExecuteReader

            Do While dReader.Read
                Me.clnEmployeeid.Add(dReader.Item("Employee_ID"), Me.intCollectionCnt)
                Me.clnUsername.Add(dReader.Item("Username"), Me.intCollectionCnt)
                Me.clnPassword.Add(dReader.Item("Pass"), Me.intCollectionCnt)
                Me.clnFirstname.Add(dReader.Item("First_name"), Me.intCollectionCnt)
                Me.clnEmployeePosition.Add(dReader.Item("Employee_position"), Me.intCollectionCnt)

                Me.intCollectionCnt += 1
            Loop

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error Message")

        Finally

            connString.Close()
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MessageBox.Show("Do you want to Exit", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        'Declare objects
        Dim objClsAdministration As New frmAdministration
        Dim ObjClsSalesCashier As New frmSalesCashier
        Dim ObjClsKnowledgeBase As New frmknowledgebase

        Me.blnLoginInfoFound = False

        For Me.intLoop = 1 To Me.intCollectionCnt - 1
            'Hold temp username and convert to upper to allow any case to be entered for username
            Me.strTempUsername = Me.clnUsername.Item(Me.intLoop)
            If (Me.txtusername.Text.ToUpper = Me.strTempUsername.ToUpper And (Me.txtpassword.Text = Me.clnPassword.Item(Me.intLoop))) Then
                Me.blnLoginInfoFound = True
                Exit For
            End If
        Next

        If (Me.blnLoginInfoFound = True) Then
            Me.Hide()

            If Me.clnEmployeePosition.Item(Me.intLoop) = "Manager" Then
                'Show menu 

                objClsAdministration.Show()

                objClsAdministration.lblemployeename2.Text = Me.clnFirstname.Item(Me.intLoop)


            ElseIf Me.clnEmployeePosition.Item(Me.intLoop) = "Cashier" Then

                ObjClsSalesCashier.Show()


                ObjClsSalesCashier.lblemployeename1.Text = Me.clnFirstname.Item(Me.intLoop)

            ElseIf Me.clnEmployeePosition.Item(Me.intLoop) = "Pharmacist" Then

                ObjClsKnowledgeBase.Show()


                ObjClsKnowledgeBase.lblemployeename3.Text = Me.clnFirstname.Item(Me.intLoop)

            End If

            Me.loginClearFields()

            'objClsAdministration.Show()

        Else
            If Me.intloginCnt = 3 Then
                MessageBox.Show("Please contact the manager to resolve this issue")
                End
            Else
                MessageBox.Show("Invalid Login information")
                Me.intloginCnt += 1
            End If

        End If


    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SelectAllUsers()
    End Sub


    Public Sub loginClearFields()

        Me.txtusername.Text = ""
        Me.txtpassword.Text = ""

    End Sub
End Class