<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hospital
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
        Me.btnPatients = New System.Windows.Forms.RadioButton()
        Me.btnStaff = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnPatients
        '
        Me.btnPatients.AutoSize = True
        Me.btnPatients.Location = New System.Drawing.Point(12, 32)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.Size = New System.Drawing.Size(63, 17)
        Me.btnPatients.TabIndex = 3
        Me.btnPatients.Text = "Patients"
        Me.btnPatients.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.AutoSize = True
        Me.btnStaff.Location = New System.Drawing.Point(12, 9)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(47, 17)
        Me.btnStaff.TabIndex = 2
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'Hospital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 62)
        Me.Controls.Add(Me.btnPatients)
        Me.Controls.Add(Me.btnStaff)
        Me.Name = "Hospital"
        Me.Text = "Hospital"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPatients As RadioButton
    Friend WithEvents btnStaff As RadioButton
End Class
