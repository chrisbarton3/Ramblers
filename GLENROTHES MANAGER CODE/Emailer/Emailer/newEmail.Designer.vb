<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newEmail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recipient's Name"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(12, 89)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(330, 26)
        Me.tbName.TabIndex = 1
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(12, 139)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(330, 26)
        Me.tbEmail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Recipient's Email Address"
        '
        'bAdd
        '
        Me.bAdd.Location = New System.Drawing.Point(13, 183)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(106, 30)
        Me.bAdd.TabIndex = 4
        Me.bAdd.Text = "Add to list"
        Me.bAdd.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(218, 183)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(106, 30)
        Me.bCancel.TabIndex = 5
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 38)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Add new address to send list ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will NOT be added to DB Contacts table."
        '
        'newEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 227)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "newEmail"
        Me.Text = "Add New Email Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bAdd As Button
    Friend WithEvents bCancel As Button
    Friend WithEvents Label3 As Label
End Class
