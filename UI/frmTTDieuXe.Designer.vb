Namespace UI
	Partial Class frmTTDieuXe
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
            Me.cbkhachhang = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.cbhopdong = New System.Windows.Forms.ComboBox()
            Me.gb1 = New System.Windows.Forms.GroupBox()
            Me.lvxe = New System.Windows.Forms.ListView()
            Me.c0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.c1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.c2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.c3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.c4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.lvnhanvien = New System.Windows.Forms.ListView()
            Me.h0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.h1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.h2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.h3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.h4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.h5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.h6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.gb3 = New System.Windows.Forms.GroupBox()
            Me.cbbaogia = New System.Windows.Forms.ComboBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.cbnoigiao = New System.Windows.Forms.ComboBox()
            Me.cbnoinhan = New System.Windows.Forms.ComboBox()
            Me.cbtinhtrangthanhtoan = New System.Windows.Forms.ComboBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.dtpngayve = New System.Windows.Forms.DateTimePicker()
            Me.label7 = New System.Windows.Forms.Label()
            Me.dtpngaydi = New System.Windows.Forms.DateTimePicker()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.txtsotan = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.btnthem = New System.Windows.Forms.Button()
            Me.btnxoa = New System.Windows.Forms.Button()
            Me.btnsua = New System.Windows.Forms.Button()
            Me.btnthoat = New System.Windows.Forms.Button()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.lvthongtindieuxe = New System.Windows.Forms.ListView()
            Me.ch0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ch8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.label9 = New System.Windows.Forms.Label()
            Me.txtmadieuxe = New System.Windows.Forms.TextBox()
            Me.btnthemma = New System.Windows.Forms.Button()
            Me.gb1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.gb3.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(5, 5)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(101, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Chọn Khách Hàng :"
            '
            'cbkhachhang
            '
            Me.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbkhachhang.FormattingEnabled = True
            Me.cbkhachhang.Location = New System.Drawing.Point(112, 2)
            Me.cbkhachhang.Name = "cbkhachhang"
            Me.cbkhachhang.Size = New System.Drawing.Size(200, 21)
            Me.cbkhachhang.TabIndex = 1
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(318, 9)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(90, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Chọn Hợp Đồng :"
            '
            'cbhopdong
            '
            Me.cbhopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbhopdong.FormattingEnabled = True
            Me.cbhopdong.Location = New System.Drawing.Point(414, 2)
            Me.cbhopdong.Name = "cbhopdong"
            Me.cbhopdong.Size = New System.Drawing.Size(200, 21)
            Me.cbhopdong.TabIndex = 3
            '
            'gb1
            '
            Me.gb1.Controls.Add(Me.lvxe)
            Me.gb1.Location = New System.Drawing.Point(4, 29)
            Me.gb1.Name = "gb1"
            Me.gb1.Size = New System.Drawing.Size(500, 177)
            Me.gb1.TabIndex = 4
            Me.gb1.TabStop = False
            Me.gb1.Text = "Chọn Xe"
            '
            'lvxe
            '
            Me.lvxe.CheckBoxes = True
            Me.lvxe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c0, Me.c1, Me.c2, Me.c3, Me.c4})
            Me.lvxe.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lvxe.FullRowSelect = True
            Me.lvxe.Location = New System.Drawing.Point(3, 16)
            Me.lvxe.MultiSelect = False
            Me.lvxe.Name = "lvxe"
            Me.lvxe.Size = New System.Drawing.Size(494, 158)
            Me.lvxe.TabIndex = 0
            Me.lvxe.UseCompatibleStateImageBehavior = False
            Me.lvxe.View = System.Windows.Forms.View.Details
            '
            'c0
            '
            Me.c0.Text = "STT"
            Me.c0.Width = 69
            '
            'c1
            '
            Me.c1.Text = "Mã Số Xe"
            Me.c1.Width = 101
            '
            'c2
            '
            Me.c2.Text = "Tải Trọng"
            Me.c2.Width = 106
            '
            'c3
            '
            Me.c3.Text = "Tình Trạng Xe"
            Me.c3.Width = 105
            '
            'c4
            '
            Me.c4.Text = "Loại Xe"
            Me.c4.Width = 120
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.lvnhanvien)
            Me.groupBox1.Location = New System.Drawing.Point(510, 29)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(493, 177)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Nhân Viên Xe"
            '
            'lvnhanvien
            '
            Me.lvnhanvien.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.h0, Me.h1, Me.h2, Me.h3, Me.h4, Me.h5, Me.h6})
            Me.lvnhanvien.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lvnhanvien.FullRowSelect = True
            Me.lvnhanvien.Location = New System.Drawing.Point(3, 16)
            Me.lvnhanvien.MultiSelect = False
            Me.lvnhanvien.Name = "lvnhanvien"
            Me.lvnhanvien.Size = New System.Drawing.Size(487, 158)
            Me.lvnhanvien.TabIndex = 0
            Me.lvnhanvien.UseCompatibleStateImageBehavior = False
            Me.lvnhanvien.View = System.Windows.Forms.View.Details
            '
            'h0
            '
            Me.h0.Text = "STT"
            Me.h0.Width = 66
            '
            'h1
            '
            Me.h1.Text = "Tên Nhân Viên"
            Me.h1.Width = 107
            '
            'h2
            '
            Me.h2.Text = "CMND"
            Me.h2.Width = 88
            '
            'h3
            '
            Me.h3.Text = "Địa Chỉ"
            Me.h3.Width = 87
            '
            'h4
            '
            Me.h4.Text = "Điện Thoại"
            Me.h4.Width = 100
            '
            'h5
            '
            Me.h5.Text = "Chức Vụ"
            Me.h5.Width = 120
            '
            'h6
            '
            Me.h6.Text = "Năm Sinh"
            Me.h6.Width = 100
            '
            'gb3
            '
            Me.gb3.Controls.Add(Me.cbbaogia)
            Me.gb3.Controls.Add(Me.label10)
            Me.gb3.Controls.Add(Me.cbnoigiao)
            Me.gb3.Controls.Add(Me.cbnoinhan)
            Me.gb3.Controls.Add(Me.cbtinhtrangthanhtoan)
            Me.gb3.Controls.Add(Me.label8)
            Me.gb3.Controls.Add(Me.dtpngayve)
            Me.gb3.Controls.Add(Me.label7)
            Me.gb3.Controls.Add(Me.dtpngaydi)
            Me.gb3.Controls.Add(Me.label6)
            Me.gb3.Controls.Add(Me.label5)
            Me.gb3.Controls.Add(Me.label4)
            Me.gb3.Controls.Add(Me.txtsotan)
            Me.gb3.Controls.Add(Me.label3)
            Me.gb3.Location = New System.Drawing.Point(4, 212)
            Me.gb3.Name = "gb3"
            Me.gb3.Size = New System.Drawing.Size(999, 72)
            Me.gb3.TabIndex = 6
            Me.gb3.TabStop = False
            Me.gb3.Text = "Thông Tin Chuyến "
            '
            'cbbaogia
            '
            Me.cbbaogia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbaogia.FormattingEnabled = True
            Me.cbbaogia.Location = New System.Drawing.Point(18, 36)
            Me.cbbaogia.Name = "cbbaogia"
            Me.cbbaogia.Size = New System.Drawing.Size(102, 21)
            Me.cbbaogia.TabIndex = 22
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(5, 16)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(79, 13)
            Me.label10.TabIndex = 21
            Me.label10.Text = "Chọn Báo Giá :"
            '
            'cbnoigiao
            '
            Me.cbnoigiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbnoigiao.FormattingEnabled = True
            Me.cbnoigiao.Location = New System.Drawing.Point(190, 43)
            Me.cbnoigiao.Name = "cbnoigiao"
            Me.cbnoigiao.Size = New System.Drawing.Size(191, 21)
            Me.cbnoigiao.TabIndex = 20
            '
            'cbnoinhan
            '
            Me.cbnoinhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbnoinhan.FormattingEnabled = True
            Me.cbnoinhan.Location = New System.Drawing.Point(190, 12)
            Me.cbnoinhan.Name = "cbnoinhan"
            Me.cbnoinhan.Size = New System.Drawing.Size(191, 21)
            Me.cbnoinhan.TabIndex = 19
            '
            'cbtinhtrangthanhtoan
            '
            Me.cbtinhtrangthanhtoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbtinhtrangthanhtoan.FormattingEnabled = True
            Me.cbtinhtrangthanhtoan.Location = New System.Drawing.Point(804, 39)
            Me.cbtinhtrangthanhtoan.Name = "cbtinhtrangthanhtoan"
            Me.cbtinhtrangthanhtoan.Size = New System.Drawing.Size(188, 21)
            Me.cbtinhtrangthanhtoan.TabIndex = 18
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(672, 44)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(127, 13)
            Me.label8.TabIndex = 16
            Me.label8.Text = "Tình Trạng Thanh Toán :"
            '
            'dtpngayve
            '
            Me.dtpngayve.Location = New System.Drawing.Point(804, 12)
            Me.dtpngayve.Name = "dtpngayve"
            Me.dtpngayve.Size = New System.Drawing.Size(188, 20)
            Me.dtpngayve.TabIndex = 15
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(744, 18)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(54, 13)
            Me.label7.TabIndex = 14
            Me.label7.Text = "Ngày Về :"
            '
            'dtpngaydi
            '
            Me.dtpngaydi.Location = New System.Drawing.Point(468, 38)
            Me.dtpngaydi.Name = "dtpngaydi"
            Me.dtpngaydi.Size = New System.Drawing.Size(188, 20)
            Me.dtpngaydi.TabIndex = 13
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(411, 43)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(51, 13)
            Me.label6.TabIndex = 12
            Me.label6.Text = "Ngày Đi :"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(130, 45)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(54, 13)
            Me.label5.TabIndex = 10
            Me.label5.Text = "Nơi Giao :"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(126, 15)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(58, 13)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Nơi Nhận :"
            '
            'txtsotan
            '
            Me.txtsotan.Location = New System.Drawing.Point(468, 13)
            Me.txtsotan.Name = "txtsotan"
            Me.txtsotan.Size = New System.Drawing.Size(188, 20)
            Me.txtsotan.TabIndex = 7
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(386, 18)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(76, 13)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Tổng Số Tấn :"
            '
            'btnthem
            '
            Me.btnthem.Location = New System.Drawing.Point(4, 290)
            Me.btnthem.Name = "btnthem"
            Me.btnthem.Size = New System.Drawing.Size(102, 23)
            Me.btnthem.TabIndex = 7
            Me.btnthem.Text = "Thêm Điều Xe"
            Me.btnthem.UseVisualStyleBackColor = True
            '
            'btnxoa
            '
            Me.btnxoa.Location = New System.Drawing.Point(112, 290)
            Me.btnxoa.Name = "btnxoa"
            Me.btnxoa.Size = New System.Drawing.Size(102, 23)
            Me.btnxoa.TabIndex = 8
            Me.btnxoa.Text = "Xóa Điều Xe"
            Me.btnxoa.UseVisualStyleBackColor = True
            '
            'btnsua
            '
            Me.btnsua.Location = New System.Drawing.Point(220, 290)
            Me.btnsua.Name = "btnsua"
            Me.btnsua.Size = New System.Drawing.Size(102, 23)
            Me.btnsua.TabIndex = 9
            Me.btnsua.Text = "Sửa Điều Xe"
            Me.btnsua.UseVisualStyleBackColor = True
            '
            'btnthoat
            '
            Me.btnthoat.Location = New System.Drawing.Point(928, 290)
            Me.btnthoat.Name = "btnthoat"
            Me.btnthoat.Size = New System.Drawing.Size(75, 23)
            Me.btnthoat.TabIndex = 10
            Me.btnthoat.Text = "Thoát"
            Me.btnthoat.UseVisualStyleBackColor = True
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.lvthongtindieuxe)
            Me.groupBox2.Location = New System.Drawing.Point(4, 319)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(999, 309)
            Me.groupBox2.TabIndex = 11
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Thông Tin Điều Xe"
            '
            'lvthongtindieuxe
            '
            Me.lvthongtindieuxe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch0, Me.ch1, Me.ch11, Me.ch2, Me.ch3, Me.ch4, Me.ch5, Me.ch6, Me.ch7, Me.ch8})
            Me.lvthongtindieuxe.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lvthongtindieuxe.FullRowSelect = True
            Me.lvthongtindieuxe.Location = New System.Drawing.Point(3, 16)
            Me.lvthongtindieuxe.MultiSelect = False
            Me.lvthongtindieuxe.Name = "lvthongtindieuxe"
            Me.lvthongtindieuxe.Size = New System.Drawing.Size(993, 290)
            Me.lvthongtindieuxe.TabIndex = 0
            Me.lvthongtindieuxe.UseCompatibleStateImageBehavior = False
            Me.lvthongtindieuxe.View = System.Windows.Forms.View.Details
            '
            'ch0
            '
            Me.ch0.Text = "Mã Điều Xe"
            Me.ch0.Width = 118
            '
            'ch1
            '
            Me.ch1.Text = "Mã Số Xe"
            Me.ch1.Width = 110
            '
            'ch11
            '
            Me.ch11.Text = "Tải Trọng Của Xe"
            Me.ch11.Width = 100
            '
            'ch2
            '
            Me.ch2.Text = "Nơi Nhận"
            Me.ch2.Width = 184
            '
            'ch3
            '
            Me.ch3.Text = "Nơi Giao"
            Me.ch3.Width = 154
            '
            'ch4
            '
            Me.ch4.Text = "Số Tấn Mỗi Xe"
            Me.ch4.Width = 100
            '
            'ch5
            '
            Me.ch5.Text = "Ngày Đi"
            Me.ch5.Width = 114
            '
            'ch6
            '
            Me.ch6.Text = "Ngày Về"
            Me.ch6.Width = 91
            '
            'ch7
            '
            Me.ch7.Text = "Tình Trạng Thanh Toán"
            Me.ch7.Width = 200
            '
            'ch8
            '
            Me.ch8.Text = "Mã Điều Xe"
            Me.ch8.Width = 0
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(629, 10)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(69, 13)
            Me.label9.TabIndex = 21
            Me.label9.Text = "Mã Điều Xe :"
            '
            'txtmadieuxe
            '
            Me.txtmadieuxe.BackColor = System.Drawing.SystemColors.InactiveCaption
            Me.txtmadieuxe.Location = New System.Drawing.Point(704, 7)
            Me.txtmadieuxe.Name = "txtmadieuxe"
            Me.txtmadieuxe.Size = New System.Drawing.Size(215, 20)
            Me.txtmadieuxe.TabIndex = 21
            '
            'btnthemma
            '
            Me.btnthemma.Location = New System.Drawing.Point(925, 5)
            Me.btnthemma.Name = "btnthemma"
            Me.btnthemma.Size = New System.Drawing.Size(75, 23)
            Me.btnthemma.TabIndex = 22
            Me.btnthemma.Text = "..+.."
            Me.btnthemma.UseVisualStyleBackColor = True
            '
            'frmTTDieuXe
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1008, 632)
            Me.Controls.Add(Me.btnthemma)
            Me.Controls.Add(Me.txtmadieuxe)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.btnthoat)
            Me.Controls.Add(Me.btnsua)
            Me.Controls.Add(Me.btnxoa)
            Me.Controls.Add(Me.btnthem)
            Me.Controls.Add(Me.gb3)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gb1)
            Me.Controls.Add(Me.cbhopdong)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.cbkhachhang)
            Me.Controls.Add(Me.label1)
            Me.Name = "frmTTDieuXe"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "QUẢN LÝ ĐIỀU XE"
            Me.gb1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.gb3.ResumeLayout(False)
            Me.gb3.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private cbkhachhang As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private cbhopdong As System.Windows.Forms.ComboBox
		Private gb1 As System.Windows.Forms.GroupBox
		Private lvxe As System.Windows.Forms.ListView
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private lvnhanvien As System.Windows.Forms.ListView
		Private gb3 As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private txtsotan As System.Windows.Forms.TextBox
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private dtpngaydi As System.Windows.Forms.DateTimePicker
		Private label6 As System.Windows.Forms.Label
		Private dtpngayve As System.Windows.Forms.DateTimePicker
		Private label8 As System.Windows.Forms.Label
		Private cbtinhtrangthanhtoan As System.Windows.Forms.ComboBox
		Private btnthem As System.Windows.Forms.Button
		Private btnxoa As System.Windows.Forms.Button
		Private btnsua As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private lvthongtindieuxe As System.Windows.Forms.ListView
		Private c1 As System.Windows.Forms.ColumnHeader
		Private c2 As System.Windows.Forms.ColumnHeader
		Private c3 As System.Windows.Forms.ColumnHeader
		Private c4 As System.Windows.Forms.ColumnHeader
		Private c0 As System.Windows.Forms.ColumnHeader
		Private h0 As System.Windows.Forms.ColumnHeader
		Private h1 As System.Windows.Forms.ColumnHeader
		Private h2 As System.Windows.Forms.ColumnHeader
		Private h3 As System.Windows.Forms.ColumnHeader
		Private h4 As System.Windows.Forms.ColumnHeader
		Private h5 As System.Windows.Forms.ColumnHeader
		Private h6 As System.Windows.Forms.ColumnHeader
		Private ch1 As System.Windows.Forms.ColumnHeader
		Private ch2 As System.Windows.Forms.ColumnHeader
		Private ch3 As System.Windows.Forms.ColumnHeader
		Private ch4 As System.Windows.Forms.ColumnHeader
		Private ch5 As System.Windows.Forms.ColumnHeader
		Private ch6 As System.Windows.Forms.ColumnHeader
		Private ch7 As System.Windows.Forms.ColumnHeader
		Private cbnoigiao As System.Windows.Forms.ComboBox
		Private cbnoinhan As System.Windows.Forms.ComboBox
		Private label9 As System.Windows.Forms.Label
		Private txtmadieuxe As System.Windows.Forms.TextBox
		Private btnthemma As System.Windows.Forms.Button
		Private ch0 As System.Windows.Forms.ColumnHeader
		Private ch8 As System.Windows.Forms.ColumnHeader
		Private cbbaogia As System.Windows.Forms.ComboBox
		Private label10 As System.Windows.Forms.Label
		Private ch11 As System.Windows.Forms.ColumnHeader
	End Class
End Namespace
