Imports System.Threading


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO13' table. You can move, or remove it, as needed.
        Try
            Me.View_MS_PONO13TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO13)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO12' table. You can move, or remove it, as needed.
        Try
            Me.View_MS_PONO12TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO12)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO11' table. You can move, or remove it, as needed.
        Try
            Me.View_MS_PONO11TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO11)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO1' table. You can move, or remove it, as needed.
        Try
            Me.View_MS_PONO1TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO1)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO' table. You can move, or remove it, as needed.
        Try
            Me.View_MS_PONOTableAdapter.Fill(Me.DSmatalDed.view_MS_PONO)

        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSmatalDed.tbl_Matel_ded' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Matel_dedTableAdapter.Fill(Me.DSmatalDed.tbl_Matel_ded)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSmatalDed.Tbl_Ded_machine' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Ded_machineTableAdapter.Fill(Me.DSmatalDed.Tbl_Ded_machine)
        Catch ex As Exception

        End Try



        Me.Timer1.Interval = 4000

        Me.Timer2.Interval = 1000
        Try
            Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSmatalDed.tbl_Inv_Tran_Date, Now.Date)
        Catch ex As Exception

        End Try
        loadData()
    End Sub

    Dim StartClick = False

    Dim t As New Thread(Sub()
                            While (True)
                                loadData()

                                If StartClick Then
                                    Dim Machinename As String
LastLine:
                                    Try
                                        Me.SerialPort1.Open()
                                    Catch ex As Exception

                                    End Try


                                    If (Me.SerialPort1.IsOpen) Then
                                        Dim Incoming As String
                                        Try
                                            Incoming = Me.SerialPort1.ReadLine()
                                        Catch ex As Exception
                                            MsgBox(ex.Message)
                                        End Try
                                        'If Incoming = "machine 1" & vbCr Then
                                        '    Machinename = "Metal Ded 1"
                                        '    If RadioButton1.Checked = True Then

                                        '        Try
                                        '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename, 0)
                                        '            loadData()

                                        '        Catch ex As Exception
                                        '        End Try

                                        '    End If

                                        'Else
                                        If Incoming = "1" & vbCr Then
                                            Machinename = "1"
                                            If RadioButton1.Checked = True Then

                                                Try
                                                    Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename, 1)


                                                Catch ex As Exception
                                                End Try

                                            End If


                                        ElseIf Incoming = "2" & vbCr Then

                                            Machinename = "2"
                                            If RadioButton4.Checked = True Then

                                                Try
                                                    Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label68.Text), Val(Label69.Text), Val(Label70.Text), Machinename, 1)


                                                Catch ex As Exception
                                                End Try

                                            End If
                                        ElseIf Incoming = "3" & vbCr Then
                                            Machinename = "3"
                                            If RadioButton1.Checked = True Then
                                                Dim dayid As Int64
                                                dayid = Label81.Text
                                                Try
                                                    Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename, 1)


                                                Catch ex As Exception
                                                End Try
                                                loadData()
                                            End If
                                        ElseIf Incoming = "4" & vbCr Then
                                            Machinename = "4"
                                            If RadioButton1.Checked = True Then
                                                Dim dayid As Int64
                                                dayid = Label81.Text
                                                Try
                                                    Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename, 1)
                                                    Try
                                                        Me.DataTable1TableAdapter.Fill(Me.DSmatalDed.DataTable1, dayid)
                                                    Catch ex As Exception

                                                    End Try

                                                Catch ex As Exception
                                                End Try

                                            End If
                                        ElseIf Incoming = "5" & vbCr Then
                                            Machinename = "5"
                                            If RadioButton1.Checked = True Then
                                                Dim dayid As Int64
                                                dayid = Label81.Text
                                                Try
                                                    Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename, 1)
                                                    Try
                                                        Me.DataTable1TableAdapter.Fill(Me.DSmatalDed.DataTable1, dayid)
                                                    Catch ex As Exception

                                                    End Try

                                                Catch ex As Exception
                                                End Try

                                            End If
                                            'ElseIf Incoming = "machine 1" & vbCr Then

                                            '    Machinename = "Metal Ded 2"
                                            '    If RadioButton4.Checked = True Then

                                            '        Try
                                            '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label68.Text), Val(Label69.Text), Val(Label70.Text), Machinename, 0)
                                            '            loadData()

                                            '        Catch ex As Exception
                                            '        End Try

                                            '    End If

                                            'ElseIf Incoming = "machine 2" & vbCr Then

                                            '    Machinename = "Metal Ded 2"
                                            '    If RadioButton4.Checked = True Then

                                            '        Try
                                            '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label68.Text), Val(Label69.Text), Val(Label70.Text), Machinename, 0)
                                            '            loadData()

                                            '        Catch ex As Exception
                                            '        End Try

                                            '    End If

                                            'ElseIf Incoming = "machine 3" & vbCr Then
                                            '    Machinename = "Metal Ded 3"
                                            '    If RadioButton4.Checked = True Then

                                            '        Try
                                            '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label71.Text), Val(Label72.Text), Val(Label73.Text), Machinename, 0)
                                            '            loadData()

                                            '        Catch ex As Exception
                                            '        End Try

                                            '    End If

                                            'ElseIf Incoming = "machine 4" & vbCr Then
                                            '    Machinename = "Metal Ded 4"
                                            '    If RadioButton6.Checked = True Then

                                            '        Try
                                            '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label74.Text), Val(Label75.Text), Val(Label76.Text), Machinename, 0)
                                            '            loadData()

                                            '        Catch ex As Exception
                                            '        End Try

                                            '    End If

                                            'ElseIf Incoming = "machine 5" & vbCr Then
                                            '    Machinename = "Metal Ded 5"
                                            '    If RadioButton8.Checked = True Then

                                            '        Try
                                            '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label77.Text), Val(Label78.Text), Val(Label79.Text), Machinename, 0)
                                            '            loadData()

                                            '        Catch ex As Exception
                                            '        End Try

                                            '    End If

                                            'Else
                                            'GoTo LastLine
                                        End If
                                        loadData()

                                    End If


                                    Thread.Sleep(100)
                                    Application.DoEvents()
                                Else
                                    Exit While
                                    loadData()
                                End If
                            End While
                            Try
                                Me.DataTable1TableAdapter.Fill(Me.DSmatalDed.DataTable1, 8694)
                            Catch ex As Exception

                            End Try
                            loadData()
                        End Sub)

    Private Sub insertion PO As Int32, POM As Int32, POD As Int32, MachineName As String)
        Dim dayid As Int64
        dayid = Label81.Text
        Try
            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, dayid, PO, POM, POD, MachineName, 1)
            loadData()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer1.Stop()

        Dim Machinename As String
