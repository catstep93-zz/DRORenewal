<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExperiment
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
        Me.btnResponse = New System.Windows.Forms.Button()
        Me.btnStartExperiment = New System.Windows.Forms.Button()
        Me.tmrClicked = New System.Windows.Forms.Timer(Me.components)
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPoints = New System.Windows.Forms.Button()
        Me.grpConsumatory = New System.Windows.Forms.GroupBox()
        Me.tmrPhase = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponent = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDRO = New System.Windows.Forms.Timer(Me.components)
        Me.lblSessionEnd = New System.Windows.Forms.Label()
        Me.grpConsumatory.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnResponse
        '
        Me.btnResponse.BackColor = System.Drawing.Color.Black
        Me.btnResponse.CausesValidation = False
        Me.btnResponse.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnResponse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnResponse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnResponse.ForeColor = System.Drawing.Color.Black
        Me.btnResponse.Location = New System.Drawing.Point(560, 297)
        Me.btnResponse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnResponse.Name = "btnResponse"
        Me.btnResponse.Size = New System.Drawing.Size(306, 68)
        Me.btnResponse.TabIndex = 0
        Me.btnResponse.TabStop = False
        Me.btnResponse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnResponse.UseVisualStyleBackColor = False
        '
        'btnStartExperiment
        '
        Me.btnStartExperiment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartExperiment.Location = New System.Drawing.Point(588, 375)
        Me.btnStartExperiment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStartExperiment.Name = "btnStartExperiment"
        Me.btnStartExperiment.Size = New System.Drawing.Size(219, 62)
        Me.btnStartExperiment.TabIndex = 1
        Me.btnStartExperiment.Text = "START"
        Me.btnStartExperiment.UseVisualStyleBackColor = True
        '
        'tmrClicked
        '
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(624, 37)
        Me.lblPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(221, 57)
        Me.lblPoints.TabIndex = 4
        Me.lblPoints.Text = "Points: 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 44.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(144, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 101)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "+1"
        '
        'btnPoints
        '
        Me.btnPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoints.Location = New System.Drawing.Point(54, 185)
        Me.btnPoints.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPoints.Name = "btnPoints"
        Me.btnPoints.Size = New System.Drawing.Size(336, 62)
        Me.btnPoints.TabIndex = 6
        Me.btnPoints.Text = "Collect Point"
        Me.btnPoints.UseVisualStyleBackColor = True
        '
        'grpConsumatory
        '
        Me.grpConsumatory.Controls.Add(Me.btnPoints)
        Me.grpConsumatory.Controls.Add(Me.Label1)
        Me.grpConsumatory.Location = New System.Drawing.Point(30, 25)
        Me.grpConsumatory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpConsumatory.Name = "grpConsumatory"
        Me.grpConsumatory.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpConsumatory.Size = New System.Drawing.Size(450, 271)
        Me.grpConsumatory.TabIndex = 7
        Me.grpConsumatory.TabStop = False
        '
        'tmrComponent
        '
        '
        'tmrDRO
        '
        '
        'lblSessionEnd
        '
        Me.lblSessionEnd.AllowDrop = True
        Me.lblSessionEnd.AutoSize = True
        Me.lblSessionEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSessionEnd.Location = New System.Drawing.Point(100, 552)
        Me.lblSessionEnd.Name = "lblSessionEnd"
        Me.lblSessionEnd.Size = New System.Drawing.Size(1354, 59)
        Me.lblSessionEnd.TabIndex = 12
        Me.lblSessionEnd.Text = "Please let the experimenter know that this session is over."
        Me.lblSessionEnd.Visible = False
        '
        'frmExperiment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1436, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSessionEnd)
        Me.Controls.Add(Me.grpConsumatory)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btnStartExperiment)
        Me.Controls.Add(Me.btnResponse)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmExperiment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpConsumatory.ResumeLayout(False)
        Me.grpConsumatory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnResponse As Button
    Friend WithEvents btnStartExperiment As Button
    Friend WithEvents tmrClicked As Timer
    Friend WithEvents lblPoints As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPoints As Button
    Friend WithEvents grpConsumatory As GroupBox
    Friend WithEvents tmrPhase As Timer
    Friend WithEvents tmrComponent As Timer
    Friend WithEvents tmrDRO As Timer
    Friend WithEvents lblSessionEnd As Label
End Class
