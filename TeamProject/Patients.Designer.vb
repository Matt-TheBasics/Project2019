<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Me.btnTB = New System.Windows.Forms.RadioButton()
        Me.btnHIV = New System.Windows.Forms.RadioButton()
        Me.btnOther = New System.Windows.Forms.RadioButton()
        Me.check1 = New System.Windows.Forms.CheckBox()
        Me.txtillness = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTB
        '
        Me.btnTB.AutoSize = True
        Me.btnTB.Location = New System.Drawing.Point(12, 31)
        Me.btnTB.Name = "btnTB"
        Me.btnTB.Size = New System.Drawing.Size(39, 17)
        Me.btnTB.TabIndex = 3
        Me.btnTB.TabStop = True
        Me.btnTB.Text = "TB"
        Me.btnTB.UseVisualStyleBackColor = True
        '
        'btnHIV
        '
        Me.btnHIV.AutoSize = True
        Me.btnHIV.Location = New System.Drawing.Point(12, 8)
        Me.btnHIV.Name = "btnHIV"
        Me.btnHIV.Size = New System.Drawing.Size(43, 17)
        Me.btnHIV.TabIndex = 2
        Me.btnHIV.TabStop = True
        Me.btnHIV.Text = "HIV"
        Me.btnHIV.UseVisualStyleBackColor = True
        '
        'btnOther
        '
        Me.btnOther.AutoSize = True
        Me.btnOther.Location = New System.Drawing.Point(12, 55)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(51, 17)
        Me.btnOther.TabIndex = 4
        Me.btnOther.TabStop = True
        Me.btnOther.Text = "Other"
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'check1
        '
        Me.check1.AutoSize = True
        Me.check1.Location = New System.Drawing.Point(224, 97)
        Me.check1.Name = "check1"
        Me.check1.Size = New System.Drawing.Size(15, 14)
        Me.check1.TabIndex = 5
        Me.check1.UseVisualStyleBackColor = True
        Me.check1.Visible = False
        '
        'txtillness
        '
        Me.txtillness.Location = New System.Drawing.Point(12, 91)
        Me.txtillness.Name = "txtillness"
        Me.txtillness.Size = New System.Drawing.Size(206, 20)
        Me.txtillness.TabIndex = 6
        Me.txtillness.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(9, 75)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(168, 13)
        Me.lblMsg.TabIndex = 7
        Me.lblMsg.Text = "Please specify the illness then tick"
        Me.lblMsg.Visible = False
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 144)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtillness)
        Me.Controls.Add(Me.check1)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnTB)
        Me.Controls.Add(Me.btnHIV)
        Me.Name = "Patients"
        Me.Text = "Patients"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTB As RadioButton
    Friend WithEvents btnHIV As RadioButton
    Friend WithEvents btnOther As RadioButton
    Friend WithEvents check1 As CheckBox
    Friend WithEvents txtillness As TextBox
    Friend WithEvents lblMsg As Label
End Class
