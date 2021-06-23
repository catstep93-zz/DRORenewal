
Imports System.IO

' This version requires the support file entitled
' VI_and_VR.vb

'Program created by Catherine Williams (2020) at West Virginia University
'v 1.1 Fixed data collection and made all timing based on one timer (not separate timers for phase and component)
'v 1.2 Changed end of session text, disabled start button during session so space button wouldn't do anything
'v 1.3 Made it so that the SR+ button is disabled when not visible
'v 1.4 When minute times out, needed to mark end time of comsumatory response before it did calculation

Public Class frmExperiment
    Const mc_strPathList As String = "C:\RenewalDROPathList.txt"
    Dim m_intTimeStartConsumatory As Integer
    Dim m_intTimeStopConsumatory As Integer
    Dim m_intTimeinConsumatory As Integer
    Dim m_strDataFilePath As String
    Dim m_strRawDataFileName As String
    Dim m_strSessionStartTime As String
    Dim m_strSessionEndTime As String
    Dim m_intPoints As Integer
    Dim m_intTargetPress As Integer
    Dim m_intOffKeyPress As Integer
    Dim m_intAlternativePress As Integer
    Dim m_intControlPress As Integer
    Dim m_boolSR As Boolean
    Dim m_intSchedule() As Integer
    Dim m_intCount As Integer = 0
    Dim m_intTimeLastSR As Integer
    Dim m_strResponse As String
    Dim m_intScheduleItem As Integer
    Dim m_intResponseTime As Integer
    Dim m_intLastResponseTime As Integer
    Dim m_intPhaseNumber As Integer = 0 '1: Target; 2: Alt; 3: Ext
    Dim m_intSessionStartTime As Integer
    Dim m_intScheduleDuration As Integer
    Dim m_strColor As String
    Dim m_boolTimeOut As Boolean
    Dim m_dblTimeinTimeOutSinceSR As Double
    Dim m_intEventsPhase As Integer
    Dim m_intData(1, 0) As Integer
    Dim m_strDurations(1, 10, 0) As String
    Dim m_sngCumulativeTimeinTimeOutDuringComponent As Single
    Dim m_sngCumulativeTimeinConsumatoryDuringComponent As Single
    Dim m_intTargetPressTO As Integer
    Dim m_intAlternativePressTO As Integer
    Dim m_intControlPressTO As Integer
    Dim m_intSR As Integer
    Dim m_intCurrentComponentNumber As Integer
    Dim m_intComponentNumber As Integer
    Dim m_intComponentsPerPhase As Integer
    Dim m_boolCurrentTimeOutStatus As Boolean
    Dim m_blnConsumatory As Boolean
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Integer) As Boolean
    Dim m_boolSessionEnded As Boolean = False
    Dim m_blnDRO As Boolean = False

    Private Sub btnMiddle_MouseHover(sender As Object, e As EventArgs) Handles btnResponse.MouseHover
        PreventColorChange(btnResponse)
        ClearKeyBuffer()
    End Sub

    Private Sub btnStartExperiment_Click(sender As Object, e As EventArgs) Handles btnStartExperiment.Click
        btnStartExperiment.Visible = False
        SetPhaseParameters()
        CheckSchedule()
        ClearKeyBuffer()
        Me.BackColor = Color.FromName(m_strColor)
        m_intSessionStartTime = Environment.TickCount
        m_intTimeLastSR = Environment.TickCount
        ActivateButtons(True)
        btnStartExperiment.Visible = False
        btnStartExperiment.Enabled = False
        lblPoints.Visible = True
        lblPoints.Text = "Points: 0"
        m_strSessionStartTime = Now
        tmrComponent.Interval = 60000
        ReDim m_intSchedule(11)
        tmrComponent.Enabled = True
        tmrPhase.Enabled = True
    End Sub

    Private Sub ActivateButtons(boolOnOff As Boolean)
        btnResponse.BackColor = Color.Black
        btnResponse.ForeColor = Color.Black
        btnResponse.Visible = boolOnOff
        btnResponse.Enabled = boolOnOff
        Me.BackColor = Color.FromName(m_strColor)
    End Sub

    Private Sub PreventColorChange(btnButtonName As Button)
        btnButtonName.BackColor = Color.Black
        btnButtonName.ForeColor = Color.Black
    End Sub

    Private Sub tmrClicked_Tick(sender As Object, e As EventArgs) Handles tmrClicked.Tick
        tmrClicked.Enabled = False
        ButtonFeedback(False)
    End Sub

    Private Sub ButtonFeedback(boolOnOff As Boolean)
        If boolOnOff = True Then
            btnResponse.BackColor = Color.Gray
            btnResponse.ForeColor = Color.Gray
            tmrClicked.Enabled = True
        Else
            btnResponse.BackColor = Color.Black
            btnResponse.ForeColor = Color.Black
            tmrClicked.Enabled = False
        End If
    End Sub

    Private Sub btnMiddle_MouseDown(sender As Object, e As MouseEventArgs) Handles btnResponse.MouseDown
        ButtonFeedback(True)
        SelectConsequence(m_strResponse)
    End Sub

    Private Sub SelectConsequence(strLeverName As String)
        m_intResponseTime = Environment.TickCount
        Dim dblIntervalSinceLastSR As Double
        CollectData("target", intCalcTimeSince())
        m_intTargetPress += 1
        Select Case m_strResponse
            Case "VI"
                dblIntervalSinceLastSR = m_intResponseTime - m_intTimeLastSR
                If dblIntervalSinceLastSR > m_intScheduleItem Then
                    Consumatory(True)
                End If
            Case "FI"
                dblIntervalSinceLastSR = m_intResponseTime - m_intTimeLastSR
                If dblIntervalSinceLastSR > m_intScheduleItem Then
                    Consumatory(True)
                End If
            Case "Extinction"
            Case "DRO"
                tmrDRO.Enabled = False
                tmrDRO.Enabled = True
        End Select
    End Sub

    Private Sub CheckSchedule()
        Dim intScheduleMean As Integer
        Select Case m_strResponse
            Case "VI"
                If m_intCount > 11 Then
                    ' reset counter
                    m_intCount = 1
                End If
                m_intCount += 1
                intScheduleMean = m_intScheduleDuration 'in ms
                m_intScheduleItem = NextVI(m_intSchedule, intScheduleMean)
            Case "FI"
                m_intScheduleItem = m_intScheduleDuration 'in ms
            Case "Extinction"
            Case "DRO"
                tmrDRO.Interval = m_intScheduleDuration
                tmrDRO.Enabled = True
        End Select
    End Sub

    Private Sub frmExperiment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClicked.Interval = 100
    End Sub

    Private Sub btnPoints_Click(sender As Object, e As EventArgs) Handles btnPoints.Click
        m_intPoints += 1
        lblPoints.Text = "Points: " & CStr(m_intPoints)
        Consumatory(False)
        m_intTimeLastSR = Environment.TickCount
    End Sub

    Private Sub Consumatory(OnOff As Boolean)
        grpConsumatory.BackColor = Color.White
        grpConsumatory.Visible = OnOff
        btnPoints.Enabled = OnOff 'added 11-10
        If OnOff = False Then 'this should happen when consumatory turned off
            m_intTimeStopConsumatory = intCalcTimeSince()
            CollectData("ConRS stop", m_intTimeStopConsumatory)
            m_intTimeinConsumatory = m_intTimeStopConsumatory - m_intTimeStartConsumatory
            m_sngCumulativeTimeinConsumatoryDuringComponent += m_intTimeinConsumatory
            ActivateButtons(True)
            CheckSchedule() 'gets next interval ready
            m_intSR += 1
            m_blnConsumatory = False
        Else
            m_intTimeStartConsumatory = intCalcTimeSince()
            CollectData("ConRS start", m_intTimeStartConsumatory)
            m_blnConsumatory = True
            ActivateButtons(False)
        End If
    End Sub


    Private Sub labelcolor()
        lblPoints.BackColor = Color.White
    End Sub

    Private Sub frmExperiment_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If m_boolSessionEnded = False Then
            CollectData("off screen", intCalcTimeSince())
            m_intOffKeyPress += 1
        End If
    End Sub

    Private Sub tmrComponent_Tick(sender As Object, e As EventArgs) Handles tmrComponent.Tick
        m_intCurrentComponentNumber += 1
        If m_intCurrentComponentNumber = m_intComponentsPerPhase Then
            PhaseOver()
            Exit Sub
        Else
            If m_blnConsumatory = True Then
                m_intTimeStopConsumatory = intCalcTimeSince() 'added 12-6
                m_intTimeinConsumatory = m_intTimeStopConsumatory - m_intTimeStartConsumatory
                m_sngCumulativeTimeinConsumatoryDuringComponent += m_intTimeinConsumatory
                m_intTimeStartConsumatory = intCalcTimeSince()
            End If
            CalculateComponentData()
        End If
        m_sngCumulativeTimeinTimeOutDuringComponent = 0
        m_sngCumulativeTimeinConsumatoryDuringComponent = 0
        m_intTargetPress = 0 'added 1/29 3:35pm
        m_intOffKeyPress = 0
        m_intSR = 0
        m_intTimeLastSR = Environment.TickCount
        labelcolor()
        CheckSchedule()
    End Sub

    Private Sub PhaseOver()
        tmrPhase.Enabled = False
        tmrComponent.Enabled = False
        If m_blnConsumatory = True Then
            m_intTimeStopConsumatory = intCalcTimeSince()
            CollectData("ConRS stop", m_intTimeStopConsumatory)
            m_intTimeinConsumatory = m_intTimeStopConsumatory - m_intTimeStartConsumatory
            m_sngCumulativeTimeinConsumatoryDuringComponent += m_intTimeinConsumatory
            grpConsumatory.Visible = False
            ActivateButtons(True)
            CheckSchedule() 'gets next interval ready
            m_blnConsumatory = False
        End If
        CalculateComponentData()
        m_sngCumulativeTimeinTimeOutDuringComponent = 0
        m_sngCumulativeTimeinConsumatoryDuringComponent = 0
        m_intTargetPress = 0 'added 1/29 3:35pm
        m_intOffKeyPress = 0
        m_intSR = 0
        m_intCurrentComponentNumber = 0
        m_intTimeLastSR = Environment.TickCount
        SetPhaseParameters() 'moved from bottom 11-1
    End Sub

    Private Sub SetPhaseParameters()
        m_intPhaseNumber += 1
        Select Case m_intPhaseNumber
            Case 1
                m_intComponentsPerPhase = frmMain.nudPhase1Duration.Value  '# of 1 min components per phases
                tmrComponent.Enabled = True
                'tmrPhase.Interval = frmMain.nudPhase1Duration.Value * 60000
                'tmrPhase.Enabled = True
                m_strResponse = frmMain.cmbPhase1Schedule.SelectedItem
                m_intScheduleDuration = frmMain.nudPhase1Int.Value * 1000
                m_strColor = frmMain.cmbColor1.SelectedItem
            Case 2 'end of target SR+; Start alt SR+
                m_intComponentsPerPhase = frmMain.nudPhase2Duration.Value  '# of 1 min components per phases
                tmrComponent.Enabled = True
                'tmrPhase.Interval = frmMain.nudPhase2Duration.Value * 60000
                'tmrPhase.Enabled = True
                m_strResponse = frmMain.cmbPhase2Schedule.SelectedItem
                m_intScheduleDuration = frmMain.nudPhase2Int.Value * 1000
                m_strColor = frmMain.cmbColor2.SelectedItem
                CollectData("Phase 1 -> 2", intCalcTimeSince())
            Case 3 'end of alter SR+; Start ext
                m_intComponentsPerPhase = frmMain.nudPhase3Duration.Value  '# of 1 min components per phases
                tmrComponent.Enabled = True
                'tmrPhase.Interval = frmMain.nudPhase3Duration.Value * 60000
                'tmrPhase.Enabled = True
                m_strResponse = frmMain.cmbPhase3Schedule.SelectedItem
                m_intScheduleDuration = frmMain.nudPhase3Int.Value * 1000
                m_strColor = frmMain.cmbColor3.SelectedItem
                CollectData("Phase 2 -> 3", intCalcTimeSince())
            Case 4
                m_intPhaseNumber = 3
                m_strSessionEndTime = Now
                CollectData("Session Ended", intCalcTimeSince())
                endSession()
                Exit SUB
        End Select
        If m_strResponse = "DRO" Then
            m_blnDRO = True
        Else m_blnDRO = False
        End If
        labelcolor()
        CheckSchedule()
        ActivateButtons(True) 'added 11-1
    End Sub

    Private Sub tmrDRO_Tick(sender As Object, e As EventArgs) Handles tmrDRO.Tick
        tmrDRO.Enabled = False
        Consumatory(True)
    End Sub


    Private Sub endSession()
        m_boolSessionEnded = True
        tmrComponent.Enabled = False
        tmrPhase.Enabled = False
        tmrDRO.Enabled = False
        tmrClicked.Enabled = False
        ActivateButtons(False)
        lblSessionEnd.Location = New System.Drawing.Point(Me.Width / 2 - lblSessionEnd.Width / 2, Me.Height / 2)
        lblSessionEnd.Visible = True
        Me.BackColor = Color.White
        WriteDataFile()
    End Sub

    Public Function TerminateKeyPressed() As Boolean
        If GetAsyncKeyState(System.Windows.Forms.Keys.T) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CheckTerminateKey()
        If TerminateKeyPressed() = True Then
            If m_intPhaseNumber <> 4 Then
                endSession()
            End If
            Me.Close()
            frmBlack.Close()
            frmMain.Close()
        End If
    End Sub

    '______________________DATA COLLECTION FILES_________________________

    Private Function intCalcTimeSince() As Integer
        Dim intCurrentTime = Environment.TickCount
        Dim intTimeSince As Integer
        intTimeSince = intCurrentTime - m_intSessionStartTime
        Return intTimeSince
    End Function

    Private Sub CollectData(strEvent As String, intTime As Integer)
        Dim intEvent As Integer
        Select Case strEvent
            Case = "target"
                intEvent = 1
            Case = "off screen"
                intEvent = 2
            Case = "ConRS start"
                intEvent = 7
            Case = "ConRS stop"
                intEvent = 8
            Case = "Phase 1 -> 2"
                intEvent = 50
            Case = "Phase 2 -> 3"
                intEvent = 51
            Case = "Session Ended"
                intEvent = 99
            Case = "Session Terminated"
                CalculateComponentData()
                intEvent = 98
        End Select
        m_intData(1, m_intEventsPhase) = intTime '1=event time
        m_intData(0, m_intEventsPhase) = intEvent '0=event code 
        m_intEventsPhase += 1 'resets at start of each phase
        ReDim Preserve m_intData(1, m_intEventsPhase)
    End Sub

    Private Sub CalculateComponentData()
        Dim intComponent As Integer
        Dim sngTimeIn As Integer
        sngTimeIn = sngCalcTimeIn() 'seconds
        'TextBox1.Text = CStr(boolComponent)
        'TextBox2.Text = m_intCurrentComponentNumber
        intComponent = 0
        m_strDurations(intComponent, 0, m_intComponentNumber) = (sngTimeIn / 60000).ToString("n2") 'min
        m_strDurations(intComponent, 1, m_intComponentNumber) = m_intTargetPress.ToString("n0") 'per min
        m_strDurations(intComponent, 2, m_intComponentNumber) = (m_intTargetPress / (sngTimeIn / 60000)).ToString("n2") 'per min
        m_strDurations(intComponent, 3, m_intComponentNumber) = (m_intOffKeyPress).ToString("n0") 'per min
        m_strDurations(intComponent, 4, m_intComponentNumber) = (m_intOffKeyPress / (sngTimeIn / 60000)).ToString("n2") 'per min
        m_strDurations(intComponent, 5, m_intComponentNumber) = (m_sngCumulativeTimeinConsumatoryDuringComponent / 60000).ToString("n2")
        m_strDurations(intComponent, 6, m_intComponentNumber) = m_intSR.ToString("n2")
        m_strDurations(intComponent, 7, m_intComponentNumber) = (m_intSR / (sngTimeIn / 60000)).ToString("n2") 'per min
        m_strDurations(intComponent, 8, m_intComponentNumber) = m_strResponse
        If m_boolSessionEnded = False Then
            m_intComponentNumber += 1
            ReDim Preserve m_strDurations(1, 10, (m_intComponentNumber))
        End If
    End Sub

    Private Function sngCalcTimeIn() As Single
        Dim sngTimeIn As Single
        sngTimeIn = ((tmrComponent.Interval - m_sngCumulativeTimeinTimeOutDuringComponent - m_sngCumulativeTimeinConsumatoryDuringComponent)) 'total time in component-time in timout-time in consumatory respone
        Return sngTimeIn
    End Function

    '______________________RESULT FILE CREATION__________________________

    Private Sub WriteDataFile()
        Dim ReadDataPaths As New StreamReader(New FileStream(mc_strPathList, FileMode.Open, FileAccess.Read))
        m_strDataFilePath = ReadDataPaths.ReadLine
        ReadDataPaths.Close()
        Dim swWriteResults As StreamWriter
        m_strRawDataFileName = m_strDataFilePath & " Results for " & frmMain.txtParticipantID.Text & ".txt"
        swWriteResults = File.CreateText(m_strRawDataFileName)
        'write header
        swWriteResults.WriteLine(" ")
        swWriteResults.WriteLine("Session Summary_________________________________________________________")
        swWriteResults.WriteLine("  Results for Participant " & frmMain.txtParticipantID.Text & " on " & DateString)
        swWriteResults.WriteLine("  Session Conducted By " & frmMain.txtExperimenterID.Text)
        swWriteResults.WriteLine("  Phase 1")
        swWriteResults.WriteLine("    Duration: " & (frmMain.nudPhase1Duration.Value).ToString("n0") & " min")
        swWriteResults.WriteLine("    Color: " & (frmMain.cmbColor1.SelectedItem))
        swWriteResults.WriteLine("    SR Schedule: " & (frmMain.cmbPhase1Schedule.SelectedItem))
        If frmMain.cmbPhase1Schedule.SelectedItem <> "Extinction" Then
            swWriteResults.WriteLine("    Schedule Value: " & (frmMain.nudPhase1Int.Value).ToString("n0") & " s")
        End If
        swWriteResults.WriteLine("  Phase 2")
        swWriteResults.WriteLine("    Duration: " & (frmMain.nudPhase2Duration.Value).ToString("n0") & " min")
        swWriteResults.WriteLine("    Color: " & (frmMain.cmbColor2.SelectedItem))
        swWriteResults.WriteLine("    SR Schedule: " & (frmMain.cmbPhase2Schedule.SelectedItem))
        If frmMain.cmbPhase1Schedule.SelectedItem <> "Extinction" Then
            swWriteResults.WriteLine("    Schedule Value: " & (frmMain.nudPhase2Int.Value).ToString("n0") & " s")
        End If
        swWriteResults.WriteLine("  Phase 3")
        swWriteResults.WriteLine("    Duration: " & (frmMain.nudPhase3Duration.Value).ToString("n0") & " min")
        swWriteResults.WriteLine("    Color: " & (frmMain.cmbColor3.SelectedItem))
        swWriteResults.WriteLine("    SR Schedule: " & (frmMain.cmbPhase3Schedule.SelectedItem))
        If frmMain.cmbPhase1Schedule.SelectedItem <> "Extinction" Then
            swWriteResults.WriteLine("    Schedule Value: " & (frmMain.nudPhase1Int.Value).ToString("n0") & " s")
        End If
        swWriteResults.WriteLine("  Session Start Time: " & m_strSessionStartTime)
        swWriteResults.WriteLine("  Session End Time: " & m_strSessionEndTime)
        swWriteResults.WriteLine("")
        swWriteResults.WriteLine("Session Data___________________________________________________________")
        swWriteResults.WriteLine("    " & "SR Schedule" & vbTab & "Time in(min)" & vbTab & "# RS" & vbTab & "RS/min" & vbTab & "# Off" & vbTab & "Off/min" & vbTab & "Time in CR(min)" & vbTab & "# SR" & vbTab & "SR/min")
        For i As Integer = 0 To m_intComponentNumber - 1
            swWriteResults.WriteLine("    " & m_strDurations(0, 8, i) & vbTab & vbTab & m_strDurations(0, 0, i) & vbTab & vbTab & m_strDurations(0, 1, i) & vbTab & m_strDurations(0, 2, i) & vbTab & m_strDurations(0, 3, i) & vbTab & m_strDurations(0, 4, i) & vbTab & m_strDurations(0, 5, i) & vbTab & vbTab & m_strDurations(0, 6, i) & vbTab & m_strDurations(0, 7, i) & vbTab)
        Next
        swWriteResults.WriteLine("")
        swWriteResults.WriteLine("**Event Codes**")
        swWriteResults.WriteLine("1 = Target Response")
        swWriteResults.WriteLine("2 = Off Key Response")
        swWriteResults.WriteLine("7 = Start of Consumatory Response")
        swWriteResults.WriteLine("8 = End of Consumatory Response")
        swWriteResults.WriteLine("50 = Start of Phase 2")
        swWriteResults.WriteLine("51 = Start of Phase 3")
        swWriteResults.WriteLine("98 = Session Terminated")
        swWriteResults.WriteLine("99 = Session Completed")
        For i As Integer = 0 To m_intEventsPhase
            For j As Integer = 0 To 1
                If m_intData(j, i) <> 0 Then
                    swWriteResults.WriteLine(CStr(m_intData(j, i)))
                End If
            Next
        Next

        swWriteResults.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        'WriteDataFile()
        Me.Close()
        frmBlack.Close()
        frmMain.Close()
    End Sub

    Public Sub ClearKeyBuffer()  ' CLEARS ANY BUTTON PRESSES 
        Do Until GetAsyncKeyState(Keys.Left) = False
        Loop
        Do Until GetAsyncKeyState(Keys.Space) = False
        Loop
        Do Until GetAsyncKeyState(Keys.Down) = False
        Loop
        Do Until GetAsyncKeyState(Keys.Right) = False
        Loop
        Do Until GetAsyncKeyState(Keys.T) = False
        Loop
        Do Until GetAsyncKeyState(Keys.H) = False
        Loop
    End Sub


    Private Sub lblPoints_Click(sender As Object, e As EventArgs) Handles lblPoints.Click
        CheckTerminateKey()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnMiddle_Click(sender As Object, e As EventArgs) Handles btnResponse.Click

    End Sub









    '______________________DATA CALCULATIONS___________________________
End Class