LastLine:
        If (Me.SerialPort1.IsOpen) Then
            Dim Incoming As String
            Try
                Incoming = Me.SerialPort1.ReadLine()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If Incoming = "1" & vbCr Then
                Machinename = "1"
                If RadioButton1.Checked = True Then
                    insertion(Val(Label105.Text), Val(Label106.Text), Val(Label107.Text), Machinename)
                ElseIf RadioButton1.Checked = True Then
                    insertion(Label1.Text, Nothing, Nothing, Nothing, Machinename)
                End If
            ElseIf Incoming = "2" & vbCr Then
                Machinename = "2"
                If RadioButton4.Checked = True Then
                    insertion(Val(Label108.Text), Val(Label109.Text), Val(Label110.Text), Machinename)
                ElseIf RadioButton1.Checked = True Then
                    insertion(Label1.Text, Nothing, Nothing, Nothing, Machinename)
                End If
            ElseIf Incoming = "3" & vbCr Then
                Machinename = "3"
                If RadioButton6.Checked = True Then

                    insertion(Val(Label111.Text), Val(Label112.Text), Val(Label113.Text), Machinename)
                ElseIf RadioButton1.Checked = True Then
                    insertion(Label1.Text, Nothing, Nothing, Nothing, Machinename)

                End If
            ElseIf Incoming = "4" & vbCr Then
                Machinename = "4"
                If RadioButton8.Checked = True Then
                    insertion(Val(Label114.Text), Val(Label115.Text), Val(Label116.Text), Machinename)
                ElseIf RadioButton1.Checked = True Then
                    insertion(Label1.Text, Nothing, Nothing, Nothing, Machinename)
                End If
            ElseIf Incoming = "5" & vbCr Then
                Machinename = "5"
                If RadioButton10.Checked = True Then
                    insertion(Val(Label117.Text), Val(Label118.Text), Val(Label119.Text), Machinename)
                ElseIf RadioButton1.Checked = True Then
                    insertion(Label1.Text, Nothing, Nothing, Nothing, Machinename)
                End If
                'ElseIf Incoming = "6" & vbCr Then
                '    Machinename = "6"
                '    If RadioButton1.Checked = True Then
                '        Dim dayid As Int64
                '        dayid = Label81.Text
                '        Try
                '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename, 1)
                '            Try
                '                Me.DataTable1TableAdapter.Fill(Me.DSmatalDed.DataTable1, dayid)
                '            Catch ex As Exception

                '            End Try

                '        Catch ex As Exception
                '        End Try

                '    End If
                'ElseIf Incoming = "7" & vbCr Then
                '    Machinename = "7"
                '    If RadioButton1.Checked = True Then
                '        Dim dayid As Int64
                '        dayid = Label81.Text
                '        Try
                '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename, 1)
                '            Try
                '                Me.DataTable1TableAdapter.Fill(Me.DSmatalDed.DataTable1, dayid)
                '            Catch ex As Exception

                '            End Try

                '        Catch ex As Exception
                '        End Try

                '    End If
                'ElseIf Incoming = "machine 1" & vbCr Then
                '    Machinename = "Metal Ded 1"
                '    If RadioButton4.Checked = True Then

                '        Try
                '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label71.Text), Val(Label72.Text), Val(Label73.Text), Machinename, 0)


                '        Catch ex As Exception
                '        End Try

                '    End If
                'ElseIf Incoming = "machine 2" & vbCr Then
                '    Machinename = "Metal Ded 2"
                '    If RadioButton4.Checked = True Then

                '        Try
                '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label71.Text), Val(Label72.Text), Val(Label73.Text), Machinename, 0)


                '        Catch ex As Exception
                '        End Try

                '    End If
                'ElseIf Incoming = "machine 3" & vbCr Then
                '    Machinename = "Metal Ded 3"
                '    If RadioButton4.Checked = True Then

                '        Try
                '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label71.Text), Val(Label72.Text), Val(Label73.Text), Machinename, 0)


                '        Catch ex As Exception
                '        End Try

                '    End If

                'ElseIf Incoming = "machine 4" & vbCr Then
                '    Machinename = "Metal Ded 4"
                '    If RadioButton6.Checked = True Then

                '        Try
                '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label74.Text), Val(Label75.Text), Val(Label76.Text), Machinename, 0)


                '        Catch ex As Exception
                '        End Try

                '    End If

                'ElseIf Incoming = "machine 5" & vbCr Then
                '    Machinename = "Metal Ded 5"
                '    If RadioButton8.Checked = True Then

                '        Try
                '            Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label77.Text), Val(Label78.Text), Val(Label79.Text), Machinename, 0)


                '        Catch ex As Exception
                '        End Try

                '    End If
                loadData()
            Else
                'GoTo LastLine
            End If


        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (Me.Label2.Text.Length <> 10) Then
            Me.Label2.Text = String.Concat(Me.Label2.Text, ".")

            Me.Label2.Text = "Running"
        End If
        If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Label8.Text, "...", False) <> 0) Then
            Me.Label8.Text = String.Concat(Me.Label8.Text, ".")
        Else
            Me.Label8.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartClick = False
        Label2.Text = "Stop"
        Button2.Enabled = True
        Button1.Enabled = False
        t.Suspend()
        'Timer1.Stop()
        'Me.SerialPort1.Close()
        'Timer2.Stop()
        'Button2.Enabled = True
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StartClick = True
        Button2.Enabled = False
        Button1.Enabled = True
        Label2.Text = "Running"
        If (t.ThreadState And ThreadState.Unstarted) <> 0 Then
            ' The thread has never been started. Start it.
            t.Start()
        Else
            ' The thread is paused. Resume it.
            t.Resume()
        End If
        t.IsBackground = True



        '        StartClick = True
        '        Button2.Enabled = False
        '        Button1.Enabled = True

        '        Label2.Text = "Running"
        '        While (True)
        '            If StartClick Then
        '                Dim Machinename As String
        'LastLine:
        '                Me.SerialPort1.Open()

        '                If (Me.SerialPort1.IsOpen) Then
        '                    Dim Incoming As String
        '                    Try
        '                        Incoming = Me.SerialPort1.ReadLine()
        '                    Catch ex As Exception
        '                        MsgBox(ex.Message)
        '                    End Try
        '                    If Incoming = "machine 1" & vbCr Then
        '                        Machinename = "Metal Ded 1"
        '                        If RadioButton1.Checked = True Then

        '                            Try
        '                                Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename)


        '                            Catch ex As Exception
        '                            End Try

        '                        End If


        '                    ElseIf Incoming = "machine 2" & vbCr Then

        '                        Machinename = "Metal Ded 2"
        '                        If RadioButton4.Checked = True Then

        '                            Try
        '                                Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label68.Text), Val(Label69.Text), Val(Label70.Text), Machinename)


        '                            Catch ex As Exception
        '                            End Try

        '                        End If

        '                    ElseIf Incoming = "machine 3" & vbCr Then
        '                        Machinename = "Metal Ded 3"
        '                        If RadioButton4.Checked = True Then

        '                            Try
        '                                Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label71.Text), Val(Label72.Text), Val(Label73.Text), Machinename)


        '                            Catch ex As Exception
        '                            End Try

        '                        End If

        '                    ElseIf Incoming = "machine 4" & vbCr Then
        '                        Machinename = "Metal Ded 4"
        '                        If RadioButton6.Checked = True Then

        '                            Try
        '                                Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label74.Text), Val(Label75.Text), Val(Label76.Text), Machinename)


        '                            Catch ex As Exception
        '                            End Try

        '                        End If

        '                    ElseIf Incoming = "machine 5" & vbCr Then
        '                        Machinename = "Metal Ded 5"
        '                        If RadioButton8.Checked = True Then

        '                            Try
        '                                Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label77.Text), Val(Label78.Text), Val(Label79.Text), Machinename)


        '                            Catch ex As Exception
        '                            End Try

        '                        End If
        '                        loadData()
        '                    Else
        '                        'GoTo LastLine
        '                    End If


        '                End If


        '                Thread.Sleep(100)
        '                Application.DoEvents()
        '            Else
        '                Exit While

        '            End If
        '        End While



        'Me.Timer1.Start()
        'Button2.Enabled = False
        'Button1.Enabled = True

        'Try
        ' Me.SerialPort1.Open()
        ' If (Me.SerialPort1.IsOpen) Then
        ' Me.SerialPort1.Write(1)
        ' End If
        'Catch ex As Exception
        ' MessageBox.Show("Robotic Device is not connected. Connect Robotic device to COM15", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' 'Application.Exit()
        'End Try
        'Me.Timer2.Start()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.SerialPort1.Close()
        Me.Close()
    End Sub

    Private Sub loadData()
        Dim dayid As Int64
        dayid = Label81.Text



        'Try
        '    'Me.View_Ded_CounterTableAdapter.Fill(Me.DSmatalDed.view_Ded_Counter, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text))
        '    Me.View_Ded_CounterTableAdapter.Fill(Me.DSmatalDed.view_Ded_Counter, Val(Label8.Text))
        'Catch ex As Exception

        'End Try
        Try
            Ded1TableAdapter.Fill(Me.DSmatalDed.Ded1, Label1.Text)
            Ded2TableAdapter.Fill(Me.DSmatalDed.Ded2, Label1.Text)
            Ded3TableAdapter.Fill(Me.DSmatalDed.Ded3, Label1.Text)
            Ded4TableAdapter.Fill(Me.DSmatalDed.Ded4, Label1.Text)
            Ded5TableAdapter.Fill(Me.DSmatalDed.Ded5, Label1.Text)

        Catch ex As Exception

        End Try
        Try
            POWiseCOunter1TableAdapter.Fill(Me.DSmatalDed.POWiseCOunter1, Val(Label105.Text), Val(Label106.Text), Val(Label107.Text), Val(Label1.Text))
            POWiseCOunter2TableAdapter.Fill(Me.DSmatalDed.POWiseCOunter2, Val(Label108.Text), Val(Label109.Text), Val(Label110.Text), Val(Label1.Text))
            POWiseCOunter3TableAdapter.Fill(Me.DSmatalDed.POWiseCOunter3, Val(Label111.Text), Val(Label112.Text), Val(Label113.Text), Val(Label1.Text))
            POWiseCOunter4TableAdapter.Fill(Me.DSmatalDed.POWiseCOunter4, Val(Label114.Text), Val(Label115.Text), Val(Label116.Text), Val(Label1.Text))
            POWiseCOunter5TableAdapter.Fill(Me.DSmatalDed.POWiseCOunter5, Val(Label117.Text), Val(Label118.Text), Val(Label119.Text), Val(Label1.Text))

        Catch ex As Exception

        End Try
        Try
            Me.DataTable1TableAdapter.Fill(Me.DSmatalDed.DataTable1, dayid)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.Ded1TableAdapter.Fill(Me.DSmatalDed.Ded1, New System.Nullable(Of Integer)(CType(DayIDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click_1(sender As Object, e As EventArgs)
        Try
            Me.Ded2TableAdapter.Fill(Me.DSmatalDed.Ded2, New System.Nullable(Of Integer)(CType(DayIDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click_2(sender As Object, e As EventArgs)
        Try
            Me.Ded3TableAdapter.Fill(Me.DSmatalDed.Ded3, New System.Nullable(Of Integer)(CType(DayIDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click_3(sender As Object, e As EventArgs)
        Try
            Me.Ded4TableAdapter.Fill(Me.DSmatalDed.Ded4, New System.Nullable(Of Integer)(CType(DayIDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click_4(sender As Object, e As EventArgs)
        Try
            Me.Ded5TableAdapter.Fill(Me.DSmatalDed.Ded5, New System.Nullable(Of Integer)(CType(DayIDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged

    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub FillToolStripButton2_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton2_Click_1(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton3_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton4_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton5_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton6_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label84_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label82_Click(sender As Object, e As EventArgs)

    End Sub


End Class
