<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addphoto
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
        Me.bGetphoto = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.tbFilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCaption = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lYear = New System.Windows.Forms.Label()
        Me.bUpload = New System.Windows.Forms.Button()
        Me.bClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.Chrisbarton_grg10DataSet = New Programme_Designer.chrisbarton_grg10DataSet()
        Me.PHOTOALBUMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PHOTOALBUMTableAdapter = New Programme_Designer.chrisbarton_grg10DataSetTableAdapters.PHOTOALBUMTableAdapter()
        Me.TableAdapterManager = New Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lWidth = New System.Windows.Forms.Label()
        Me.lHeight = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHOTOALBUMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bGetphoto
        '
        Me.bGetphoto.Location = New System.Drawing.Point(31, 24)
        Me.bGetphoto.Name = "bGetphoto"
        Me.bGetphoto.Size = New System.Drawing.Size(137, 26)
        Me.bGetphoto.TabIndex = 0
        Me.bGetphoto.Text = "Get Photo"
        Me.bGetphoto.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(31, 70)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(137, 26)
        Me.bCancel.TabIndex = 1
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'tbFilename
        '
        Me.tbFilename.Location = New System.Drawing.Point(326, 23)
        Me.tbFilename.Name = "tbFilename"
        Me.tbFilename.ReadOnly = True
        Me.tbFilename.Size = New System.Drawing.Size(412, 27)
        Me.tbFilename.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filename "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Add Caption:"
        '
        'tbCaption
        '
        Me.tbCaption.Location = New System.Drawing.Point(326, 71)
        Me.tbCaption.Name = "tbCaption"
        Me.tbCaption.Size = New System.Drawing.Size(565, 27)
        Me.tbCaption.TabIndex = 4
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(707, 150)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(184, 27)
        Me.dtpDate.TabIndex = 6
        '
        'lYear
        '
        Me.lYear.AutoSize = True
        Me.lYear.Location = New System.Drawing.Point(829, 26)
        Me.lYear.Name = "lYear"
        Me.lYear.Size = New System.Drawing.Size(37, 19)
        Me.lYear.TabIndex = 7
        Me.lYear.Text = "year"
        '
        'bUpload
        '
        Me.bUpload.Location = New System.Drawing.Point(754, 503)
        Me.bUpload.Name = "bUpload"
        Me.bUpload.Size = New System.Drawing.Size(137, 26)
        Me.bUpload.TabIndex = 9
        Me.bUpload.Text = "Upload Photo"
        Me.bUpload.UseVisualStyleBackColor = True
        '
        'bClose
        '
        Me.bClose.Location = New System.Drawing.Point(754, 560)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(137, 26)
        Me.bClose.TabIndex = 10
        Me.bClose.Text = "Finished"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(763, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Gallery"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.photo)
        Me.Panel1.Location = New System.Drawing.Point(1, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 500)
        Me.Panel1.TabIndex = 12
        '
        'photo
        '
        Me.photo.BackColor = System.Drawing.Color.White
        Me.photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.photo.Location = New System.Drawing.Point(3, 0)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(695, 495)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.photo.TabIndex = 9
        Me.photo.TabStop = False
        '
        'Chrisbarton_grg10DataSet
        '
        Me.Chrisbarton_grg10DataSet.DataSetName = "chrisbarton_grg10DataSet"
        Me.Chrisbarton_grg10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PHOTOALBUMBindingSource
        '
        Me.PHOTOALBUMBindingSource.DataMember = "PHOTOALBUM"
        Me.PHOTOALBUMBindingSource.DataSource = Me.Chrisbarton_grg10DataSet
        '
        'PHOTOALBUMTableAdapter
        '
        Me.PHOTOALBUMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALLWALKSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GROUP_CONTACTSTableAdapter = Nothing
        Me.TableAdapterManager.LEADERSTableAdapter = Nothing
        Me.TableAdapterManager.PHOTOALBUMTableAdapter = Me.PHOTOALBUMTableAdapter
        Me.TableAdapterManager.PROGRAMMETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(708, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Set photo date:"
        '
        'lWidth
        '
        Me.lWidth.AutoSize = True
        Me.lWidth.Location = New System.Drawing.Point(708, 220)
        Me.lWidth.Name = "lWidth"
        Me.lWidth.Size = New System.Drawing.Size(111, 19)
        Me.lWidth.TabIndex = 14
        Me.lWidth.Text = "width in pixels: "
        '
        'lHeight
        '
        Me.lHeight.AutoSize = True
        Me.lHeight.Location = New System.Drawing.Point(708, 259)
        Me.lHeight.Name = "lHeight"
        Me.lHeight.Size = New System.Drawing.Size(116, 19)
        Me.lHeight.TabIndex = 15
        Me.lHeight.Text = "height in pixels: "
        '
        'addphoto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(903, 630)
        Me.Controls.Add(Me.lHeight)
        Me.Controls.Add(Me.lWidth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bUpload)
        Me.Controls.Add(Me.lYear)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCaption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbFilename)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bGetphoto)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addphoto"
        Me.Text = "Upload Photo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHOTOALBUMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bGetphoto As System.Windows.Forms.Button
    Friend WithEvents bCancel As System.Windows.Forms.Button
    Friend WithEvents tbFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCaption As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lYear As System.Windows.Forms.Label
    Friend WithEvents bUpload As System.Windows.Forms.Button
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents photo As System.Windows.Forms.PictureBox
    Friend WithEvents Chrisbarton_grg10DataSet As Programme_Designer.chrisbarton_grg10DataSet
    Friend WithEvents PHOTOALBUMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PHOTOALBUMTableAdapter As Programme_Designer.chrisbarton_grg10DataSetTableAdapters.PHOTOALBUMTableAdapter
    Friend WithEvents TableAdapterManager As Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lWidth As System.Windows.Forms.Label
    Friend WithEvents lHeight As System.Windows.Forms.Label
End Class
