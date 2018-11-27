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
        Me.LabelPasswordResult = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelPasswordCheck = New System.Windows.Forms.Label()
        Me.TextBoxPasswordCheck = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxLanguageOther = New System.Windows.Forms.TextBox()
        Me.CheckBoxLanguageOther = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLanguageChiness = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLanguageJapaness = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLanguageEnglish = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLanguageThai = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelPasswordResult
        '
        Me.LabelPasswordResult.Location = New System.Drawing.Point(277, 33)
        Me.LabelPasswordResult.Name = "LabelPasswordResult"
        Me.LabelPasswordResult.Size = New System.Drawing.Size(167, 20)
        Me.LabelPasswordResult.TabIndex = 5
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(104, 33)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxPassword.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(104, 7)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxUsername.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxUsername.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'LabelPasswordCheck
        '
        Me.LabelPasswordCheck.Location = New System.Drawing.Point(277, 59)
        Me.LabelPasswordCheck.Name = "LabelPasswordCheck"
        Me.LabelPasswordCheck.Size = New System.Drawing.Size(167, 20)
        Me.LabelPasswordCheck.TabIndex = 10
        '
        'TextBoxPasswordCheck
        '
        Me.TextBoxPasswordCheck.Location = New System.Drawing.Point(104, 59)
        Me.TextBoxPasswordCheck.Name = "TextBoxPasswordCheck"
        Me.TextBoxPasswordCheck.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPasswordCheck.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxPasswordCheck.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirm Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 35)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(148, 14)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(94, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Gender"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxLanguageOther)
        Me.GroupBox2.Controls.Add(Me.CheckBoxLanguageOther)
        Me.GroupBox2.Controls.Add(Me.CheckBoxLanguageChiness)
        Me.GroupBox2.Controls.Add(Me.CheckBoxLanguageJapaness)
        Me.GroupBox2.Controls.Add(Me.CheckBoxLanguageEnglish)
        Me.GroupBox2.Controls.Add(Me.CheckBoxLanguageThai)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 146)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'TextBoxLanguageOther
        '
        Me.TextBoxLanguageOther.Location = New System.Drawing.Point(148, 105)
        Me.TextBoxLanguageOther.Name = "TextBoxLanguageOther"
        Me.TextBoxLanguageOther.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLanguageOther.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxLanguageOther.TabIndex = 13
        '
        'CheckBoxLanguageOther
        '
        Me.CheckBoxLanguageOther.AutoSize = True
        Me.CheckBoxLanguageOther.Location = New System.Drawing.Point(94, 107)
        Me.CheckBoxLanguageOther.Name = "CheckBoxLanguageOther"
        Me.CheckBoxLanguageOther.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxLanguageOther.TabIndex = 19
        Me.CheckBoxLanguageOther.Text = "Other :"
        Me.CheckBoxLanguageOther.UseVisualStyleBackColor = True
        '
        'CheckBoxLanguageChiness
        '
        Me.CheckBoxLanguageChiness.AutoSize = True
        Me.CheckBoxLanguageChiness.Location = New System.Drawing.Point(94, 84)
        Me.CheckBoxLanguageChiness.Name = "CheckBoxLanguageChiness"
        Me.CheckBoxLanguageChiness.Size = New System.Drawing.Size(63, 17)
        Me.CheckBoxLanguageChiness.TabIndex = 18
        Me.CheckBoxLanguageChiness.Text = "Chiness"
        Me.CheckBoxLanguageChiness.UseVisualStyleBackColor = True
        '
        'CheckBoxLanguageJapaness
        '
        Me.CheckBoxLanguageJapaness.AutoSize = True
        Me.CheckBoxLanguageJapaness.Location = New System.Drawing.Point(94, 61)
        Me.CheckBoxLanguageJapaness.Name = "CheckBoxLanguageJapaness"
        Me.CheckBoxLanguageJapaness.Size = New System.Drawing.Size(71, 17)
        Me.CheckBoxLanguageJapaness.TabIndex = 17
        Me.CheckBoxLanguageJapaness.Text = "Japaness"
        Me.CheckBoxLanguageJapaness.UseVisualStyleBackColor = True
        '
        'CheckBoxLanguageEnglish
        '
        Me.CheckBoxLanguageEnglish.AutoSize = True
        Me.CheckBoxLanguageEnglish.Location = New System.Drawing.Point(94, 38)
        Me.CheckBoxLanguageEnglish.Name = "CheckBoxLanguageEnglish"
        Me.CheckBoxLanguageEnglish.Size = New System.Drawing.Size(60, 17)
        Me.CheckBoxLanguageEnglish.TabIndex = 16
        Me.CheckBoxLanguageEnglish.Text = "English"
        Me.CheckBoxLanguageEnglish.UseVisualStyleBackColor = True
        '
        'CheckBoxLanguageThai
        '
        Me.CheckBoxLanguageThai.AutoSize = True
        Me.CheckBoxLanguageThai.Location = New System.Drawing.Point(94, 15)
        Me.CheckBoxLanguageThai.Name = "CheckBoxLanguageThai"
        Me.CheckBoxLanguageThai.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxLanguageThai.TabIndex = 13
        Me.CheckBoxLanguageThai.Text = "Thai"
        Me.CheckBoxLanguageThai.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Language"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(13, 279)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(114, 35)
        Me.ButtonRegister.TabIndex = 13
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(151, 279)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(114, 35)
        Me.ButtonReset.TabIndex = 14
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 348)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelPasswordCheck)
        Me.Controls.Add(Me.TextBoxPasswordCheck)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelPasswordResult)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPasswordResult As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelPasswordCheck As Label
    Friend WithEvents TextBoxPasswordCheck As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBoxLanguageOther As CheckBox
    Friend WithEvents CheckBoxLanguageChiness As CheckBox
    Friend WithEvents CheckBoxLanguageJapaness As CheckBox
    Friend WithEvents CheckBoxLanguageEnglish As CheckBox
    Friend WithEvents CheckBoxLanguageThai As CheckBox
    Friend WithEvents TextBoxLanguageOther As TextBox
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonReset As Button
End Class
