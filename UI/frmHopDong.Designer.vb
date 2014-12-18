Namespace UI
	Partial Class frmHopDong
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
			Me.label2 = New System.Windows.Forms.Label()
			Me.txtmakhachhang = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.txtmahopdong = New System.Windows.Forms.TextBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.dtpngaybatdau = New System.Windows.Forms.DateTimePicker()
			Me.label6 = New System.Windows.Forms.Label()
			Me.dtpngayketthuc = New System.Windows.Forms.DateTimePicker()
			Me.btnluu = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.lvthongtinhopdong = New System.Windows.Forms.ListView()
			Me.c1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c2 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c3 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c4 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c5 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c6 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c7 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c8 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c9 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c10 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c11 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.btnxoa = New System.Windows.Forms.Button()
			Me.btnshow = New System.Windows.Forms.Button()
			Me.btnrefesh = New System.Windows.Forms.Button()
			Me.btntaoma = New System.Windows.Forms.Button()
			Me.btntim = New System.Windows.Forms.Button()
			Me.btncapnhat = New System.Windows.Forms.Button()
			Me.label7 = New System.Windows.Forms.Label()
			Me.cbkhachhang = New System.Windows.Forms.ComboBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.txtloaihanghoa = New System.Windows.Forms.TextBox()
			Me.txtlotrinhvanchuyen = New System.Windows.Forms.TextBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.txtphuongthucvanchuyen = New System.Windows.Forms.TextBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.txtgiatrihopdong = New System.Windows.Forms.TextBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.txtphuongthucthanhtoan = New System.Windows.Forms.TextBox()
			Me.c12 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(370, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(203, 23)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Hợp Đồng Vận Chuyển"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(556, 46)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(91, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Mã Khách Hàng :"
			' 
			' txtmakhachhang
			' 
			Me.txtmakhachhang.Location = New System.Drawing.Point(653, 44)
			Me.txtmakhachhang.Name = "txtmakhachhang"
			Me.txtmakhachhang.Size = New System.Drawing.Size(299, 20)
			Me.txtmakhachhang.TabIndex = 2
			AddHandler Me.txtmakhachhang.TextChanged, New System.EventHandler(AddressOf Me.txtmakhachhang_TextChanged)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(52, 73)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(80, 13)
			Me.label4.TabIndex = 5
			Me.label4.Text = "Mã Hợp Đồng :"
			' 
			' txtmahopdong
			' 
			Me.txtmahopdong.BackColor = System.Drawing.SystemColors.InactiveBorder
			Me.txtmahopdong.Location = New System.Drawing.Point(138, 73)
			Me.txtmahopdong.Name = "txtmahopdong"
			Me.txtmahopdong.Size = New System.Drawing.Size(333, 20)
			Me.txtmahopdong.TabIndex = 6
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(52, 159)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(80, 13)
			Me.label5.TabIndex = 7
			Me.label5.Text = "Ngày Bắt Đầu :"
			' 
			' dtpngaybatdau
			' 
			Me.dtpngaybatdau.Location = New System.Drawing.Point(138, 159)
			Me.dtpngaybatdau.Name = "dtpngaybatdau"
			Me.dtpngaybatdau.Size = New System.Drawing.Size(189, 20)
			Me.dtpngaybatdau.TabIndex = 8
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(351, 165)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(85, 13)
			Me.label6.TabIndex = 9
			Me.label6.Text = "Ngày Kết Thúc :"
			' 
			' dtpngayketthuc
			' 
			Me.dtpngayketthuc.Location = New System.Drawing.Point(465, 159)
			Me.dtpngayketthuc.Name = "dtpngayketthuc"
			Me.dtpngayketthuc.Size = New System.Drawing.Size(189, 20)
			Me.dtpngayketthuc.TabIndex = 10
			' 
			' btnluu
			' 
			Me.btnluu.Location = New System.Drawing.Point(138, 191)
			Me.btnluu.Name = "btnluu"
			Me.btnluu.Size = New System.Drawing.Size(75, 23)
			Me.btnluu.TabIndex = 11
			Me.btnluu.Text = "Thêm"
			Me.btnluu.UseVisualStyleBackColor = True
			AddHandler Me.btnluu.Click, New System.EventHandler(AddressOf Me.btnluu_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(915, 191)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 12
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.lvthongtinhopdong)
			Me.groupBox1.Location = New System.Drawing.Point(13, 220)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(983, 400)
			Me.groupBox1.TabIndex = 13
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Thông Tin Hợp Đồng "
			' 
			' lvthongtinhopdong
			' 
			Me.lvthongtinhopdong.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, _
				Me.c7, Me.c8, Me.c9, Me.c10, Me.c11, Me.c12})
			Me.lvthongtinhopdong.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lvthongtinhopdong.FullRowSelect = True
			Me.lvthongtinhopdong.GridLines = True
			Me.lvthongtinhopdong.Location = New System.Drawing.Point(3, 16)
			Me.lvthongtinhopdong.MultiSelect = False
			Me.lvthongtinhopdong.Name = "lvthongtinhopdong"
			Me.lvthongtinhopdong.Size = New System.Drawing.Size(977, 381)
			Me.lvthongtinhopdong.TabIndex = 0
			Me.lvthongtinhopdong.UseCompatibleStateImageBehavior = False
			Me.lvthongtinhopdong.View = System.Windows.Forms.View.Details
			AddHandler Me.lvthongtinhopdong.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lvthongtinhopdong_SelectedIndexChanged)
			' 
			' c1
			' 
			Me.c1.Text = "STT"
			' 
			' c2
			' 
			Me.c2.Text = "Mã Khách Hàng"
			Me.c2.Width = 99
			' 
			' c3
			' 
			Me.c3.Text = "Họ Và Tên Khách Hàng"
			Me.c3.Width = 280
			' 
			' c4
			' 
			Me.c4.Text = "Hợp Đồng Vận Chuyển Có Mã"
			Me.c4.Width = 187
			' 
			' c5
			' 
			Me.c5.Text = "Ngày Bắt Đầu"
			Me.c5.Width = 113
			' 
			' c6
			' 
			Me.c6.Text = "Ngày Kết Thúc"
			Me.c6.Width = 121
			' 
			' c7
			' 
			Me.c7.Text = "Loại Hàng Hóa"
			Me.c7.Width = 100
			' 
			' c8
			' 
			Me.c8.Text = "Lộ Trình Vận Chuyển "
			Me.c8.Width = 150
			' 
			' c9
			' 
			Me.c9.Text = "Phương Thức Vận Chuyển "
			Me.c9.Width = 150
			' 
			' c10
			' 
			Me.c10.Text = "Giá Trị Hợp Đồng"
			Me.c10.Width = 150
			' 
			' c11
			' 
			Me.c11.Text = "Phương Thức Thanh Toán"
			Me.c11.Width = 150
			' 
			' btnxoa
			' 
			Me.btnxoa.Location = New System.Drawing.Point(333, 191)
			Me.btnxoa.Name = "btnxoa"
			Me.btnxoa.Size = New System.Drawing.Size(75, 23)
			Me.btnxoa.TabIndex = 15
			Me.btnxoa.Text = "Xóa"
			Me.btnxoa.UseVisualStyleBackColor = True
			AddHandler Me.btnxoa.Click, New System.EventHandler(AddressOf Me.btnxoa_Click)
			' 
			' btnshow
			' 
			Me.btnshow.Location = New System.Drawing.Point(958, 42)
			Me.btnshow.Name = "btnshow"
			Me.btnshow.Size = New System.Drawing.Size(32, 23)
			Me.btnshow.TabIndex = 16
			Me.btnshow.Text = "-->"
			Me.btnshow.UseVisualStyleBackColor = True
			AddHandler Me.btnshow.Click, New System.EventHandler(AddressOf Me.btnshow_Click)
			' 
			' btnrefesh
			' 
			Me.btnrefesh.Location = New System.Drawing.Point(234, 191)
			Me.btnrefesh.Name = "btnrefesh"
			Me.btnrefesh.Size = New System.Drawing.Size(75, 23)
			Me.btnrefesh.TabIndex = 17
			Me.btnrefesh.Text = "Làm Lại"
			Me.btnrefesh.UseVisualStyleBackColor = True
			AddHandler Me.btnrefesh.Click, New System.EventHandler(AddressOf Me.btnrefesh_Click)
			' 
			' btntaoma
			' 
			Me.btntaoma.Location = New System.Drawing.Point(477, 73)
			Me.btntaoma.Name = "btntaoma"
			Me.btntaoma.Size = New System.Drawing.Size(32, 21)
			Me.btntaoma.TabIndex = 18
			Me.btntaoma.Text = "+"
			Me.btntaoma.UseVisualStyleBackColor = True
			AddHandler Me.btntaoma.Click, New System.EventHandler(AddressOf Me.btntaoma_Click)
			' 
			' btntim
			' 
			Me.btntim.Location = New System.Drawing.Point(530, 191)
			Me.btntim.Name = "btntim"
			Me.btntim.Size = New System.Drawing.Size(75, 23)
			Me.btntim.TabIndex = 19
			Me.btntim.Text = "Tìm"
			Me.btntim.UseVisualStyleBackColor = True
			AddHandler Me.btntim.Click, New System.EventHandler(AddressOf Me.btntim_Click)
			' 
			' btncapnhat
			' 
			Me.btncapnhat.Location = New System.Drawing.Point(434, 191)
			Me.btncapnhat.Name = "btncapnhat"
			Me.btncapnhat.Size = New System.Drawing.Size(75, 23)
			Me.btncapnhat.TabIndex = 20
			Me.btncapnhat.Text = "Cập Nhật"
			Me.btncapnhat.UseVisualStyleBackColor = True
			AddHandler Me.btncapnhat.Click, New System.EventHandler(AddressOf Me.btncapnhat_Click)
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(31, 46)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(101, 13)
			Me.label7.TabIndex = 21
			Me.label7.Text = "Chọn Khách Hàng :"
			' 
			' cbkhachhang
			' 
			Me.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbkhachhang.FormattingEnabled = True
			Me.cbkhachhang.Location = New System.Drawing.Point(138, 43)
			Me.cbkhachhang.Name = "cbkhachhang"
			Me.cbkhachhang.Size = New System.Drawing.Size(371, 21)
			Me.cbkhachhang.TabIndex = 22
			AddHandler Me.cbkhachhang.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbkhachhang_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(19, 102)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(113, 13)
			Me.label3.TabIndex = 23
			Me.label3.Text = "Lộ Trình Vận Chuyển :"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(562, 77)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(85, 13)
			Me.label8.TabIndex = 24
			Me.label8.Text = "Loại Hàng Hóa :"
			' 
			' txtloaihanghoa
			' 
			Me.txtloaihanghoa.Location = New System.Drawing.Point(653, 72)
			Me.txtloaihanghoa.Name = "txtloaihanghoa"
			Me.txtloaihanghoa.Size = New System.Drawing.Size(299, 20)
			Me.txtloaihanghoa.TabIndex = 26
			' 
			' txtlotrinhvanchuyen
			' 
			Me.txtlotrinhvanchuyen.Location = New System.Drawing.Point(138, 99)
			Me.txtlotrinhvanchuyen.Name = "txtlotrinhvanchuyen"
			Me.txtlotrinhvanchuyen.Size = New System.Drawing.Size(371, 20)
			Me.txtlotrinhvanchuyen.TabIndex = 27
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(515, 102)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(139, 13)
			Me.label10.TabIndex = 28
			Me.label10.Text = "Phương Thức Vận Chuyển :"
			' 
			' txtphuongthucvanchuyen
			' 
			Me.txtphuongthucvanchuyen.Location = New System.Drawing.Point(653, 99)
			Me.txtphuongthucvanchuyen.Name = "txtphuongthucvanchuyen"
			Me.txtphuongthucvanchuyen.Size = New System.Drawing.Size(299, 20)
			Me.txtphuongthucvanchuyen.TabIndex = 29
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(36, 131)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(96, 13)
			Me.label11.TabIndex = 30
			Me.label11.Text = "Giá Trị Hợp Đồng :"
			' 
			' txtgiatrihopdong
			' 
			Me.txtgiatrihopdong.Location = New System.Drawing.Point(138, 128)
			Me.txtgiatrihopdong.Name = "txtgiatrihopdong"
			Me.txtgiatrihopdong.Size = New System.Drawing.Size(371, 20)
			Me.txtgiatrihopdong.TabIndex = 31
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(515, 135)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(140, 13)
			Me.label12.TabIndex = 32
			Me.label12.Text = "Phương Thức Thanh Toán :"
			' 
			' txtphuongthucthanhtoan
			' 
			Me.txtphuongthucthanhtoan.Location = New System.Drawing.Point(653, 128)
			Me.txtphuongthucthanhtoan.Name = "txtphuongthucthanhtoan"
			Me.txtphuongthucthanhtoan.Size = New System.Drawing.Size(299, 20)
			Me.txtphuongthucthanhtoan.TabIndex = 33
			' 
			' c12
			' 
			Me.c12.Text = "Ngày tạo"
			' 
			' frmHopDong
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1028, 632)
			Me.Controls.Add(Me.txtphuongthucthanhtoan)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.txtgiatrihopdong)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.txtphuongthucvanchuyen)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.txtlotrinhvanchuyen)
			Me.Controls.Add(Me.txtloaihanghoa)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.cbkhachhang)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.btncapnhat)
			Me.Controls.Add(Me.btntim)
			Me.Controls.Add(Me.btntaoma)
			Me.Controls.Add(Me.btnrefesh)
			Me.Controls.Add(Me.btnshow)
			Me.Controls.Add(Me.btnxoa)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btnluu)
			Me.Controls.Add(Me.dtpngayketthuc)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.dtpngaybatdau)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.txtmahopdong)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.txtmakhachhang)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmHopDong"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "LẬP HỢP ĐỒNG VẬN CHUYỂN"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private txtmakhachhang As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private txtmahopdong As System.Windows.Forms.TextBox
		Private label5 As System.Windows.Forms.Label
		Private dtpngaybatdau As System.Windows.Forms.DateTimePicker
		Private label6 As System.Windows.Forms.Label
		Private dtpngayketthuc As System.Windows.Forms.DateTimePicker
		Private btnluu As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private lvthongtinhopdong As System.Windows.Forms.ListView
		Private c1 As System.Windows.Forms.ColumnHeader
		Private c2 As System.Windows.Forms.ColumnHeader
		Private c3 As System.Windows.Forms.ColumnHeader
		Private c4 As System.Windows.Forms.ColumnHeader
		Private c5 As System.Windows.Forms.ColumnHeader
		Private c6 As System.Windows.Forms.ColumnHeader
		Private btnxoa As System.Windows.Forms.Button
		Private btnshow As System.Windows.Forms.Button
		Private btnrefesh As System.Windows.Forms.Button
		Private btntaoma As System.Windows.Forms.Button
		Private btntim As System.Windows.Forms.Button
		Private btncapnhat As System.Windows.Forms.Button
		Private label7 As System.Windows.Forms.Label
		Private cbkhachhang As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private txtloaihanghoa As System.Windows.Forms.TextBox
		Private txtlotrinhvanchuyen As System.Windows.Forms.TextBox
		Private label10 As System.Windows.Forms.Label
		Private txtphuongthucvanchuyen As System.Windows.Forms.TextBox
		Private label11 As System.Windows.Forms.Label
		Private txtgiatrihopdong As System.Windows.Forms.TextBox
		Private label12 As System.Windows.Forms.Label
		Private txtphuongthucthanhtoan As System.Windows.Forms.TextBox
		Private c7 As System.Windows.Forms.ColumnHeader
		Private c8 As System.Windows.Forms.ColumnHeader
		Private c9 As System.Windows.Forms.ColumnHeader
		Private c10 As System.Windows.Forms.ColumnHeader
		Private c11 As System.Windows.Forms.ColumnHeader
		Private c12 As System.Windows.Forms.ColumnHeader
	End Class
End Namespace
