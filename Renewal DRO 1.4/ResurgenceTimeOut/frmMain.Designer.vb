<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudPhase1Int = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudPhase1Duration = New System.Windows.Forms.NumericUpDown()
        Me.nudPhase2Duration = New System.Windows.Forms.NumericUpDown()
        Me.nudPhase3Duration = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtParticipantID = New System.Windows.Forms.TextBox()
        Me.txtExperimenterID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbColor3 = New System.Windows.Forms.ComboBox()
        Me.cmbColor2 = New System.Windows.Forms.ComboBox()
        Me.cmbColor1 = New System.Windows.Forms.ComboBox()
        Me.cmbPhase3Schedule = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudPhase3Int = New System.Windows.Forms.NumericUpDown()
        Me.cmbPhase2Schedule = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudPhase2Int = New System.Windows.Forms.NumericUpDown()
        Me.cmbPhase1Schedule = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChangeParameters = New System.Windows.Forms.Button()
        CType(Me.nudPhase1Int, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase1Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase2Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase3Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudPhase3Int, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase2Int, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(368, 428)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(132, 45)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(562, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Interval (s):"
        '
        'nudPhase1Int
        '
        Me.nudPhase1Int.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase1Int.Location = New System.Drawing.Point(714, 35)
        Me.nudPhase1Int.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPhase1Int.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudPhase1Int.Name = "nudPhase1Int"
        Me.nudPhase1Int.Size = New System.Drawing.Size(106, 35)
        Me.nudPhase1Int.TabIndex = 2
        Me.nudPhase1Int.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Phase 1 Duration (min):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phase 2 Duration (min):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(286, 29)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Phase 3 Duration (min):"
        '
        'nudPhase1Duration
        '
        Me.nudPhase1Duration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase1Duration.Location = New System.Drawing.Point(304, 29)
        Me.nudPhase1Duration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPhase1Duration.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudPhase1Duration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPhase1Duration.Name = "nudPhase1Duration"
        Me.nudPhase1Duration.Size = New System.Drawing.Size(105, 35)
        Me.nudPhase1Duration.TabIndex = 14
        Me.nudPhase1Duration.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'nudPhase2Duration
        '
        Me.nudPhase2Duration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase2Duration.Location = New System.Drawing.Point(304, 69)
        Me.nudPhase2Duration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPhase2Duration.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudPhase2Duration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPhase2Duration.Name = "nudPhase2Duration"
        Me.nudPhase2Duration.Size = New System.Drawing.Size(105, 35)
        Me.nudPhase2Duration.TabIndex = 15
        Me.nudPhase2Duration.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'nudPhase3Duration
        '
        Me.nudPhase3Duration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase3Duration.Location = New System.Drawing.Point(304, 112)
        Me.nudPhase3Duration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPhase3Duration.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudPhase3Duration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPhase3Duration.Name = "nudPhase3Duration"
        Me.nudPhase3Duration.Size = New System.Drawing.Size(105, 35)
        Me.nudPhase3Duration.TabIndex = 16
        Me.nudPhase3Duration.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 46)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 29)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Participant ID:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 97)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(259, 29)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Experimenter Initials:"
        '
        'txtParticipantID
        '
        Me.txtParticipantID.Location = New System.Drawing.Point(210, 42)
        Me.txtParticipantID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtParticipantID.Name = "txtParticipantID"
        Me.txtParticipantID.Size = New System.Drawing.Size(178, 35)
        Me.txtParticipantID.TabIndex = 29
        '
        'txtExperimenterID
        '
        Me.txtExperimenterID.Location = New System.Drawing.Point(284, 92)
        Me.txtExperimenterID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtExperimenterID.Name = "txtExperimenterID"
        Me.txtExperimenterID.Size = New System.Drawing.Size(104, 35)
        Me.txtExperimenterID.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtExperimenterID)
        Me.GroupBox1.Controls.Add(Me.txtParticipantID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 160)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Session Info"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 29)
        Me.Label15.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.nudPhase1Duration)
        Me.GroupBox2.Controls.Add(Me.nudPhase2Duration)
        Me.GroupBox2.Controls.Add(Me.nudPhase3Duration)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(440, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 160)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Duration"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 31)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 29)
        Me.Label18.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 31)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 29)
        Me.Label17.TabIndex = 27
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Silver
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.cmbColor3)
        Me.GroupBox4.Controls.Add(Me.cmbColor2)
        Me.GroupBox4.Controls.Add(Me.cmbColor1)
        Me.GroupBox4.Controls.Add(Me.cmbPhase3Schedule)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.nudPhase3Int)
        Me.GroupBox4.Controls.Add(Me.cmbPhase2Schedule)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.nudPhase2Int)
        Me.GroupBox4.Controls.Add(Me.cmbPhase1Schedule)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.nudPhase1Int)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(30, 178)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(838, 225)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reinforcement Schedule"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(124, 157)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 29)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Color:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(124, 95)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 29)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Color:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(124, 38)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 29)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Color:"
        '
        'cmbColor3
        '
        Me.cmbColor3.FormattingEnabled = True
        Me.cmbColor3.Items.AddRange(New Object() {"Yellow", "Blue", "Red", "White", "Black"})
        Me.cmbColor3.Location = New System.Drawing.Point(210, 154)
        Me.cmbColor3.Name = "cmbColor3"
        Me.cmbColor3.Size = New System.Drawing.Size(103, 37)
        Me.cmbColor3.TabIndex = 43
        '
        'cmbColor2
        '
        Me.cmbColor2.FormattingEnabled = True
        Me.cmbColor2.Items.AddRange(New Object() {"Yellow", "Blue", "Red", "White", "Black"})
        Me.cmbColor2.Location = New System.Drawing.Point(210, 94)
        Me.cmbColor2.Name = "cmbColor2"
        Me.cmbColor2.Size = New System.Drawing.Size(103, 37)
        Me.cmbColor2.TabIndex = 42
        '
        'cmbColor1
        '
        Me.cmbColor1.FormattingEnabled = True
        Me.cmbColor1.Items.AddRange(New Object() {"Yellow", "Blue", "Red", "White", "Black"})
        Me.cmbColor1.Location = New System.Drawing.Point(208, 35)
        Me.cmbColor1.Name = "cmbColor1"
        Me.cmbColor1.Size = New System.Drawing.Size(103, 37)
        Me.cmbColor1.TabIndex = 41
        '
        'cmbPhase3Schedule
        '
        Me.cmbPhase3Schedule.FormattingEnabled = True
        Me.cmbPhase3Schedule.Items.AddRange(New Object() {"VI", "FI", "Extinction", "DRO"})
        Me.cmbPhase3Schedule.Location = New System.Drawing.Point(446, 152)
        Me.cmbPhase3Schedule.Name = "cmbPhase3Schedule"
        Me.cmbPhase3Schedule.Size = New System.Drawing.Size(103, 37)
        Me.cmbPhase3Schedule.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(320, 157)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 29)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Schedule:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 29)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Phase 3: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(564, 157)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 29)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Interval (s):"
        '
        'nudPhase3Int
        '
        Me.nudPhase3Int.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase3Int.Location = New System.Drawing.Point(714, 154)
        Me.nudPhase3Int.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPhase3Int.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudPhase3Int.Name = "nudPhase3Int"
        Me.nudPhase3Int.Size = New System.Drawing.Size(108, 35)
        Me.nudPhase3Int.TabIndex = 37
        Me.nudPhase3Int.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'cmbPhase2Schedule
        '
        Me.cmbPhase2Schedule.FormattingEnabled = True
        Me.cmbPhase2Schedule.Items.AddRange(New Object() {"VI", "FI", "Extinction", "DRO"})
        Me.cmbPhase2Schedule.Location = New System.Drawing.Point(446, 92)
        Me.cmbPhase2Schedule.Name = "cmbPhase2Schedule"
        Me.cmbPhase2Schedule.Size = New System.Drawing.Size(103, 37)
        Me.cmbPhase2Schedule.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 29)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Schedule:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 29)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Phase 2: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 29)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Interval (s):"
        '
        'nudPhase2Int
        '
        Me.nudPhase2Int.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase2Int.Location = New System.Drawing.Point(714, 94)
        Me.nudPhase2Int.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudPhase2Int.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudPhase2Int.Name = "nudPhase2Int"
        Me.nudPhase2Int.Size = New System.Drawing.Size(108, 35)
        Me.nudPhase2Int.TabIndex = 32
        Me.nudPhase2Int.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'cmbPhase1Schedule
        '
        Me.cmbPhase1Schedule.FormattingEnabled = True
        Me.cmbPhase1Schedule.Items.AddRange(New Object() {"VI", "FI", "Extinction", "DRO"})
        Me.cmbPhase1Schedule.Location = New System.Drawing.Point(442, 34)
        Me.cmbPhase1Schedule.Name = "cmbPhase1Schedule"
        Me.cmbPhase1Schedule.Size = New System.Drawing.Size(103, 37)
        Me.cmbPhase1Schedule.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 29)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Schedule:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Phase 1: "
        '
        'btnChangeParameters
        '
        Me.btnChangeParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeParameters.Location = New System.Drawing.Point(252, 482)
        Me.btnChangeParameters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChangeParameters.Name = "btnChangeParameters"
        Me.btnChangeParameters.Size = New System.Drawing.Size(351, 45)
        Me.btnChangeParameters.TabIndex = 36
        Me.btnChangeParameters.Text = "Change Session Parameters"
        Me.btnChangeParameters.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(900, 545)
        Me.Controls.Add(Me.btnChangeParameters)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Renewal DRO v. 1.4 12-6-2020"
        CType(Me.nudPhase1Int, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase1Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase2Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase3Duration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudPhase3Int, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase2Int, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nudPhase1Int As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nudPhase1Duration As NumericUpDown
    Friend WithEvents nudPhase2Duration As NumericUpDown
    Friend WithEvents nudPhase3Duration As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtParticipantID As TextBox
    Friend WithEvents txtExperimenterID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnChangeParameters As Button
    Friend WithEvents cmbPhase3Schedule As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents nudPhase3Int As NumericUpDown
    Friend WithEvents cmbPhase2Schedule As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nudPhase2Int As NumericUpDown
    Friend WithEvents cmbPhase1Schedule As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbColor3 As ComboBox
    Friend WithEvents cmbColor2 As ComboBox
    Friend WithEvents cmbColor1 As ComboBox
End Class
