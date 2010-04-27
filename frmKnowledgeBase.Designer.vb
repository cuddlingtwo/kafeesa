<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnowledgeBase
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
        Me.lblemployeename3 = New System.Windows.Forms.Label
        Me.lbluseradmin = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblemployeename3
        '
        Me.lblemployeename3.AutoSize = True
        Me.lblemployeename3.Location = New System.Drawing.Point(803, 61)
        Me.lblemployeename3.Name = "lblemployeename3"
        Me.lblemployeename3.Size = New System.Drawing.Size(102, 13)
        Me.lblemployeename3.TabIndex = 65
        Me.lblemployeename3.Text = "Cashier's name here"
        '
        'lbluseradmin
        '
        Me.lbluseradmin.AutoSize = True
        Me.lbluseradmin.Location = New System.Drawing.Point(764, 60)
        Me.lbluseradmin.Name = "lbluseradmin"
        Me.lbluseradmin.Size = New System.Drawing.Size(35, 13)
        Me.lbluseradmin.TabIndex = 64
        Me.lbluseradmin.Text = "User :"
        '
        'KnowledgeBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 694)
        Me.Controls.Add(Me.lblemployeename3)
        Me.Controls.Add(Me.lbluseradmin)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "KnowledgeBase"
        Me.Text = "KnowledgeBase"
        Me.Controls.SetChildIndex(Me.lbluseradmin, 0)
        Me.Controls.SetChildIndex(Me.lblemployeename3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblemployeename3 As System.Windows.Forms.Label
    Friend WithEvents lbluseradmin As System.Windows.Forms.Label
End Class
