﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.SendMessage = New System.Windows.Forms.Button()
        Me.MessageBox = New System.Windows.Forms.RichTextBox()
        Me.ChannelList = New System.Windows.Forms.ListBox()
        Me.GuildList = New System.Windows.Forms.ListBox()
        Me.RefreshGuild = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UserList = New System.Windows.Forms.ListBox()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenChatViewer = New System.Windows.Forms.Button()
        Me.MentionToggle = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ShowLastMention = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.UserSearchBox = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertMentionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendDMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KickUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetAvatarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EmogiAutocomplete = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
<<<<<<< HEAD:bot test/forms/Form1.Designer.vb
        Me.console_output = New System.Windows.Forms.TextBox()
        Me.input = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
=======
>>>>>>> 426859a59eb33aac0a3a2696dff0b8bf86014afa:bot test/Form1.Designer.vb
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SendMessage
        '
        Me.SendMessage.Location = New System.Drawing.Point(6, 83)
        Me.SendMessage.Name = "SendMessage"
        Me.SendMessage.Size = New System.Drawing.Size(208, 27)
        Me.SendMessage.TabIndex = 0
        Me.SendMessage.Text = "Send message"
        Me.SendMessage.UseVisualStyleBackColor = True
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(6, 22)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(208, 55)
        Me.MessageBox.TabIndex = 2
        Me.MessageBox.Text = ""
        '
        'ChannelList
        '
        Me.ChannelList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChannelList.FormattingEnabled = True
        Me.ChannelList.Location = New System.Drawing.Point(3, 16)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(194, 255)
        Me.ChannelList.Sorted = True
        Me.ChannelList.TabIndex = 4
        '
        'GuildList
        '
        Me.GuildList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GuildList.FormattingEnabled = True
        Me.GuildList.Location = New System.Drawing.Point(3, 16)
        Me.GuildList.Name = "GuildList"
        Me.GuildList.Size = New System.Drawing.Size(217, 193)
        Me.GuildList.Sorted = True
        Me.GuildList.TabIndex = 7
        '
        'RefreshGuild
        '
        Me.RefreshGuild.Location = New System.Drawing.Point(11, 232)
        Me.RefreshGuild.Name = "RefreshGuild"
        Me.RefreshGuild.Size = New System.Drawing.Size(217, 23)
        Me.RefreshGuild.TabIndex = 8
        Me.RefreshGuild.Text = "Refresh Guild List"
        Me.RefreshGuild.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UserList
        '
        Me.UserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserList.FormattingEnabled = True
        Me.UserList.Location = New System.Drawing.Point(3, 16)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(222, 230)
        Me.UserList.Sorted = True
        Me.UserList.TabIndex = 12
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(6, 116)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(208, 23)
        Me.OpenFile.TabIndex = 16
        Me.OpenFile.Text = "Send File"
        Me.OpenFile.UseVisualStyleBackColor = True
        '
        'OpenChatViewer
        '
        Me.OpenChatViewer.Location = New System.Drawing.Point(17, 19)
        Me.OpenChatViewer.Name = "OpenChatViewer"
        Me.OpenChatViewer.Size = New System.Drawing.Size(169, 31)
        Me.OpenChatViewer.TabIndex = 19
        Me.OpenChatViewer.Text = "Open Chat Viewer"
        Me.OpenChatViewer.UseVisualStyleBackColor = True
        '
        'MentionToggle
        '
        Me.MentionToggle.AutoSize = True
        Me.MentionToggle.Location = New System.Drawing.Point(192, 27)
        Me.MentionToggle.Name = "MentionToggle"
        Me.MentionToggle.Size = New System.Drawing.Size(147, 17)
        Me.MentionToggle.TabIndex = 21
        Me.MentionToggle.Text = "Disable Mention Pop-Up?"
        Me.MentionToggle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GuildList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 212)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guilds list"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChannelList)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 274)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Channels List"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UserList)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 249)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Users List"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ShowLastMention)
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.OpenChatViewer)
        Me.GroupBox8.Controls.Add(Me.MentionToggle)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 309)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(341, 207)
        Me.GroupBox8.TabIndex = 27
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Chat Commands"
        '
        'ShowLastMention
        '
        Me.ShowLastMention.Location = New System.Drawing.Point(192, 45)
        Me.ShowLastMention.Name = "ShowLastMention"
        Me.ShowLastMention.Size = New System.Drawing.Size(147, 21)
        Me.ShowLastMention.TabIndex = 29
        Me.ShowLastMention.Text = "Show Last Mention"
        Me.ShowLastMention.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.MessageBox)
        Me.GroupBox9.Controls.Add(Me.SendMessage)
        Me.GroupBox9.Controls.Add(Me.OpenFile)
        Me.GroupBox9.Location = New System.Drawing.Point(17, 56)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(232, 145)
        Me.GroupBox9.TabIndex = 28
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Message"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.UserSearchBox)
        Me.GroupBox10.Controls.Add(Me.GroupBox3)
        Me.GroupBox10.Location = New System.Drawing.Point(452, 24)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(240, 291)
        Me.GroupBox10.TabIndex = 28
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "User Management"
        '
        'UserSearchBox
        '
        Me.UserSearchBox.Location = New System.Drawing.Point(14, 265)
        Me.UserSearchBox.Name = "UserSearchBox"
        Me.UserSearchBox.Size = New System.Drawing.Size(217, 20)
        Me.UserSearchBox.TabIndex = 25
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.GroupBox1)
        Me.GroupBox11.Controls.Add(Me.RefreshGuild)
        Me.GroupBox11.Location = New System.Drawing.Point(3, 24)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(238, 274)
        Me.GroupBox11.TabIndex = 29
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Guilds Management"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertMentionToolStripMenuItem, Me.SendDMToolStripMenuItem, Me.KickUserToolStripMenuItem, Me.BanUserToolStripMenuItem, Me.GetAvatarToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 136)
        '
        'InsertMentionToolStripMenuItem
        '
        Me.InsertMentionToolStripMenuItem.Name = "InsertMentionToolStripMenuItem"
        Me.InsertMentionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsertMentionToolStripMenuItem.Text = "Insert Mention"
        '
        'SendDMToolStripMenuItem
        '
        Me.SendDMToolStripMenuItem.Name = "SendDMToolStripMenuItem"
        Me.SendDMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SendDMToolStripMenuItem.Text = "Send DM"
        '
        'KickUserToolStripMenuItem
        '
        Me.KickUserToolStripMenuItem.Name = "KickUserToolStripMenuItem"
        Me.KickUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KickUserToolStripMenuItem.Text = "Kick User"
        '
        'BanUserToolStripMenuItem
        '
        Me.BanUserToolStripMenuItem.Name = "BanUserToolStripMenuItem"
        Me.BanUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BanUserToolStripMenuItem.Text = "Ban User"
        '
        'GetAvatarToolStripMenuItem1
        '
        Me.GetAvatarToolStripMenuItem1.Name = "GetAvatarToolStripMenuItem1"
        Me.GetAvatarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.GetAvatarToolStripMenuItem1.Text = "Get User Info"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Current bot: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(350, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Status:"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'EmogiAutocomplete
        '
        Me.EmogiAutocomplete.Name = "ContextMenuStrip3"
        Me.EmogiAutocomplete.Size = New System.Drawing.Size(61, 4)
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6})
        Me.MenuItem1.Text = "Settings"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem2.Text = "Help"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Discord"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Source"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "About"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Bot Settngs"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DiscordGUI.net.My.Resources.Resources.DISCORDGUI_net
        Me.PictureBox1.Location = New System.Drawing.Point(350, 354)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
