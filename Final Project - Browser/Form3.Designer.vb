<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lab_Date = New System.Windows.Forms.Label()
        Me.EnableDate = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateCreation = New System.Windows.Forms.TextBox()
        Me.EnableOrganization = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBox_Organization = New System.Windows.Forms.TextBox()
        Me.EnableVNum = New System.Windows.Forms.CheckBox()
        Me.TBox_VNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AutoSiteName = New System.Windows.Forms.Button()
        Me.EnableSiteName = New System.Windows.Forms.CheckBox()
        Me.TBox_SiteName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EnableName = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBox_Name = New System.Windows.Forms.TextBox()
        Me.But_Gen = New System.Windows.Forms.Button()
        Me.EnableURL = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EnableURL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Lab_Date)
        Me.GroupBox1.Controls.Add(Me.EnableDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateCreation)
        Me.GroupBox1.Controls.Add(Me.EnableOrganization)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBox_Organization)
        Me.GroupBox1.Controls.Add(Me.EnableVNum)
        Me.GroupBox1.Controls.Add(Me.TBox_VNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.AutoSiteName)
        Me.GroupBox1.Controls.Add(Me.EnableSiteName)
        Me.GroupBox1.Controls.Add(Me.TBox_SiteName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.EnableName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBox_Name)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 289)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Data Here"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "URL will be automatically added to the file."
        '
        'Lab_Date
        '
        Me.Lab_Date.AutoSize = True
        Me.Lab_Date.Location = New System.Drawing.Point(3, 265)
        Me.Lab_Date.Name = "Lab_Date"
        Me.Lab_Date.Size = New System.Drawing.Size(83, 13)
        Me.Lab_Date.TabIndex = 16
        Me.Lab_Date.Text = "Date of Access:"
        '
        'EnableDate
        '
        Me.EnableDate.AutoSize = True
        Me.EnableDate.Checked = True
        Me.EnableDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableDate.Location = New System.Drawing.Point(401, 244)
        Me.EnableDate.Name = "EnableDate"
        Me.EnableDate.Size = New System.Drawing.Size(65, 17)
        Me.EnableDate.TabIndex = 15
        Me.EnableDate.Text = "Enabled"
        Me.EnableDate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Date of Creation"
        '
        'DateCreation
        '
        Me.DateCreation.Location = New System.Drawing.Point(6, 242)
        Me.DateCreation.Name = "DateCreation"
        Me.DateCreation.Size = New System.Drawing.Size(389, 20)
        Me.DateCreation.TabIndex = 13
        '
        'EnableOrganization
        '
        Me.EnableOrganization.AutoSize = True
        Me.EnableOrganization.Checked = True
        Me.EnableOrganization.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableOrganization.Location = New System.Drawing.Point(401, 205)
        Me.EnableOrganization.Name = "EnableOrganization"
        Me.EnableOrganization.Size = New System.Drawing.Size(65, 17)
        Me.EnableOrganization.TabIndex = 12
        Me.EnableOrganization.Text = "Enabled"
        Me.EnableOrganization.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Organization"
        '
        'TBox_Organization
        '
        Me.TBox_Organization.Location = New System.Drawing.Point(6, 203)
        Me.TBox_Organization.Name = "TBox_Organization"
        Me.TBox_Organization.Size = New System.Drawing.Size(389, 20)
        Me.TBox_Organization.TabIndex = 10
        '
        'EnableVNum
        '
        Me.EnableVNum.AutoSize = True
        Me.EnableVNum.Checked = True
        Me.EnableVNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableVNum.Location = New System.Drawing.Point(401, 166)
        Me.EnableVNum.Name = "EnableVNum"
        Me.EnableVNum.Size = New System.Drawing.Size(65, 17)
        Me.EnableVNum.TabIndex = 9
        Me.EnableVNum.Text = "Enabled"
        Me.EnableVNum.UseVisualStyleBackColor = True
        '
        'TBox_VNum
        '
        Me.TBox_VNum.Location = New System.Drawing.Point(6, 164)
        Me.TBox_VNum.Name = "TBox_VNum"
        Me.TBox_VNum.Size = New System.Drawing.Size(389, 20)
        Me.TBox_VNum.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Version Number"
        '
        'AutoSiteName
        '
        Me.AutoSiteName.Location = New System.Drawing.Point(6, 122)
        Me.AutoSiteName.Name = "AutoSiteName"
        Me.AutoSiteName.Size = New System.Drawing.Size(107, 23)
        Me.AutoSiteName.TabIndex = 6
        Me.AutoSiteName.Text = "AutoFill Site Name"
        Me.AutoSiteName.UseVisualStyleBackColor = True
        '
        'EnableSiteName
        '
        Me.EnableSiteName.AutoSize = True
        Me.EnableSiteName.Checked = True
        Me.EnableSiteName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableSiteName.Location = New System.Drawing.Point(401, 98)
        Me.EnableSiteName.Name = "EnableSiteName"
        Me.EnableSiteName.Size = New System.Drawing.Size(65, 17)
        Me.EnableSiteName.TabIndex = 5
        Me.EnableSiteName.Text = "Enabled"
        Me.EnableSiteName.UseVisualStyleBackColor = True
        '
        'TBox_SiteName
        '
        Me.TBox_SiteName.Location = New System.Drawing.Point(6, 96)
        Me.TBox_SiteName.Name = "TBox_SiteName"
        Me.TBox_SiteName.Size = New System.Drawing.Size(389, 20)
        Me.TBox_SiteName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name of Site"
        '
        'EnableName
        '
        Me.EnableName.AutoSize = True
        Me.EnableName.Checked = True
        Me.EnableName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableName.Location = New System.Drawing.Point(401, 59)
        Me.EnableName.Name = "EnableName"
        Me.EnableName.Size = New System.Drawing.Size(65, 17)
        Me.EnableName.TabIndex = 2
        Me.EnableName.Text = "Enabled"
        Me.EnableName.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Editor, Author, or Compiler name"
        '
        'TBox_Name
        '
        Me.TBox_Name.Location = New System.Drawing.Point(6, 57)
        Me.TBox_Name.Name = "TBox_Name"
        Me.TBox_Name.Size = New System.Drawing.Size(389, 20)
        Me.TBox_Name.TabIndex = 0
        '
        'But_Gen
        '
        Me.But_Gen.Location = New System.Drawing.Point(394, 307)
        Me.But_Gen.Name = "But_Gen"
        Me.But_Gen.Size = New System.Drawing.Size(99, 23)
        Me.But_Gen.TabIndex = 1
        Me.But_Gen.Text = "Generate Text"
        Me.But_Gen.UseVisualStyleBackColor = True
        '
        'EnableURL
        '
        Me.EnableURL.AutoSize = True
        Me.EnableURL.Checked = True
        Me.EnableURL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableURL.Location = New System.Drawing.Point(219, 15)
        Me.EnableURL.Name = "EnableURL"
        Me.EnableURL.Size = New System.Drawing.Size(90, 17)
        Me.EnableURL.TabIndex = 18
        Me.EnableURL.Text = "URL Enabled"
        Me.EnableURL.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 344)
        Me.Controls.Add(Me.But_Gen)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.Text = "MLA Citation Machine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBox_SiteName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EnableName As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents EnableSiteName As System.Windows.Forms.CheckBox
    Friend WithEvents EnableVNum As System.Windows.Forms.CheckBox
    Friend WithEvents TBox_VNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AutoSiteName As System.Windows.Forms.Button
    Friend WithEvents EnableOrganization As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBox_Organization As System.Windows.Forms.TextBox
    Friend WithEvents EnableDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateCreation As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Date As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents But_Gen As System.Windows.Forms.Button
    Friend WithEvents EnableURL As System.Windows.Forms.CheckBox
End Class
