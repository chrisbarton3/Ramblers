<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preview
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.lAttach = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lHeading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wbBody = New System.Windows.Forms.WebBrowser()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lAttach)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lHeading)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.wbBody)
        Me.SplitContainer2.Size = New System.Drawing.Size(784, 461)
        Me.SplitContainer2.SplitterDistance = 130
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lCount)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bCancel)
        Me.Panel1.Controls.Add(Me.bOK)
        Me.Panel1.Location = New System.Drawing.Point(13, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 45)
        Me.Panel1.TabIndex = 6
        '
        'lCount
        '
        Me.lCount.AutoSize = True
        Me.lCount.Location = New System.Drawing.Point(237, 14)
        Me.lCount.Name = "lCount"
        Me.lCount.Size = New System.Drawing.Size(0, 18)
        Me.lCount.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Check email then click <OK> to send"
        '
        'bCancel
        '
        Me.bCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancel.Location = New System.Drawing.Point(590, 10)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(129, 28)
        Me.bCancel.TabIndex = 5
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOK.Location = New System.Drawing.Point(432, 10)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(129, 28)
        Me.bOK.TabIndex = 4
        Me.bOK.Text = "OK "
        Me.bOK.UseVisualStyleBackColor = True
        '
        'lAttach
        '
        Me.lAttach.AutoSize = True
        Me.lAttach.BackColor = System.Drawing.Color.White
        Me.lAttach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAttach.Location = New System.Drawing.Point(101, 47)
        Me.lAttach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAttach.Name = "lAttach"
        Me.lAttach.Size = New System.Drawing.Size(50, 20)
        Me.lAttach.TabIndex = 3
        Me.lAttach.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Attachment"
        '
        'lHeading
        '
        Me.lHeading.AutoSize = True
        Me.lHeading.BackColor = System.Drawing.Color.White
        Me.lHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lHeading.Location = New System.Drawing.Point(101, 12)
        Me.lHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lHeading.Name = "lHeading"
        Me.lHeading.Size = New System.Drawing.Size(50, 20)
        Me.lHeading.TabIndex = 1
        Me.lHeading.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Heading"
        '
        'wbBody
        '
        Me.wbBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbBody.Location = New System.Drawing.Point(0, 0)
        Me.wbBody.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.wbBody.MinimumSize = New System.Drawing.Size(36, 39)
        Me.wbBody.Name = "wbBody"
        Me.wbBody.Size = New System.Drawing.Size(784, 325)
        Me.wbBody.TabIndex = 0
        '
        'Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Preview"
        Me.Text = "Email Preview"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents bCancel As Button
    Friend WithEvents bOK As Button
    Friend WithEvents lAttach As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents wbBody As WebBrowser
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lCount As Label
End Class
