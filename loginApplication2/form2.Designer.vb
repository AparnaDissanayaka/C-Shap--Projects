<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm
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
        Me.btncheckaccount = New System.Windows.Forms.Button()
        Me.btnwithrow = New System.Windows.Forms.Button()
        Me.btndeposite = New System.Windows.Forms.Button()
        Me.btnCheckLoanAccount = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnCloseLoan = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnCloseAccount = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncheckaccount
        '
        Me.btncheckaccount.Location = New System.Drawing.Point(12, 24)
        Me.btncheckaccount.Name = "btncheckaccount"
        Me.btncheckaccount.Size = New System.Drawing.Size(113, 60)
        Me.btncheckaccount.TabIndex = 1
        Me.btncheckaccount.Text = "Check Accounts"
        Me.btncheckaccount.UseVisualStyleBackColor = True
        '
        'btnwithrow
        '
        Me.btnwithrow.Location = New System.Drawing.Point(150, 24)
        Me.btnwithrow.Name = "btnwithrow"
        Me.btnwithrow.Size = New System.Drawing.Size(106, 60)
        Me.btnwithrow.TabIndex = 2
        Me.btnwithrow.Text = "Withrow"
        Me.btnwithrow.UseVisualStyleBackColor = True
        '
        'btndeposite
        '
        Me.btndeposite.Location = New System.Drawing.Point(275, 24)
        Me.btndeposite.Name = "btndeposite"
        Me.btndeposite.Size = New System.Drawing.Size(106, 60)
        Me.btndeposite.TabIndex = 3
        Me.btndeposite.Text = "Deposite"
        Me.btndeposite.UseVisualStyleBackColor = True
        '
        'btnCheckLoanAccount
        '
        Me.btnCheckLoanAccount.Location = New System.Drawing.Point(12, 108)
        Me.btnCheckLoanAccount.Name = "btnCheckLoanAccount"
        Me.btnCheckLoanAccount.Size = New System.Drawing.Size(113, 69)
        Me.btnCheckLoanAccount.TabIndex = 4
        Me.btnCheckLoanAccount.Text = "Check Loan Accounts"
        Me.btnCheckLoanAccount.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.Location = New System.Drawing.Point(150, 108)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(106, 69)
        Me.btnLoan.TabIndex = 5
        Me.btnLoan.Text = "Loan"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnCloseLoan
        '
        Me.btnCloseLoan.Location = New System.Drawing.Point(275, 108)
        Me.btnCloseLoan.Name = "btnCloseLoan"
        Me.btnCloseLoan.Size = New System.Drawing.Size(106, 69)
        Me.btnCloseLoan.TabIndex = 6
        Me.btnCloseLoan.Text = "Close Loan"
        Me.btnCloseLoan.UseVisualStyleBackColor = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(12, 205)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(113, 64)
        Me.btnCreateAccount.TabIndex = 7
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnCloseAccount
        '
        Me.btnCloseAccount.Location = New System.Drawing.Point(150, 205)
        Me.btnCloseAccount.Name = "btnCloseAccount"
        Me.btnCloseAccount.Size = New System.Drawing.Size(106, 64)
        Me.btnCloseAccount.TabIndex = 8
        Me.btnCloseAccount.Text = "Close Account"
        Me.btnCloseAccount.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(275, 205)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(106, 64)
        Me.Button9.TabIndex = 9
        Me.Button9.UseVisualStyleBackColor = True
        '
        'fm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(420, 332)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.btnCloseAccount)
        Me.Controls.Add(Me.btnCloseLoan)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.btndeposite)
        Me.Controls.Add(Me.btnCheckLoanAccount)
        Me.Controls.Add(Me.btnwithrow)
        Me.Controls.Add(Me.btncheckaccount)
        Me.Name = "fm"
        Me.Text = "Welcome to the XXXX bank"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncheckaccount As System.Windows.Forms.Button
    Friend WithEvents btnwithrow As System.Windows.Forms.Button
    Friend WithEvents btndeposite As System.Windows.Forms.Button
    Friend WithEvents btnCheckLoanAccount As System.Windows.Forms.Button
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents btnCloseLoan As System.Windows.Forms.Button
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents btnCloseAccount As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
