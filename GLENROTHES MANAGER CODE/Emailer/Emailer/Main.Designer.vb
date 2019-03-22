<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.EmailPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.llDelAttached = New System.Windows.Forms.LinkLabel()
        Me.attachFile = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bAttach = New System.Windows.Forms.Button()
        Me.tbHeading = New System.Windows.Forms.TextBox()
        Me.tbRTF = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bShowPreview = New System.Windows.Forms.Button()
        Me.bNewEmail = New System.Windows.Forms.Button()
        Me.bLastEmail = New System.Windows.Forms.Button()
        Me.ll18pt = New System.Windows.Forms.LinkLabel()
        Me.ll14pt = New System.Windows.Forms.LinkLabel()
        Me.bSaveMessage = New System.Windows.Forms.Button()
        Me.ll12pt = New System.Windows.Forms.LinkLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bLink = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bUline = New System.Windows.Forms.Button()
        Me.bItalic = New System.Windows.Forms.Button()
        Me.bBold = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContactsPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ContactsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chrisbarton_grg10DataSet = New Emailer.chrisbarton_grg10DataSet()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SendEmailsList = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbSelectAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSelectNone = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbNewEmailAddr = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDelSendItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbClearSend = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SendPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.lCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bSendOneBatch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bSaveSettings = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbServerAccount = New System.Windows.Forms.TextBox()
        Me.tbFromEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbemailServer = New System.Windows.Forms.TextBox()
        Me.tbFromName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bClearHistory = New System.Windows.Forms.Button()
        Me.tbResults = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContactsTableAdapter = New Emailer.chrisbarton_grg10DataSetTableAdapters.contactsTableAdapter()
        Me.TableAdapterManager = New Emailer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.EmailPage.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContactsPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SendPage.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1084, 674)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1084, 674)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.EmailPage)
        Me.TabControl1.Controls.Add(Me.ContactsPage)
        Me.TabControl1.Controls.Add(Me.SendPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 674)
        Me.TabControl1.TabIndex = 0
        '
        'EmailPage
        '
        Me.EmailPage.Controls.Add(Me.SplitContainer2)
        Me.EmailPage.Location = New System.Drawing.Point(4, 28)
        Me.EmailPage.Name = "EmailPage"
        Me.EmailPage.Padding = New System.Windows.Forms.Padding(3)
        Me.EmailPage.Size = New System.Drawing.Size(1076, 642)
        Me.EmailPage.TabIndex = 1
        Me.EmailPage.Text = "1. Compose Email  >"
        Me.EmailPage.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer2.Panel1.Controls.Add(Me.llDelAttached)
        Me.SplitContainer2.Panel1.Controls.Add(Me.attachFile)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.bAttach)
        Me.SplitContainer2.Panel1.Controls.Add(Me.tbHeading)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.tbRTF)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1070, 636)
        Me.SplitContainer2.SplitterDistance = 85
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 0
        '
        'llDelAttached
        '
        Me.llDelAttached.AutoSize = True
        Me.llDelAttached.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llDelAttached.Location = New System.Drawing.Point(902, 48)
        Me.llDelAttached.Name = "llDelAttached"
        Me.llDelAttached.Size = New System.Drawing.Size(128, 20)
        Me.llDelAttached.TabIndex = 8
        Me.llDelAttached.TabStop = True
        Me.llDelAttached.Text = "Remove attachment"
        Me.llDelAttached.Visible = False
        '
        'attachFile
        '
        Me.attachFile.AutoSize = True
        Me.attachFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attachFile.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attachFile.Location = New System.Drawing.Point(158, 48)
        Me.attachFile.Name = "attachFile"
        Me.attachFile.Size = New System.Drawing.Size(2, 22)
        Me.attachFile.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Heading:"
        '
        'bAttach
        '
        Me.bAttach.BackColor = System.Drawing.Color.White
        Me.bAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAttach.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAttach.Image = CType(resources.GetObject("bAttach.Image"), System.Drawing.Image)
        Me.bAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAttach.Location = New System.Drawing.Point(5, 45)
        Me.bAttach.Name = "bAttach"
        Me.bAttach.Size = New System.Drawing.Size(154, 35)
        Me.bAttach.TabIndex = 6
        Me.bAttach.Text = "Attach File (1 only)"
        Me.bAttach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.bAttach, "Select a file from this PC to attach")
        Me.bAttach.UseVisualStyleBackColor = False
        '
        'tbHeading
        '
        Me.tbHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbHeading.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHeading.Location = New System.Drawing.Point(93, 6)
        Me.tbHeading.Name = "tbHeading"
        Me.tbHeading.Size = New System.Drawing.Size(947, 26)
        Me.tbHeading.TabIndex = 0
        '
        'tbRTF
        '
        Me.tbRTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbRTF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRTF.Location = New System.Drawing.Point(124, 0)
        Me.tbRTF.Name = "tbRTF"
        Me.tbRTF.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.tbRTF.Size = New System.Drawing.Size(946, 550)
        Me.tbRTF.TabIndex = 0
        Me.tbRTF.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.bShowPreview)
        Me.Panel3.Controls.Add(Me.bNewEmail)
        Me.Panel3.Controls.Add(Me.bLastEmail)
        Me.Panel3.Controls.Add(Me.ll18pt)
        Me.Panel3.Controls.Add(Me.ll14pt)
        Me.Panel3.Controls.Add(Me.bSaveMessage)
        Me.Panel3.Controls.Add(Me.ll12pt)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.bLink)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.bUline)
        Me.Panel3.Controls.Add(Me.bItalic)
        Me.Panel3.Controls.Add(Me.bBold)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 550)
        Me.Panel3.TabIndex = 15
        '
        'bShowPreview
        '
        Me.bShowPreview.BackColor = System.Drawing.Color.White
        Me.bShowPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bShowPreview.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bShowPreview.Image = CType(resources.GetObject("bShowPreview.Image"), System.Drawing.Image)
        Me.bShowPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bShowPreview.Location = New System.Drawing.Point(3, 162)
        Me.bShowPreview.Name = "bShowPreview"
        Me.bShowPreview.Size = New System.Drawing.Size(113, 35)
        Me.bShowPreview.TabIndex = 40
        Me.bShowPreview.Text = "Preview"
        Me.bShowPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bShowPreview.UseVisualStyleBackColor = False
        '
        'bNewEmail
        '
        Me.bNewEmail.BackColor = System.Drawing.Color.White
        Me.bNewEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNewEmail.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNewEmail.Image = CType(resources.GetObject("bNewEmail.Image"), System.Drawing.Image)
        Me.bNewEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNewEmail.Location = New System.Drawing.Point(3, 122)
        Me.bNewEmail.Name = "bNewEmail"
        Me.bNewEmail.Size = New System.Drawing.Size(113, 35)
        Me.bNewEmail.TabIndex = 16
        Me.bNewEmail.Text = "New Email"
        Me.bNewEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bNewEmail.UseVisualStyleBackColor = False
        '
        'bLastEmail
        '
        Me.bLastEmail.BackColor = System.Drawing.Color.White
        Me.bLastEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLastEmail.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLastEmail.Image = CType(resources.GetObject("bLastEmail.Image"), System.Drawing.Image)
        Me.bLastEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLastEmail.Location = New System.Drawing.Point(3, 82)
        Me.bLastEmail.Name = "bLastEmail"
        Me.bLastEmail.Size = New System.Drawing.Size(113, 35)
        Me.bLastEmail.TabIndex = 17
        Me.bLastEmail.Text = "Last Email"
        Me.bLastEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bLastEmail.UseVisualStyleBackColor = False
        '
        'll18pt
        '
        Me.ll18pt.AutoSize = True
        Me.ll18pt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll18pt.Location = New System.Drawing.Point(76, 286)
        Me.ll18pt.Name = "ll18pt"
        Me.ll18pt.Size = New System.Drawing.Size(40, 27)
        Me.ll18pt.TabIndex = 39
        Me.ll18pt.TabStop = True
        Me.ll18pt.Text = "aA"
        '
        'll14pt
        '
        Me.ll14pt.AutoSize = True
        Me.ll14pt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll14pt.Location = New System.Drawing.Point(40, 291)
        Me.ll14pt.Name = "ll14pt"
        Me.ll14pt.Size = New System.Drawing.Size(33, 22)
        Me.ll14pt.TabIndex = 38
        Me.ll14pt.TabStop = True
        Me.ll14pt.Text = "aA"
        '
        'bSaveMessage
        '
        Me.bSaveMessage.BackColor = System.Drawing.Color.White
        Me.bSaveMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSaveMessage.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSaveMessage.Image = CType(resources.GetObject("bSaveMessage.Image"), System.Drawing.Image)
        Me.bSaveMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSaveMessage.Location = New System.Drawing.Point(3, 42)
        Me.bSaveMessage.Name = "bSaveMessage"
        Me.bSaveMessage.Size = New System.Drawing.Size(113, 35)
        Me.bSaveMessage.TabIndex = 15
        Me.bSaveMessage.Text = "Save "
        Me.bSaveMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.bSaveMessage, "Save this email to resend")
        Me.bSaveMessage.UseVisualStyleBackColor = False
        '
        'll12pt
        '
        Me.ll12pt.AutoSize = True
        Me.ll12pt.Location = New System.Drawing.Point(9, 295)
        Me.ll12pt.Name = "ll12pt"
        Me.ll12pt.Size = New System.Drawing.Size(29, 19)
        Me.ll12pt.TabIndex = 37
        Me.ll12pt.TabStop = True
        Me.ll12pt.Text = "aA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 223)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 60)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Change " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "document" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "font size:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 436)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 60)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Convert selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text to hyperlink" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(copy URL first)"
        '
        'bLink
        '
        Me.bLink.BackColor = System.Drawing.Color.White
        Me.bLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLink.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLink.ForeColor = System.Drawing.Color.RoyalBlue
        Me.bLink.Location = New System.Drawing.Point(19, 499)
        Me.bLink.Name = "bLink"
        Me.bLink.Size = New System.Drawing.Size(91, 38)
        Me.bLink.TabIndex = 31
        Me.bLink.Text = "Hyperlink"
        Me.ToolTip1.SetToolTip(Me.bLink, "Make a hyperlink from selected text." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add hyperlink address in dialog box.")
        Me.bLink.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 330)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 40)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Format selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text:"
        '
        'bUline
        '
        Me.bUline.BackColor = System.Drawing.Color.White
        Me.bUline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUline.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bUline.Location = New System.Drawing.Point(79, 383)
        Me.bUline.Name = "bUline"
        Me.bUline.Size = New System.Drawing.Size(24, 36)
        Me.bUline.TabIndex = 28
        Me.bUline.Text = "U"
        Me.bUline.UseVisualStyleBackColor = False
        '
        'bItalic
        '
        Me.bItalic.BackColor = System.Drawing.Color.White
        Me.bItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bItalic.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bItalic.Location = New System.Drawing.Point(52, 383)
        Me.bItalic.Name = "bItalic"
        Me.bItalic.Size = New System.Drawing.Size(24, 36)
        Me.bItalic.TabIndex = 27
        Me.bItalic.Text = "I"
        Me.bItalic.UseVisualStyleBackColor = False
        '
        'bBold
        '
        Me.bBold.BackColor = System.Drawing.Color.White
        Me.bBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBold.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBold.Location = New System.Drawing.Point(25, 383)
        Me.bBold.Name = "bBold"
        Me.bBold.Size = New System.Drawing.Size(24, 36)
        Me.bBold.TabIndex = 26
        Me.bBold.Text = "B"
        Me.bBold.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Email body:"
        '
        'ContactsPage
        '
        Me.ContactsPage.Controls.Add(Me.SplitContainer1)
        Me.ContactsPage.Controls.Add(Me.ToolStrip1)
        Me.ContactsPage.Location = New System.Drawing.Point(4, 28)
        Me.ContactsPage.Name = "ContactsPage"
        Me.ContactsPage.Size = New System.Drawing.Size(1076, 642)
        Me.ContactsPage.TabIndex = 2
        Me.ContactsPage.Text = "2. Select Recipients >"
        Me.ContactsPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ContactsDataGridView)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1076, 615)
        Me.SplitContainer1.SplitterDistance = 600
        Me.SplitContainer1.TabIndex = 2
        '
        'ContactsDataGridView
        '
        Me.ContactsDataGridView.AllowUserToAddRows = False
        Me.ContactsDataGridView.AllowUserToDeleteRows = False
        Me.ContactsDataGridView.AutoGenerateColumns = False
        Me.ContactsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ContactsDataGridView.DataSource = Me.ContactsBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ContactsDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.ContactsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ContactsDataGridView.Name = "ContactsDataGridView"
        Me.ContactsDataGridView.ReadOnly = True
        Me.ContactsDataGridView.RowHeadersVisible = False
        Me.ContactsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ContactsDataGridView.Size = New System.Drawing.Size(600, 615)
        Me.ContactsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CONTACT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DB Contacts Table - Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 235
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 340
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "contacts"
        Me.ContactsBindingSource.DataSource = Me.Chrisbarton_grg10DataSet
        '
        'Chrisbarton_grg10DataSet
        '
        Me.Chrisbarton_grg10DataSet.DataSetName = "chrisbarton_grg10DataSet"
        Me.Chrisbarton_grg10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.IsSplitterFixed = True
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SendEmailsList)
        Me.SplitContainer4.Size = New System.Drawing.Size(472, 615)
        Me.SplitContainer4.SplitterDistance = 30
        Me.SplitContainer4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Send to: Emails list"
        '
        'SendEmailsList
        '
        Me.SendEmailsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SendEmailsList.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendEmailsList.FormattingEnabled = True
        Me.SendEmailsList.ItemHeight = 18
        Me.SendEmailsList.Location = New System.Drawing.Point(0, 0)
        Me.SendEmailsList.Name = "SendEmailsList"
        Me.SendEmailsList.ScrollAlwaysVisible = True
        Me.SendEmailsList.Size = New System.Drawing.Size(472, 581)
        Me.SendEmailsList.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSelectAll, Me.ToolStripSeparator1, Me.tsbSelectNone, Me.ToolStripSeparator2, Me.tsbUpdate, Me.ToolStripSeparator5, Me.tsbNewEmailAddr, Me.ToolStripSeparator6, Me.tsbDelSendItem, Me.ToolStripSeparator3, Me.tsbClearSend, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1076, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbSelectAll
        '
        Me.tsbSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSelectAll.Name = "tsbSelectAll"
        Me.tsbSelectAll.Size = New System.Drawing.Size(72, 24)
        Me.tsbSelectAll.Text = "Select All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsbSelectNone
        '
        Me.tsbSelectNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSelectNone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSelectNone.Name = "tsbSelectNone"
        Me.tsbSelectNone.Size = New System.Drawing.Size(87, 24)
        Me.tsbSelectNone.Text = "Select None"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbUpdate
        '
        Me.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpdate.Name = "tsbUpdate"
        Me.tsbUpdate.Size = New System.Drawing.Size(174, 24)
        Me.tsbUpdate.Text = "Add Selected to Send List"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'tsbNewEmailAddr
        '
        Me.tsbNewEmailAddr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNewEmailAddr.Image = CType(resources.GetObject("tsbNewEmailAddr.Image"), System.Drawing.Image)
        Me.tsbNewEmailAddr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNewEmailAddr.Name = "tsbNewEmailAddr"
        Me.tsbNewEmailAddr.Size = New System.Drawing.Size(248, 24)
        Me.tsbNewEmailAddr.Text = "Add a New Email Address to Send list"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'tsbDelSendItem
        '
        Me.tsbDelSendItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbDelSendItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelSendItem.Name = "tsbDelSendItem"
        Me.tsbDelSendItem.Size = New System.Drawing.Size(162, 24)
        Me.tsbDelSendItem.Text = "Delete Selected list Item"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'tsbClearSend
        '
        Me.tsbClearSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClearSend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClearSend.Name = "tsbClearSend"
        Me.tsbClearSend.Size = New System.Drawing.Size(108, 24)
        Me.tsbClearSend.Text = "Clear Send List"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'SendPage
        '
        Me.SendPage.Controls.Add(Me.SplitContainer3)
        Me.SendPage.Location = New System.Drawing.Point(4, 28)
        Me.SendPage.Name = "SendPage"
        Me.SendPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SendPage.Size = New System.Drawing.Size(1076, 642)
        Me.SendPage.TabIndex = 0
        Me.SendPage.Text = "3. Send Emails"
        Me.SendPage.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer3.Panel1.Controls.Add(Me.lCount)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.bSendOneBatch)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer3.Size = New System.Drawing.Size(1070, 636)
        Me.SplitContainer3.SplitterDistance = 450
        Me.SplitContainer3.TabIndex = 19
        '
        'lCount
        '
        Me.lCount.AutoSize = True
        Me.lCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCount.Location = New System.Drawing.Point(12, 396)
        Me.lCount.Name = "lCount"
        Me.lCount.Size = New System.Drawing.Size(0, 18)
        Me.lCount.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(358, 38)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current email will be saved when program closes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'bSendOneBatch
        '
        Me.bSendOneBatch.BackColor = System.Drawing.Color.LightBlue
        Me.bSendOneBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSendOneBatch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSendOneBatch.Image = CType(resources.GetObject("bSendOneBatch.Image"), System.Drawing.Image)
        Me.bSendOneBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSendOneBatch.Location = New System.Drawing.Point(10, 297)
        Me.bSendOneBatch.Name = "bSendOneBatch"
        Me.bSendOneBatch.Size = New System.Drawing.Size(314, 63)
        Me.bSendOneBatch.TabIndex = 20
        Me.bSendOneBatch.Text = "Preview and Send Email(s)"
        Me.bSendOneBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.bSendOneBatch, "Send email to all recipients in send list, 25 at a time")
        Me.bSendOneBatch.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bSaveSettings)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tbServerAccount)
        Me.Panel1.Controls.Add(Me.tbFromEmail)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tbemailServer)
        Me.Panel1.Controls.Add(Me.tbFromName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tbPassword)
        Me.Panel1.Location = New System.Drawing.Point(6, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 250)
        Me.Panel1.TabIndex = 19
        '
        'bSaveSettings
        '
        Me.bSaveSettings.BackColor = System.Drawing.Color.PaleGreen
        Me.bSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSaveSettings.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSaveSettings.Image = CType(resources.GetObject("bSaveSettings.Image"), System.Drawing.Image)
        Me.bSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSaveSettings.Location = New System.Drawing.Point(278, 203)
        Me.bSaveSettings.Name = "bSaveSettings"
        Me.bSaveSettings.Size = New System.Drawing.Size(136, 36)
        Me.bSaveSettings.TabIndex = 11
        Me.bSaveSettings.Text = "Save Changes"
        Me.bSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bSaveSettings.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Email Sending Parameters"
        '
        'tbServerAccount
        '
        Me.tbServerAccount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbServerAccount.Location = New System.Drawing.Point(141, 75)
        Me.tbServerAccount.Name = "tbServerAccount"
        Me.tbServerAccount.Size = New System.Drawing.Size(273, 26)
        Me.tbServerAccount.TabIndex = 3
        '
        'tbFromEmail
        '
        Me.tbFromEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFromEmail.Location = New System.Drawing.Point(141, 171)
        Me.tbFromEmail.Name = "tbFromEmail"
        Me.tbFromEmail.Size = New System.Drawing.Size(273, 26)
        Me.tbFromEmail.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Email server"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Sent from email"
        '
        'tbemailServer
        '
        Me.tbemailServer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbemailServer.Location = New System.Drawing.Point(141, 43)
        Me.tbemailServer.Name = "tbemailServer"
        Me.tbemailServer.Size = New System.Drawing.Size(273, 26)
        Me.tbemailServer.TabIndex = 1
        '
        'tbFromName
        '
        Me.tbFromName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFromName.Location = New System.Drawing.Point(141, 139)
        Me.tbFromName.Name = "tbFromName"
        Me.tbFromName.Size = New System.Drawing.Size(273, 26)
        Me.tbFromName.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Email account"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Sent from name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Account password"
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(141, 107)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(273, 26)
        Me.tbPassword.TabIndex = 5
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.IsSplitterFixed = True
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer5.Panel1.Controls.Add(Me.bClearHistory)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.tbResults)
        Me.SplitContainer5.Size = New System.Drawing.Size(616, 636)
        Me.SplitContainer5.SplitterDistance = 35
        Me.SplitContainer5.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Results:"
        '
        'bClearHistory
        '
        Me.bClearHistory.BackColor = System.Drawing.Color.AliceBlue
        Me.bClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClearHistory.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClearHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bClearHistory.Location = New System.Drawing.Point(141, 5)
        Me.bClearHistory.Name = "bClearHistory"
        Me.bClearHistory.Size = New System.Drawing.Size(92, 28)
        Me.bClearHistory.TabIndex = 20
        Me.bClearHistory.Text = " Clear History"
        Me.bClearHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bClearHistory.UseVisualStyleBackColor = False
        '
        'tbResults
        '
        Me.tbResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbResults.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResults.Location = New System.Drawing.Point(0, 0)
        Me.tbResults.Multiline = True
        Me.tbResults.Name = "tbResults"
        Me.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbResults.Size = New System.Drawing.Size(616, 597)
        Me.tbResults.TabIndex = 19
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.contactsTableAdapter = Me.ContactsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Emailer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1084, 674)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Email Manager"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.EmailPage.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ContactsPage.ResumeLayout(False)
        Me.ContactsPage.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SendPage.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.Panel2.PerformLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Chrisbarton_grg10DataSet As chrisbarton_grg10DataSet
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As chrisbarton_grg10DataSetTableAdapters.contactsTableAdapter
    Friend WithEvents TableAdapterManager As chrisbarton_grg10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents EmailPage As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents llDelAttached As LinkLabel
    Friend WithEvents attachFile As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bAttach As Button
    Friend WithEvents tbHeading As TextBox
    Friend WithEvents bLastEmail As Button
    Friend WithEvents bNewEmail As Button
    Friend WithEvents bSaveMessage As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ll18pt As LinkLabel
    Friend WithEvents ll14pt As LinkLabel
    Friend WithEvents ll12pt As LinkLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents bLink As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents bUline As Button
    Friend WithEvents bItalic As Button
    Friend WithEvents bBold As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbRTF As RichTextBox
    Friend WithEvents ContactsPage As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ContactsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents SendEmailsList As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbSelectAll As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSelectNone As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbUpdate As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbNewEmailAddr As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbDelSendItem As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbClearSend As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SendPage As TabPage
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label5 As Label
    Friend WithEvents cbVirtualmode As CheckBox
    Friend WithEvents bSendOneBatch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bSaveSettings As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents tbServerAccount As TextBox
    Friend WithEvents tbFromEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbemailServer As TextBox
    Friend WithEvents tbFromName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents bClearHistory As Button
    Friend WithEvents tbResults As TextBox
    Friend WithEvents lCount As Label
    Friend WithEvents bShowPreview As Button
End Class
