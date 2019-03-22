<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DraftAJP
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
        Me.components = New System.ComponentModel.Container()
        Me.Chrisbarton_grg10DataSet = New Programme_Designer.chrisbarton_grg10DataSet()
        Me.PROGRAMMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROGRAMMETableAdapter = New Programme_Designer.chrisbarton_grg10DataSetTableAdapters.PROGRAMMETableAdapter()
        Me.TableAdapterManager = New Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager()
        Me.tbAJP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROGRAMMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chrisbarton_grg10DataSet
        '
        Me.Chrisbarton_grg10DataSet.DataSetName = "chrisbarton_grg10DataSet"
        Me.Chrisbarton_grg10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROGRAMMEBindingSource
        '
        Me.PROGRAMMEBindingSource.DataMember = "PROGRAMME"
        Me.PROGRAMMEBindingSource.DataSource = Me.Chrisbarton_grg10DataSet
        '
        'PROGRAMMETableAdapter
        '
        Me.PROGRAMMETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALLWALKSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GROUP_CONTACTSTableAdapter = Nothing
        Me.TableAdapterManager.LEADERSTableAdapter = Nothing
        Me.TableAdapterManager.PHOTOALBUMTableAdapter = Nothing
        Me.TableAdapterManager.PROGRAMMETableAdapter = Me.PROGRAMMETableAdapter
        Me.TableAdapterManager.UpdateOrder = Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'tbAJP
        '
        Me.tbAJP.BackColor = System.Drawing.Color.White
        Me.tbAJP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAJP.Location = New System.Drawing.Point(0, 0)
        Me.tbAJP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbAJP.Multiline = True
        Me.tbAJP.Name = "tbAJP"
        Me.tbAJP.ReadOnly = True
        Me.tbAJP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAJP.Size = New System.Drawing.Size(984, 607)
        Me.tbAJP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GLENROTHES GROUP PROGRAMME"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbAJP)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 661)
        Me.SplitContainer1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(717, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "This shows the current programme as it will appear in the AJP (capitalised items " &
    "will be bold in the printed version)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(809, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Copy to Clipboard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DraftAJP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DraftAJP"
        Me.Text = "Draft Area Joint Programme"
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROGRAMMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chrisbarton_grg10DataSet As chrisbarton_grg10DataSet
    Friend WithEvents PROGRAMMEBindingSource As BindingSource
    Friend WithEvents PROGRAMMETableAdapter As chrisbarton_grg10DataSetTableAdapters.PROGRAMMETableAdapter
    Friend WithEvents TableAdapterManager As chrisbarton_grg10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents tbAJP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
