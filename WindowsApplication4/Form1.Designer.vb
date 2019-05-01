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
        Me.components = New System.ComponentModel.Container()
        Me.TitleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ExitBT = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleTimer
        '
        Me.TitleTimer.Enabled = True
        Me.TitleTimer.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.ExitBT)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Controls.Add(Me.LogoBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 57)
        Me.Panel1.TabIndex = 0
        '
        'LogoBox
        '
        Me.LogoBox.Image = Global.WindowsApplication4.My.Resources.Resources.home
        Me.LogoBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(58, 57)
        Me.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoBox.TabIndex = 1
        Me.LogoBox.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(57, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(107, 57)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Form1"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitBT
        '
        Me.ExitBT.BackColor = System.Drawing.Color.Firebrick
        Me.ExitBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitBT.FlatAppearance.BorderSize = 0
        Me.ExitBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBT.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBT.ForeColor = System.Drawing.Color.White
        Me.ExitBT.Location = New System.Drawing.Point(860, 0)
        Me.ExitBT.Name = "ExitBT"
        Me.ExitBT.Size = New System.Drawing.Size(62, 57)
        Me.ExitBT.TabIndex = 1
        Me.ExitBT.Text = "X"
        Me.ExitBT.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 577)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleTimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LogoBox As System.Windows.Forms.PictureBox
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents ExitBT As System.Windows.Forms.Button

End Class
