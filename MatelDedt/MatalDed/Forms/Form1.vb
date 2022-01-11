Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'DSmatalDed.view_MS_PONO' table. You can move, or remove it, as needed.
		Me.View_MS_PONOTableAdapter.Fill(Me.DSmatalDed.view_MS_PONO)
		'TODO: This line of code loads data into the 'DSmatalDed.tbl_Matel_ded' table. You can move, or remove it, as needed.
		Me.Tbl_Matel_dedTableAdapter.Fill(Me.DSmatalDed.tbl_Matel_ded)
        'TODO: This line of code loads data into the 'DSmatalDed.Tbl_Ded_machine' table. You can move, or remove it, as needed.
        Me.Tbl_Ded_machineTableAdapter.Fill(Me.DSmatalDed.Tbl_Ded_machine)



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
		If (Me.SerialPort1.IsOpen) Then
			Dim Incoming As String = Me.SerialPort1.ReadLine()
			If Incoming = "1" & vbCr Then
				Machinename = "Metal Ded 1"
			ElseIf Incoming = "2" & vbCr Then
				Machinename = "Metal Ded 2"
			ElseIf Incoming = "3" & vbCr Then
				Machinename = "Metal Ded 3"
			ElseIf Incoming = "4" & vbCr Then
				Machinename = "Metal Ded 4"
			End If

			Try
				Tbl_Matel_dedTableAdapter.Insert(1, 1, Nothing, Now, Nothing, Label1.Text, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text), Machinename)
				loadData()
			Catch ex As Exception

			End Try
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
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Timer1.Start()
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
			Me.View_Ded_CounterTableAdapter.Fill(Me.DSmatalDed.view_Ded_Counter, Label1.Text, NameComboBox.SelectedValue, Val(Label6.Text), Val(Label7.Text), Val(Label8.Text))
		Catch ex As Exception

		End Try
	End Sub
End Class
