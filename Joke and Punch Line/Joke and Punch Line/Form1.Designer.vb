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
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(180, 27)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine.TabIndex = 0
        Me.btnPunchLine.Text = "Punch line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(180, 140)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(12, 65)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(403, 24)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "What do you call it when Batman skips church?"
        Me.lblQuestion.Visible = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(154, 192)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(124, 24)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "Christian Bale"
        Me.lblAnswer.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 307)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
