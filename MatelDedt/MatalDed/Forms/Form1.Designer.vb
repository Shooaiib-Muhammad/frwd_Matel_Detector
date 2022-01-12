<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_MS_PONOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSmatalDed = New MatelDedt.DSmatalDed()
        Me.Tbl_Ded_machineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Ded_machineTableAdapter = New MatelDedt.DSmatalDedTableAdapters.Tbl_Ded_machineTableAdapter()
        Me.TableAdapterManager = New MatelDedt.DSmatalDedTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Tbl_Matel_dedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Matel_dedTableAdapter = New MatelDedt.DSmatalDedTableAdapters.tbl_Matel_dedTableAdapter()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New MatelDedt.DSmatalDedTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.View_Ded_CounterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Ded_CounterTableAdapter = New MatelDedt.DSmatalDedTableAdapters.view_Ded_CounterTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.View_MS_PONOTableAdapter = New MatelDedt.DSmatalDedTableAdapters.view_MS_PONOTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DedCountLabel1 = New System.Windows.Forms.Label()
        Me.Ded1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Ded2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Ded3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Ded4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Ded5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ded1TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded1TableAdapter()
        Me.Ded2TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded2TableAdapter()
        Me.Ded3TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded3TableAdapter()
        Me.Ded4TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded4TableAdapter()
        Me.Ded5TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded5TableAdapter()
        NameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSmatalDed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Ded_machineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Matel_dedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Ded_CounterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ded1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Ded2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Ded3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Ded4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Ded5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(11, 55)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(294, 46)
        NameLabel.TabIndex = 18
        NameLabel.Text = "Select PO NO :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(1176, 384)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(194, 31)
        Label4.TabIndex = 24
        Label4.Text = "Total Counter :"
        '
        'Label13
        '
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(1231, 59)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(305, 47)
        Label13.TabIndex = 111
        Label13.Text = "Order Quantity :"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(461, 63)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(283, 46)
        Label14.TabIndex = 110
        Label14.Text = "Factory Code :"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(1070, 64)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(120, 46)
        Label15.TabIndex = 109
        Label15.Text = "Size :"
        '
        'Label17
        '
        Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(758, 64)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(262, 44)
        Label17.TabIndex = 108
        Label17.Text = "Article Code :"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(0, 670)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1556, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stoped!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(265, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 94)
        Me.Label8.TabIndex = 15
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(248, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 70)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(34, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 70)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.View_MS_PONOBindingSource
        Me.NameComboBox.DisplayMember = "POCode"
        Me.NameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(8, 104)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(443, 54)
        Me.NameComboBox.TabIndex = 19
        Me.NameComboBox.ValueMember = "PO"
        '
        'View_MS_PONOBindingSource
        '
        Me.View_MS_PONOBindingSource.DataMember = "view_MS_PONO"
        Me.View_MS_PONOBindingSource.DataSource = Me.DSmatalDed
        '
        'DSmatalDed
        '
        Me.DSmatalDed.DataSetName = "DSmatalDed"
        Me.DSmatalDed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Ded_machineBindingSource
        '
        Me.Tbl_Ded_machineBindingSource.DataMember = "Tbl_Ded_machine"
        Me.Tbl_Ded_machineBindingSource.DataSource = Me.DSmatalDed
        '
        'Tbl_Ded_machineTableAdapter
        '
        Me.Tbl_Ded_machineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tbl_Ded_machineTableAdapter = Me.Tbl_Ded_machineTableAdapter
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Matel_dedTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MatelDedt.DSmatalDedTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1154, 559)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(282, 61)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Tbl_Matel_dedBindingSource
        '
        Me.Tbl_Matel_dedBindingSource.DataMember = "tbl_Matel_ded"
        Me.Tbl_Matel_dedBindingSource.DataSource = Me.DSmatalDed
        '
        'Tbl_Matel_dedTableAdapter
        '
        Me.Tbl_Matel_dedTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSmatalDed
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(848, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Ded_CounterBindingSource, "DedCount", True))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(1154, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 139)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Ded_CounterBindingSource
        '
        Me.View_Ded_CounterBindingSource.DataMember = "view_Ded_Counter"
        Me.View_Ded_CounterBindingSource.DataSource = Me.DSmatalDed
        '
        'View_Ded_CounterTableAdapter
        '
        Me.View_Ded_CounterTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1556, 50)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Metal Detector Indicator"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_MS_PONOTableAdapter
        '
        Me.View_MS_PONOTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "PO", True))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1050, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 46)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POM", True))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1050, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 46)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Label7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POD", True))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(603, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 46)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Label9"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtSize", True))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1062, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 44)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Label12"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtCode", True))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(758, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(260, 44)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "OrderQty", True))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1231, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(305, 47)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "FactoryCode", True))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(467, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(261, 50)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Label16"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DedCountLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 153)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1 Counter :"
        '
        'DedCountLabel1
        '
        Me.DedCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded1BindingSource, "DedCount", True))
        Me.DedCountLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DedCountLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DedCountLabel1.Location = New System.Drawing.Point(64, 59)
        Me.DedCountLabel1.Name = "DedCountLabel1"
        Me.DedCountLabel1.Size = New System.Drawing.Size(124, 54)
        Me.DedCountLabel1.TabIndex = 1
        Me.DedCountLabel1.Text = "Label18"
        Me.DedCountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ded1BindingSource
        '
        Me.Ded1BindingSource.DataMember = "Ded1"
        Me.Ded1BindingSource.DataSource = Me.DSmatalDed
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(289, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 153)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Machine 2 Counter :"
        '
        'Label18
        '
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded2BindingSource, "DedCount", True))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(91, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 54)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Label18"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ded2BindingSource
        '
        Me.Ded2BindingSource.DataMember = "Ded2"
        Me.Ded2BindingSource.DataSource = Me.DSmatalDed
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(579, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 153)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Machine 3 Counter :"
        '
        'Label19
        '
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded3BindingSource, "DedCount", True))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(59, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 54)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Label18"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ded3BindingSource
        '
        Me.Ded3BindingSource.DataMember = "Ded3"
        Me.Ded3BindingSource.DataSource = Me.DSmatalDed
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(860, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(275, 153)
        Me.GroupBox4.TabIndex = 117
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Machine 4 Counter :"
        '
        'Label20
        '
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded4BindingSource, "DedCount", True))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(67, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 54)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Label18"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ded4BindingSource
        '
        Me.Ded4BindingSource.DataMember = "Ded4"
        Me.Ded4BindingSource.DataSource = Me.DSmatalDed
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(1161, 202)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(275, 153)
        Me.GroupBox5.TabIndex = 117
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Machine 5 Counter :"
        '
        'Label21
        '
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded5BindingSource, "DedCount", True))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(85, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 54)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Label18"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ded5BindingSource
        '
        Me.Ded5BindingSource.DataMember = "Ded5"
        Me.Ded5BindingSource.DataSource = Me.DSmatalDed
        '
        'Ded1TableAdapter
        '
        Me.Ded1TableAdapter.ClearBeforeFill = True
        '
        'Ded2TableAdapter
        '
        Me.Ded2TableAdapter.ClearBeforeFill = True
        '
        'Ded3TableAdapter
        '
        Me.Ded3TableAdapter.ClearBeforeFill = True
        '
        'Ded4TableAdapter
        '
        Me.Ded4TableAdapter.ClearBeforeFill = True
        '
        'Ded5TableAdapter
        '
        Me.Ded5TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1556, 684)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSmatalDed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Ded_machineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Matel_dedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Ded_CounterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Ded1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Ded2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Ded3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Ded4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Ded5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DSmatalDed As DSmatalDed
    Friend WithEvents Tbl_Ded_machineBindingSource As BindingSource
    Friend WithEvents Tbl_Ded_machineTableAdapter As DSmatalDedTableAdapters.Tbl_Ded_machineTableAdapter
    Friend WithEvents TableAdapterManager As DSmatalDedTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Ded_machineBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_Ded_machineBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Tbl_Matel_dedBindingSource As BindingSource
    Friend WithEvents Tbl_Matel_dedTableAdapter As DSmatalDedTableAdapters.tbl_Matel_dedTableAdapter
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As DSmatalDedTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents DateNameToolStripLabel As ToolStripLabel
    Friend WithEvents DateNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents View_Ded_CounterBindingSource As BindingSource
    Friend WithEvents View_Ded_CounterTableAdapter As DSmatalDedTableAdapters.view_Ded_CounterTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents View_MS_PONOBindingSource As BindingSource
    Friend WithEvents View_MS_PONOTableAdapter As DSmatalDedTableAdapters.view_MS_PONOTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Ded1BindingSource As BindingSource
    Friend WithEvents Ded1TableAdapter As DSmatalDedTableAdapters.Ded1TableAdapter
    Friend WithEvents DedCountLabel1 As Label
    Friend WithEvents Ded2BindingSource As BindingSource
    Friend WithEvents Ded2TableAdapter As DSmatalDedTableAdapters.Ded2TableAdapter
    Friend WithEvents Ded3BindingSource As BindingSource
    Friend WithEvents Ded3TableAdapter As DSmatalDedTableAdapters.Ded3TableAdapter
    Friend WithEvents Ded4BindingSource As BindingSource
    Friend WithEvents Ded4TableAdapter As DSmatalDedTableAdapters.Ded4TableAdapter
    Friend WithEvents Ded5BindingSource As BindingSource
    Friend WithEvents Ded5TableAdapter As DSmatalDedTableAdapters.Ded5TableAdapter
    Friend WithEvents FillToolStrip1 As ToolStrip
    Friend WithEvents DayIDToolStripLabel As ToolStripLabel
    Friend WithEvents DayIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton1 As ToolStripButton
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
End Class
