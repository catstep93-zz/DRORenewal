'Program created by Catherine Williams January 2020



Imports System.IO
Public Class frmMain
    Const mc_strPathList As String = "C:\RenewalDROPathList.txt"
    Dim m_strDataFilePath As String
    Dim m_strrawDataFileName As String
    Dim m_boolWhatToDo As Boolean

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmBlack.Show()
        frmBlack.Enabled = False
        txtParticipantID.Focus()
        txtExperimenterID.Enabled = False
        nudPhase1Duration.Value = 15
        nudPhase2Duration.Value = 15
        nudPhase3Duration.Value = 15
        nudPhase1Int.Value = 2
        nudPhase2Int.Value = 2
        nudPhase3Int.Value = 2
        cmbColor1.SelectedItem = "Yellow"
        cmbColor2.SelectedItem = "Blue"
        cmbColor3.SelectedItem = "Yellow"
        cmbPhase1Schedule.SelectedItem = "FI"
        cmbPhase2Schedule.SelectedItem = "DRO"
        cmbPhase3Schedule.SelectedItem = "DRO"
        ActiveGroupBoxes(False)
        btnChangeParameters.Enabled = False
        btnStart.Enabled = False
        Me.Location = New System.Drawing.Point(0, 0)

        If Not File.Exists(mc_strPathList) Then
            MsgBox("'" & mc_strPathList & "' not found. Session aborted.", MsgBoxStyle.Critical, "Time Out")
            End
        Else
            Dim ReadDataPaths As New StreamReader(New FileStream(mc_strPathList, FileMode.Open, FileAccess.Read))
            m_strDataFilePath = ReadDataPaths.ReadLine
            ReadDataPaths.Close()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If CheckDataFile() = True Then
            Me.Visible = False
            frmExperiment.Visible = True
            SetUpExperimentLayout()
        End If
    End Sub

    Private Sub SetUpExperimentLayout()
        ActivateButtons(False)
        frmExperiment.lblPoints.Location = New System.Drawing.Point(frmExperiment.Width / 2 - 75, 20)
        frmExperiment.btnStartExperiment.Location = New System.Drawing.Point(frmExperiment.Width / 2 - 45, frmExperiment.Height / 2 - 20)
        frmExperiment.btnResponse.Location = New System.Drawing.Point(frmExperiment.Width / 2 - frmExperiment.btnResponse.Width / 2, frmExperiment.Height / 2 - frmExperiment.btnResponse.Height / 2)
        frmExperiment.grpConsumatory.Location = New System.Drawing.Point(frmExperiment.Width / 2 - frmExperiment.grpConsumatory.Width / 2, frmExperiment.Height / 2 - frmExperiment.grpConsumatory.Height / 2)
    End Sub

    Private Sub ActivateButtons(boolOnOff As Boolean)
        frmExperiment.btnResponse.Visible = boolOnOff
        frmExperiment.btnResponse.Enabled = boolOnOff
        frmExperiment.lblPoints.Visible = boolOnOff
        frmExperiment.grpConsumatory.Visible = boolOnOff
    End Sub

    Private Function CheckDataFile() As Boolean
        m_strrawDataFileName = m_strDataFilePath & " Results for " & txtParticipantID.Text & ".txt"
        Dim boolstatus As Boolean = True
        If File.Exists(m_strrawDataFileName) Then
            If MsgBox("There is already a file for this participant. Are you sure you want to override this file?", vbYesNo) = vbNo Then
                boolstatus = False
                Return boolstatus
                Exit Function
            End If
        End If

        Return boolstatus
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChangeParameters.Click
        If m_boolWhatToDo = False Then
            ActiveGroupBoxes(True)
            m_boolWhatToDo = True
        Else
            ActiveGroupBoxes(False)
            m_boolWhatToDo = False
        End If
    End Sub

    Private Sub ActiveGroupBoxes(OnOff As Boolean)
        GroupBox2.Enabled = OnOff
        GroupBox4.Enabled = OnOff
        If OnOff = False Then
            btnStart.Enabled = True
            btnChangeParameters.Text = "Change Parameters"
        Else
            btnStart.Enabled = False
            btnChangeParameters.Text = "Save Parameters"
        End If
    End Sub

    Private Sub cmbFirstComponent_SelectedIndexChanged(sender As Object, e As EventArgs)
        btnStart.Enabled = True
        btnChangeParameters.Enabled = True
    End Sub

    Private Sub txtParticipantID_TextChanged(sender As Object, e As EventArgs) Handles txtParticipantID.TextChanged
        txtExperimenterID.Enabled = True
    End Sub

    Private Sub cmbSessionNumber_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub



    Private Sub nudItems_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor1.SelectedIndexChanged

    End Sub

    Private Sub cboPhase1Schedule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPhase1Schedule.SelectedIndexChanged
        If cmbPhase1Schedule.SelectedItem = "Extinction" Then
            nudPhase1Int.Value = 0
            nudPhase1Int.Enabled = False
        Else
            nudPhase1Int.Value = 2
            nudPhase1Int.Enabled = True
        End If
    End Sub

    Private Sub cmbPhase2Schedule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPhase2Schedule.SelectedIndexChanged
        If cmbPhase2Schedule.SelectedItem = "Extinction" Then
            nudPhase2Int.Value = 0
            nudPhase2Int.Enabled = False
        Else
            nudPhase2Int.Value = 2
            nudPhase2Int.Enabled = True
        End If
    End Sub

    Private Sub cmbPhase3Schedule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPhase3Schedule.SelectedIndexChanged
        If cmbPhase3Schedule.SelectedItem = "Extinction" Then
            nudPhase3Int.Value = 0
            nudPhase3Int.Enabled = False
        Else
            nudPhase3Int.Value = 2
            nudPhase3Int.Enabled = True
        End If
    End Sub

    Private Sub txtExperimenterID_TextChanged(sender As Object, e As EventArgs) Handles txtExperimenterID.TextChanged
        btnStart.Enabled = True
        btnChangeParameters.Enabled = True
    End Sub

    Private Sub nudPhase1Int_ValueChanged(sender As Object, e As EventArgs) Handles nudPhase1Int.ValueChanged

    End Sub
End Class
