Imports System.Data.SqlClient
Imports System.IO

Module modd

    'Declare sql objects
    Public connString As New SqlConnection("Data Source=EAGLEI1;Initial Catalog=KAFEESA;Integrated Security=True")

    Public commObject As New SqlCommand

    Public dAdapter As New SqlDataAdapter
    Public dReader As SqlDataReader
    Public dSet As DataSet

    Public blnErrorsFromForm As Boolean = False
    Private strErrors As String = ""

    'Declare variables
    Public m_intSupplyID As Integer
    Public m_strItemSerialNumber As String
    Public m_strItemName As String
    Public m_strEmployeeID As String
    Public m_strCustomerID As String
    Public m_strSupplierID As String
    Public m_strSearchType As String
    Public m_strTempADDREMOVE As String
    Public m_strTempADDREMOVEUnitCostPrice As String

    Public m_strEmployeeIDMain As String

    Public Function ConvertToSentenceCase(ByVal strField As String) As String

        If strField <> "" Then
            'Convert to sentence case
            strField = strField.Substring(0, 1).ToUpper() & strField.Substring(1, strField.Length - 1)
        End If

        Return strField

    End Function

    Public Function CheckEmail(ByVal strEmailAddress As System.Windows.Forms.TextBox) As Boolean
        'set to false to indicate email is invalid
        Dim blnValidEmailAt As Boolean = False
        Dim blnValidEmailDot As Boolean = False
        'set to true to proceed 
        Dim blnValidEmail As Boolean = True
        Dim intLoop As Integer



        For intLoop = 0 To strEmailAddress.Text.Length - 1
            If strEmailAddress.Text <> "" Then
                If strEmailAddress.Text.Substring(intLoop, 1) = "@" Then
                    blnValidEmailAt = True
                End If
            End If
            If strEmailAddress.Text <> "" Then
                If strEmailAddress.Text.Substring(intLoop, 1) = "." Then
                    blnValidEmailDot = True
                End If
            End If
        Next

        If blnValidEmailAt = False Then
            'MessageBox.Show("A valid email must contain the '@' symbol")
            blnValidEmail = False
            strEmailAddress.Focus()
        End If
        If blnValidEmailDot = False Then
            ' MessageBox.Show("A valid email must contain the dot(.) symbol.")
            blnValidEmail = False
            strEmailAddress.Focus()

        End If

        Return blnValidEmail
    End Function


    Public Function GetNetworkPhotoPath(ByVal ofdPhoto As System.Windows.Forms.OpenFileDialog) As String
        Dim strPhotoPath As String = ""
        Dim cnt As Integer = ofdPhoto.FileName.Length

        While (cnt > 0)

            If ofdPhoto.FileName.Substring(cnt - 1, 1) = "\" Then

                strPhotoPath = ofdPhoto.FileName.Substring(cnt, ofdPhoto.FileName.Length - cnt)

                Exit While
            End If
            cnt -= 1

        End While

        'path name assigned or put in the global level variable 
        strPhotoPath = strPhotoPath

        Return strPhotoPath
    End Function


    Public Function ValidateSpecialCharacters(ByVal strStringValue As String) As Boolean

        Dim blnAcceptedCharacter As Boolean = True
        Dim intString As Integer
        Dim intAcceptedCharacters As Integer

        Dim UnAcceptedCharacters() As String = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", _
                                    "_", "=", "+", "\", "|", "]", "[", "{", "}", "/", _
                                    "?", ",", "<", ">", "`", "~", """", ";", ":"}

        For intAcceptedCharacters = 0 To UnAcceptedCharacters.Length - 1
            For intString = 0 To strStringValue.Length - 1
                If strStringValue.Substring(intString, 1) = UnAcceptedCharacters(intAcceptedCharacters) Then
                    blnAcceptedCharacter = False
                    'MessageBox.Show("A valid name cannot contain special characters" & vbCrLf & "Eg: ?, @, /, $, (, {")
                    Exit For
                End If

            Next
        Next

        Return blnAcceptedCharacter
    End Function

    Public Function ValidateNumericCharacter(ByVal strStringValue As String) As Boolean

        Dim intStringValue As Integer
        Dim blnNonNumericCharacter As Boolean = True

        For intStringValue = 0 To strStringValue.Length - 1
            If IsNumeric(strStringValue.Substring(intStringValue, 1)) Then
                blnNonNumericCharacter = False
                'MessageBox.Show("A name cannot contain numeric charatecters")
                Exit For
            End If
        Next

        Return blnNonNumericCharacter

    End Function

    Public Function ConvertPhotoToSql(ByVal filePath As String) As Byte()

        Dim stream As FileStream = New FileStream( _
           filePath, FileMode.Open, FileAccess.Read)

        Dim reader As BinaryReader = New BinaryReader(stream)

        Dim photo() As Byte = reader.ReadBytes(stream.Length)

        reader.Close()
        stream.Close()

        Return photo
    End Function

End Module

