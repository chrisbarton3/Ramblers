<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StopPress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CDATELabel As System.Windows.Forms.Label
        Dim CDESCRLabel As System.Windows.Forms.Label
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.texttb = New System.Windows.Forms.TextBox()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chrisbarton_grg10DataSet3 = New Programme_Designer.chrisbarton_grg10DataSet3()
        Me.PUBLISHEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PUBLISHEDTableAdapter = New Programme_Designer.chrisbarton_grg10DataSet3TableAdapters.PUBLISHEDTableAdapter()
        Me.TableAdapterManager1 = New Programme_Designer.chrisbarton_grg10DataSet3TableAdapters.TableAdapterManager()
        CDATELabel = New System.Windows.Forms.Label()
        CDESCRLabel = New System.Windows.Forms.Label()
        CType(Me.Chrisbarton_grg10DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CDATELabel
        '
        CDATELabel.AutoSize = True
        CDATELabel.Location = New System.Drawing.Point(19, 109)
        CDATELabel.Name = "CDATELabel"
        CDATELabel.Size = New System.Drawing.Size(113, 18)
        CDATELabel.TabIndex = 0
        CDATELabel.Text = "Select item date:"
        '
        'CDESCRLabel
        '
        CDESCRLabel.AutoSize = True
        CDESCRLabel.Location = New System.Drawing.Point(19, 163)
        CDESCRLabel.Name = "CDESCRLabel"
        CDESCRLabel.Size = New System.Drawing.Size(69, 18)
        CDESCRLabel.TabIndex = 2
        CDESCRLabel.Text = "Item text:"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(138, 103)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 26)
        Me.dtp.TabIndex = 1
        '
        'texttb
        '
        Me.texttb.Location = New System.Drawing.Point(94, 160)
        Me.texttb.Multiline = True
        Me.texttb.Name = "texttb"
        Me.texttb.Size = New System.Drawing.Size(266, 88)
        Me.texttb.TabIndex = 3
        '
        'bSave
        '
        Me.bSave.Location = New System.Drawing.Point(30, 278)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(175, 33)
        Me.bSave.TabIndex = 4
        Me.bSave.Text = "Add item to website"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(267, 278)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(119, 33)
        Me.bCancel.TabIndex = 5
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "This will add a red and black banner item to the top of the Home Page"
        '
        'Chrisbarton_grg10DataSet3
        '
        Me.Chrisbarton_grg10DataSet3.DataSetName = "chrisbarton_grg10DataSet3"
        Me.Chrisbarton_grg10DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUBLISHEDBindingSource
        '
        Me.PUBLISHEDBindingSource.DataMember = "PUBLISHED"
        Me.PUBLISHEDBindingSource.DataSource = Me.Chrisbarton_grg10DataSet3
        '
        'PUBLISHEDTableAdapter
        '
        Me.PUBLISHEDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PUBLISHEDTableAdapter = Me.PUBLISHEDTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Programme_Designer.chrisbarton_grg10DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StopPress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 347)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(CDESCRLabel)
        Me.Controls.Add(Me.texttb)
        Me.Controls.Add(CDATELabel)
        Me.Controls.Add(Me.dtp)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StopPress"
        Me.Text = "StopPress"
        CType(Me.Chrisbarton_grg10DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents texttb As TextBox
    Friend WithEvents bSave As Button
    Friend WithEvents bCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Chrisbarton_grg10DataSet3 As chrisbarton_grg10DataSet3
    Friend WithEvents PUBLISHEDBindingSource As BindingSource
    Friend WithEvents PUBLISHEDTableAdapter As chrisbarton_grg10DataSet3TableAdapters.PUBLISHEDTableAdapter
    Friend WithEvents TableAdapterManager1 As chrisbarton_grg10DataSet3TableAdapters.TableAdapterManager
End Class