<<<<<<< HEAD:bot test/forms/Form1.Designer.vb
        'console_output
        '
        Me.console_output.BackColor = System.Drawing.Color.Black
        Me.console_output.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.console_output.Location = New System.Drawing.Point(21, 19)
        Me.console_output.Multiline = True
        Me.console_output.Name = "console_output"
        Me.console_output.Size = New System.Drawing.Size(255, 120)
        Me.console_output.TabIndex = 35
        '
        'input
        '
        Me.input.BackColor = System.Drawing.Color.Black
        Me.input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input.Location = New System.Drawing.Point(21, 145)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(255, 13)
        Me.input.TabIndex = 36
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.console_output)
        Me.GroupBox4.Controls.Add(Me.input)
        Me.GroupBox4.Location = New System.Drawing.Point(619, 403)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
=======
>>>>>>> 426859a59eb33aac0a3a2696dff0b8bf86014afa:bot test/Form1.Designer.vb
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(843, 561)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "MainWindow"
        Me.Text = "DiscordGUI.NET 1.1.0"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendMessage As Button
    Friend WithEvents MessageBox As RichTextBox
    Friend WithEvents ChannelList As ListBox
    Friend WithEvents GuildList As ListBox
    Friend WithEvents RefreshGuild As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents UserList As ListBox
    Friend WithEvents OpenFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenChatViewer As Button
    Friend WithEvents MentionToggle As CheckBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InsertMentionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendDMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KickUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BanUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents EmogiAutocomplete As ContextMenuStrip
    Friend WithEvents ShowLastMention As Button
    Friend WithEvents GetAvatarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserSearchBox As TextBox
    Friend WithEvents MainMenu1 As MainMenu
    Friend WithEvents MenuItem1 As MenuItem
    Friend WithEvents MenuItem2 As MenuItem
    Friend WithEvents MenuItem3 As MenuItem
    Friend WithEvents MenuItem4 As MenuItem
    Friend WithEvents MenuItem5 As MenuItem
    Friend WithEvents MenuItem6 As MenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents console_output As TextBox
    Friend WithEvents input As TextBox
End Class