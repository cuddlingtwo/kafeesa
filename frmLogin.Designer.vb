<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

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
        Me.btnexit = New System.Windows.Forms.Button
        Me.lblinstruction2 = New System.Windows.Forms.Label
        Me.lblinstruction1 = New System.Windows.Forms.Label
        Me.lblcopyright = New System.Windows.Forms.Label
        Me.btnlogin = New System.Windows.Forms.Button
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.lblpassword = New System.Windows.Forms.Label
        Me.lblusername = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexit.Location = New System.Drawing.Point(373, 111)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'lblinstruction2
        '
        Me.lblinstruction2.AutoSize = True
        Me.lblinstruction2.Location = New System.Drawing.Point(88, 105)
        Me.lblinstruction2.Name = "lblinstruction2"
        Me.lblinstruction2.Size = New System.Drawing.Size(250, 13)
        Me.lblinstruction2.TabIndex = 16
        Me.lblinstruction2.Text = "See the manager for your Username and Password."
        '
        'lblinstruction1
        '
        Me.lblinstruction1.AutoSize = True
        Me.lblinstruction1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinstruction1.Location = New System.Drawing.Point(66, 8)
        Me.lblinstruction1.Name = "lblinstruction1"
        Me.lblinstruction1.Size = New System.Drawing.Size(311, 16)
        Me.lblinstruction1.TabIndex = 15
        Me.lblinstruction1.Text = "Please Enter Your Username And Password"
        '
        'lblcopyright
        '
        Me.lblcopyright.AutoSize = True
        Me.lblcopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcopyright.Location = New System.Drawing.Point(394, 153)
        Me.lblcopyright.Name = "lblcopyright"
        Me.lblcopyright.Size = New System.Drawing.Size(58, 15)
        Me.lblcopyright.TabIndex = 14
        Me.lblcopyright.Text = "© Insight."
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(373, 79)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 12
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(91, 82)
        Me.txtpassword.MaxLength = 20
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(261, 20)
        Me.txtpassword.TabIndex = 10
        Me.txtpassword.UseSystemPasswordChar = True
        Me.txtpassword.WordWrap = False
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(91, 43)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(261, 20)
        Me.txtusername.TabIndex = 8
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(30, 85)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(59, 13)
        Me.lblpassword.TabIndex = 11
        Me.lblpassword.Text = "Password :"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(27, 46)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(61, 13)
        Me.lblusername.TabIndex = 9
        Me.lblusername.Text = "Username :"
        '
        'frmlogin
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 177)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.lblinstruction2)
        Me.Controls.Add(Me.lblinstruction1)
        Me.Controls.Add(Me.lblcopyright)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insight Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblinstruction2 As System.Windows.Forms.Label
    Friend WithEvents lblinstruction1 As System.Windows.Forms.Label
    Friend WithEvents lblcopyright As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
End Class
