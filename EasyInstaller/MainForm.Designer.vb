'
' Created by SharpDevelop.
' User: steppsr
' Date: 3/11/2010
' Time: 11:23 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox
		Me.pictureBox2 = New System.Windows.Forms.PictureBox
		Me.button1 = New System.Windows.Forms.Button
		Me.button2 = New System.Windows.Forms.Button
		Me.button3 = New System.Windows.Forms.Button
		Me.button4 = New System.Windows.Forms.Button
		Me.button5 = New System.Windows.Forms.Button
		Me.webBrowser1 = New System.Windows.Forms.WebBrowser
		Me.button6 = New System.Windows.Forms.Button
		Me.button7 = New System.Windows.Forms.Button
		Me.button8 = New System.Windows.Forms.Button
		Me.button9 = New System.Windows.Forms.Button
		Me.button10 = New System.Windows.Forms.Button
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.Location = New System.Drawing.Point(442, 8)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(144, 148)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'pictureBox2
		'
		Me.pictureBox2.Location = New System.Drawing.Point(8, 8)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(428, 148)
		Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.pictureBox2.TabIndex = 1
		Me.pictureBox2.TabStop = false
		'
		'button1
		'
		Me.button1.Enabled = false
		Me.button1.Location = New System.Drawing.Point(442, 162)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(69, 40)
		Me.button1.TabIndex = 2
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Enabled = false
		Me.button2.Location = New System.Drawing.Point(442, 208)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(69, 40)
		Me.button2.TabIndex = 3
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button3
		'
		Me.button3.Enabled = false
		Me.button3.Location = New System.Drawing.Point(442, 254)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(69, 40)
		Me.button3.TabIndex = 4
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button4
		'
		Me.button4.Enabled = false
		Me.button4.Location = New System.Drawing.Point(442, 300)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(69, 40)
		Me.button4.TabIndex = 5
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'button5
		'
		Me.button5.Enabled = false
		Me.button5.Location = New System.Drawing.Point(442, 344)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(69, 40)
		Me.button5.TabIndex = 6
		Me.button5.UseVisualStyleBackColor = true
		AddHandler Me.button5.Click, AddressOf Me.Button5Click
		'
		'webBrowser1
		'
		Me.webBrowser1.Location = New System.Drawing.Point(8, 162)
		Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.webBrowser1.Name = "webBrowser1"
		Me.webBrowser1.ScrollBarsEnabled = false
		Me.webBrowser1.Size = New System.Drawing.Size(428, 222)
		Me.webBrowser1.TabIndex = 7
		'
		'button6
		'
		Me.button6.Enabled = false
		Me.button6.Location = New System.Drawing.Point(517, 162)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(69, 40)
		Me.button6.TabIndex = 8
		Me.button6.UseVisualStyleBackColor = true
		AddHandler Me.button6.Click, AddressOf Me.Button6Click
		'
		'button7
		'
		Me.button7.Enabled = false
		Me.button7.Location = New System.Drawing.Point(517, 208)
		Me.button7.Name = "button7"
		Me.button7.Size = New System.Drawing.Size(69, 40)
		Me.button7.TabIndex = 9
		Me.button7.UseVisualStyleBackColor = true
		AddHandler Me.button7.Click, AddressOf Me.Button7Click
		'
		'button8
		'
		Me.button8.Enabled = false
		Me.button8.Location = New System.Drawing.Point(517, 254)
		Me.button8.Name = "button8"
		Me.button8.Size = New System.Drawing.Size(69, 40)
		Me.button8.TabIndex = 10
		Me.button8.UseVisualStyleBackColor = true
		AddHandler Me.button8.Click, AddressOf Me.Button8Click
		'
		'button9
		'
		Me.button9.Enabled = false
		Me.button9.Location = New System.Drawing.Point(517, 300)
		Me.button9.Name = "button9"
		Me.button9.Size = New System.Drawing.Size(69, 40)
		Me.button9.TabIndex = 11
		Me.button9.UseVisualStyleBackColor = true
		AddHandler Me.button9.Click, AddressOf Me.Button9Click
		'
		'button10
		'
		Me.button10.Location = New System.Drawing.Point(517, 344)
		Me.button10.Name = "button10"
		Me.button10.Size = New System.Drawing.Size(69, 40)
		Me.button10.TabIndex = 12
		Me.button10.Text = "E&xit"
		Me.button10.UseVisualStyleBackColor = true
		AddHandler Me.button10.Click, AddressOf Me.Button10Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(598, 396)
		Me.Controls.Add(Me.button10)
		Me.Controls.Add(Me.button9)
		Me.Controls.Add(Me.button8)
		Me.Controls.Add(Me.button7)
		Me.Controls.Add(Me.button6)
		Me.Controls.Add(Me.webBrowser1)
		Me.Controls.Add(Me.button5)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.pictureBox2)
		Me.Controls.Add(Me.pictureBox1)
		Me.Name = "MainForm"
		Me.Text = "EasyInstaller"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private button10 As System.Windows.Forms.Button
	Private button9 As System.Windows.Forms.Button
	Private button8 As System.Windows.Forms.Button
	Private button7 As System.Windows.Forms.Button
	Private button6 As System.Windows.Forms.Button
	Private webBrowser1 As System.Windows.Forms.WebBrowser
	Private button5 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
