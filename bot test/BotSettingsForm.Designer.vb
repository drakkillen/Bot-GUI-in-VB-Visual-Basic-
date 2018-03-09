﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BotSettingsForm
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
        Me.TokenInput = New System.Windows.Forms.TextBox()
        Me.SaveToken = New System.Windows.Forms.Button()
        Me.ReloadBotButton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.str_url = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pl_txt = New System.Windows.Forms.TextBox()
        Me.ColourSettings = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.ColourSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TokenInput
        '
        Me.TokenInput.Location = New System.Drawing.Point(12, 12)
        Me.TokenInput.Name = "TokenInput"
        Me.TokenInput.Size = New System.Drawing.Size(338, 20)
        Me.TokenInput.TabIndex = 0
        Me.TokenInput.UseSystemPasswordChar = True
        '
        'SaveToken
        '
        Me.SaveToken.AutoEllipsis = True
        Me.SaveToken.Location = New System.Drawing.Point(356, 12)
        Me.SaveToken.Name = "SaveToken"
        Me.SaveToken.Size = New System.Drawing.Size(75, 23)
        Me.SaveToken.TabIndex = 1
        Me.SaveToken.Text = "Save Token"
        Me.SaveToken.UseVisualStyleBackColor = True
        '
        'ReloadBotButton
        '
        Me.ReloadBotButton.Location = New System.Drawing.Point(448, 12)
        Me.ReloadBotButton.Name = "ReloadBotButton"
        Me.ReloadBotButton.Size = New System.Drawing.Size(125, 22)
        Me.ReloadBotButton.TabIndex = 2
        Me.ReloadBotButton.Text = "Reload Bot"
        Me.ReloadBotButton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(408, 127)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Bot Settings"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.str_url)
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.pl_txt)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(386, 99)
        Me.GroupBox7.TabIndex = 27
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Current Playing Message"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(266, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 29)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Save Them"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Streaming URL [Leave Empty if you dont want it]"
        '
        'str_url
        '
        Me.str_url.Location = New System.Drawing.Point(12, 68)
        Me.str_url.Name = "str_url"
        Me.str_url.Size = New System.Drawing.Size(248, 20)
        Me.str_url.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(266, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Set Them"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pl_txt
        '
        Me.pl_txt.Location = New System.Drawing.Point(12, 19)
        Me.pl_txt.Name = "pl_txt"
        Me.pl_txt.Size = New System.Drawing.Size(248, 20)
        Me.pl_txt.TabIndex = 30
        '
        'ColourSettings
        '
        Me.ColourSettings.Controls.Add(Me.Label5)
        Me.ColourSettings.Controls.Add(Me.Label4)
        Me.ColourSettings.Controls.Add(Me.Label3)
        Me.ColourSettings.Controls.Add(Me.Label1)
        Me.ColourSettings.Location = New System.Drawing.Point(439, 48)
        Me.ColourSettings.Name = "ColourSettings"
        Me.ColourSettings.Size = New System.Drawing.Size(226, 129)
        Me.ColourSettings.TabIndex = 28
        Me.ColourSettings.TabStop = False
        Me.ColourSettings.Text = "Color Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.DiscordGUI.net.My.MySettings.Default, "CurrentBotColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label5.ForeColor = Global.DiscordGUI.net.My.MySettings.Default.CurrentBotColor
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Current Bot:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.DiscordGUI.net.My.MySettings.Default, "MessageColorSetting", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label4.ForeColor = Global.DiscordGUI.net.My.MySettings.Default.MessageColorSetting
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Message:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.DiscordGUI.net.My.MySettings.Default, "ChannelColourSettings", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label3.ForeColor = Global.DiscordGUI.net.My.MySettings.Default.ChannelColourSettings
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Channel:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.DiscordGUI.net.My.MySettings.Default, "GuildColourSetting", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.ForeColor = Global.DiscordGUI.net.My.MySettings.Default.GuildColourSetting
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guild:"
        '
        'BotSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 198)
        Me.Controls.Add(Me.ColourSettings)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ReloadBotButton)
        Me.Controls.Add(Me.SaveToken)
        Me.Controls.Add(Me.TokenInput)
        Me.Name = "BotSettingsForm"
        Me.Text = "BotSettingsForm"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ColourSettings.ResumeLayout(False)
        Me.ColourSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TokenInput As TextBox
    Friend WithEvents SaveToken As Button
    Friend WithEvents ReloadBotButton As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents str_url As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pl_txt As TextBox
    Friend WithEvents ColourSettings As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
