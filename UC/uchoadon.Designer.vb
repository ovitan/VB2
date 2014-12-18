Namespace UC
	Partial Class uchoadon
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.cbkhachhang = New System.Windows.Forms.ComboBox()
			Me.cbhopdong = New System.Windows.Forms.ComboBox()
			Me.cbhoadon = New System.Windows.Forms.ComboBox()
			Me.btnxuat = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' cbkhachhang
			' 
			Me.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbkhachhang.FormattingEnabled = True
			Me.cbkhachhang.Location = New System.Drawing.Point(3, 3)
			Me.cbkhachhang.Name = "cbkhachhang"
			Me.cbkhachhang.Size = New System.Drawing.Size(191, 21)
			Me.cbkhachhang.TabIndex = 0
			AddHandler Me.cbkhachhang.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbkhachhang_SelectedIndexChanged)
			' 
			' cbhopdong
			' 
			Me.cbhopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbhopdong.FormattingEnabled = True
			Me.cbhopdong.Location = New System.Drawing.Point(3, 30)
			Me.cbhopdong.Name = "cbhopdong"
			Me.cbhopdong.Size = New System.Drawing.Size(191, 21)
			Me.cbhopdong.TabIndex = 1
			AddHandler Me.cbhopdong.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbhopdong_SelectedIndexChanged)
			' 
			' cbhoadon
			' 
			Me.cbhoadon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbhoadon.FormattingEnabled = True
			Me.cbhoadon.Location = New System.Drawing.Point(3, 57)
			Me.cbhoadon.Name = "cbhoadon"
			Me.cbhoadon.Size = New System.Drawing.Size(191, 21)
			Me.cbhoadon.TabIndex = 2
			' 
			' btnxuat
			' 
			Me.btnxuat.Location = New System.Drawing.Point(30, 94)
			Me.btnxuat.Name = "btnxuat"
			Me.btnxuat.Size = New System.Drawing.Size(128, 23)
			Me.btnxuat.TabIndex = 3
			Me.btnxuat.Text = "Xuất Hóa Đơn"
			Me.btnxuat.UseVisualStyleBackColor = True
			AddHandler Me.btnxuat.Click, New System.EventHandler(AddressOf Me.btnxuat_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(30, 123)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(128, 23)
			Me.btnthoat.TabIndex = 5
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' uchoadon
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btnxuat)
			Me.Controls.Add(Me.cbhoadon)
			Me.Controls.Add(Me.cbhopdong)
			Me.Controls.Add(Me.cbkhachhang)
			Me.Name = "uchoadon"
			Me.Size = New System.Drawing.Size(197, 185)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cbkhachhang As System.Windows.Forms.ComboBox
		Private cbhopdong As System.Windows.Forms.ComboBox
		Private cbhoadon As System.Windows.Forms.ComboBox
		Private btnxuat As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
	End Class
End Namespace
