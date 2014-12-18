Namespace UC
	Partial Class uckhachhang
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
			Me.cbdanhsachtuyechon = New System.Windows.Forms.ComboBox()
			Me.btnxuat = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' cbdanhsachtuyechon
			' 
			Me.cbdanhsachtuyechon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbdanhsachtuyechon.FormattingEnabled = True
			Me.cbdanhsachtuyechon.Location = New System.Drawing.Point(2, 3)
			Me.cbdanhsachtuyechon.Name = "cbdanhsachtuyechon"
			Me.cbdanhsachtuyechon.Size = New System.Drawing.Size(193, 21)
			Me.cbdanhsachtuyechon.TabIndex = 0
			' 
			' btnxuat
			' 
			Me.btnxuat.Location = New System.Drawing.Point(21, 29)
			Me.btnxuat.Name = "btnxuat"
			Me.btnxuat.Size = New System.Drawing.Size(75, 23)
			Me.btnxuat.TabIndex = 2
			Me.btnxuat.Text = "Xuất"
			Me.btnxuat.UseVisualStyleBackColor = True
			AddHandler Me.btnxuat.Click, New System.EventHandler(AddressOf Me.btnxuat_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(102, 29)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 3
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' uckhachhang
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btnxuat)
			Me.Controls.Add(Me.cbdanhsachtuyechon)
			Me.Name = "uckhachhang"
			Me.Size = New System.Drawing.Size(197, 59)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cbdanhsachtuyechon As System.Windows.Forms.ComboBox
		Private btnxuat As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
	End Class
End Namespace
