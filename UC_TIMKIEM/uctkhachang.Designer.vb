Namespace UC_TIMKIEM
	Partial Class uctkhachang
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.txttenkhachhang = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.txtmakhachhang = New System.Windows.Forms.TextBox()
			Me.btntruyvan = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(124, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Nhập Tên Khách Hàng :"
			' 
			' txttenkhachhang
			' 
			Me.txttenkhachhang.Location = New System.Drawing.Point(11, 29)
			Me.txttenkhachhang.MaxLength = 50
			Me.txttenkhachhang.Name = "txttenkhachhang"
			Me.txttenkhachhang.Size = New System.Drawing.Size(260, 20)
			Me.txttenkhachhang.TabIndex = 1
			AddHandler Me.txttenkhachhang.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txttenkhachhang_KeyPress)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(3, 57)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(120, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Nhập Mã Khách Hàng :"
			' 
			' txtmakhachhang
			' 
			Me.txtmakhachhang.Location = New System.Drawing.Point(10, 81)
			Me.txtmakhachhang.MaxLength = 10
			Me.txtmakhachhang.Name = "txtmakhachhang"
			Me.txtmakhachhang.Size = New System.Drawing.Size(260, 20)
			Me.txtmakhachhang.TabIndex = 3
			AddHandler Me.txtmakhachhang.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtmakhachhang_KeyPress)
			' 
			' btntruyvan
			' 
			Me.btntruyvan.Location = New System.Drawing.Point(94, 110)
			Me.btntruyvan.Name = "btntruyvan"
			Me.btntruyvan.Size = New System.Drawing.Size(75, 23)
			Me.btntruyvan.TabIndex = 4
			Me.btntruyvan.Text = "Truy Vấn"
			Me.btntruyvan.UseVisualStyleBackColor = True
			AddHandler Me.btntruyvan.Click, New System.EventHandler(AddressOf Me.btntruyvan_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(94, 139)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 5
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' uctkhachang
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btntruyvan)
			Me.Controls.Add(Me.txtmakhachhang)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txttenkhachhang)
			Me.Controls.Add(Me.label1)
			Me.Name = "uctkhachang"
			Me.Size = New System.Drawing.Size(281, 183)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txttenkhachhang As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private txtmakhachhang As System.Windows.Forms.TextBox
		Private btntruyvan As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
	End Class
End Namespace
