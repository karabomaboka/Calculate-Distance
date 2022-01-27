<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.lblJbhb = New System.Windows.Forms.Label()
    Me.lblCpt = New System.Windows.Forms.Label()
    Me.lblPe = New System.Windows.Forms.Label()
    Me.lblDbn = New System.Windows.Forms.Label()
    Me.lblStartingPoint = New System.Windows.Forms.Label()
    Me.txtStartingPoint = New System.Windows.Forms.TextBox()
    Me.lblDestination = New System.Windows.Forms.Label()
    Me.txtDestination = New System.Windows.Forms.TextBox()
    Me.btnDistance = New System.Windows.Forms.Button()
    Me.lblDistance = New System.Windows.Forms.Label()
    Me.txtDistance = New System.Windows.Forms.TextBox()
    Me.btnReenter = New System.Windows.Forms.Button()
    Me.btnExit = New System.Windows.Forms.Button()
    Me.btnGetMore = New System.Windows.Forms.Button()
    Me.lstResults = New System.Windows.Forms.ListBox()
    Me.btnDisplayCity = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lblJbhb
    '
    Me.lblJbhb.AutoSize = True
    Me.lblJbhb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblJbhb.Location = New System.Drawing.Point(151, 35)
    Me.lblJbhb.Name = "lblJbhb"
    Me.lblJbhb.Size = New System.Drawing.Size(54, 20)
    Me.lblJbhb.TabIndex = 0
    Me.lblJbhb.Text = "1. Jhb"
    '
    'lblCpt
    '
    Me.lblCpt.AutoSize = True
    Me.lblCpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCpt.Location = New System.Drawing.Point(284, 35)
    Me.lblCpt.Name = "lblCpt"
    Me.lblCpt.Size = New System.Drawing.Size(53, 20)
    Me.lblCpt.TabIndex = 1
    Me.lblCpt.Text = "2. Cpt"
    '
    'lblPe
    '
    Me.lblPe.AutoSize = True
    Me.lblPe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPe.Location = New System.Drawing.Point(415, 35)
    Me.lblPe.Name = "lblPe"
    Me.lblPe.Size = New System.Drawing.Size(49, 20)
    Me.lblPe.TabIndex = 2
    Me.lblPe.Text = "3. PE"
    '
    'lblDbn
    '
    Me.lblDbn.AutoSize = True
    Me.lblDbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDbn.Location = New System.Drawing.Point(539, 35)
    Me.lblDbn.Name = "lblDbn"
    Me.lblDbn.Size = New System.Drawing.Size(58, 20)
    Me.lblDbn.TabIndex = 3
    Me.lblDbn.Text = "4. Dbn"
    '
    'lblStartingPoint
    '
    Me.lblStartingPoint.AutoSize = True
    Me.lblStartingPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStartingPoint.Location = New System.Drawing.Point(151, 124)
    Me.lblStartingPoint.Name = "lblStartingPoint"
    Me.lblStartingPoint.Size = New System.Drawing.Size(115, 20)
    Me.lblStartingPoint.TabIndex = 4
    Me.lblStartingPoint.Text = "Starting Point:"
    '
    'txtStartingPoint
    '
    Me.txtStartingPoint.Location = New System.Drawing.Point(288, 116)
    Me.txtStartingPoint.Multiline = True
    Me.txtStartingPoint.Name = "txtStartingPoint"
    Me.txtStartingPoint.Size = New System.Drawing.Size(309, 28)
    Me.txtStartingPoint.TabIndex = 5
    '
    'lblDestination
    '
    Me.lblDestination.AutoSize = True
    Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDestination.Location = New System.Drawing.Point(151, 200)
    Me.lblDestination.Name = "lblDestination"
    Me.lblDestination.Size = New System.Drawing.Size(99, 20)
    Me.lblDestination.TabIndex = 6
    Me.lblDestination.Text = "Destination:"
    '
    'txtDestination
    '
    Me.txtDestination.Location = New System.Drawing.Point(288, 200)
    Me.txtDestination.Multiline = True
    Me.txtDestination.Name = "txtDestination"
    Me.txtDestination.Size = New System.Drawing.Size(309, 28)
    Me.txtDestination.TabIndex = 7
    '
    'btnDistance
    '
    Me.btnDistance.Location = New System.Drawing.Point(155, 253)
    Me.btnDistance.Name = "btnDistance"
    Me.btnDistance.Size = New System.Drawing.Size(204, 36)
    Me.btnDistance.TabIndex = 8
    Me.btnDistance.Text = "Calculate Distance"
    Me.btnDistance.UseVisualStyleBackColor = True
    '
    'lblDistance
    '
    Me.lblDistance.AutoSize = True
    Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDistance.Location = New System.Drawing.Point(151, 314)
    Me.lblDistance.Name = "lblDistance"
    Me.lblDistance.Size = New System.Drawing.Size(81, 20)
    Me.lblDistance.TabIndex = 9
    Me.lblDistance.Text = "Distance:"
    '
    'txtDistance
    '
    Me.txtDistance.Location = New System.Drawing.Point(288, 314)
    Me.txtDistance.Multiline = True
    Me.txtDistance.Name = "txtDistance"
    Me.txtDistance.ReadOnly = True
    Me.txtDistance.Size = New System.Drawing.Size(309, 28)
    Me.txtDistance.TabIndex = 10
    '
    'btnReenter
    '
    Me.btnReenter.Location = New System.Drawing.Point(155, 381)
    Me.btnReenter.Name = "btnReenter"
    Me.btnReenter.Size = New System.Drawing.Size(204, 35)
    Me.btnReenter.TabIndex = 11
    Me.btnReenter.Text = "Re-Enter"
    Me.btnReenter.UseVisualStyleBackColor = True
    '
    'btnExit
    '
    Me.btnExit.Location = New System.Drawing.Point(393, 381)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(204, 36)
    Me.btnExit.TabIndex = 12
    Me.btnExit.Text = "Exit"
    Me.btnExit.UseVisualStyleBackColor = True
    '
    'btnGetMore
    '
    Me.btnGetMore.Location = New System.Drawing.Point(393, 253)
    Me.btnGetMore.Name = "btnGetMore"
    Me.btnGetMore.Size = New System.Drawing.Size(204, 36)
    Me.btnGetMore.TabIndex = 13
    Me.btnGetMore.Text = "Get More than 1000 km"
    Me.btnGetMore.UseVisualStyleBackColor = True
    '
    'lstResults
    '
    Me.lstResults.FormattingEnabled = True
    Me.lstResults.ItemHeight = 16
    Me.lstResults.Location = New System.Drawing.Point(628, 116)
    Me.lstResults.Name = "lstResults"
    Me.lstResults.Size = New System.Drawing.Size(333, 308)
    Me.lstResults.TabIndex = 14
    '
    'btnDisplayCity
    '
    Me.btnDisplayCity.Location = New System.Drawing.Point(693, 60)
    Me.btnDisplayCity.Name = "btnDisplayCity"
    Me.btnDisplayCity.Size = New System.Drawing.Size(204, 36)
    Me.btnDisplayCity.TabIndex = 15
    Me.btnDisplayCity.Text = "Display City"
    Me.btnDisplayCity.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(973, 450)
    Me.Controls.Add(Me.btnDisplayCity)
    Me.Controls.Add(Me.lstResults)
    Me.Controls.Add(Me.btnGetMore)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnReenter)
    Me.Controls.Add(Me.txtDistance)
    Me.Controls.Add(Me.lblDistance)
    Me.Controls.Add(Me.btnDistance)
    Me.Controls.Add(Me.txtDestination)
    Me.Controls.Add(Me.lblDestination)
    Me.Controls.Add(Me.txtStartingPoint)
    Me.Controls.Add(Me.lblStartingPoint)
    Me.Controls.Add(Me.lblDbn)
    Me.Controls.Add(Me.lblPe)
    Me.Controls.Add(Me.lblCpt)
    Me.Controls.Add(Me.lblJbhb)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblJbhb As Label
  Friend WithEvents lblCpt As Label
  Friend WithEvents lblPe As Label
  Friend WithEvents lblDbn As Label
  Friend WithEvents lblStartingPoint As Label
  Friend WithEvents txtStartingPoint As TextBox
  Friend WithEvents lblDestination As Label
  Friend WithEvents txtDestination As TextBox
  Friend WithEvents btnDistance As Button
  Friend WithEvents lblDistance As Label
  Friend WithEvents txtDistance As TextBox
  Friend WithEvents btnReenter As Button
  Friend WithEvents btnExit As Button
  Friend WithEvents btnGetMore As Button
  Friend WithEvents lstResults As ListBox
  Friend WithEvents btnDisplayCity As Button
End Class
