<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTPform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FTPform))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.getlocalfolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.scLocal = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbDefault = New System.Windows.Forms.ToolStripButton()
        Me.tsbBrowse = New System.Windows.Forms.ToolStripButton()
        Me.tsbBack = New System.Windows.Forms.ToolStripButton()
        Me.TSBdeletelocal = New System.Windows.Forms.ToolStripButton()
        Me.tsbUpload = New System.Windows.Forms.ToolStripButton()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colFile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.scremote = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tbrHome = New System.Windows.Forms.ToolStripButton()
        Me.tbrBack = New System.Windows.Forms.ToolStripButton()
        Me.tbrDelete = New System.Windows.Forms.ToolStripButton()
        Me.tbrDownload = New System.Windows.Forms.ToolStripButton()
        Me.TSBadddir = New System.Windows.Forms.ToolStripButton()
        Me.TSBrename = New System.Windows.Forms.ToolStripButton()
        Me.txtRemote = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.message = New System.Windows.Forms.TextBox()
        CType(Me.scLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scLocal.Panel1.SuspendLayout()
        Me.scLocal.Panel2.SuspendLayout()
        Me.scLocal.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.scremote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scremote.Panel1.SuspendLayout()
        Me.scremote.Panel2.SuspendLayout()
        Me.scremote.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "page.png")
        Me.ImageList1.Images.SetKeyName(1, "open.png")
        Me.ImageList1.Images.SetKeyName(2, "Web-page.png")
        Me.ImageList1.Images.SetKeyName(3, "doc_pdf.png")
        Me.ImageList1.Images.SetKeyName(4, "script.png")
        Me.ImageList1.Images.SetKeyName(5, "photo.png")
        '
        'getlocalfolder
        '
        Me.getlocalfolder.Description = "Select a Folder to show Files"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.Size = New System.Drawing.Size(797, 470)
        '
        'scLocal
        '
        Me.scLocal.BackColor = System.Drawing.Color.White
        Me.scLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scLocal.Dock = System.Windows.Forms.DockStyle.Left
        Me.scLocal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scLocal.IsSplitterFixed = True
        Me.scLocal.Location = New System.Drawing.Point(0, 0)
        Me.scLocal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.scLocal.Name = "scLocal"
        Me.scLocal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scLocal.Panel1
        '
        Me.scLocal.Panel1.Controls.Add(Me.ToolStrip1)
        Me.scLocal.Panel1.Controls.Add(Me.txtLocal)
        '
        'scLocal.Panel2
        '
        Me.scLocal.Panel2.Controls.Add(Me.ListView1)
        Me.scLocal.Size = New System.Drawing.Size(400, 484)
        Me.scLocal.SplitterDistance = 46
        Me.scLocal.SplitterWidth = 2
        Me.scLocal.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDefault, Me.tsbBrowse, Me.tsbBack, Me.TSBdeletelocal, Me.tsbUpload})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(398, 23)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbDefault
        '
        Me.tsbDefault.Image = CType(resources.GetObject("tsbDefault.Image"), System.Drawing.Image)
        Me.tsbDefault.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDefault.Name = "tsbDefault"
        Me.tsbDefault.Size = New System.Drawing.Size(62, 20)
        Me.tsbDefault.Text = "Home"
        Me.tsbDefault.ToolTipText = "Save this folder as Default"
        '
        'tsbBrowse
        '
        Me.tsbBrowse.Image = CType(resources.GetObject("tsbBrowse.Image"), System.Drawing.Image)
        Me.tsbBrowse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBrowse.Name = "tsbBrowse"
        Me.tsbBrowse.Size = New System.Drawing.Size(71, 20)
        Me.tsbBrowse.Text = "Browse"
        '
        'tsbBack
        '
        Me.tsbBack.Image = CType(resources.GetObject("tsbBack.Image"), System.Drawing.Image)
        Me.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBack.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbBack.Name = "tsbBack"
        Me.tsbBack.Size = New System.Drawing.Size(58, 20)
        Me.tsbBack.Text = "Back"
        '
        'TSBdeletelocal
        '
        Me.TSBdeletelocal.Image = CType(resources.GetObject("TSBdeletelocal.Image"), System.Drawing.Image)
        Me.TSBdeletelocal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBdeletelocal.Name = "TSBdeletelocal"
        Me.TSBdeletelocal.Size = New System.Drawing.Size(47, 20)
        Me.TSBdeletelocal.Text = "Del"
        '
        'tsbUpload
        '
        Me.tsbUpload.Image = CType(resources.GetObject("tsbUpload.Image"), System.Drawing.Image)
        Me.tsbUpload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpload.Name = "tsbUpload"
        Me.tsbUpload.Size = New System.Drawing.Size(68, 20)
        Me.tsbUpload.Text = "Upload"
        '
        'txtLocal
        '
        Me.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLocal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtLocal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocal.Location = New System.Drawing.Point(0, 29)
        Me.txtLocal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.ReadOnly = True
        Me.txtLocal.Size = New System.Drawing.Size(398, 15)
        Me.txtLocal.TabIndex = 5
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFile, Me.colDate})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(398, 434)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colFile
        '
        Me.colFile.Text = "Local Files"
        Me.colFile.Width = 175
        '
        'colDate
        '
        Me.colDate.Text = "Modified Date"
        Me.colDate.Width = 100
        '
        'scremote
        '
        Me.scremote.BackColor = System.Drawing.Color.White
        Me.scremote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scremote.Dock = System.Windows.Forms.DockStyle.Right
        Me.scremote.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scremote.IsSplitterFixed = True
        Me.scremote.Location = New System.Drawing.Point(484, 0)
        Me.scremote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.scremote.Name = "scremote"
        Me.scremote.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scremote.Panel1
        '
        Me.scremote.Panel1.Controls.Add(Me.ToolStrip2)
        Me.scremote.Panel1.Controls.Add(Me.txtRemote)
        '
        'scremote.Panel2
        '
        Me.scremote.Panel2.Controls.Add(Me.ListView2)
        Me.scremote.Size = New System.Drawing.Size(400, 484)
        Me.scremote.SplitterDistance = 46
        Me.scremote.SplitterWidth = 2
        Me.scremote.TabIndex = 8
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrHome, Me.tbrBack, Me.tbrDelete, Me.tbrDownload, Me.TSBadddir, Me.TSBrename})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(398, 23)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tbrHome
        '
        Me.tbrHome.Image = CType(resources.GetObject("tbrHome.Image"), System.Drawing.Image)
        Me.tbrHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrHome.Name = "tbrHome"
        Me.tbrHome.Size = New System.Drawing.Size(62, 20)
        Me.tbrHome.Text = "Home"
        Me.tbrHome.ToolTipText = "Connect to Home folder"
        '
        'tbrBack
        '
        Me.tbrBack.Image = CType(resources.GetObject("tbrBack.Image"), System.Drawing.Image)
        Me.tbrBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrBack.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tbrBack.Name = "tbrBack"
        Me.tbrBack.Size = New System.Drawing.Size(58, 20)
        Me.tbrBack.Text = "Back"
        '
        'tbrDelete
        '
        Me.tbrDelete.Image = CType(resources.GetObject("tbrDelete.Image"), System.Drawing.Image)
        Me.tbrDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrDelete.Name = "tbrDelete"
        Me.tbrDelete.Size = New System.Drawing.Size(47, 20)
        Me.tbrDelete.Text = "Del"
        '
        'tbrDownload
        '
        Me.tbrDownload.Image = CType(resources.GetObject("tbrDownload.Image"), System.Drawing.Image)
        Me.tbrDownload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrDownload.Name = "tbrDownload"
        Me.tbrDownload.Size = New System.Drawing.Size(63, 20)
        Me.tbrDownload.Text = "D'load"
        '
        'TSBadddir
        '
        Me.TSBadddir.Image = CType(resources.GetObject("TSBadddir.Image"), System.Drawing.Image)
        Me.TSBadddir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBadddir.Name = "TSBadddir"
        Me.TSBadddir.Size = New System.Drawing.Size(53, 20)
        Me.TSBadddir.Text = "New"
        '
        'TSBrename
        '
        Me.TSBrename.Image = CType(resources.GetObject("TSBrename.Image"), System.Drawing.Image)
        Me.TSBrename.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBrename.Name = "TSBrename"
        Me.TSBrename.Size = New System.Drawing.Size(76, 20)
        Me.TSBrename.Text = "Rename"
        '
        'txtRemote
        '
        Me.txtRemote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemote.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtRemote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemote.Location = New System.Drawing.Point(0, 29)
        Me.txtRemote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRemote.Name = "txtRemote"
        Me.txtRemote.ReadOnly = True
        Me.txtRemote.Size = New System.Drawing.Size(398, 15)
        Me.txtRemote.TabIndex = 5
        '
        'ListView2
        '
        Me.ListView2.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(398, 434)
        Me.ListView2.SmallImageList = Me.ImageList1
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Remote Files"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Modified Date"
        Me.ColumnHeader2.Width = 100
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(884, 587)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(884, 612)
        Me.ToolStripContainer1.TabIndex = 18
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.scLocal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.scremote)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.message)
        Me.SplitContainer1.Size = New System.Drawing.Size(884, 587)
        Me.SplitContainer1.SplitterDistance = 484
        Me.SplitContainer1.TabIndex = 1
        '
        'message
        '
        Me.message.BackColor = System.Drawing.Color.White
        Me.message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.message.Location = New System.Drawing.Point(0, 0)
        Me.message.Multiline = True
        Me.message.Name = "message"
        Me.message.ReadOnly = True
        Me.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.message.Size = New System.Drawing.Size(884, 99)
        Me.message.TabIndex = 0
        '
        'FTPform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FTPform"
        Me.Text = "File Transfer Utility"
        Me.scLocal.Panel1.ResumeLayout(False)
        Me.scLocal.Panel1.PerformLayout()
        Me.scLocal.Panel2.ResumeLayout(False)
        CType(Me.scLocal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scLocal.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.scremote.Panel1.ResumeLayout(False)
        Me.scremote.Panel1.PerformLayout()
        Me.scremote.Panel2.ResumeLayout(False)
        CType(Me.scremote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scremote.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents getlocalfolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents scLocal As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbDefault As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBrowse As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbUpload As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colFile As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents scremote As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrDownload As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtRemote As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents message As System.Windows.Forms.TextBox
    Friend WithEvents TSBadddir As ToolStripButton
    Friend WithEvents TSBrename As ToolStripButton
    Friend WithEvents TSBdeletelocal As ToolStripButton
End Class
