<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class walkfinder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(walkfinder))
        Me.Chrisbarton_grg10DataSet = New LocalGRGmanager.chrisbarton_grg10DataSet()
        Me.TableAdapterManager = New LocalGRGmanager.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager()
        Me.sfdlg = New System.Windows.Forms.SaveFileDialog()
        Me.lCSVlen = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslPeriod = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.PUBLISHEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PUBLISHEDTableAdapter = New LocalGRGmanager.chrisbarton_grg10DataSetTableAdapters.PUBLISHEDTableAdapter()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PUBLISHEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chrisbarton_grg10DataSet
        '
        Me.Chrisbarton_grg10DataSet.DataSetName = "chrisbarton_grg10DataSet"
        Me.Chrisbarton_grg10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AJPwalksTableAdapter = Nothing
        Me.TableAdapterManager.ALLWALKSTableAdapter = Nothing
        Me.TableAdapterManager.ARCHIVED_WALKSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.GROUP_CONTACTSTableAdapter = Nothing
        Me.TableAdapterManager.LEADERSTableAdapter = Nothing
        Me.TableAdapterManager.PHOTOALBUMTableAdapter = Nothing
        Me.TableAdapterManager.PROGRAMMETableAdapter = Nothing
        Me.TableAdapterManager.PUBLISHEDTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LocalGRGmanager.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lCSVlen
        '
        Me.lCSVlen.AutoSize = True
        Me.lCSVlen.Location = New System.Drawing.Point(155, 441)
        Me.lCSVlen.Name = "lCSVlen"
        Me.lCSVlen.Size = New System.Drawing.Size(49, 15)
        Me.lCSVlen.TabIndex = 14
        Me.lCSVlen.Text = "              "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslPeriod})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 637)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1034, 24)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslPeriod
        '
        Me.tslPeriod.Name = "tslPeriod"
        Me.tslPeriod.Size = New System.Drawing.Size(13, 19)
        Me.tslPeriod.Text = " "
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.RichTextBox1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1034, 604)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1034, 637)
        Me.ToolStripContainer1.TabIndex = 17
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(586, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 345)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(580, 604)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = " "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(249, 33)
        Me.ToolStrip1.TabIndex = 0
        '
        'tsbSave
        '
        Me.tsbSave.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(237, 30)
        Me.tsbSave.Text = "Save File as spreadsheet"
        '
        'PUBLISHEDBindingSource
        '
        Me.PUBLISHEDBindingSource.DataMember = "PUBLISHED"
        Me.PUBLISHEDBindingSource.DataSource = Me.Chrisbarton_grg10DataSet
        '
        'PUBLISHEDTableAdapter
        '
        Me.PUBLISHEDTableAdapter.ClearBeforeFill = True
        '
        'walkfinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 661)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lCSVlen)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "walkfinder"
        Me.Text = "Ramblers Walk Finder"
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PUBLISHEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chrisbarton_grg10DataSet As LocalGRGmanager.chrisbarton_grg10DataSet
    Friend WithEvents TableAdapterManager As LocalGRGmanager.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents sfdlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lCSVlen As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslPeriod As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PUBLISHEDBindingSource As BindingSource
    Friend WithEvents PUBLISHEDTableAdapter As chrisbarton_grg10DataSetTableAdapters.PUBLISHEDTableAdapter
End Class
