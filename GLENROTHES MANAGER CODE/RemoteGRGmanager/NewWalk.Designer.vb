<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewWalk
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
        Dim TIMELabel As System.Windows.Forms.Label
        Me.bCancel = New System.Windows.Forms.Button()
        Me.ALLWALKSTableAdapter1 = New Programme_Designer.chrisbarton_grg10DataSet1TableAdapters.ALLWALKSTableAdapter()
        Me.Chrisbarton_grg10DataSet1 = New Programme_Designer.chrisbarton_grg10DataSet1()
        Me.ALLWALKSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAMEtb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bSave = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New Programme_Designer.chrisbarton_grg10DataSet1TableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DESCRtb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PLACEtb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.STARTcb = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MEETcb = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OStb = New System.Windows.Forms.TextBox()
        Me.GRIDtb = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CHILDchk = New System.Windows.Forms.CheckBox()
        Me.DOGchk = New System.Windows.Forms.CheckBox()
        Me.ASCtb = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MAPtb = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TOWNtb = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Townlistcb = New System.Windows.Forms.ComboBox()
        Me.OSmaplistcb = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TOWNSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chrisbarton_grg10DataSet = New Programme_Designer.chrisbarton_grg10DataSet()
        Me.TOWNSTableAdapter = New Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TOWNSTableAdapter()
        Me.TableAdapterManager = New Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager()
        Me.FindGRll = New System.Windows.Forms.LinkLabel()
        Me.ALLWALKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALLWALKSTableAdapter = New Programme_Designer.chrisbarton_grg10DataSetTableAdapters.ALLWALKSTableAdapter()
        Me.TIMETextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SEPAlink = New System.Windows.Forms.LinkLabel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DISTcb = New System.Windows.Forms.ComboBox()
        Me.GRADEcb = New System.Windows.Forms.ComboBox()
        TIMELabel = New System.Windows.Forms.Label()
        CType(Me.Chrisbarton_grg10DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALLWALKSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOWNSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALLWALKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TIMELabel
        '
        TIMELabel.AutoSize = True
        TIMELabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TIMELabel.Location = New System.Drawing.Point(494, 250)
        TIMELabel.Name = "TIMELabel"
        TIMELabel.Size = New System.Drawing.Size(81, 19)
        TIMELabel.TabIndex = 36
        TIMELabel.Text = "Time (hrs):"
        '
        'bCancel
        '
        Me.bCancel.Location = New System.Drawing.Point(672, 571)
        Me.bCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(100, 34)
        Me.bCancel.TabIndex = 0
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'ALLWALKSTableAdapter1
        '
        Me.ALLWALKSTableAdapter1.ClearBeforeFill = True
        '
        'Chrisbarton_grg10DataSet1
        '
        Me.Chrisbarton_grg10DataSet1.DataSetName = "chrisbarton_grg10DataSet1"
        Me.Chrisbarton_grg10DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALLWALKSBindingSource1
        '
        Me.ALLWALKSBindingSource1.DataMember = "ALLWALKS"
        '
        'NAMEtb
        '
        Me.NAMEtb.Location = New System.Drawing.Point(171, 56)
        Me.NAMEtb.Name = "NAMEtb"
        Me.NAMEtb.Size = New System.Drawing.Size(601, 27)
        Me.NAMEtb.TabIndex = 2
        Me.NAMEtb.Text = "new"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "New Walk Name:"
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.bSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.Location = New System.Drawing.Point(475, 571)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(165, 34)
        Me.bSave.TabIndex = 4
        Me.bSave.Text = "Save New Walk"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ALLWALKSTableAdapter = Me.ALLWALKSTableAdapter1
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.LEADERSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Programme_Designer.chrisbarton_grg10DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nearest Town:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Grade A - D:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Description:"
        '
        'DESCRtb
        '
        Me.DESCRtb.Location = New System.Drawing.Point(171, 89)
        Me.DESCRtb.Multiline = True
        Me.DESCRtb.Name = "DESCRtb"
        Me.DESCRtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DESCRtb.Size = New System.Drawing.Size(601, 111)
        Me.DESCRtb.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Distance (mls):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Start Place:"
        '
        'PLACEtb
        '
        Me.PLACEtb.Location = New System.Drawing.Point(171, 289)
        Me.PLACEtb.Multiline = True
        Me.PLACEtb.Name = "PLACEtb"
        Me.PLACEtb.Size = New System.Drawing.Size(601, 60)
        Me.PLACEtb.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Meet time at LCCP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(258, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "as hh:mm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Meet time at LCCP:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(648, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "as hh:mm"
        '
        'STARTcb
        '
        Me.STARTcb.FormattingEnabled = True
        Me.STARTcb.Items.AddRange(New Object() {"9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00"})
        Me.STARTcb.Location = New System.Drawing.Point(560, 365)
        Me.STARTcb.Name = "STARTcb"
        Me.STARTcb.Size = New System.Drawing.Size(80, 27)
        Me.STARTcb.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(408, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Start time at Walk:"
        '
        'MEETcb
        '
        Me.MEETcb.FormattingEnabled = True
        Me.MEETcb.Items.AddRange(New Object() {"9:30", "9:45", "10:00", "10:15", "10:30"})
        Me.MEETcb.Location = New System.Drawing.Point(172, 365)
        Me.MEETcb.Name = "MEETcb"
        Me.MEETcb.Size = New System.Drawing.Size(80, 27)
        Me.MEETcb.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 408)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 19)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "OS Map (1:50,000):"
        '
        'OStb
        '
        Me.OStb.Location = New System.Drawing.Point(172, 405)
        Me.OStb.Name = "OStb"
        Me.OStb.Size = New System.Drawing.Size(47, 27)
        Me.OStb.TabIndex = 23
        '
        'GRIDtb
        '
        Me.GRIDtb.Location = New System.Drawing.Point(641, 405)
        Me.GRIDtb.Name = "GRIDtb"
        Me.GRIDtb.Size = New System.Drawing.Size(131, 27)
        Me.GRIDtb.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(311, 408)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(292, 19)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "OS Grid Reference (as NN123456 or nn...):"
        '
        'CHILDchk
        '
        Me.CHILDchk.AutoSize = True
        Me.CHILDchk.Location = New System.Drawing.Point(419, 520)
        Me.CHILDchk.Name = "CHILDchk"
        Me.CHILDchk.Size = New System.Drawing.Size(157, 23)
        Me.CHILDchk.TabIndex = 26
        Me.CHILDchk.Text = "- Child friendly walk"
        Me.CHILDchk.UseVisualStyleBackColor = True
        '
        'DOGchk
        '
        Me.DOGchk.AutoSize = True
        Me.DOGchk.Location = New System.Drawing.Point(605, 520)
        Me.DOGchk.Name = "DOGchk"
        Me.DOGchk.Size = New System.Drawing.Size(150, 23)
        Me.DOGchk.TabIndex = 27
        Me.DOGchk.Text = "- Dog friendly walk"
        Me.DOGchk.UseVisualStyleBackColor = True
        '
        'ASCtb
        '
        Me.ASCtb.Location = New System.Drawing.Point(249, 516)
        Me.ASCtb.Name = "ASCtb"
        Me.ASCtb.Size = New System.Drawing.Size(109, 27)
        Me.ASCtb.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 519)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 19)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Ascent in feet (if over 250ft):"
        '
        'MAPtb
        '
        Me.MAPtb.Location = New System.Drawing.Point(247, 576)
        Me.MAPtb.Name = "MAPtb"
        Me.MAPtb.Size = New System.Drawing.Size(174, 27)
        Me.MAPtb.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 579)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(210, 19)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Route map image file if known:"
        '
        'TOWNtb
        '
        Me.TOWNtb.Location = New System.Drawing.Point(171, 206)
        Me.TOWNtb.Name = "TOWNtb"
        Me.TOWNtb.Size = New System.Drawing.Size(184, 27)
        Me.TOWNtb.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(360, 209)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 19)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Towns List (click to select):"
        '
        'Townlistcb
        '
        Me.Townlistcb.FormattingEnabled = True
        Me.Townlistcb.Items.AddRange(New Object() {"Aberdour", "Aberfeldy", "Abernethy", "Airth", "Alyth", "Amulree", "Anstruther", "Arbroath", "Arncroach", "Auchterarder", "Auchtermuchty", "Balerno", "Balmullo", "Blackford", "Blair Atholl", "Blairgowrie", "Bo'ness", "Bridge of Earn", "Burntisland", "Burnturk", "Cardenden", "Cellardyke", "Ceres", "Colinsburgh", "Comrie", "Cowdenbeath", "Crail", "Cramond", "Crieff", "Crook of Devon", "Crossgates", "Culross", "Cupar", "Dairsie", "Dalgety Bay", "Dalwhinnie", "Dollar", "Dunbar", "Dundee", "Dunfermline", "Dunkeld", "Dunning", "Edinburgh", "Elie", "Errol", "Falkirk", "Falkland", "Forgandenny", "Forteviot", "Glamis", "Glen Clova", "Glen Devon", "Glenfarg", "Glenrothes", "Grandtully", "Inverkeithing", "Kelty", "Kemback", "Kennoway", "Kettlebridge", "Kilmany", "Kincardine", "Kinghorn", "Kingsbarns", "Kingskettle", "Kinross", "Kirkcaldy", "Kirriemuir", "Ladybank", "Lauder", "Leuchars", "Leven", "Limekilns", "Lindores", "Linlithgow", "Lochore", "Lomonds", "Lower Largo", "Luthrie", "Manor Powis", "Markinch", "Monimail", "Newburgh", "Newtyle", "Pencaitland", "Perth", "Pitlochry", "Pittenweem", "Rait", "Rannoch Station", "Scone", "Scotlandwell", "South Queensferry", "Springfield", "St Andrews", "St Fillans", "St Monans", "Stanley", "Steelend", "Stirling", "Strathmiglo", "Stronachie", "Tay Bridge", "Tayport", "Thornton", "Tillicoultry", "West Linton", "West Wemyss", "Wormit"})
        Me.Townlistcb.Location = New System.Drawing.Point(565, 206)
        Me.Townlistcb.Name = "Townlistcb"
        Me.Townlistcb.Size = New System.Drawing.Size(207, 27)
        Me.Townlistcb.TabIndex = 33
        '
        'OSmaplistcb
        '
        Me.OSmaplistcb.FormattingEnabled = True
        Me.OSmaplistcb.Items.AddRange(New Object() {"43 Braemar to Blair Atholl", "44 Ballater", "51 Loch Tay", "52 Pitlochry & Crieff", "53 Blairgowrie & Forest of Alyth", "54 Dundee Montrose Forfar & Arbroath", "57 Stirling & The Trossachs Area", "58 Perth & Alloa Auchterarder", "59 St Andrews Kirkcaldy & Glenrothes", "65 Falkirk & West Lothian", "66 Edinburgh & Midlothian Area", "67 Duns Dunbar & Eyemouth", "72 Upper Clyde Valley", "73 Peebles Galashields & Area", "74 Kelso Coldstream Jedburgh & Duns"})
        Me.OSmaplistcb.Location = New System.Drawing.Point(19, 469)
        Me.OSmaplistcb.Name = "OSmaplistcb"
        Me.OSmaplistcb.Size = New System.Drawing.Size(207, 27)
        Me.OSmaplistcb.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 447)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(201, 19)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "OS Maps List (click to select):"
        '
        'TOWNSBindingSource
        '
        Me.TOWNSBindingSource.DataMember = "TOWNS"
        Me.TOWNSBindingSource.DataSource = Me.Chrisbarton_grg10DataSet
        '
        'Chrisbarton_grg10DataSet
        '
        Me.Chrisbarton_grg10DataSet.DataSetName = "chrisbarton_grg10DataSet"
        Me.Chrisbarton_grg10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOWNSTableAdapter
        '
        Me.TOWNSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALLWALKSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.GROUP_CONTACTSTableAdapter = Nothing
        Me.TableAdapterManager.LEADERSTableAdapter = Nothing
        Me.TableAdapterManager.PHOTOALBUMTableAdapter = Nothing
        Me.TableAdapterManager.PROGRAMMETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FindGRll
        '
        Me.FindGRll.AutoSize = True
        Me.FindGRll.Location = New System.Drawing.Point(328, 447)
        Me.FindGRll.Name = "FindGRll"
        Me.FindGRll.Size = New System.Drawing.Size(270, 19)
        Me.FindGRll.TabIndex = 36
        Me.FindGRll.TabStop = True
        Me.FindGRll.Text = "Find OS Grid Reference using Bing maps"
        '
        'ALLWALKSBindingSource
        '
        Me.ALLWALKSBindingSource.DataMember = "ALLWALKS"
        Me.ALLWALKSBindingSource.DataSource = Me.Chrisbarton_grg10DataSet
        '
        'ALLWALKSTableAdapter
        '
        Me.ALLWALKSTableAdapter.ClearBeforeFill = True
        '
        'TIMETextBox
        '
        Me.TIMETextBox.Location = New System.Drawing.Point(585, 246)
        Me.TIMETextBox.Name = "TIMETextBox"
        Me.TIMETextBox.Size = New System.Drawing.Size(55, 27)
        Me.TIMETextBox.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(23, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(578, 19)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Bold field names are required for AJP, Nearest Town needed for Members Walk Finde" &
    "r"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(630, 447)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(129, 19)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "+/- 100m accuracy"
        '
        'SEPAlink
        '
        Me.SEPAlink.AutoSize = True
        Me.SEPAlink.Location = New System.Drawing.Point(328, 477)
        Me.SEPAlink.Name = "SEPAlink"
        Me.SEPAlink.Size = New System.Drawing.Size(139, 19)
        Me.SEPAlink.TabIndex = 41
        Me.SEPAlink.TabStop = True
        Me.SEPAlink.Text = "or use SEPA website"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(494, 477)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(173, 19)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "8 digits +/- 10m accuracy"
        '
        'DISTcb
        '
        Me.DISTcb.FormattingEnabled = True
        Me.DISTcb.Items.AddRange(New Object() {"5", "5.5", "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10", "11", "12", "13", "14", "15"})
        Me.DISTcb.Location = New System.Drawing.Point(384, 246)
        Me.DISTcb.Name = "DISTcb"
        Me.DISTcb.Size = New System.Drawing.Size(61, 27)
        Me.DISTcb.TabIndex = 12
        '
        'GRADEcb
        '
        Me.GRADEcb.FormattingEnabled = True
        Me.GRADEcb.Items.AddRange(New Object() {"A", "B+", "B", "C+", "C", "D"})
        Me.GRADEcb.Location = New System.Drawing.Point(171, 246)
        Me.GRADEcb.Name = "GRADEcb"
        Me.GRADEcb.Size = New System.Drawing.Size(61, 27)
        Me.GRADEcb.TabIndex = 8
        '
        'NewWalk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(812, 628)
        Me.Controls.Add(Me.TIMETextBox)
        Me.Controls.Add(Me.OSmaplistcb)
        Me.Controls.Add(Me.Townlistcb)
        Me.Controls.Add(Me.MAPtb)
        Me.Controls.Add(Me.ASCtb)
        Me.Controls.Add(Me.GRIDtb)
        Me.Controls.Add(Me.OStb)
        Me.Controls.Add(Me.MEETcb)
        Me.Controls.Add(Me.STARTcb)
        Me.Controls.Add(Me.PLACEtb)
        Me.Controls.Add(Me.DISTcb)
        Me.Controls.Add(Me.DESCRtb)
        Me.Controls.Add(Me.GRADEcb)
        Me.Controls.Add(Me.TOWNtb)
        Me.Controls.Add(Me.NAMEtb)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.SEPAlink)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(TIMELabel)
        Me.Controls.Add(Me.FindGRll)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DOGchk)
        Me.Controls.Add(Me.CHILDchk)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bCancel)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewWalk"
        Me.Text = "Add New Walk"
        CType(Me.Chrisbarton_grg10DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALLWALKSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOWNSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chrisbarton_grg10DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALLWALKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bCancel As System.Windows.Forms.Button
    Friend WithEvents ALLWALKSTableAdapter1 As Programme_Designer.chrisbarton_grg10DataSet1TableAdapters.ALLWALKSTableAdapter
    Friend WithEvents ALLWALKSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Chrisbarton_grg10DataSet1 As Programme_Designer.chrisbarton_grg10DataSet1
    Friend WithEvents NAMEtb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager1 As Programme_Designer.chrisbarton_grg10DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DESCRtb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PLACEtb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents STARTcb As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MEETcb As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OStb As System.Windows.Forms.TextBox
    Friend WithEvents GRIDtb As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CHILDchk As System.Windows.Forms.CheckBox
    Friend WithEvents DOGchk As System.Windows.Forms.CheckBox
    Friend WithEvents ASCtb As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MAPtb As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TOWNtb As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Townlistcb As System.Windows.Forms.ComboBox
    Friend WithEvents OSmaplistcb As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Chrisbarton_grg10DataSet As Programme_Designer.chrisbarton_grg10DataSet
    Friend WithEvents TOWNSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOWNSTableAdapter As Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TOWNSTableAdapter
    Friend WithEvents TableAdapterManager As Programme_Designer.chrisbarton_grg10DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FindGRll As System.Windows.Forms.LinkLabel
    Friend WithEvents ALLWALKSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALLWALKSTableAdapter As Programme_Designer.chrisbarton_grg10DataSetTableAdapters.ALLWALKSTableAdapter
    Friend WithEvents TIMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SEPAlink As System.Windows.Forms.LinkLabel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DISTcb As System.Windows.Forms.ComboBox
    Friend WithEvents GRADEcb As System.Windows.Forms.ComboBox
End Class
