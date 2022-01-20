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
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label59 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Dim Label40 As System.Windows.Forms.Label
        Dim Label47 As System.Windows.Forms.Label
        Dim Label48 As System.Windows.Forms.Label
        Dim Label49 As System.Windows.Forms.Label
        Dim Label51 As System.Windows.Forms.Label
        Dim Label55 As System.Windows.Forms.Label
        Dim Label56 As System.Windows.Forms.Label
        Dim Label57 As System.Windows.Forms.Label
        Dim Label61 As System.Windows.Forms.Label
        Dim Label65 As System.Windows.Forms.Label
        Dim Label66 As System.Windows.Forms.Label
        Dim Label67 As System.Windows.Forms.Label
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.View_MS_PONOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSmatalDed = New MatelDedt.DSmatalDed()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
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
        Me.DedCountLabel1 = New System.Windows.Forms.Label()
        Me.Ded1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Ded2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Ded3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Ded4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Ded5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ded1TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded1TableAdapter()
        Me.Ded2TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded2TableAdapter()
        Me.Ded3TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded3TableAdapter()
        Me.Ded4TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded4TableAdapter()
        Me.Ded5TableAdapter = New MatelDedt.DSmatalDedTableAdapters.Ded5TableAdapter()
        Me.View_MS_PONO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_MS_PONO1TableAdapter = New MatelDedt.DSmatalDedTableAdapters.view_MS_PONO1TableAdapter()
        Me.View_MS_PONO11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_MS_PONO11TableAdapter = New MatelDedt.DSmatalDedTableAdapters.view_MS_PONO11TableAdapter()
        Me.View_MS_PONO12BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_MS_PONO12TableAdapter = New MatelDedt.DSmatalDedTableAdapters.view_MS_PONO12TableAdapter()
        Me.View_MS_PONO13BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_MS_PONO13TableAdapter = New MatelDedt.DSmatalDedTableAdapters.view_MS_PONO13TableAdapter()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label59 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        Label40 = New System.Windows.Forms.Label()
        Label47 = New System.Windows.Forms.Label()
        Label48 = New System.Windows.Forms.Label()
        Label49 = New System.Windows.Forms.Label()
        Label51 = New System.Windows.Forms.Label()
        Label55 = New System.Windows.Forms.Label()
        Label56 = New System.Windows.Forms.Label()
        Label57 = New System.Windows.Forms.Label()
        Label61 = New System.Windows.Forms.Label()
        Label65 = New System.Windows.Forms.Label()
        Label66 = New System.Windows.Forms.Label()
        Label67 = New System.Windows.Forms.Label()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSmatalDed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Ded_machineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Matel_dedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Ded_CounterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ded1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ded2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ded3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ded4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ded5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MS_PONO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MS_PONO11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MS_PONO12BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MS_PONO13BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(8, 99)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(147, 25)
        NameLabel.TabIndex = 18
        NameLabel.Text = "Select PO NO :"
        AddHandler NameLabel.Click, AddressOf Me.NameLabel_Click
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(1472, 427)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(194, 31)
        Label4.TabIndex = 24
        Label4.Text = "Total Counter :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(125, 295)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(126, 31)
        Label10.TabIndex = 20
        Label10.Text = "Counter :"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(134, 295)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(126, 31)
        Label11.TabIndex = 21
        Label11.Text = "Counter :"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(152, 298)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(126, 31)
        Label12.TabIndex = 22
        Label12.Text = "Counter :"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(139, 297)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(126, 31)
        Label13.TabIndex = 23
        Label13.Text = "Counter :"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(140, 293)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(126, 31)
        Label14.TabIndex = 24
        Label14.Text = "Counter :"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(6, 99)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(147, 25)
        Label15.TabIndex = 21
        Label15.Text = "Select PO NO :"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(24, 103)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(147, 25)
        Label16.TabIndex = 23
        Label16.Text = "Select PO NO :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(15, 100)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(147, 25)
        Label17.TabIndex = 25
        Label17.Text = "Select PO NO :"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(12, 98)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(147, 25)
        Label22.TabIndex = 27
        Label22.Text = "Select PO NO :"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.Location = New System.Drawing.Point(8, 137)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(141, 25)
        Label23.TabIndex = 121
        Label23.Text = "Factory Code :"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.Location = New System.Drawing.Point(8, 173)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(77, 25)
        Label29.TabIndex = 122
        Label29.Text = "Article :"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.Location = New System.Drawing.Point(8, 243)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(146, 25)
        Label30.TabIndex = 123
        Label30.Text = "Order Quantity:"
        '
        'Label59
        '
        Label59.AutoSize = True
        Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label59.Location = New System.Drawing.Point(8, 209)
        Label59.Name = "Label59"
        Label59.Size = New System.Drawing.Size(62, 25)
        Label59.TabIndex = 127
        Label59.Text = "Size :"
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label32.Location = New System.Drawing.Point(5, 212)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(62, 25)
        Label32.TabIndex = 135
        Label32.Text = "Size :"
        '
        'Label36
        '
        Label36.AutoSize = True
        Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label36.Location = New System.Drawing.Point(1, 244)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(146, 25)
        Label36.TabIndex = 131
        Label36.Text = "Order Quantity:"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label37.Location = New System.Drawing.Point(1, 174)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(77, 25)
        Label37.TabIndex = 130
        Label37.Text = "Article :"
        '
        'Label38
        '
        Label38.AutoSize = True
        Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label38.Location = New System.Drawing.Point(1, 138)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(141, 25)
        Label38.TabIndex = 129
        Label38.Text = "Factory Code :"
        '
        'Label40
        '
        Label40.AutoSize = True
        Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label40.Location = New System.Drawing.Point(19, 213)
        Label40.Name = "Label40"
        Label40.Size = New System.Drawing.Size(62, 25)
        Label40.TabIndex = 143
        Label40.Text = "Size :"
        '
        'Label47
        '
        Label47.AutoSize = True
        Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label47.Location = New System.Drawing.Point(19, 247)
        Label47.Name = "Label47"
        Label47.Size = New System.Drawing.Size(146, 25)
        Label47.TabIndex = 139
        Label47.Text = "Order Quantity:"
        '
        'Label48
        '
        Label48.AutoSize = True
        Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label48.Location = New System.Drawing.Point(19, 177)
        Label48.Name = "Label48"
        Label48.Size = New System.Drawing.Size(77, 25)
        Label48.TabIndex = 138
        Label48.Text = "Article :"
        '
        'Label49
        '
        Label49.AutoSize = True
        Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label49.Location = New System.Drawing.Point(19, 141)
        Label49.Name = "Label49"
        Label49.Size = New System.Drawing.Size(141, 25)
        Label49.TabIndex = 137
        Label49.Text = "Factory Code :"
        '
        'Label51
        '
        Label51.AutoSize = True
        Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label51.Location = New System.Drawing.Point(15, 206)
        Label51.Name = "Label51"
        Label51.Size = New System.Drawing.Size(62, 25)
        Label51.TabIndex = 151
        Label51.Text = "Size :"
        '
        'Label55
        '
        Label55.AutoSize = True
        Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label55.Location = New System.Drawing.Point(15, 240)
        Label55.Name = "Label55"
        Label55.Size = New System.Drawing.Size(146, 25)
        Label55.TabIndex = 147
        Label55.Text = "Order Quantity:"
        '
        'Label56
        '
        Label56.AutoSize = True
        Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label56.Location = New System.Drawing.Point(15, 170)
        Label56.Name = "Label56"
        Label56.Size = New System.Drawing.Size(77, 25)
        Label56.TabIndex = 146
        Label56.Text = "Article :"
        '
        'Label57
        '
        Label57.AutoSize = True
        Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label57.Location = New System.Drawing.Point(15, 134)
        Label57.Name = "Label57"
        Label57.Size = New System.Drawing.Size(141, 25)
        Label57.TabIndex = 145
        Label57.Text = "Factory Code :"
        '
        'Label61
        '
        Label61.AutoSize = True
        Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label61.Location = New System.Drawing.Point(7, 208)
        Label61.Name = "Label61"
        Label61.Size = New System.Drawing.Size(62, 25)
        Label61.TabIndex = 159
        Label61.Text = "Size :"
        '
        'Label65
        '
        Label65.AutoSize = True
        Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label65.Location = New System.Drawing.Point(7, 242)
        Label65.Name = "Label65"
        Label65.Size = New System.Drawing.Size(146, 25)
        Label65.TabIndex = 155
        Label65.Text = "Order Quantity:"
        '
        'Label66
        '
        Label66.AutoSize = True
        Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label66.Location = New System.Drawing.Point(7, 172)
        Label66.Name = "Label66"
        Label66.Size = New System.Drawing.Size(77, 25)
        Label66.TabIndex = 154
        Label66.Text = "Article :"
        '
        'Label67
        '
        Label67.AutoSize = True
        Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label67.Location = New System.Drawing.Point(7, 136)
        Label67.Name = "Label67"
        Label67.Size = New System.Drawing.Size(141, 25)
        Label67.TabIndex = 153
        Label67.Text = "Factory Code :"
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
        Me.Label2.Location = New System.Drawing.Point(0, 814)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1756, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stoped!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POD", True))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(876, 495)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 137)
        Me.Label8.TabIndex = 15
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(426, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(400, 70)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(426, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(400, 70)
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
        Me.NameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(160, 96)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(237, 33)
        Me.NameComboBox.TabIndex = 19
        Me.NameComboBox.ValueMember = "PO"
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
        Me.Button3.Location = New System.Drawing.Point(1450, 602)
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
        Me.Label3.Location = New System.Drawing.Point(1450, 442)
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
        Me.Label5.Size = New System.Drawing.Size(1756, 50)
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
        'DedCountLabel1
        '
        Me.DedCountLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DedCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded1BindingSource, "DedCount", True))
        Me.DedCountLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DedCountLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DedCountLabel1.Location = New System.Drawing.Point(273, 283)
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
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded2BindingSource, "DedCount", True))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(266, 283)
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
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded3BindingSource, "DedCount", True))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(284, 286)
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
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded4BindingSource, "DedCount", True))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(280, 285)
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
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ded5BindingSource, "DedCount", True))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(272, 281)
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
        'View_MS_PONO1BindingSource
        '
        Me.View_MS_PONO1BindingSource.DataMember = "view_MS_PONO1"
        Me.View_MS_PONO1BindingSource.DataSource = Me.DSmatalDed
        '
        'View_MS_PONO1TableAdapter
        '
        Me.View_MS_PONO1TableAdapter.ClearBeforeFill = True
        '
        'View_MS_PONO11BindingSource
        '
        Me.View_MS_PONO11BindingSource.DataMember = "view_MS_PONO11"
        Me.View_MS_PONO11BindingSource.DataSource = Me.DSmatalDed
        '
        'View_MS_PONO11TableAdapter
        '
        Me.View_MS_PONO11TableAdapter.ClearBeforeFill = True
        '
        'View_MS_PONO12BindingSource
        '
        Me.View_MS_PONO12BindingSource.DataMember = "view_MS_PONO12"
        Me.View_MS_PONO12BindingSource.DataSource = Me.DSmatalDed
        '
        'View_MS_PONO12TableAdapter
        '
        Me.View_MS_PONO12TableAdapter.ClearBeforeFill = True
        '
        'View_MS_PONO13BindingSource
        '
        Me.View_MS_PONO13BindingSource.DataMember = "view_MS_PONO13"
        Me.View_MS_PONO13BindingSource.DataSource = Me.DSmatalDed
        '
        'View_MS_PONO13TableAdapter
        '
        Me.View_MS_PONO13TableAdapter.ClearBeforeFill = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(20, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 33)
        Me.RadioButton1.TabIndex = 118
        Me.RadioButton1.Text = "Active"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(3, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 61)
        Me.Panel1.TabIndex = 119
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(136, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(129, 33)
        Me.RadioButton2.TabIndex = 119
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "In Active"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RadioButton3)
        Me.Panel2.Controls.Add(Me.RadioButton4)
        Me.Panel2.Location = New System.Drawing.Point(4, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 61)
        Me.Panel2.TabIndex = 120
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(136, 13)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(129, 33)
        Me.RadioButton3.TabIndex = 119
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "In Active"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(20, 13)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(101, 33)
        Me.RadioButton4.TabIndex = 118
        Me.RadioButton4.Text = "Active"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RadioButton5)
        Me.Panel3.Controls.Add(Me.RadioButton6)
        Me.Panel3.Location = New System.Drawing.Point(5, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 61)
        Me.Panel3.TabIndex = 120
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(136, 13)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(129, 33)
        Me.RadioButton5.TabIndex = 119
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "In Active"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(20, 13)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(101, 33)
        Me.RadioButton6.TabIndex = 118
        Me.RadioButton6.Text = "Active"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RadioButton7)
        Me.Panel4.Controls.Add(Me.RadioButton8)
        Me.Panel4.Location = New System.Drawing.Point(4, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 61)
        Me.Panel4.TabIndex = 120
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(136, 13)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(129, 33)
        Me.RadioButton7.TabIndex = 119
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "In Active"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(20, 13)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(101, 33)
        Me.RadioButton8.TabIndex = 118
        Me.RadioButton8.Text = "Active"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.RadioButton9)
        Me.Panel5.Controls.Add(Me.RadioButton10)
        Me.Panel5.Location = New System.Drawing.Point(3, 28)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 61)
        Me.Panel5.TabIndex = 120
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Checked = True
        Me.RadioButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.Location = New System.Drawing.Point(136, 13)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(129, 33)
        Me.RadioButton9.TabIndex = 119
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "In Active"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton10.Location = New System.Drawing.Point(20, 13)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(101, 33)
        Me.RadioButton10.TabIndex = 118
        Me.RadioButton10.Text = "Active"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.View_MS_PONO1BindingSource
        Me.ComboBox1.DisplayMember = "POCode"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(153, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(237, 33)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.ValueMember = "PO"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.View_MS_PONO11BindingSource
        Me.ComboBox2.DisplayMember = "POCode"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(171, 100)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(237, 33)
        Me.ComboBox2.TabIndex = 24
        Me.ComboBox2.ValueMember = "PO"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataSource = Me.View_MS_PONO12BindingSource
        Me.ComboBox3.DisplayMember = "POCode"
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(167, 97)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(237, 33)
        Me.ComboBox3.TabIndex = 26
        Me.ComboBox3.ValueMember = "PO"
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.DataSource = Me.View_MS_PONO13BindingSource
        Me.ComboBox4.DisplayMember = "POCode"
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(160, 95)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(236, 33)
        Me.ComboBox4.TabIndex = 28
        Me.ComboBox4.ValueMember = "PO"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label60)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Label61)
        Me.Panel7.Controls.Add(Me.ComboBox4)
        Me.Panel7.Controls.Add(Me.Label62)
        Me.Panel7.Controls.Add(Label22)
        Me.Panel7.Controls.Add(Me.Label63)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Controls.Add(Me.Label64)
        Me.Panel7.Controls.Add(Label65)
        Me.Panel7.Controls.Add(Label14)
        Me.Panel7.Controls.Add(Label66)
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Controls.Add(Label67)
        Me.Panel7.Location = New System.Drawing.Point(3, 417)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(410, 344)
        Me.Panel7.TabIndex = 122
        '
        'Label60
        '
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label60.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO13BindingSource, "ArtSize", True))
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(159, 208)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(237, 29)
        Me.Label60.TabIndex = 160
        Me.Label60.Text = "Label60"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label24.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(0, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(408, 25)
        Me.Label24.TabIndex = 120
        Me.Label24.Text = "Metal Detector  5"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label62.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO13BindingSource, "OrderQty", True))
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(159, 241)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(237, 29)
        Me.Label62.TabIndex = 158
        Me.Label62.Text = "Label62"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label63
        '
        Me.Label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label63.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO13BindingSource, "ArtCode", True))
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(159, 172)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(237, 29)
        Me.Label63.TabIndex = 157
        Me.Label63.Text = "Label63"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label64.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO13BindingSource, "FactoryCode", True))
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(159, 135)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(237, 29)
        Me.Label64.TabIndex = 156
        Me.Label64.Text = "Label64"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label50)
        Me.Panel8.Controls.Add(Me.Label25)
        Me.Panel8.Controls.Add(Label51)
        Me.Panel8.Controls.Add(Me.ComboBox3)
        Me.Panel8.Controls.Add(Me.Label52)
        Me.Panel8.Controls.Add(Label17)
        Me.Panel8.Controls.Add(Me.Label53)
        Me.Panel8.Controls.Add(Me.Label20)
        Me.Panel8.Controls.Add(Me.Label54)
        Me.Panel8.Controls.Add(Label55)
        Me.Panel8.Controls.Add(Label13)
        Me.Panel8.Controls.Add(Label56)
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Controls.Add(Label57)
        Me.Panel8.Location = New System.Drawing.Point(1285, 55)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(440, 353)
        Me.Panel8.TabIndex = 122
        '
        'Label50
        '
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label50.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO12BindingSource, "ArtSize", True))
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(167, 206)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(237, 29)
        Me.Label50.TabIndex = 152
        Me.Label50.Text = "Label50"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label25.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(438, 25)
        Me.Label25.TabIndex = 120
        Me.Label25.Text = "Metal Detector  4 "
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO12BindingSource, "OrderQty", True))
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(167, 239)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(237, 29)
        Me.Label52.TabIndex = 150
        Me.Label52.Text = "Label52"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO12BindingSource, "ArtCode", True))
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(167, 170)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(237, 29)
        Me.Label53.TabIndex = 149
        Me.Label53.Text = "Label53"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO12BindingSource, "FactoryCode", True))
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(167, 133)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(237, 29)
        Me.Label54.TabIndex = 148
        Me.Label54.Text = "Label54"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label39)
        Me.Panel9.Controls.Add(Me.ComboBox2)
        Me.Panel9.Controls.Add(Label40)
        Me.Panel9.Controls.Add(Label16)
        Me.Panel9.Controls.Add(Me.Label41)
        Me.Panel9.Controls.Add(Me.Label26)
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Label12)
        Me.Panel9.Controls.Add(Me.Label46)
        Me.Panel9.Controls.Add(Label47)
        Me.Panel9.Controls.Add(Me.Panel3)
        Me.Panel9.Controls.Add(Label48)
        Me.Panel9.Controls.Add(Me.Label19)
        Me.Panel9.Controls.Add(Label49)
        Me.Panel9.Location = New System.Drawing.Point(843, 54)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(428, 352)
        Me.Panel9.TabIndex = 122
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO11BindingSource, "ArtSize", True))
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(171, 213)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(237, 29)
        Me.Label39.TabIndex = 144
        Me.Label39.Text = "Label39"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO11BindingSource, "OrderQty", True))
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(171, 246)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(237, 29)
        Me.Label41.TabIndex = 142
        Me.Label41.Text = "Label41"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label26.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(0, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(426, 25)
        Me.Label26.TabIndex = 120
        Me.Label26.Text = "Metal Detector  3 "
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO11BindingSource, "ArtCode", True))
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(171, 177)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(237, 29)
        Me.Label42.TabIndex = 141
        Me.Label42.Text = "Label42"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO11BindingSource, "FactoryCode", True))
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(171, 140)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(237, 29)
        Me.Label46.TabIndex = 140
        Me.Label46.Text = "Label46"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Label31)
        Me.Panel10.Controls.Add(Me.Label27)
        Me.Panel10.Controls.Add(Label32)
        Me.Panel10.Controls.Add(Me.ComboBox1)
        Me.Panel10.Controls.Add(Me.Label33)
        Me.Panel10.Controls.Add(Label15)
        Me.Panel10.Controls.Add(Me.Label34)
        Me.Panel10.Controls.Add(Me.Panel2)
        Me.Panel10.Controls.Add(Me.Label35)
        Me.Panel10.Controls.Add(Label36)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Controls.Add(Label37)
        Me.Panel10.Controls.Add(Label11)
        Me.Panel10.Controls.Add(Label38)
        Me.Panel10.Location = New System.Drawing.Point(426, 53)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(411, 353)
        Me.Panel10.TabIndex = 122
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO1BindingSource, "ArtSize", True))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(153, 210)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(237, 29)
        Me.Label31.TabIndex = 136
        Me.Label31.Text = "Label31"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label27.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(0, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(409, 25)
        Me.Label27.TabIndex = 120
        Me.Label27.Text = "Metal Detector  2 "
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO1BindingSource, "OrderQty", True))
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(153, 243)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(237, 29)
        Me.Label33.TabIndex = 134
        Me.Label33.Text = "Label33"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO1BindingSource, "ArtCode", True))
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(153, 174)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(237, 29)
        Me.Label34.TabIndex = 133
        Me.Label34.Text = "Label34"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO1BindingSource, "FactoryCode", True))
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(153, 137)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(237, 29)
        Me.Label35.TabIndex = 132
        Me.Label35.Text = "Label35"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Label58)
        Me.Panel11.Controls.Add(Label59)
        Me.Panel11.Controls.Add(Me.Label45)
        Me.Panel11.Controls.Add(Me.Label44)
        Me.Panel11.Controls.Add(Me.Label43)
        Me.Panel11.Controls.Add(Label30)
        Me.Panel11.Controls.Add(Label29)
        Me.Panel11.Controls.Add(Label23)
        Me.Panel11.Controls.Add(Me.Label28)
        Me.Panel11.Controls.Add(Me.NameComboBox)
        Me.Panel11.Controls.Add(Me.Panel1)
        Me.Panel11.Controls.Add(Label10)
        Me.Panel11.Controls.Add(NameLabel)
        Me.Panel11.Controls.Add(Me.DedCountLabel1)
        Me.Panel11.Location = New System.Drawing.Point(3, 53)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(410, 353)
        Me.Panel11.TabIndex = 122
        '
        'Label58
        '
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label58.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtSize", True))
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(160, 209)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(237, 29)
        Me.Label58.TabIndex = 128
        Me.Label58.Text = "Label58"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "OrderQty", True))
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(160, 242)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(237, 29)
        Me.Label45.TabIndex = 126
        Me.Label45.Text = "Label45"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label44.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtCode", True))
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(160, 173)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(237, 29)
        Me.Label44.TabIndex = 125
        Me.Label44.Text = "Label44"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "FactoryCode", True))
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(160, 136)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(237, 29)
        Me.Label43.TabIndex = 124
        Me.Label43.Text = "Label43"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label28.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(0, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(408, 25)
        Me.Label28.TabIndex = 120
        Me.Label28.Text = "Metal Detector 1"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO1BindingSource, "PO", True))
        Me.Label68.ForeColor = System.Drawing.Color.White
        Me.Label68.Location = New System.Drawing.Point(523, 429)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(45, 13)
        Me.Label68.TabIndex = 123
        Me.Label68.Text = "Label68"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO1BindingSource, "POM", True))
        Me.Label69.ForeColor = System.Drawing.Color.White
        Me.Label69.Location = New System.Drawing.Point(574, 430)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(45, 13)
        Me.Label69.TabIndex = 124
        Me.Label69.Text = "Label69"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO1BindingSource, "POD", True))
        Me.Label70.ForeColor = System.Drawing.Color.White
        Me.Label70.Location = New System.Drawing.Point(625, 429)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(45, 13)
        Me.Label70.TabIndex = 125
        Me.Label70.Text = "Label70"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO11BindingSource, "PO", True))
        Me.Label71.ForeColor = System.Drawing.Color.White
        Me.Label71.Location = New System.Drawing.Point(926, 442)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(45, 13)
        Me.Label71.TabIndex = 126
        Me.Label71.Text = "Label71"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO11BindingSource, "POM", True))
        Me.Label72.ForeColor = System.Drawing.Color.White
        Me.Label72.Location = New System.Drawing.Point(983, 445)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(45, 13)
        Me.Label72.TabIndex = 127
        Me.Label72.Text = "Label72"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO11BindingSource, "POD", True))
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(1055, 442)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(45, 13)
        Me.Label73.TabIndex = 128
        Me.Label73.Text = "Label73"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO12BindingSource, "PO", True))
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(1308, 426)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(45, 13)
        Me.Label74.TabIndex = 129
        Me.Label74.Text = "Label74"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO12BindingSource, "POM", True))
        Me.Label75.ForeColor = System.Drawing.Color.White
        Me.Label75.Location = New System.Drawing.Point(1367, 429)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(45, 13)
        Me.Label75.TabIndex = 130
        Me.Label75.Text = "Label75"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO12BindingSource, "POD", True))
        Me.Label76.ForeColor = System.Drawing.Color.White
        Me.Label76.Location = New System.Drawing.Point(1424, 426)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(45, 13)
        Me.Label76.TabIndex = 131
        Me.Label76.Text = "Label76"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO13BindingSource, "PO", True))
        Me.Label77.ForeColor = System.Drawing.Color.White
        Me.Label77.Location = New System.Drawing.Point(43, 778)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(45, 13)
        Me.Label77.TabIndex = 132
        Me.Label77.Text = "Label77"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO13BindingSource, "POM", True))
        Me.Label78.ForeColor = System.Drawing.Color.White
        Me.Label78.Location = New System.Drawing.Point(118, 778)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(45, 13)
        Me.Label78.TabIndex = 133
        Me.Label78.Text = "Label78"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONO13BindingSource, "POD", True))
        Me.Label79.ForeColor = System.Drawing.Color.White
        Me.Label79.Location = New System.Drawing.Point(210, 778)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(45, 13)
        Me.Label79.TabIndex = 134
        Me.Label79.Text = "Label79"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1756, 828)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
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
        CType(Me.Ded1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ded2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ded3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ded4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ded5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MS_PONO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MS_PONO11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MS_PONO12BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MS_PONO13BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
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
    Friend WithEvents View_MS_PONO1BindingSource As BindingSource
    Friend WithEvents View_MS_PONO1TableAdapter As DSmatalDedTableAdapters.view_MS_PONO1TableAdapter
    Friend WithEvents View_MS_PONO11BindingSource As BindingSource
    Friend WithEvents View_MS_PONO11TableAdapter As DSmatalDedTableAdapters.view_MS_PONO11TableAdapter
    Friend WithEvents View_MS_PONO12BindingSource As BindingSource
    Friend WithEvents View_MS_PONO12TableAdapter As DSmatalDedTableAdapters.view_MS_PONO12TableAdapter
    Friend WithEvents View_MS_PONO13BindingSource As BindingSource
    Friend WithEvents View_MS_PONO13TableAdapter As DSmatalDedTableAdapters.view_MS_PONO13TableAdapter
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
End Class
