Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim queue As Integer = 21

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
        lbFM1WaitingList.Enabled = False

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(100, 150)
    End Sub

    Private Sub btnAddQueue_Click(sender As Object, e As EventArgs) Handles btnAddQueue.Click
        If queue > 50 Then
            btnAddQueue.Enabled = False
            lblTNQ.ForeColor = Color.Red
            Form2.lblTNQ.ForeColor = Color.Red
            MessageBox.Show("You've reached maximum number of queue per day!", "Maximum Queue Reached")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to add TN-0000" & queue & " to the queue?", "Add Queue Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                lbFM1WaitingList.Items.Add("TN-0000" & CStr(queue))
                Form2.lbFM2WaitingList.Items.Add("TN-0000" & CStr(queue))
                queue += 1
                lblTNQ.Text += 1
                Form2.lblTNQ.Text += 1
                lblNE.Text += 1
                Form2.lblNE.Text += 1
                btnCounter1.Enabled = True
                btnCounter2.Enabled = True
                btnCounter3.Enabled = True
                btnCounter4.Enabled = True
                btnCounter5.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCounter1.Click
        lbFM1WaitingList.SelectedIndex = 0
        lblCO1.Text = lbFM1WaitingList.SelectedItem.ToString()
        Form2.lblCU1.Text = lblCO1.Text
        lbFM1WaitingList.Items.RemoveAt(lbFM1WaitingList.SelectedIndex)
        Form2.lbFM2WaitingList.SelectedIndex = 0
        Form2.lbFM2WaitingList.Items.RemoveAt(Form2.lbFM2WaitingList.SelectedIndex)
        lblNE.Text -= 1
        Form2.lblNE.Text -= 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCounter2.Click
        lbFM1WaitingList.SelectedIndex = 0
        lblCO2.Text = lbFM1WaitingList.SelectedItem.ToString()
        Form2.lblCU2.Text = lblCO2.Text
        lbFM1WaitingList.Items.RemoveAt(lbFM1WaitingList.SelectedIndex)
        Form2.lbFM2WaitingList.SelectedIndex = 0
        Form2.lbFM2WaitingList.Items.RemoveAt(Form2.lbFM2WaitingList.SelectedIndex)
        lblNE.Text -= 1
        Form2.lblNE.Text -= 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCounter3.Click
        lbFM1WaitingList.SelectedIndex = 0
        lblCO3.Text = lbFM1WaitingList.SelectedItem.ToString()
        Form2.lblCU3.Text = lblCO3.Text
        lbFM1WaitingList.Items.RemoveAt(lbFM1WaitingList.SelectedIndex)
        Form2.lbFM2WaitingList.SelectedIndex = 0
        Form2.lbFM2WaitingList.Items.RemoveAt(Form2.lbFM2WaitingList.SelectedIndex)
        lblNE.Text -= 1
        Form2.lblNE.Text -= 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCounter4.Click
        lbFM1WaitingList.SelectedIndex = 0
        lblCO4.Text = lbFM1WaitingList.SelectedItem.ToString()
        Form2.lblCU4.Text = lblCO4.Text
        lbFM1WaitingList.Items.RemoveAt(lbFM1WaitingList.SelectedIndex)
        Form2.lbFM2WaitingList.SelectedIndex = 0
        Form2.lbFM2WaitingList.Items.RemoveAt(Form2.lbFM2WaitingList.SelectedIndex)
        lblNE.Text -= 1
        Form2.lblNE.Text -= 1
    End Sub

    Private Sub btnCounter5_Click(sender As Object, e As EventArgs) Handles btnCounter5.Click
        lbFM1WaitingList.SelectedIndex = 0
        lblCO5.Text = lbFM1WaitingList.SelectedItem.ToString()
        Form2.lblCU5.Text = lblCO5.Text
        lbFM1WaitingList.Items.RemoveAt(lbFM1WaitingList.SelectedIndex)
        Form2.lbFM2WaitingList.SelectedIndex = 0
        Form2.lbFM2WaitingList.Items.RemoveAt(Form2.lbFM2WaitingList.SelectedIndex)
        lblNE.Text -= 1
        Form2.lblNE.Text -= 1
    End Sub

    Private Sub lbWaitingList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFM1WaitingList.SelectedIndexChanged
        If lbFM1WaitingList.Items.Count > 0 Then
            btnCounter1.Enabled = True
            btnCounter2.Enabled = True
            btnCounter3.Enabled = True
            btnCounter4.Enabled = True
            btnCounter5.Enabled = True
        Else
            btnCounter1.Enabled = False
            btnCounter2.Enabled = False
            btnCounter3.Enabled = False
            btnCounter4.Enabled = False
            btnCounter5.Enabled = False
        End If
    End Sub
End Class