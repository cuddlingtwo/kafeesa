<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseform))
        Me.ssmessage = New System.Windows.Forms.StatusStrip
        Me.tsplblmessage = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label8 = New System.Windows.Forms.Label
        Me.pbbackground = New System.Windows.Forms.PictureBox
        Me.ssmessage.SuspendLayout()
        CType(Me.pbbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssmessage
        '
        Me.ssmessage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsplblmessage})
        Me.ssmessage.Location = New System.Drawing.Point(0, 672)
        Me.ssmessage.Name = "ssmessage"
        Me.ssmessage.Size = New System.Drawing.Size(1004, 22)
        Me.ssmessage.TabIndex = 31
        Me.ssmessage.Text = "StatusStrip1"
        '
        'tsplblmessage
        '
        Me.tsplblmessage.Name = "tsplblmessage"
        Me.tsplblmessage.Size = New System.Drawing.Size(51, 17)
        Me.tsplblmessage.Text = "Ready...."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(393, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 25)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "KAFEESA PHARMA"
        '
        'pbbackground
        '
        Me.pbbackground.BackgroundImage = Global.Kafeesa_Pharma.My.Resources.Resources.kafeesabg
        Me.pbbackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbbackground.Location = New System.Drawing.Point(0, 0)
        Me.pbbackground.Name = "pbbackground"
        Me.pbbackground.Size = New System.Drawing.Size(1004, 694)
        Me.pbbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbbackground.TabIndex = 56
        Me.pbbackground.TabStop = False
        '
        'frmBaseform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 694)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ssmessage)
        Me.Controls.Add(Me.pbbackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBaseform"
        Me.Text = "Kafeesa Pharmarcy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ssmessage.ResumeLayout(False)
        Me.ssmessage.PerformLayout()
        CType(Me.pbbackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ssmessage As System.Windows.Forms.StatusStrip
    Friend WithEvents tsplblmessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pbbackground As System.Windows.Forms.PictureBox
End Class
