'Will Eccles
'Date: 12/18/13
'Project: Final Project - Browser
'Language: VB.net

Option Explicit On
Imports System.IO
Imports System.Net
Imports System.Reflection

Public Class Form1
    'search google in 'Browser' for the text 'input'
    Public Sub searchgoogle(ByVal chosenBrowser As WebBrowser, ByVal input As String)
		chosenBrowser.Navigate(New Uri("http://www.google.com/#hl=en&q=" & input.Replace(" ", "+")))
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        'Show settings when you press the button in the File Menu
        Form2.ShowDialog()
	End Sub
    'Save while closing form.
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If Me.WindowState = FormWindowState.Maximized Then
			My.Settings.IsMaxed = True
			My.Settings.Save()
		Else
			My.Settings.IsMaxed = False
			My.Settings.LastWidth = Me.Width
			My.Settings.LastHeight = Me.Height
			My.Settings.Save()
		End If
	End Sub

	Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'When you load the app, it needs to use the file for the home page it comes with.
        'If it is still set to my path (as in you just got this app) it will replace the path.
        If My.Settings.UserHomePage = "file:///R:/E_Dillard/StudentApplications/WEccles/Final Project - Browser/Final Project - Browser/bin/Debug/Home.html" Then
			My.Settings.UserHomePage = Path.GetFullPath("Home.html")
			My.Settings.Save()
		End If
        'On load: When you launch the application, go to user home page.
        'I used the My Settings property of the app.
        TBox_Address.Text = My.Settings.UserHomePage
		Browser.Navigate(New Uri(My.Settings.UserHomePage))
        'Set height and width from last session.
        If My.Settings.IsMaxed = True Then
			Me.WindowState = FormWindowState.Maximized
		ElseIf My.Settings.IsMaxed = False Then
			Me.Height = My.Settings.LastHeight
			Me.Width = My.Settings.LastWidth
		End If
	End Sub

	Private Sub But_Back_Click(sender As System.Object, e As System.EventArgs) Handles But_Back.Click
        'Go back in the browser.
        Browser.GoBack()
	End Sub

	Private Sub But_Forward_Click(sender As System.Object, e As System.EventArgs) Handles But_Forward.Click
        'Go forward in browser.
        Browser.GoForward()
		TBox_Address.Text = Browser.Url.ToString
	End Sub

	Private Sub ReloadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        'Refresh browser.
        Browser.Refresh()
	End Sub
    'When you press the Go button.
    Private Sub But_Go_Click(sender As System.Object, e As System.EventArgs) Handles But_Go.Click
		Dim new_address As String = TBox_Address.Text
        'check for URL usability. If not usable, google search.
        'if usable, go to it.
        If My.Settings.Rbut1chosen = True Then
			Try
				Browser.Navigate(New Uri(new_address))
			Catch ex As Exception
                'return an error because that's how the setting is set.
                MessageBox.Show("ERROR: The URL you entered is not valid. Searching Google instead.")
				searchgoogle(Browser, new_address)
				TBox_Address.Text = Browser.Url.ToString
			End Try
		ElseIf My.Settings.Rbut2chosen = True Then
			Try
				Browser.Navigate(New Uri(new_address))
			Catch ex As Exception
                'no error, setting is set as such.
                searchgoogle(Browser, new_address)
			End Try
		End If
	End Sub
    'This runs when the user clicks the home button.
    Private Sub But_Home_Click(sender As System.Object, e As System.EventArgs) Handles But_Home.Click
        'go to defined home page
        Browser.Navigate(New Uri(My.Settings.UserHomePage))
		TBox_Address.Text = Browser.Url.ToString
	End Sub
    'close app on click of close app button in file menu
    Private Sub But_CloseApp_Click(sender As System.Object, e As System.EventArgs) Handles But_CloseApp.Click
		Me.Close()
	End Sub
    'press [ENTER] while in the text box to press the go button
    Private Sub TBox_Address_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TBox_Address.KeyPress
		If TBox_Address.Text = Nothing Then Return
		If TBox_Address.Text.Length >= 1 And Asc(e.KeyChar) = 13 Then
			But_Go_Click(Nothing, Nothing)
		End If
	End Sub
    'This will run when the browser has finished loading.
    Private Sub Browser_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles Browser.DocumentCompleted
        'This just changes the state of the loading status indicator.
        LoadingLabel.ForeColor = Color.Green
		LoadingLabel.Text = "Page loaded."
        'Set title of form.
        If (Browser.DocumentTitle IsNot Nothing) Then
			Me.Text = Browser.DocumentTitle
		Else
			Me.Text = "[No title available.]"
		End If
        'Set form icon to website icon.
        'This makes a bitmap 'webIcon'
        Dim webIcon As Bitmap = getIconFromWeb(Browser.Url.ToString)
		If Not webIcon Is Nothing Then
            'Get icon from bitmap.
            Me.Icon = Icon.FromHandle(webIcon.GetHicon())
		End If
		TBox_Address.Text = Browser.Url.ToString
	End Sub
    'Just in case the web page changes title (using a script or something) then this will handle it.
    Private Sub Browser_DocumentTitleChanged(sender As Object, e As System.EventArgs) Handles Browser.DocumentTitleChanged
		Me.Text = Browser.DocumentTitle
	End Sub
    'When page is loading, change label accordingly.
    Private Sub Browser_Navigating(sender As Object, e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles Browser.Navigating
		LoadingLabel.ForeColor = Color.Red
		LoadingLabel.Text = "Page loading."
	End Sub
    'Get icon of page.
    'I did Google some of the things in this function...
    '...such as downloading the favicon. However, I do understand what...
    '...is going on, I just needed help with how to write it, as we...
    '...aren't gonna be doing anything where we download...
    '...favicons from web sites.
    Function getIconFromWeb(ByVal website As String) As Image
		Dim url As Uri = New Uri(website)
		Dim stream As System.IO.Stream = Nothing
		If url.HostNameType = UriHostNameType.Dns Then
			Try
                ' Get the URL of the favicon
                ' url.Host will return such string as www.google.com
                Dim iconURL = "http://" & url.Host & "/favicon.ico"
                ' Download the favicon
                Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
				Dim response As System.Net.HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
				stream = response.GetResponseStream()
				Dim favicon As Image = Image.FromStream(stream)
				stream.Close()
				Return favicon
			Catch ex As Exception
			Finally
				If Not stream Is Nothing Then
					stream.Close()
				End If
			End Try
			Return Nothing
		End If
		Return Nothing
	End Function
    'This runs when the user clicks the button to download the page source.
    Private Sub But_DLSource_Click(sender As System.Object, e As System.EventArgs) Handles But_DLSource.Click
        'Defining the file selector to save the file to.
        Dim fileSelector As New FolderBrowserDialog
        'This is the browser title as a nice string for a file name.
        Dim browsertitlefriendly As String = Browser.DocumentTitle.ToString.Replace(" ", "_").Replace(",", "_").Replace("<", "_").Replace(">", "_").Replace(":", "_").Replace(Chr(34), "_").Replace("/", "_").Replace("\", "_").Replace("|", "_").Replace("?", "_").Replace("*", "_").Replace("-", "_")
        'Description of Dialog.
        fileSelector.Description = "Choose the folder to place the file in. It will show up as 'page_name_src.html', depending on your page name."
        'Dialog result.
        Dim result As DialogResult = fileSelector.ShowDialog()
        'What happens when they press the OK button in the dialog.
        If (result = Windows.Forms.DialogResult.OK) Then
			Dim folderName As String = fileSelector.SelectedPath.ToString
            'Create document path by using the page name.
            Dim finalPath As String = (folderName & "\" & browsertitlefriendly & "_src.html")
            'Writes HTML to the document.
            My.Computer.FileSystem.WriteAllText(finalPath, Browser.DocumentText, False)
		End If
	End Sub
    'Open an html file to diaplay in the browser.
    Private Sub But_OpenSrc_Click(sender As System.Object, e As System.EventArgs) Handles But_OpenSrc.Click
        'Define open file dialog.
        Dim fileSelector2 As New OpenFileDialog
        'File selector properties being set.
        fileSelector2.Title = "Choose a File to Open"
		fileSelector2.InitialDirectory = "c:\"
		fileSelector2.Filter = "Text (*.html;*.htm;*.txt;*.rtf)|*.html;*.htm;*.txt;*.rtf"
		fileSelector2.FilterIndex = 1
		fileSelector2.RestoreDirectory = True
        'If they click OK...
        If fileSelector2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Set browser to go open that file.
            Browser.Navigate(New Uri(("file:///" & fileSelector2.FileName)))
			TBox_Address.Text = ("file:///" & fileSelector2.FileName)
			Me.Text = "Custom Loaded File"
		End If
	End Sub

	Private Sub But_MLA_Click(sender As System.Object, e As System.EventArgs) Handles But_MLA.Click
        'Just launches the form for the MLA citation machine (Form4).
        Form3.Show()
    End Sub
End Class
