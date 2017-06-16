<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkAccount
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ByAccountNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsingNICToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByAccountNumberToolStripMenuItem, Me.UsingNICToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ByAccountNumberToolStripMenuItem
        '
        Me.ByAccountNumberToolStripMenuItem.Name = "ByAccountNumberToolStripMenuItem"
        Me.ByAccountNumberToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.ByAccountNumberToolStripMenuItem.Text = "Using Account Number"
        '
        'UsingNICToolStripMenuItem
        '
        Me.UsingNICToolStripMenuItem.Name = "UsingNICToolStripMenuItem"
        Me.UsingNICToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.UsingNICToolStripMenuItem.Text = "Using NIC"
        '
        'checkAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "checkAccount"
        Me.Text = "Check Account"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ByAccountNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsingNICToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
