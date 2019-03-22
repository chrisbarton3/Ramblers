<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim CONTACTLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim _01_Membership_NumberLabel As System.Windows.Forms.Label
        Dim _06_Joint_WithLabel As System.Windows.Forms.Label
        Dim _07_TitleLabel As System.Windows.Forms.Label
        Dim _08_InitialsLabel As System.Windows.Forms.Label
        Dim _09_ForenamesLabel As System.Windows.Forms.Label
        Dim _10_SurnameLabel As System.Windows.Forms.Label
        Dim _11_Address1Label As System.Windows.Forms.Label
        Dim _12_Address2Label As System.Windows.Forms.Label
        Dim _13_Address3Label As System.Windows.Forms.Label
        Dim _14_TownLabel As System.Windows.Forms.Label
        Dim _16_PostcodeLabel As System.Windows.Forms.Label
        Dim _18_Email_AddressLabel As System.Windows.Forms.Label
        Dim _19_LandlineLabel As System.Windows.Forms.Label
        Dim _20_MobileLabel As System.Windows.Forms.Label
        Dim _28_Email_Direct_MarketingLabel As System.Windows.Forms.Label
        Dim _30_Post_Direct_MarketingLabel As System.Windows.Forms.Label
        Dim _22_Ramblers_Join_DateLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.EmailsPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Bcomposeemail = New System.Windows.Forms.Button()
        Me.LLaddnewemail = New System.Windows.Forms.LinkLabel()
        Me.LLdeleteemail = New System.Windows.Forms.LinkLabel()
        Me.UnusedEmailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnusedEmailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembershipDataSet = New MembershipManager.membershipDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OrphanedEmailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrphanedEmailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.LocalEmailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SURNAMETextBox = New System.Windows.Forms.TextBox()
        Me.CONTACTTextBox = New System.Windows.Forms.TextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.LocalEmailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullListPage = New System.Windows.Forms.TabPage()
        Me.Full_ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Full_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailsPage = New System.Windows.Forms.TabPage()
        Me._22_Ramblers_Join_DateTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblJoint = New System.Windows.Forms.Label()
        Me._01_Membership_NumberTextBox = New System.Windows.Forms.TextBox()
        Me._06_Joint_WithTextBox = New System.Windows.Forms.TextBox()
        Me._07_TitleTextBox = New System.Windows.Forms.TextBox()
        Me._08_InitialsTextBox = New System.Windows.Forms.TextBox()
        Me._09_ForenamesTextBox = New System.Windows.Forms.TextBox()
        Me._10_SurnameTextBox = New System.Windows.Forms.TextBox()
        Me._11_Address1TextBox = New System.Windows.Forms.TextBox()
        Me._12_Address2TextBox = New System.Windows.Forms.TextBox()
        Me._13_Address3TextBox = New System.Windows.Forms.TextBox()
        Me._14_TownTextBox = New System.Windows.Forms.TextBox()
        Me._16_PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me._18_Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me._19_LandlineTextBox = New System.Windows.Forms.TextBox()
        Me._20_MobileTextBox = New System.Windows.Forms.TextBox()
        Me._28_Email_Direct_MarketingTextBox = New System.Windows.Forms.TextBox()
        Me._30_Post_Direct_MarketingTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.HouseholdsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseholdsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalPostalPage = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.LocalPostalListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalPostalListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBreload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBmakepostal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBsaveall = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBmemberlist = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBarchivexls = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBarchivepdf = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.PostalListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Full_ListTableAdapter = New MembershipManager.membershipDataSetTableAdapters.Full_ListTableAdapter()
        Me.TableAdapterManager = New MembershipManager.membershipDataSetTableAdapters.TableAdapterManager()
        Me.LocalEmailsTableAdapter = New MembershipManager.membershipDataSetTableAdapters.LocalEmailsTableAdapter()
        Me.LocalPostalListTableAdapter = New MembershipManager.membershipDataSetTableAdapters.LocalPostalListTableAdapter()
        Me.PostalListTableAdapter = New MembershipManager.membershipDataSetTableAdapters.PostalListTableAdapter()
        Me.OrphanedEmailsTableAdapter = New MembershipManager.membershipDataSetTableAdapters.OrphanedEmailsTableAdapter()
        Me.UnusedEmailsTableAdapter = New MembershipManager.membershipDataSetTableAdapters.UnusedEmailsTableAdapter()
        Me.HouseholdsTableAdapter = New MembershipManager.membershipDataSetTableAdapters.HouseholdsTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        CONTACTLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        _01_Membership_NumberLabel = New System.Windows.Forms.Label()
        _06_Joint_WithLabel = New System.Windows.Forms.Label()
        _07_TitleLabel = New System.Windows.Forms.Label()
        _08_InitialsLabel = New System.Windows.Forms.Label()
        _09_ForenamesLabel = New System.Windows.Forms.Label()
        _10_SurnameLabel = New System.Windows.Forms.Label()
        _11_Address1Label = New System.Windows.Forms.Label()
        _12_Address2Label = New System.Windows.Forms.Label()
        _13_Address3Label = New System.Windows.Forms.Label()
        _14_TownLabel = New System.Windows.Forms.Label()
        _16_PostcodeLabel = New System.Windows.Forms.Label()
        _18_Email_AddressLabel = New System.Windows.Forms.Label()
        _19_LandlineLabel = New System.Windows.Forms.Label()
        _20_MobileLabel = New System.Windows.Forms.Label()
        _28_Email_Direct_MarketingLabel = New System.Windows.Forms.Label()
        _30_Post_Direct_MarketingLabel = New System.Windows.Forms.Label()
        _22_Ramblers_Join_DateLabel = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.EmailsPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UnusedEmailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnusedEmailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembershipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrphanedEmailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrphanedEmailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.LocalEmailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalEmailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FullListPage.SuspendLayout()
        CType(Me.Full_ListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Full_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsPage.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.HouseholdsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseholdsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LocalPostalPage.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.LocalPostalListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalPostalListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PostalListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(5, 38)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 19)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'CONTACTLabel
        '
        CONTACTLabel.AutoSize = True
        CONTACTLabel.Location = New System.Drawing.Point(5, 73)
        CONTACTLabel.Name = "CONTACTLabel"
        CONTACTLabel.Size = New System.Drawing.Size(75, 19)
        CONTACTLabel.TabIndex = 4
        CONTACTLabel.Text = "CONTACT:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(4, 106)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(54, 19)
        EMAILLabel.TabIndex = 6
        EMAILLabel.Text = "EMAIL:"
        '
        '_01_Membership_NumberLabel
        '
        _01_Membership_NumberLabel.AutoSize = True
        _01_Membership_NumberLabel.Location = New System.Drawing.Point(24, 43)
        _01_Membership_NumberLabel.Name = "_01_Membership_NumberLabel"
        _01_Membership_NumberLabel.Size = New System.Drawing.Size(169, 19)
        _01_Membership_NumberLabel.TabIndex = 2
        _01_Membership_NumberLabel.Text = "01 Membership Number:"
        '
        '_06_Joint_WithLabel
        '
        _06_Joint_WithLabel.AutoSize = True
        _06_Joint_WithLabel.Location = New System.Drawing.Point(24, 78)
        _06_Joint_WithLabel.Name = "_06_Joint_WithLabel"
        _06_Joint_WithLabel.Size = New System.Drawing.Size(98, 19)
        _06_Joint_WithLabel.TabIndex = 10
        _06_Joint_WithLabel.Text = "06 Joint With:"
        '
        '_07_TitleLabel
        '
        _07_TitleLabel.AutoSize = True
        _07_TitleLabel.Location = New System.Drawing.Point(24, 113)
        _07_TitleLabel.Name = "_07_TitleLabel"
        _07_TitleLabel.Size = New System.Drawing.Size(62, 19)
        _07_TitleLabel.TabIndex = 12
        _07_TitleLabel.Text = "07 Title:"
        '
        '_08_InitialsLabel
        '
        _08_InitialsLabel.AutoSize = True
        _08_InitialsLabel.Location = New System.Drawing.Point(24, 148)
        _08_InitialsLabel.Name = "_08_InitialsLabel"
        _08_InitialsLabel.Size = New System.Drawing.Size(77, 19)
        _08_InitialsLabel.TabIndex = 14
        _08_InitialsLabel.Text = "08 Initials:"
        '
        '_09_ForenamesLabel
        '
        _09_ForenamesLabel.AutoSize = True
        _09_ForenamesLabel.Location = New System.Drawing.Point(24, 183)
        _09_ForenamesLabel.Name = "_09_ForenamesLabel"
        _09_ForenamesLabel.Size = New System.Drawing.Size(104, 19)
        _09_ForenamesLabel.TabIndex = 16
        _09_ForenamesLabel.Text = "09 Forenames:"
        '
        '_10_SurnameLabel
        '
        _10_SurnameLabel.AutoSize = True
        _10_SurnameLabel.Location = New System.Drawing.Point(24, 218)
        _10_SurnameLabel.Name = "_10_SurnameLabel"
        _10_SurnameLabel.Size = New System.Drawing.Size(89, 19)
        _10_SurnameLabel.TabIndex = 18
        _10_SurnameLabel.Text = "10 Surname:"
        '
        '_11_Address1Label
        '
        _11_Address1Label.AutoSize = True
        _11_Address1Label.Location = New System.Drawing.Point(24, 253)
        _11_Address1Label.Name = "_11_Address1Label"
        _11_Address1Label.Size = New System.Drawing.Size(93, 19)
        _11_Address1Label.TabIndex = 20
        _11_Address1Label.Text = "11 Address1:"
        '
        '_12_Address2Label
        '
        _12_Address2Label.AutoSize = True
        _12_Address2Label.Location = New System.Drawing.Point(24, 288)
        _12_Address2Label.Name = "_12_Address2Label"
        _12_Address2Label.Size = New System.Drawing.Size(93, 19)
        _12_Address2Label.TabIndex = 22
        _12_Address2Label.Text = "12 Address2:"
        '
        '_13_Address3Label
        '
        _13_Address3Label.AutoSize = True
        _13_Address3Label.Location = New System.Drawing.Point(24, 323)
        _13_Address3Label.Name = "_13_Address3Label"
        _13_Address3Label.Size = New System.Drawing.Size(93, 19)
        _13_Address3Label.TabIndex = 24
        _13_Address3Label.Text = "13 Address3:"
        '
        '_14_TownLabel
        '
        _14_TownLabel.AutoSize = True
        _14_TownLabel.Location = New System.Drawing.Point(24, 358)
        _14_TownLabel.Name = "_14_TownLabel"
        _14_TownLabel.Size = New System.Drawing.Size(67, 19)
        _14_TownLabel.TabIndex = 26
        _14_TownLabel.Text = "14 Town:"
        '
        '_16_PostcodeLabel
        '
        _16_PostcodeLabel.AutoSize = True
        _16_PostcodeLabel.Location = New System.Drawing.Point(24, 393)
        _16_PostcodeLabel.Name = "_16_PostcodeLabel"
        _16_PostcodeLabel.Size = New System.Drawing.Size(92, 19)
        _16_PostcodeLabel.TabIndex = 30
        _16_PostcodeLabel.Text = "16 Postcode:"
        '
        '_18_Email_AddressLabel
        '
        _18_Email_AddressLabel.AutoSize = True
        _18_Email_AddressLabel.Location = New System.Drawing.Point(24, 428)
        _18_Email_AddressLabel.Name = "_18_Email_AddressLabel"
        _18_Email_AddressLabel.Size = New System.Drawing.Size(125, 19)
        _18_Email_AddressLabel.TabIndex = 34
        _18_Email_AddressLabel.Text = "18 Email Address:"
        '
        '_19_LandlineLabel
        '
        _19_LandlineLabel.AutoSize = True
        _19_LandlineLabel.Location = New System.Drawing.Point(24, 463)
        _19_LandlineLabel.Name = "_19_LandlineLabel"
        _19_LandlineLabel.Size = New System.Drawing.Size(88, 19)
        _19_LandlineLabel.TabIndex = 36
        _19_LandlineLabel.Text = "19 Landline:"
        '
        '_20_MobileLabel
        '
        _20_MobileLabel.AutoSize = True
        _20_MobileLabel.Location = New System.Drawing.Point(450, 463)
        _20_MobileLabel.Name = "_20_MobileLabel"
        _20_MobileLabel.Size = New System.Drawing.Size(78, 19)
        _20_MobileLabel.TabIndex = 38
        _20_MobileLabel.Text = "20 Mobile:"
        '
        '_28_Email_Direct_MarketingLabel
        '
        _28_Email_Direct_MarketingLabel.AutoSize = True
        _28_Email_Direct_MarketingLabel.Location = New System.Drawing.Point(504, 40)
        _28_Email_Direct_MarketingLabel.Name = "_28_Email_Direct_MarketingLabel"
        _28_Email_Direct_MarketingLabel.Size = New System.Drawing.Size(181, 19)
        _28_Email_Direct_MarketingLabel.TabIndex = 46
        _28_Email_Direct_MarketingLabel.Text = "28 Email Direct Marketing:"
        '
        '_30_Post_Direct_MarketingLabel
        '
        _30_Post_Direct_MarketingLabel.AutoSize = True
        _30_Post_Direct_MarketingLabel.Location = New System.Drawing.Point(504, 75)
        _30_Post_Direct_MarketingLabel.Name = "_30_Post_Direct_MarketingLabel"
        _30_Post_Direct_MarketingLabel.Size = New System.Drawing.Size(173, 19)
        _30_Post_Direct_MarketingLabel.TabIndex = 48
        _30_Post_Direct_MarketingLabel.Text = "30 Post Direct Marketing:"
        '
        '_22_Ramblers_Join_DateLabel
        '
        _22_Ramblers_Join_DateLabel.AutoSize = True
        _22_Ramblers_Join_DateLabel.Location = New System.Drawing.Point(504, 151)
        _22_Ramblers_Join_DateLabel.Name = "_22_Ramblers_Join_DateLabel"
        _22_Ramblers_Join_DateLabel.Size = New System.Drawing.Size(158, 19)
        _22_Ramblers_Join_DateLabel.TabIndex = 71
        _22_Ramblers_Join_DateLabel.Text = "22 Ramblers Join Date:"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1084, 636)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1084, 661)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.EmailsPage)
        Me.TabControl1.Controls.Add(Me.FullListPage)
        Me.TabControl1.Controls.Add(Me.DetailsPage)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.LocalPostalPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 636)
        Me.TabControl1.TabIndex = 0
        '
        'EmailsPage
        '
        Me.EmailsPage.Controls.Add(Me.SplitContainer1)
        Me.EmailsPage.Location = New System.Drawing.Point(4, 28)
        Me.EmailsPage.Name = "EmailsPage"
        Me.EmailsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.EmailsPage.Size = New System.Drawing.Size(1076, 604)
        Me.EmailsPage.TabIndex = 0
        Me.EmailsPage.Text = "Local Email Contacts"
        Me.EmailsPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Bcomposeemail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LLaddnewemail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LLdeleteemail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UnusedEmailsDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrphanedEmailsDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer1.Panel1.Controls.Add(IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IDTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SURNAMETextBox)
        Me.SplitContainer1.Panel1.Controls.Add(CONTACTLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CONTACTTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(EMAILLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EMAILTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LocalEmailsDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1070, 598)
        Me.SplitContainer1.SplitterDistance = 356
        Me.SplitContainer1.TabIndex = 0
        '
        'Bcomposeemail
        '
        Me.Bcomposeemail.Location = New System.Drawing.Point(5, 136)
        Me.Bcomposeemail.Name = "Bcomposeemail"
        Me.Bcomposeemail.Size = New System.Drawing.Size(136, 27)
        Me.Bcomposeemail.TabIndex = 16
        Me.Bcomposeemail.Text = "Compose email"
        Me.Bcomposeemail.UseVisualStyleBackColor = True
        '
        'LLaddnewemail
        '
        Me.LLaddnewemail.AutoSize = True
        Me.LLaddnewemail.Location = New System.Drawing.Point(1, 345)
        Me.LLaddnewemail.Name = "LLaddnewemail"
        Me.LLaddnewemail.Size = New System.Drawing.Size(244, 19)
        Me.LLaddnewemail.TabIndex = 15
        Me.LLaddnewemail.TabStop = True
        Me.LLaddnewemail.Text = "Add selected email to local contacts"
        '
        'LLdeleteemail
        '
        Me.LLdeleteemail.AutoSize = True
        Me.LLdeleteemail.Location = New System.Drawing.Point(0, 202)
        Me.LLdeleteemail.Name = "LLdeleteemail"
        Me.LLdeleteemail.Size = New System.Drawing.Size(151, 19)
        Me.LLdeleteemail.TabIndex = 14
        Me.LLdeleteemail.TabStop = True
        Me.LLdeleteemail.Text = "Delete selected email"
        '
        'UnusedEmailsDataGridView
        '
        Me.UnusedEmailsDataGridView.AutoGenerateColumns = False
        Me.UnusedEmailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.UnusedEmailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnusedEmailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn44})
        Me.UnusedEmailsDataGridView.DataSource = Me.UnusedEmailsBindingSource
        Me.UnusedEmailsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UnusedEmailsDataGridView.Location = New System.Drawing.Point(0, 366)
        Me.UnusedEmailsDataGridView.Name = "UnusedEmailsDataGridView"
        Me.UnusedEmailsDataGridView.ReadOnly = True
        Me.UnusedEmailsDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.UnusedEmailsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.UnusedEmailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UnusedEmailsDataGridView.Size = New System.Drawing.Size(356, 232)
        Me.UnusedEmailsDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "01_Membership Number"
        Me.DataGridViewTextBoxColumn42.HeaderText = "01_Membership Number"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Width = 21
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "18_Email Address"
        Me.DataGridViewTextBoxColumn47.HeaderText = "18_Email Address"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Width = 21
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "06_Joint With"
        Me.DataGridViewTextBoxColumn43.HeaderText = "06_Joint With"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        Me.DataGridViewTextBoxColumn43.Width = 5
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "07_Title"
        Me.DataGridViewTextBoxColumn45.HeaderText = "07_Title"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Width = 21
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "08_Initials"
        Me.DataGridViewTextBoxColumn46.HeaderText = "08_Initials"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Width = 21
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "10_Surname"
        Me.DataGridViewTextBoxColumn44.HeaderText = "10_Surname"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Width = 21
        '
        'UnusedEmailsBindingSource
        '
        Me.UnusedEmailsBindingSource.DataMember = "UnusedEmails"
        Me.UnusedEmailsBindingSource.DataSource = Me.MembershipDataSet
        '
        'MembershipDataSet
        '
        Me.MembershipDataSet.DataSetName = "membershipDataSet"
        Me.MembershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-4, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(324, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Out-of-date Ramblers Emails or not in Local List:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(337, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Local Email contacts not in Ramblers Member List:"
        '
        'OrphanedEmailsDataGridView
        '
        Me.OrphanedEmailsDataGridView.AutoGenerateColumns = False
        Me.OrphanedEmailsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.OrphanedEmailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrphanedEmailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41})
        Me.OrphanedEmailsDataGridView.DataSource = Me.OrphanedEmailsBindingSource
        Me.OrphanedEmailsDataGridView.GridColor = System.Drawing.Color.Black
        Me.OrphanedEmailsDataGridView.Location = New System.Drawing.Point(0, 224)
        Me.OrphanedEmailsDataGridView.Name = "OrphanedEmailsDataGridView"
        Me.OrphanedEmailsDataGridView.ReadOnly = True
        Me.OrphanedEmailsDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.OrphanedEmailsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.OrphanedEmailsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OrphanedEmailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrphanedEmailsDataGridView.Size = New System.Drawing.Size(356, 84)
        Me.OrphanedEmailsDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Width = 50
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn39.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Visible = False
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "CONTACT"
        Me.DataGridViewTextBoxColumn40.HeaderText = "CONTACT"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 150
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn41.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Width = 170
        '
        'OrphanedEmailsBindingSource
        '
        Me.OrphanedEmailsBindingSource.DataMember = "OrphanedEmails"
        Me.OrphanedEmailsBindingSource.DataSource = Me.MembershipDataSet
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.LocalEmailsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(356, 25)
        Me.BindingNavigator1.TabIndex = 8
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(50, 22)
        Me.BindingNavigatorAddNewItem.Text = "New"
        '
        'LocalEmailsBindingSource
        '
        Me.LocalEmailsBindingSource.DataMember = "LocalEmails"
        Me.LocalEmailsBindingSource.DataSource = Me.MembershipDataSet
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(61, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalEmailsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(38, 35)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(68, 27)
        Me.IDTextBox.TabIndex = 1
        '
        'SURNAMETextBox
        '
        Me.SURNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalEmailsBindingSource, "SURNAME", True))
        Me.SURNAMETextBox.Location = New System.Drawing.Point(144, 35)
        Me.SURNAMETextBox.Name = "SURNAMETextBox"
        Me.SURNAMETextBox.Size = New System.Drawing.Size(193, 27)
        Me.SURNAMETextBox.TabIndex = 3
        '
        'CONTACTTextBox
        '
        Me.CONTACTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalEmailsBindingSource, "CONTACT", True))
        Me.CONTACTTextBox.Location = New System.Drawing.Point(86, 68)
        Me.CONTACTTextBox.Name = "CONTACTTextBox"
        Me.CONTACTTextBox.Size = New System.Drawing.Size(251, 27)
        Me.CONTACTTextBox.TabIndex = 5
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalEmailsBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(64, 103)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(273, 27)
        Me.EMAILTextBox.TabIndex = 7
        '
        'LocalEmailsDataGridView
        '
        Me.LocalEmailsDataGridView.AutoGenerateColumns = False
        Me.LocalEmailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LocalEmailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocalEmailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.LocalEmailsDataGridView.DataSource = Me.LocalEmailsBindingSource
        Me.LocalEmailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalEmailsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LocalEmailsDataGridView.MultiSelect = False
        Me.LocalEmailsDataGridView.Name = "LocalEmailsDataGridView"
        Me.LocalEmailsDataGridView.ReadOnly = True
        Me.LocalEmailsDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.LocalEmailsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.LocalEmailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LocalEmailsDataGridView.Size = New System.Drawing.Size(710, 598)
        Me.LocalEmailsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn34.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 48
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "SURNAME"
        Me.DataGridViewTextBoxColumn35.HeaderText = "SURNAME"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "CONTACT"
        Me.DataGridViewTextBoxColumn36.HeaderText = "CONTACT"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 97
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn37.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Width = 75
        '
        'FullListPage
        '
        Me.FullListPage.Controls.Add(Me.Full_ListDataGridView)
        Me.FullListPage.Location = New System.Drawing.Point(4, 22)
        Me.FullListPage.Name = "FullListPage"
        Me.FullListPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FullListPage.Size = New System.Drawing.Size(1076, 610)
        Me.FullListPage.TabIndex = 1
        Me.FullListPage.Text = "Member List Table"
        Me.FullListPage.UseVisualStyleBackColor = True
        '
        'Full_ListDataGridView
        '
        Me.Full_ListDataGridView.AllowUserToAddRows = False
        Me.Full_ListDataGridView.AllowUserToDeleteRows = False
        Me.Full_ListDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Full_ListDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.Full_ListDataGridView.AutoGenerateColumns = False
        Me.Full_ListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.Full_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Full_ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.Full_ListDataGridView.DataSource = Me.Full_ListBindingSource
        Me.Full_ListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Full_ListDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Full_ListDataGridView.MultiSelect = False
        Me.Full_ListDataGridView.Name = "Full_ListDataGridView"
        Me.Full_ListDataGridView.ReadOnly = True
        Me.Full_ListDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.Full_ListDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.Full_ListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Full_ListDataGridView.Size = New System.Drawing.Size(1070, 604)
        Me.Full_ListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "00_Group Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "00_Group Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "01_Membership Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "01_Membership Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "02_Member Type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "02_Member Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "04_Term"
        Me.DataGridViewTextBoxColumn4.HeaderText = "04_Term"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "05_Type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "05_Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "06_Joint With"
        Me.DataGridViewTextBoxColumn6.HeaderText = "06_Joint With"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 5
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "07_Title"
        Me.DataGridViewTextBoxColumn7.HeaderText = "07_Title"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 5
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "08_Initials"
        Me.DataGridViewTextBoxColumn8.HeaderText = "08_Initials"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 5
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "09_Forenames"
        Me.DataGridViewTextBoxColumn9.HeaderText = "09_Forenames"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 5
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "10_Surname"
        Me.DataGridViewTextBoxColumn10.HeaderText = "10_Surname"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 5
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "11_Address1"
        Me.DataGridViewTextBoxColumn11.HeaderText = "11_Address1"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 5
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "12_Address2"
        Me.DataGridViewTextBoxColumn12.HeaderText = "12_Address2"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 5
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "13_Address3"
        Me.DataGridViewTextBoxColumn13.HeaderText = "13_Address3"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 5
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "14_Town"
        Me.DataGridViewTextBoxColumn14.HeaderText = "14_Town"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 5
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "15_County"
        Me.DataGridViewTextBoxColumn15.HeaderText = "15_County"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 5
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "16_Postcode"
        Me.DataGridViewTextBoxColumn16.HeaderText = "16_Postcode"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 5
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "17_Country"
        Me.DataGridViewTextBoxColumn17.HeaderText = "17_Country"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 5
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "18_Email Address"
        Me.DataGridViewTextBoxColumn18.HeaderText = "18_Email Address"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 5
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "19_Landline"
        Me.DataGridViewTextBoxColumn19.HeaderText = "19_Landline"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 5
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "20_Mobile"
        Me.DataGridViewTextBoxColumn20.HeaderText = "20_Mobile"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 5
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "23_Area"
        Me.DataGridViewTextBoxColumn21.HeaderText = "23_Area"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 5
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "25_Group"
        Me.DataGridViewTextBoxColumn22.HeaderText = "25_Group"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        Me.DataGridViewTextBoxColumn22.Width = 5
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "27_Volunteer"
        Me.DataGridViewTextBoxColumn23.HeaderText = "27_Volunteer"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 5
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "28_Email Direct Marketing"
        Me.DataGridViewTextBoxColumn24.HeaderText = "28_Email Direct Marketing"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        Me.DataGridViewTextBoxColumn24.Width = 5
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "30_Post Direct Marketing"
        Me.DataGridViewTextBoxColumn25.HeaderText = "30_Post Direct Marketing"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        Me.DataGridViewTextBoxColumn25.Width = 5
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "32_Telephone Direct Marketing"
        Me.DataGridViewTextBoxColumn26.HeaderText = "32_Telephone Direct Marketing"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        Me.DataGridViewTextBoxColumn26.Width = 5
        '
        'Full_ListBindingSource
        '
        Me.Full_ListBindingSource.DataMember = "Full List"
        Me.Full_ListBindingSource.DataSource = Me.MembershipDataSet
        '
        'DetailsPage
        '
        Me.DetailsPage.AutoScroll = True
        Me.DetailsPage.Controls.Add(_22_Ramblers_Join_DateLabel)
        Me.DetailsPage.Controls.Add(Me._22_Ramblers_Join_DateTextBox)
        Me.DetailsPage.Controls.Add(Me.BindingNavigator2)
        Me.DetailsPage.Controls.Add(Me.Label3)
        Me.DetailsPage.Controls.Add(Me.Label2)
        Me.DetailsPage.Controls.Add(Me.Label1)
        Me.DetailsPage.Controls.Add(Me.LblJoint)
        Me.DetailsPage.Controls.Add(_01_Membership_NumberLabel)
        Me.DetailsPage.Controls.Add(Me._01_Membership_NumberTextBox)
        Me.DetailsPage.Controls.Add(_06_Joint_WithLabel)
        Me.DetailsPage.Controls.Add(Me._06_Joint_WithTextBox)
        Me.DetailsPage.Controls.Add(_07_TitleLabel)
        Me.DetailsPage.Controls.Add(Me._07_TitleTextBox)
        Me.DetailsPage.Controls.Add(_08_InitialsLabel)
        Me.DetailsPage.Controls.Add(Me._08_InitialsTextBox)
        Me.DetailsPage.Controls.Add(_09_ForenamesLabel)
        Me.DetailsPage.Controls.Add(Me._09_ForenamesTextBox)
        Me.DetailsPage.Controls.Add(_10_SurnameLabel)
        Me.DetailsPage.Controls.Add(Me._10_SurnameTextBox)
        Me.DetailsPage.Controls.Add(_11_Address1Label)
        Me.DetailsPage.Controls.Add(Me._11_Address1TextBox)
        Me.DetailsPage.Controls.Add(_12_Address2Label)
        Me.DetailsPage.Controls.Add(Me._12_Address2TextBox)
        Me.DetailsPage.Controls.Add(_13_Address3Label)
        Me.DetailsPage.Controls.Add(Me._13_Address3TextBox)
        Me.DetailsPage.Controls.Add(_14_TownLabel)
        Me.DetailsPage.Controls.Add(Me._14_TownTextBox)
        Me.DetailsPage.Controls.Add(_16_PostcodeLabel)
        Me.DetailsPage.Controls.Add(Me._16_PostcodeTextBox)
        Me.DetailsPage.Controls.Add(_18_Email_AddressLabel)
        Me.DetailsPage.Controls.Add(Me._18_Email_AddressTextBox)
        Me.DetailsPage.Controls.Add(_19_LandlineLabel)
        Me.DetailsPage.Controls.Add(Me._19_LandlineTextBox)
        Me.DetailsPage.Controls.Add(_20_MobileLabel)
        Me.DetailsPage.Controls.Add(Me._20_MobileTextBox)
        Me.DetailsPage.Controls.Add(_28_Email_Direct_MarketingLabel)
        Me.DetailsPage.Controls.Add(Me._28_Email_Direct_MarketingTextBox)
        Me.DetailsPage.Controls.Add(_30_Post_Direct_MarketingLabel)
        Me.DetailsPage.Controls.Add(Me._30_Post_Direct_MarketingTextBox)
        Me.DetailsPage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsPage.Location = New System.Drawing.Point(4, 22)
        Me.DetailsPage.Name = "DetailsPage"
        Me.DetailsPage.Size = New System.Drawing.Size(1076, 610)
        Me.DetailsPage.TabIndex = 2
        Me.DetailsPage.Text = "Member Details"
        Me.DetailsPage.UseVisualStyleBackColor = True
        '
        '_22_Ramblers_Join_DateTextBox
        '
        Me._22_Ramblers_Join_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "22_Ramblers Join Date", True))
        Me._22_Ramblers_Join_DateTextBox.Location = New System.Drawing.Point(718, 148)
        Me._22_Ramblers_Join_DateTextBox.Name = "_22_Ramblers_Join_DateTextBox"
        Me._22_Ramblers_Join_DateTextBox.Size = New System.Drawing.Size(178, 27)
        Me._22_Ramblers_Join_DateTextBox.TabIndex = 72
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Full_ListBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(1076, 25)
        Me.BindingNavigator2.TabIndex = 71
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 517)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 19)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "The following, irrelevant fields are not shown:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 547)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(705, 30)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(608, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Joint Member:"
        '
        'LblJoint
        '
        Me.LblJoint.AutoSize = True
        Me.LblJoint.Location = New System.Drawing.Point(609, 345)
        Me.LblJoint.Name = "LblJoint"
        Me.LblJoint.Size = New System.Drawing.Size(41, 19)
        Me.LblJoint.TabIndex = 67
        Me.LblJoint.Text = "none"
        '
        '_01_Membership_NumberTextBox
        '
        Me._01_Membership_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "01_Membership Number", True))
        Me._01_Membership_NumberTextBox.Location = New System.Drawing.Point(202, 40)
        Me._01_Membership_NumberTextBox.Name = "_01_Membership_NumberTextBox"
        Me._01_Membership_NumberTextBox.Size = New System.Drawing.Size(181, 27)
        Me._01_Membership_NumberTextBox.TabIndex = 3
        '
        '_06_Joint_WithTextBox
        '
        Me._06_Joint_WithTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "06_Joint With", True))
        Me._06_Joint_WithTextBox.Location = New System.Drawing.Point(202, 75)
        Me._06_Joint_WithTextBox.Name = "_06_Joint_WithTextBox"
        Me._06_Joint_WithTextBox.Size = New System.Drawing.Size(181, 27)
        Me._06_Joint_WithTextBox.TabIndex = 11
        '
        '_07_TitleTextBox
        '
        Me._07_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "07_Title", True))
        Me._07_TitleTextBox.Location = New System.Drawing.Point(202, 110)
        Me._07_TitleTextBox.Name = "_07_TitleTextBox"
        Me._07_TitleTextBox.Size = New System.Drawing.Size(181, 27)
        Me._07_TitleTextBox.TabIndex = 13
        '
        '_08_InitialsTextBox
        '
        Me._08_InitialsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "08_Initials", True))
        Me._08_InitialsTextBox.Location = New System.Drawing.Point(202, 145)
        Me._08_InitialsTextBox.Name = "_08_InitialsTextBox"
        Me._08_InitialsTextBox.Size = New System.Drawing.Size(181, 27)
        Me._08_InitialsTextBox.TabIndex = 15
        '
        '_09_ForenamesTextBox
        '
        Me._09_ForenamesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "09_Forenames", True))
        Me._09_ForenamesTextBox.Location = New System.Drawing.Point(202, 180)
        Me._09_ForenamesTextBox.Name = "_09_ForenamesTextBox"
        Me._09_ForenamesTextBox.Size = New System.Drawing.Size(181, 27)
        Me._09_ForenamesTextBox.TabIndex = 17
        '
        '_10_SurnameTextBox
        '
        Me._10_SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "10_Surname", True))
        Me._10_SurnameTextBox.Location = New System.Drawing.Point(202, 215)
        Me._10_SurnameTextBox.Name = "_10_SurnameTextBox"
        Me._10_SurnameTextBox.Size = New System.Drawing.Size(181, 27)
        Me._10_SurnameTextBox.TabIndex = 19
        '
        '_11_Address1TextBox
        '
        Me._11_Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "11_Address1", True))
        Me._11_Address1TextBox.Location = New System.Drawing.Point(202, 250)
        Me._11_Address1TextBox.Name = "_11_Address1TextBox"
        Me._11_Address1TextBox.Size = New System.Drawing.Size(181, 27)
        Me._11_Address1TextBox.TabIndex = 21
        '
        '_12_Address2TextBox
        '
        Me._12_Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "12_Address2", True))
        Me._12_Address2TextBox.Location = New System.Drawing.Point(202, 285)
        Me._12_Address2TextBox.Name = "_12_Address2TextBox"
        Me._12_Address2TextBox.Size = New System.Drawing.Size(181, 27)
        Me._12_Address2TextBox.TabIndex = 23
        '
        '_13_Address3TextBox
        '
        Me._13_Address3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "13_Address3", True))
        Me._13_Address3TextBox.Location = New System.Drawing.Point(202, 320)
        Me._13_Address3TextBox.Name = "_13_Address3TextBox"
        Me._13_Address3TextBox.Size = New System.Drawing.Size(181, 27)
        Me._13_Address3TextBox.TabIndex = 25
        '
        '_14_TownTextBox
        '
        Me._14_TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "14_Town", True))
        Me._14_TownTextBox.Location = New System.Drawing.Point(202, 355)
        Me._14_TownTextBox.Name = "_14_TownTextBox"
        Me._14_TownTextBox.Size = New System.Drawing.Size(181, 27)
        Me._14_TownTextBox.TabIndex = 27
        '
        '_16_PostcodeTextBox
        '
        Me._16_PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "16_Postcode", True))
        Me._16_PostcodeTextBox.Location = New System.Drawing.Point(202, 390)
        Me._16_PostcodeTextBox.Name = "_16_PostcodeTextBox"
        Me._16_PostcodeTextBox.Size = New System.Drawing.Size(181, 27)
        Me._16_PostcodeTextBox.TabIndex = 31
        '
        '_18_Email_AddressTextBox
        '
        Me._18_Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "18_Email Address", True))
        Me._18_Email_AddressTextBox.Location = New System.Drawing.Point(202, 425)
        Me._18_Email_AddressTextBox.Name = "_18_Email_AddressTextBox"
        Me._18_Email_AddressTextBox.Size = New System.Drawing.Size(329, 27)
        Me._18_Email_AddressTextBox.TabIndex = 35
        '
        '_19_LandlineTextBox
        '
        Me._19_LandlineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "19_Landline", True))
        Me._19_LandlineTextBox.Location = New System.Drawing.Point(202, 460)
        Me._19_LandlineTextBox.Name = "_19_LandlineTextBox"
        Me._19_LandlineTextBox.Size = New System.Drawing.Size(181, 27)
        Me._19_LandlineTextBox.TabIndex = 37
        '
        '_20_MobileTextBox
        '
        Me._20_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "20_Mobile", True))
        Me._20_MobileTextBox.Location = New System.Drawing.Point(534, 460)
        Me._20_MobileTextBox.Name = "_20_MobileTextBox"
        Me._20_MobileTextBox.Size = New System.Drawing.Size(181, 27)
        Me._20_MobileTextBox.TabIndex = 39
        '
        '_28_Email_Direct_MarketingTextBox
        '
        Me._28_Email_Direct_MarketingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "28_Email Direct Marketing", True))
        Me._28_Email_Direct_MarketingTextBox.Location = New System.Drawing.Point(718, 37)
        Me._28_Email_Direct_MarketingTextBox.Name = "_28_Email_Direct_MarketingTextBox"
        Me._28_Email_Direct_MarketingTextBox.Size = New System.Drawing.Size(178, 27)
        Me._28_Email_Direct_MarketingTextBox.TabIndex = 47
        '
        '_30_Post_Direct_MarketingTextBox
        '
        Me._30_Post_Direct_MarketingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Full_ListBindingSource, "30_Post Direct Marketing", True))
        Me._30_Post_Direct_MarketingTextBox.Location = New System.Drawing.Point(718, 72)
        Me._30_Post_Direct_MarketingTextBox.Name = "_30_Post_Direct_MarketingTextBox"
        Me._30_Post_Direct_MarketingTextBox.Size = New System.Drawing.Size(178, 27)
        Me._30_Post_Direct_MarketingTextBox.TabIndex = 49
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.HouseholdsDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1076, 610)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Single and Joint Memberships"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'HouseholdsDataGridView
        '
        Me.HouseholdsDataGridView.AllowUserToAddRows = False
        Me.HouseholdsDataGridView.AllowUserToDeleteRows = False
        Me.HouseholdsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.HouseholdsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.HouseholdsDataGridView.AutoGenerateColumns = False
        Me.HouseholdsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.HouseholdsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HouseholdsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64})
        Me.HouseholdsDataGridView.DataSource = Me.HouseholdsBindingSource
        Me.HouseholdsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HouseholdsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.HouseholdsDataGridView.MultiSelect = False
        Me.HouseholdsDataGridView.Name = "HouseholdsDataGridView"
        Me.HouseholdsDataGridView.ReadOnly = True
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        Me.HouseholdsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.HouseholdsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HouseholdsDataGridView.Size = New System.Drawing.Size(1076, 610)
        Me.HouseholdsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "01_Membership Number"
        Me.DataGridViewTextBoxColumn48.HeaderText = "01_Membership Number"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Width = 5
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "06_Joint With"
        Me.DataGridViewTextBoxColumn55.HeaderText = "06_Joint With"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Width = 5
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "07_Title"
        Me.DataGridViewTextBoxColumn56.HeaderText = "07_Title"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Width = 5
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "08_Initials"
        Me.DataGridViewTextBoxColumn57.HeaderText = "08_Initials"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Width = 5
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "09_Forenames"
        Me.DataGridViewTextBoxColumn58.HeaderText = "09_Forenames"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Width = 5
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "10_Surname"
        Me.DataGridViewTextBoxColumn59.HeaderText = "10_Surname"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        Me.DataGridViewTextBoxColumn59.Width = 5
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "11_Address1"
        Me.DataGridViewTextBoxColumn60.HeaderText = "11_Address1"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        Me.DataGridViewTextBoxColumn60.Width = 5
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "12_Address2"
        Me.DataGridViewTextBoxColumn61.HeaderText = "12_Address2"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        Me.DataGridViewTextBoxColumn61.Width = 5
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "13_Address3"
        Me.DataGridViewTextBoxColumn62.HeaderText = "13_Address3"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        Me.DataGridViewTextBoxColumn62.Width = 5
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "16_Postcode"
        Me.DataGridViewTextBoxColumn63.HeaderText = "16_Postcode"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        Me.DataGridViewTextBoxColumn63.Width = 5
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "14_Town"
        Me.DataGridViewTextBoxColumn64.HeaderText = "14_Town"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        Me.DataGridViewTextBoxColumn64.Width = 5
        '
        'HouseholdsBindingSource
        '
        Me.HouseholdsBindingSource.DataMember = "Households"
        Me.HouseholdsBindingSource.DataSource = Me.MembershipDataSet
        '
        'LocalPostalPage
        '
        Me.LocalPostalPage.Controls.Add(Me.ToolStripContainer2)
        Me.LocalPostalPage.Location = New System.Drawing.Point(4, 22)
        Me.LocalPostalPage.Name = "LocalPostalPage"
        Me.LocalPostalPage.Size = New System.Drawing.Size(1076, 610)
        Me.LocalPostalPage.TabIndex = 3
        Me.LocalPostalPage.Text = "Local Postal List"
        Me.LocalPostalPage.UseVisualStyleBackColor = True
        '
        'ToolStripContainer2
        '
        Me.ToolStripContainer2.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.LocalPostalListDataGridView)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(1076, 585)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(1076, 610)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.BindingNavigator3)
        '
        'LocalPostalListDataGridView
        '
        Me.LocalPostalListDataGridView.AutoGenerateColumns = False
        Me.LocalPostalListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LocalPostalListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocalPostalListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54})
        Me.LocalPostalListDataGridView.DataSource = Me.LocalPostalListBindingSource
        Me.LocalPostalListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalPostalListDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.LocalPostalListDataGridView.MultiSelect = False
        Me.LocalPostalListDataGridView.Name = "LocalPostalListDataGridView"
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.LocalPostalListDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.LocalPostalListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LocalPostalListDataGridView.Size = New System.Drawing.Size(1076, 585)
        Me.LocalPostalListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn49.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 48
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "CONTACT"
        Me.DataGridViewTextBoxColumn50.HeaderText = "CONTACT"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 97
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "ADDR1"
        Me.DataGridViewTextBoxColumn51.HeaderText = "ADDR1"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Width = 80
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "ADDR2"
        Me.DataGridViewTextBoxColumn52.HeaderText = "ADDR2"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Width = 80
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "TOWN"
        Me.DataGridViewTextBoxColumn53.HeaderText = "TOWN"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 77
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "POSTCODE"
        Me.DataGridViewTextBoxColumn54.HeaderText = "POSTCODE"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 106
        '
        'LocalPostalListBindingSource
        '
        Me.LocalPostalListBindingSource.DataMember = "LocalPostalList"
        Me.LocalPostalListBindingSource.DataSource = Me.MembershipDataSet
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator3.BindingSource = Me.LocalPostalListBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator3.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator3.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem1, Me.ToolStripSeparator4, Me.BindingNavigatorDeleteItem1, Me.ToolStripSeparator5})
        Me.BindingNavigator3.Location = New System.Drawing.Point(3, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator3.Size = New System.Drawing.Size(382, 25)
        Me.BindingNavigator3.TabIndex = 0
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(84, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(42, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(70, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBreload, Me.ToolStripSeparator7, Me.TSBmakepostal, Me.ToolStripSeparator8, Me.TSBsaveall, Me.ToolStripSeparator3, Me.TSBmemberlist, Me.ToolStripSeparator10, Me.TSBarchivexls, Me.ToolStripSeparator6, Me.TSBarchivepdf, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(858, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'TSBreload
        '
        Me.TSBreload.BackColor = System.Drawing.Color.Gainsboro
        Me.TSBreload.Image = CType(resources.GetObject("TSBreload.Image"), System.Drawing.Image)
        Me.TSBreload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBreload.Name = "TSBreload"
        Me.TSBreload.Size = New System.Drawing.Size(145, 22)
        Me.TSBreload.Text = "Load Memberlist"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'TSBmakepostal
        '
        Me.TSBmakepostal.BackColor = System.Drawing.Color.LightBlue
        Me.TSBmakepostal.Image = CType(resources.GetObject("TSBmakepostal.Image"), System.Drawing.Image)
        Me.TSBmakepostal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBmakepostal.Name = "TSBmakepostal"
        Me.TSBmakepostal.Size = New System.Drawing.Size(144, 22)
        Me.TSBmakepostal.Text = "Make Postal List"
        Me.TSBmakepostal.ToolTipText = "Postal List"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'TSBsaveall
        '
        Me.TSBsaveall.BackColor = System.Drawing.Color.LightGreen
        Me.TSBsaveall.Image = CType(resources.GetObject("TSBsaveall.Image"), System.Drawing.Image)
        Me.TSBsaveall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBsaveall.Name = "TSBsaveall"
        Me.TSBsaveall.Size = New System.Drawing.Size(131, 22)
        Me.TSBsaveall.Text = "Save Changes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TSBmemberlist
        '
        Me.TSBmemberlist.BackColor = System.Drawing.Color.LemonChiffon
        Me.TSBmemberlist.Image = CType(resources.GetObject("TSBmemberlist.Image"), System.Drawing.Image)
        Me.TSBmemberlist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBmemberlist.Name = "TSBmemberlist"
        Me.TSBmemberlist.Size = New System.Drawing.Size(158, 22)
        Me.TSBmemberlist.Text = "Get Memberlist file"
        Me.TSBmemberlist.ToolTipText = "Get Memberlist file"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'TSBarchivexls
        '
        Me.TSBarchivexls.Image = CType(resources.GetObject("TSBarchivexls.Image"), System.Drawing.Image)
        Me.TSBarchivexls.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBarchivexls.Name = "TSBarchivexls"
        Me.TSBarchivexls.Size = New System.Drawing.Size(115, 22)
        Me.TSBarchivexls.Text = "Archive XLS"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'TSBarchivepdf
        '
        Me.TSBarchivepdf.Image = CType(resources.GetObject("TSBarchivepdf.Image"), System.Drawing.Image)
        Me.TSBarchivepdf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBarchivepdf.Name = "TSBarchivepdf"
        Me.TSBarchivepdf.Size = New System.Drawing.Size(117, 22)
        Me.TSBarchivepdf.Text = "Archive PDF"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'PostalListBindingSource
        '
        Me.PostalListBindingSource.DataMember = "PostalList"
        Me.PostalListBindingSource.DataSource = Me.MembershipDataSet
        '
        'Full_ListTableAdapter
        '
        Me.Full_ListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Full_ListTableAdapter = Me.Full_ListTableAdapter
        Me.TableAdapterManager.LocalEmailsTableAdapter = Me.LocalEmailsTableAdapter
        Me.TableAdapterManager.LocalPostalListTableAdapter = Me.LocalPostalListTableAdapter
        Me.TableAdapterManager.UpdateOrder = MembershipManager.membershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LocalEmailsTableAdapter
        '
        Me.LocalEmailsTableAdapter.ClearBeforeFill = True
        '
        'LocalPostalListTableAdapter
        '
        Me.LocalPostalListTableAdapter.ClearBeforeFill = True
        '
        'PostalListTableAdapter
        '
        Me.PostalListTableAdapter.ClearBeforeFill = True
        '
        'OrphanedEmailsTableAdapter
        '
        Me.OrphanedEmailsTableAdapter.ClearBeforeFill = True
        '
        'UnusedEmailsTableAdapter
        '
        Me.UnusedEmailsTableAdapter.ClearBeforeFill = True
        '
        'HouseholdsTableAdapter
        '
        Me.HouseholdsTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "Membership Manager"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.EmailsPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UnusedEmailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnusedEmailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembershipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrphanedEmailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrphanedEmailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.LocalEmailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalEmailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FullListPage.ResumeLayout(False)
        CType(Me.Full_ListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Full_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsPage.ResumeLayout(False)
        Me.DetailsPage.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.HouseholdsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseholdsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LocalPostalPage.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.LocalPostalListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalPostalListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PostalListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents EmailsPage As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FullListPage As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents MembershipDataSet As membershipDataSet
    Friend WithEvents Full_ListBindingSource As BindingSource
    Friend WithEvents Full_ListTableAdapter As membershipDataSetTableAdapters.Full_ListTableAdapter
    Friend WithEvents TableAdapterManager As membershipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalEmailsTableAdapter As membershipDataSetTableAdapters.LocalEmailsTableAdapter
    Friend WithEvents LocalEmailsBindingSource As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents SURNAMETextBox As TextBox
    Friend WithEvents CONTACTTextBox As TextBox
    Friend WithEvents EMAILTextBox As TextBox
    Friend WithEvents LocalEmailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DetailsPage As TabPage
    Friend WithEvents _01_Membership_NumberTextBox As TextBox
    Friend WithEvents _06_Joint_WithTextBox As TextBox
    Friend WithEvents _07_TitleTextBox As TextBox
    Friend WithEvents _08_InitialsTextBox As TextBox
    Friend WithEvents _09_ForenamesTextBox As TextBox
    Friend WithEvents _10_SurnameTextBox As TextBox
    Friend WithEvents _11_Address1TextBox As TextBox
    Friend WithEvents _12_Address2TextBox As TextBox
    Friend WithEvents _13_Address3TextBox As TextBox
    Friend WithEvents _14_TownTextBox As TextBox
    Friend WithEvents _16_PostcodeTextBox As TextBox
    Friend WithEvents _18_Email_AddressTextBox As TextBox
    Friend WithEvents _19_LandlineTextBox As TextBox
    Friend WithEvents _20_MobileTextBox As TextBox
    Friend WithEvents _28_Email_Direct_MarketingTextBox As TextBox
    Friend WithEvents _30_Post_Direct_MarketingTextBox As TextBox
    Friend WithEvents LblJoint As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Full_ListDataGridView As DataGridView
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents LocalPostalPage As TabPage
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents PostalListBindingSource As BindingSource
    Friend WithEvents PostalListTableAdapter As membershipDataSetTableAdapters.PostalListTableAdapter
    Friend WithEvents LocalPostalListBindingSource As BindingSource
    Friend WithEvents LocalPostalListTableAdapter As membershipDataSetTableAdapters.LocalPostalListTableAdapter
    Friend WithEvents LocalPostalListDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents TSBmakepostal As ToolStripButton
    Friend WithEvents TSBreload As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents OrphanedEmailsBindingSource As BindingSource
    Friend WithEvents OrphanedEmailsTableAdapter As membershipDataSetTableAdapters.OrphanedEmailsTableAdapter
    Friend WithEvents OrphanedEmailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UnusedEmailsBindingSource As BindingSource
    Friend WithEvents UnusedEmailsTableAdapter As membershipDataSetTableAdapters.UnusedEmailsTableAdapter
    Friend WithEvents UnusedEmailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TSBsaveall As ToolStripButton
    Friend WithEvents HouseholdsBindingSource As BindingSource
    Friend WithEvents HouseholdsTableAdapter As membershipDataSetTableAdapters.HouseholdsTableAdapter
    Friend WithEvents HouseholdsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents LLdeleteemail As LinkLabel
    Friend WithEvents LLaddnewemail As LinkLabel
    Friend WithEvents Bcomposeemail As Button
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TSBarchivexls As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents TSBarchivepdf As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents TSBmemberlist As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents _22_Ramblers_Join_DateTextBox As TextBox
End Class
