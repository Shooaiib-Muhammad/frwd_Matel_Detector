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
        NameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSmatalDed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Ded_machineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Matel_dedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Ded_CounterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(12, 81)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(294, 46)
        NameLabel.TabIndex = 18
        NameLabel.Text = "Select PO NO :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(662, 71)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(126, 31)
        Label4.TabIndex = 24
        Label4.Text = "Counter :"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
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
        Me.Label2.Location = New System.Drawing.Point(0, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(948, 14)
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
        Me.Button1.Location = New System.Drawing.Point(248, 196)
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
        Me.Button2.Location = New System.Drawing.Point(12, 196)
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
        Me.NameComboBox.Location = New System.Drawing.Point(9, 129)
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
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(648, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(277, 40)
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
        Me.Label3.Location = New System.Drawing.Point(648, 92)
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
        Me.Label5.Size = New System.Drawing.Size(948, 50)
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
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(603, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POM", True))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(603, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Label7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POD", True))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(603, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Label9"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(948, 389)
        Me.ControlBox = False
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
End Class
