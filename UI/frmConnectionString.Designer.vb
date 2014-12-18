Namespace UI
	Partial Class frmConnectionString
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.txtservername = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.cbdatatbase = New System.Windows.Forms.ComboBox()
			Me.btnketnoi = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.label3 = New System.Windows.Forms.Label()
			Me.btntao = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 54)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(75, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Server Name :"
			' 
			' txtservername
			' 
			Me.txtservername.BackColor = System.Drawing.SystemColors.InactiveCaption
			Me.txtservername.Enabled = False
			Me.txtservername.Location = New System.Drawing.Point(93, 51)
			Me.txtservername.Name = "txtservername"
			Me.txtservername.Size = New System.Drawing.Size(250, 20)
			Me.txtservername.TabIndex = 1
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(18, 92)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(69, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Chọn CSDL :"
			' 
			' cbdatatbase
			' 
			Me.cbdatatbase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbdatatbase.FormattingEnabled = True
			Me.cbdatatbase.Location = New System.Drawing.Point(93, 89)
			Me.cbdatatbase.Name = "cbdatatbase"
			Me.cbdatatbase.Size = New System.Drawing.Size(250, 21)
			Me.cbdatatbase.TabIndex = 3
			' 
			' btnketnoi
			' 
			Me.btnketnoi.Location = New System.Drawing.Point(93, 129)
			Me.btnketnoi.Name = "btnketnoi"
			Me.btnketnoi.Size = New System.Drawing.Size(75, 23)
			Me.btnketnoi.TabIndex = 4
			Me.btnketnoi.Text = "Kết Nối"
			Me.btnketnoi.UseVisualStyleBackColor = True
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(200, 129)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 5
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(24, 14)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(63, 13)
			Me.label3.TabIndex = 6
			Me.label3.Text = "Tạo CSDL :"
			' 
			' btntao
			' 
			Me.btntao.Location = New System.Drawing.Point(93, 10)
			Me.btntao.Name = "btntao"
			Me.btntao.Size = New System.Drawing.Size(75, 23)
			Me.btntao.TabIndex = 7
			Me.btntao.Text = "Tạo"
			Me.btntao.UseVisualStyleBackColor = True
			' 
			' frmConnectionString
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(355, 187)
			Me.Controls.Add(Me.btntao)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btnketnoi)
			Me.Controls.Add(Me.cbdatatbase)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txtservername)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmConnectionString"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "CẤU HÌNH KẾT NỐI SQL"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txtservername As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private cbdatatbase As System.Windows.Forms.ComboBox
		Private btnketnoi As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
		Private label3 As System.Windows.Forms.Label
		Private btntao As System.Windows.Forms.Button
	End Class
End Namespace
