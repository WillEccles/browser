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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.But_MLA = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.But_OpenSrc = New System.Windows.Forms.ToolStripMenuItem()
        Me.But_DLSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.But_CloseApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.But_Back = New System.Windows.Forms.ToolStripMenuItem()
        Me.But_Forward = New System.Windows.Forms.ToolStripMenuItem()
        Me.But_Home = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TBox_Address = New System.Windows.Forms.ToolStripTextBox()
        Me.But_Go = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoadingLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Browser = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.But_Back, Me.But_Forward, Me.But_Home, Me.ReloadToolStripMenuItem, Me.TBox_Address, Me.But_Go})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 27)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.But_MLA, Me.SettingsToolStripMenuItem, Me.But_OpenSrc, Me.But_DLSource, Me.ToolStripSeparator1, Me.But_CloseApp})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'But_MLA
        '
        Me.But_MLA.Name = "But_MLA"
        Me.But_MLA.Size = New System.Drawing.Size(241, 22)
        Me.But_MLA.Text = "Get MLA Citation"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'But_OpenSrc
        '
        Me.But_OpenSrc.Name = "But_OpenSrc"
        Me.But_OpenSrc.Size = New System.Drawing.Size(241, 22)
        Me.But_OpenSrc.Text = "Open file..."
        '
        'But_DLSource
        '
        Me.But_DLSource.Name = "But_DLSource"
        Me.But_DLSource.Size = New System.Drawing.Size(241, 22)
        Me.But_DLSource.Text = "Download Page Source as .html"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(238, 6)
        '
        'But_CloseApp
        '
        Me.But_CloseApp.Name = "But_CloseApp"
        Me.But_CloseApp.Size = New System.Drawing.Size(241, 22)
        Me.But_CloseApp.Text = "Close App"
        '
        'But_Back
        '
        Me.But_Back.Name = "But_Back"
        Me.But_Back.Size = New System.Drawing.Size(44, 23)
        Me.But_Back.Text = "Back"
        '
        'But_Forward
        '
        Me.But_Forward.Name = "But_Forward"
        Me.But_Forward.Size = New System.Drawing.Size(62, 23)
        Me.But_Forward.Text = "Forward"
        '
        'But_Home
        '
        Me.But_Home.Name = "But_Home"
        Me.But_Home.Size = New System.Drawing.Size(52, 23)
        Me.But_Home.Text = "Home"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(55, 23)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'TBox_Address
        '
        Me.TBox_Address.BackColor = System.Drawing.SystemColors.Window
        Me.TBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBox_Address.Name = "TBox_Address"
        Me.TBox_Address.Size = New System.Drawing.Size(500, 23)
        '
        'But_Go
        '
        Me.But_Go.BackColor = System.Drawing.Color.Lime
        Me.But_Go.Name = "But_Go"
        Me.But_Go.Size = New System.Drawing.Size(34, 23)
        Me.But_Go.Text = "Go"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadingLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 635)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(794, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        '
        'LoadingLabel
        '
        Me.LoadingLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(71, 17)
        Me.LoadingLabel.Text = "Load Status"
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(0, 27)
        Me.Browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(794, 608)
        Me.Browser.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 657)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(810, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browser by Will Eccles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents But_Back As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents But_Forward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents But_Home As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBox_Address As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents But_Go As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents But_CloseApp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LoadingLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents But_DLSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents But_OpenSrc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents But_MLA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Browser As System.Windows.Forms.WebBrowser

End Class
