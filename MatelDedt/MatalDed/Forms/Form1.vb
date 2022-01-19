Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO13' table. You can move, or remove it, as needed.
        Me.View_MS_PONO13TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO13)
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO12' table. You can move, or remove it, as needed.
        Me.View_MS_PONO12TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO12)
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO11' table. You can move, or remove it, as needed.
        Me.View_MS_PONO11TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO11)
        'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO1' table. You can move, or remove it, as needed.
        Me.View_MS_PONO1TableAdapter.Fill(Me.DSmatalDed.view_MS_PONO1)
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

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Dim Machinename As String
LastLine:
		If (Me.SerialPort1.IsOpen) Then
			Dim Incoming As String = Me.SerialPort1.ReadLine()
			If Incoming = "machine 1" & vbCr Then
				Machinename = "Metal Ded 1"
				If RadioButton1.Checked = True Then

					Try
						Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename)
						loadData()

					Catch ex As Exception
					End Try
				ElseIf RadioButton2.Checked = True Then
					loadData()
				End If


			ElseIf Incoming = "machine 2" & vbCr Then

				Machinename = "Metal Ded 2"
				If RadioButton4.Checked = True Then

					Try
						Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label68.Text), Val(Label69.Text), Val(Label70.Text), Machinename)
						loadData()

					Catch ex As Exception
					End Try
				ElseIf RadioButton3.Checked = True Then
					loadData()
				End If

			ElseIf Incoming = "machine 3" & vbCr Then
				Machinename = "Metal Ded 3"
				If RadioButton4.Checked = True Then

					Try
						Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label71.Text), Val(Label72.Text), Val(Label73.Text), Machinename)
						loadData()

					Catch ex As Exception
					End Try
				ElseIf RadioButton5.Checked = True Then
					loadData()
				End If

			ElseIf Incoming = "machine 4" & vbCr Then
				Machinename = "Metal Ded 4"
				If RadioButton6.Checked = True Then

					Try
						Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label74.Text), Val(Label75.Text), Val(Label76.Text), Machinename)
						loadData()

					Catch ex As Exception
					End Try
				ElseIf RadioButton7.Checked = True Then
					loadData()
				End If

			ElseIf Incoming = "machine 5" & vbCr Then
				Machinename = "Metal Ded 5"
				If RadioButton8.Checked = True Then

					Try
						Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Nothing, Nothing, Label1.Text, Val(Label77.Text), Val(Label78.Text), Val(Label79.Text), Machinename)
						loadData()

					Catch ex As Exception
					End Try
				ElseIf RadioButton9.Checked = True Then
					loadData()
				End If

			Else
				GoTo LastLine
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
		Timer1.Stop()
		Me.SerialPort1.Close()
		Timer2.Stop()
		Button2.Enabled = True
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Timer1.Start()
		Button2.Enabled = False
		Button1.Enabled = True

		Try
			Me.SerialPort1.Open()
			If (Me.SerialPort1.IsOpen) Then
				Me.SerialPort1.Write(1)
			End If
		Catch ex As Exception
			MessageBox.Show("Robotic Device is not connected. Connect Robotic device to COM15", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Application.Exit()
		End Try
		Me.Timer2.Start()
	End Sub



	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Me.SerialPort1.Close()
		Me.Close()
	End Sub

	Private Sub loadData()
		Try
			Me.View_Ded_CounterTableAdapter.Fill(Me.DSmatalDed.view_Ded_Counter, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text))
		Catch ex As Exception

		End Try
		Try
			Ded1TableAdapter.Fill(Me.DSmatalDed.Ded1, Label1.Text)
			Ded2TableAdapter.Fill(Me.DSmatalDed.Ded2, Label1.Text)
			Ded3TableAdapter.Fill(Me.DSmatalDed.Ded3, Label1.Text)
			Ded4TableAdapter.Fill(Me.DSmatalDed.Ded4, Label1.Text)
			Ded5TableAdapter.Fill(Me.DSmatalDed.Ded5, Label1.Text)
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
End Class
