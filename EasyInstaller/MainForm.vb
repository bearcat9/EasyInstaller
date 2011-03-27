'
' Created by SharpDevelop.
' User: steppsr
' Date: 3/11/2010
' Time: 11:23 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Public Partial Class MainForm

	Dim sButton1Folder As String = ""
	Dim sButton2Folder As String = ""
	Dim sButton3Folder As String = ""
	Dim sButton4Folder As String = ""
	Dim sButton1File As String = ""
	Dim sButton2File As String = ""
	Dim sButton3File As String = ""
	Dim sButton4File As String = ""
	Dim sButton1Title As String = ""
	Dim sButton2Title As String = ""
	Dim sButton3Title As String = ""
	Dim sButton4Title As String = ""
	Dim sButton1PrereqFolder As String = ""
	Dim sButton2PrereqFolder As String = ""
	Dim sButton3PrereqFolder As String = ""
	Dim sButton4PrereqFolder As String = ""
	Dim sButton1PrereqFile As String = ""
	Dim sButton2PrereqFile As String = ""
	Dim sButton3PrereqFile As String = ""
	Dim sButton4PrereqFile As String = ""
	Dim sButton1PrereqInstallFolder As String = ""
	Dim sButton2PrereqInstallFolder As String = ""
	Dim sButton3PrereqInstallFolder As String = ""
	Dim sButton4PrereqInstallFolder As String = ""
	Dim sButton1PrereqInstallFile As String = ""
	Dim sButton2PrereqInstallFile As String = ""
	Dim sButton3PrereqInstallFile As String = ""
	Dim sButton4PrereqInstallFile As String = ""
	
	Dim COMPANY_NAME As String = ""
	Dim APP_NAME As String = ""

	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
		' Load application settings by reading in the main.html file under the EasyInstaller folder
		LoadMainHTML()
		
	End Sub
	
	Sub LoadMainHTML()
		
		'********** LOAD APPLICATION SETTINGS ******************
		
		Dim sHTML As String = ""
		
		Try
			'---Import an HTML file that will load a summary for the tool
			Dim sReader As System.IO.StreamReader
			Dim sTemp As String = ""
			sReader = New System.IO.StreamReader("easyinstaller/main.html")
			While(sReader.Peek > -1)
				sTemp = sReader.ReadLine
				
				' Check for config settings in the comments of the main.html file and store in some global vars
				If instr(sTemp,"Button1_Folder") > 0 Then
					sButton1Folder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button2_Folder") > 0 Then
					sButton2Folder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button3_Folder") > 0 Then
					sButton3Folder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button4_Folder") > 0 Then
					sButton4Folder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button1_File") > 0 Then
					sButton1File = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button2_File") > 0 Then
					sButton2File = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button3_File") > 0 Then
					sButton3File = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button4_File") > 0 Then
					sButton4File = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button1_Title") > 0 Then
					sButton1Title = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button2_Title") > 0 Then
					sButton2Title = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button3_Title") > 0 Then
					sButton3Title = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button4_Title") > 0 Then
					sButton4Title = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"COMPANY_NAME") > 0 Then
					COMPANY_NAME = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"APP_NAME") > 0 Then
					APP_NAME = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button1_Prereq_Folder") > 0 Then
					sButton1PrereqFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button2_Prereq_Folder") > 0 Then
					sButton2PrereqFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button3_Prereq_Folder") > 0 Then
					sButton3PrereqFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button4_Prereq_Folder") > 0 Then
					sButton4PrereqFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button1_Prereq_File") > 0 Then
					sButton1PrereqFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button2_Prereq_File") > 0 Then
					sButton2PrereqFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button3_Prereq_File") > 0 Then
					sButton3PrereqFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button4_Prereq_File") > 0 Then
					sButton4PrereqFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button1_Prereq_Install_File") > 0 Then
					sButton1PrereqInstallFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button2_Prereq_Install_File") > 0 Then
					sButton2PrereqInstallFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button3_Prereq_Install_File") > 0 Then
					sButton3PrereqInstallFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button4_Prereq_Install_File") > 0 Then
					sButton4PrereqInstallFile = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button1_Prereq_Install_Folder") > 0 Then
					sButton1PrereqInstallFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button2_Prereq_Install_Folder") > 0 Then
					sButton2PrereqInstallFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button3_Prereq_Install_Folder") > 0 Then
					sButton3PrereqInstallFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If
				If instr(sTemp,"Button4_Prereq_Install_Folder") > 0 Then
					sButton4PrereqInstallFolder = mid(sTemp,instr(sTemp,"=")+1)
				End If

				' Append regular HTML into var for main application message
				sHTML = sHTML & sTemp
				
			End While
			
			sReader.Close
			sReader.Dispose
			
		Catch
			' If there was an error, make sure the string is empty
			sHTML = ""
		End Try
		
		pictureBox1.ImageLocation = "easyinstaller/company_logo.png"
		pictureBox2.ImageLocation = "easyinstaller/app_banner.png"

		' The application main message is in a webBrowser we will need to give it some HTML and refresh
		webBrowser1.DocumentText =	sHTML
		webBrowser1.Refresh
		
		' Using config settings set title for buttons and make them enabled
		If sButton1Title <> "" Then
			button1.Text = sButton1Title
			button1.Enabled = True
		End If
		If sButton2Title <> "" Then
			button2.Text = sButton2Title
			button2.Enabled = True
		End If
		If sButton3Title <> "" Then
			button3.Text = sButton3Title
			button3.Enabled = True
		End If
		If sButton4Title <> "" Then
			button4.Text = sButton4Title
			button4.Enabled = True
		End If
				
	End Sub
	
	Sub RunButtonProcess(sButtonFolder As String, sButtonFile As String, sButtonPrereqFolder As String, sButtonPrereqFile As String, sButtonPrereqInstallFolder As String, sButtonPrereqInstallFile As String)
		
		Try
			' ***************** BUTTON PRESSED ***************
			'
			' Create an external process to run the file associated with each button. Wait for the process
			' to complete before returning.
			'
			Dim myProcess As Process
			If sButtonFile <> "" Then
				
				' Lets check the prerequisites first
				Dim sPreq As String = ""
				If sButtonPrereqFile <> "" Then		'filename cant be empty
					If sButtonPrereqFolder <> "" Then
						sPreq = sPreq & sButtonPrereqFolder & "\"
					End If
					sPreq = sPreq & sButtonPrereqFile
					If System.IO.File.Exists(sPreq) = False Then	'does the require file exist? If not then run prereq install
						If sButtonPrereqInstallFolder <> "" and sButtonPrereqInstallFile <> "" Then
							myProcess = System.Diagnostics.Process.Start(sButtonPrereqInstallFolder & "\" & sButtonPrereqInstallFile)
							myProcess.WaitForExit()
							myProcess.Close()
						Else
							msgbox("Missing path/filename for prerequisite install.", vbOKOnly, "ERROR")
						End If
					Else
						msgbox("Prerequisite already installed.",vbOkOnly,"NOTE")
					End If
				Else
					'msgbox("No prerequisites listed.",vbOKOnly,"DEBUG")
				End If
				
				' And now for the main app for the button
			    If sButtonFolder <> "" Then
			    	myProcess = System.Diagnostics.Process.Start(sButtonFolder & "\" & sButtonFile)
				Else
				    myProcess = System.Diagnostics.Process.Start(sButtonFile)
			    End If
			    myProcess.WaitForExit()
			    myProcess.Close()
			Else
				msgbox("There appears to be a problem with this option. Please notify " & COMPANY_NAME & " support staff for help.",vbOKOnly,"Easy Install Error")
			End If
		Catch
			msgbox("There appears to be a problem with this option. Please notify " & COMPANY_NAME & " support staff for help.",vbOkOnly,"Easy Install Error")
		End Try
		

	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		RunButtonProcess(sButton1Folder, sButton1File, sButton1PrereqFolder, sButton1PrereqFile, sButton1PrereqInstallFolder, sButton1PrereqInstallFile)
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		
		RunButtonProcess(sButton2Folder, sButton2File, sButton2PrereqFolder, sButton2PrereqFile, sButton2PrereqInstallFolder, sButton2PrereqInstallFile)
		
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		
		RunButtonProcess(sButton3Folder, sButton3File, sButton3PrereqFolder, sButton3PrereqFile, sButton3PrereqInstallFolder, sButton3PrereqInstallFile)
		
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		
		RunButtonProcess(sButton4Folder, sButton4File, sButton4PrereqFolder, sButton4PrereqFile, sButton4PrereqInstallFolder, sButton4PrereqInstallFile)
		
	End Sub

	Sub Button5Click(sender As Object, e As EventArgs)
		
		End
		
	End Sub
	
End Class
