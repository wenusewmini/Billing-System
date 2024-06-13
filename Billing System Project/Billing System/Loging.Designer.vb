<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loging))
        Me.btnloging = New System.Windows.Forms.Button()
        Me.checkbx1 = New System.Windows.Forms.CheckBox()
        Me.txtbxpwd = New System.Windows.Forms.TextBox()
        Me.txtbxuName = New System.Windows.Forms.TextBox()
        Me.L3Pwd = New System.Windows.Forms.Label()
        Me.L2uName = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.L1topic = New System.Windows.Forms.Label()
        Me.PbxClose = New System.Windows.Forms.PictureBox()
        Me.L4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnloging
        '
        Me.btnloging.BackColor = System.Drawing.Color.Crimson
        Me.btnloging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloging.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloging.ForeColor = System.Drawing.Color.White
        Me.btnloging.Location = New System.Drawing.Point(288, 270)
        Me.btnloging.Name = "btnloging"
        Me.btnloging.Size = New System.Drawing.Size(166, 35)
        Me.btnloging.TabIndex = 20
        Me.btnloging.Text = "LOGING"
        Me.btnloging.UseVisualStyleBackColor = False
        '
        'checkbx1
        '
        Me.checkbx1.AutoSize = True
        Me.checkbx1.Location = New System.Drawing.Point(338, 216)
        Me.checkbx1.Name = "checkbx1"
        Me.checkbx1.Size = New System.Drawing.Size(102, 17)
        Me.checkbx1.TabIndex = 19
        Me.checkbx1.Text = "Show Password"
        Me.checkbx1.UseVisualStyleBackColor = True
        '
        'txtbxpwd
        '
        Me.txtbxpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxpwd.Location = New System.Drawing.Point(338, 188)
        Me.txtbxpwd.Name = "txtbxpwd"
        Me.txtbxpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxpwd.Size = New System.Drawing.Size(176, 22)
        Me.txtbxpwd.TabIndex = 18
        '
        'txtbxuName
        '
        Me.txtbxuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxuName.Location = New System.Drawing.Point(338, 117)
        Me.txtbxuName.Name = "txtbxuName"
        Me.txtbxuName.Size = New System.Drawing.Size(176, 22)
        Me.txtbxuName.TabIndex = 17
        '
        'L3Pwd
        '
        Me.L3Pwd.AutoSize = True
        Me.L3Pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3Pwd.Location = New System.Drawing.Point(334, 165)
        Me.L3Pwd.Name = "L3Pwd"
        Me.L3Pwd.Size = New System.Drawing.Size(78, 20)
        Me.L3Pwd.TabIndex = 16
        Me.L3Pwd.Text = "Password"
        '
        'L2uName
        '
        Me.L2uName.AutoSize = True
        Me.L2uName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2uName.Location = New System.Drawing.Point(334, 94)
        Me.L2uName.Name = "L2uName"
        Me.L2uName.Size = New System.Drawing.Size(89, 20)
        Me.L2uName.TabIndex = 15
        Me.L2uName.Text = "User Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(76, 117)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 145)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(42, 351)
        Me.Panel1.TabIndex = 13
        '
        'L1topic
        '
        Me.L1topic.AutoSize = True
        Me.L1topic.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1topic.ForeColor = System.Drawing.Color.Black
        Me.L1topic.Location = New System.Drawing.Point(145, 18)
        Me.L1topic.Name = "L1topic"
        Me.L1topic.Size = New System.Drawing.Size(294, 32)
        Me.L1topic.TabIndex = 12
        Me.L1topic.Text = "SAMEERA BOOKSHOP"
        '
        'PbxClose
        '
        Me.PbxClose.Image = CType(resources.GetObject("PbxClose.Image"), System.Drawing.Image)
        Me.PbxClose.Location = New System.Drawing.Point(530, 1)
        Me.PbxClose.Name = "PbxClose"
        Me.PbxClose.Size = New System.Drawing.Size(47, 37)
        Me.PbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxClose.TabIndex = 11
        Me.PbxClose.TabStop = False
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4.ForeColor = System.Drawing.Color.Crimson
        Me.L4.Location = New System.Drawing.Point(294, 308)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(154, 20)
        Me.L4.TabIndex = 21
        Me.L4.Text = "Continue As Cashier"
        '
        'Loging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 351)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.btnloging)
        Me.Controls.Add(Me.checkbx1)
        Me.Controls.Add(Me.txtbxpwd)
        Me.Controls.Add(Me.txtbxuName)
        Me.Controls.Add(Me.L3Pwd)
        Me.Controls.Add(Me.L2uName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.L1topic)
        Me.Controls.Add(Me.PbxClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loging..."
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnloging As System.Windows.Forms.Button
    Friend WithEvents checkbx1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtbxpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtbxuName As System.Windows.Forms.TextBox
    Friend WithEvents L3Pwd As System.Windows.Forms.Label
    Friend WithEvents L2uName As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents L1topic As System.Windows.Forms.Label
    Friend WithEvents PbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents L4 As System.Windows.Forms.Label
End Class
