Namespace UI
	Partial Class frmBangKe
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
			Me.components = New System.ComponentModel.Container()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.txtmakhachhang = New System.Windows.Forms.TextBox()
			Me.cbhopdong = New System.Windows.Forms.ComboBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.txtmabangke = New System.Windows.Forms.TextBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.dtpngayvanchuyen = New System.Windows.Forms.DateTimePicker()
			Me.label7 = New System.Windows.Forms.Label()
			Me.txtmasoxe = New System.Windows.Forms.TextBox()
			Me.label8 = New System.Windows.Forms.Label()
			Me.txtnoinhan = New System.Windows.Forms.TextBox()
			Me.label9 = New System.Windows.Forms.Label()
			Me.txtnoigiao = New System.Windows.Forms.TextBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.txtdongiatan = New System.Windows.Forms.TextBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.txtdongiachuyen = New System.Windows.Forms.TextBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.rtbghichu = New System.Windows.Forms.RichTextBox()
			Me.lvthongtin = New System.Windows.Forms.ListView()
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
			Me.cmsbangke = New System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.mnxoa = New System.Windows.Forms.ToolStripMenuItem()
			Me.btnluu = New System.Windows.Forms.Button()
			Me.btnxoa = New System.Windows.Forms.Button()
			Me.btncapnhat = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.btntim = New System.Windows.Forms.Button()
			Me.btntaoma = New System.Windows.Forms.Button()
			Me.txtkhoiluong = New System.Windows.Forms.TextBox()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.cbkhachhang = New System.Windows.Forms.ComboBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.cbmadieuxe = New System.Windows.Forms.ComboBox()
			Me.c22 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cmsbangke.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(323, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(373, 24)
			Me.label1.TabIndex = 0
			Me.label1.Text = "BẢNG KÊ THÔNG TIN VẬN CHUYỂN"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(335, 52)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(91, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Mã Khách Hàng :"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(688, 49)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(80, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Mã Hợp Đồng :"
			' 
			' txtmakhachhang
			' 
			Me.txtmakhachhang.Location = New System.Drawing.Point(432, 47)
			Me.txtmakhachhang.MaxLength = 10
			Me.txtmakhachhang.Name = "txtmakhachhang"
			Me.txtmakhachhang.Size = New System.Drawing.Size(250, 20)
			Me.txtmakhachhang.TabIndex = 4
			AddHandler Me.txtmakhachhang.TextChanged, New System.EventHandler(AddressOf Me.txtmakhachhang_TextChanged)
			' 
			' cbhopdong
			' 
			Me.cbhopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbhopdong.FormattingEnabled = True
			Me.cbhopdong.Location = New System.Drawing.Point(774, 44)
			Me.cbhopdong.Name = "cbhopdong"
			Me.cbhopdong.Size = New System.Drawing.Size(222, 21)
			Me.cbhopdong.TabIndex = 6
			AddHandler Me.cbhopdong.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbhopdong_SelectedIndexChanged)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(5, 77)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(72, 13)
			Me.label5.TabIndex = 7
			Me.label5.Text = "Mã Bảng Kê :"
			' 
			' txtmabangke
			' 
			Me.txtmabangke.BackColor = System.Drawing.SystemColors.GradientActiveCaption
			Me.txtmabangke.Location = New System.Drawing.Point(79, 74)
			Me.txtmabangke.Name = "txtmabangke"
			Me.txtmabangke.Size = New System.Drawing.Size(207, 20)
			Me.txtmabangke.TabIndex = 8
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(39, 102)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(38, 13)
			Me.label6.TabIndex = 9
			Me.label6.Text = "Ngày :"
			' 
			' dtpngayvanchuyen
			' 
			Me.dtpngayvanchuyen.Location = New System.Drawing.Point(79, 100)
			Me.dtpngayvanchuyen.Name = "dtpngayvanchuyen"
			Me.dtpngayvanchuyen.Size = New System.Drawing.Size(250, 20)
			Me.dtpngayvanchuyen.TabIndex = 10
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(708, 70)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(60, 13)
			Me.label7.TabIndex = 11
			Me.label7.Text = "Mã Số Xe :"
			' 
			' txtmasoxe
			' 
			Me.txtmasoxe.Location = New System.Drawing.Point(774, 67)
			Me.txtmasoxe.MaxLength = 10
			Me.txtmasoxe.Name = "txtmasoxe"
			Me.txtmasoxe.Size = New System.Drawing.Size(222, 20)
			Me.txtmasoxe.TabIndex = 12
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(368, 98)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(58, 13)
			Me.label8.TabIndex = 13
			Me.label8.Text = "Nơi Nhận :"
			' 
			' txtnoinhan
			' 
			Me.txtnoinhan.Location = New System.Drawing.Point(432, 95)
			Me.txtnoinhan.MaxLength = 100
			Me.txtnoinhan.Name = "txtnoinhan"
			Me.txtnoinhan.Size = New System.Drawing.Size(250, 20)
			Me.txtnoinhan.TabIndex = 14
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(714, 98)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(54, 13)
			Me.label9.TabIndex = 15
			Me.label9.Text = "Nơi Giao :"
			' 
			' txtnoigiao
			' 
			Me.txtnoigiao.Location = New System.Drawing.Point(774, 91)
			Me.txtnoigiao.MaxLength = 100
			Me.txtnoigiao.Name = "txtnoigiao"
			Me.txtnoigiao.Size = New System.Drawing.Size(222, 20)
			Me.txtnoigiao.TabIndex = 16
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(352, 151)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(74, 13)
			Me.label10.TabIndex = 17
			Me.label10.Text = "Đơn Giá Tấn :"
			' 
			' txtdongiatan
			' 
			Me.txtdongiatan.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(224)), CInt(CByte(224)))
			Me.txtdongiatan.Location = New System.Drawing.Point(432, 148)
			Me.txtdongiatan.Name = "txtdongiatan"
			Me.txtdongiatan.Size = New System.Drawing.Size(250, 20)
			Me.txtdongiatan.TabIndex = 18
			AddHandler Me.txtdongiatan.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtdongiatan_KeyPress)
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(335, 127)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(91, 13)
			Me.label11.TabIndex = 19
			Me.label11.Text = "Đơn Giá Chuyến :"
			' 
			' txtdongiachuyen
			' 
			Me.txtdongiachuyen.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(224)), CInt(CByte(224)))
			Me.txtdongiachuyen.Location = New System.Drawing.Point(432, 124)
			Me.txtdongiachuyen.Name = "txtdongiachuyen"
			Me.txtdongiachuyen.Size = New System.Drawing.Size(250, 20)
			Me.txtdongiachuyen.TabIndex = 20
			AddHandler Me.txtdongiachuyen.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtdongiachuyen_KeyPress)
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(717, 124)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(51, 13)
			Me.label12.TabIndex = 21
			Me.label12.Text = "Ghi Chú :"
			' 
			' rtbghichu
			' 
			Me.rtbghichu.Location = New System.Drawing.Point(774, 117)
			Me.rtbghichu.MaxLength = 100
			Me.rtbghichu.Name = "rtbghichu"
			Me.rtbghichu.Size = New System.Drawing.Size(224, 53)
			Me.rtbghichu.TabIndex = 22
			Me.rtbghichu.Text = ""
			' 
			' lvthongtin
			' 
			Me.lvthongtin.Activation = System.Windows.Forms.ItemActivation.OneClick
			Me.lvthongtin.Alignment = System.Windows.Forms.ListViewAlignment.Left
			Me.lvthongtin.BackColor = System.Drawing.SystemColors.Window
			Me.lvthongtin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1, Me.c2, Me.c22, Me.c3, Me.c4, Me.c5, _
				Me.c6, Me.c7, Me.c8, Me.c9, Me.c10, Me.c11})
			Me.lvthongtin.ContextMenuStrip = Me.cmsbangke
			Me.lvthongtin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lvthongtin.FullRowSelect = True
			Me.lvthongtin.Location = New System.Drawing.Point(1, 213)
			Me.lvthongtin.Name = "lvthongtin"
			Me.lvthongtin.ShowItemToolTips = True
			Me.lvthongtin.Size = New System.Drawing.Size(1006, 416)
			Me.lvthongtin.TabIndex = 0
			Me.lvthongtin.UseCompatibleStateImageBehavior = False
			Me.lvthongtin.View = System.Windows.Forms.View.Details
			Me.lvthongtin.VirtualListSize = 10000
			AddHandler Me.lvthongtin.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lvthongtin_SelectedIndexChanged)
			' 
			' c1
			' 
			Me.c1.Text = "STT"
			' 
			' c2
			' 
			Me.c2.Text = "Mã Bảng Kê"
			Me.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.c2.Width = 93
			' 
			' c3
			' 
			Me.c3.Text = "Ngày Vận Chuyển"
			Me.c3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.c3.Width = 104
			' 
			' c4
			' 
			Me.c4.Text = "Mã Số Xe"
			Me.c4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.c4.Width = 92
			' 
			' c5
			' 
			Me.c5.Text = "Nơi Nhận"
			Me.c5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.c5.Width = 119
			' 
			' c6
			' 
			Me.c6.Text = "Nơi Giao"
			Me.c6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.c6.Width = 121
			' 
			' c7
			' 
			Me.c7.Text = "Số Tấn"
			Me.c7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.c7.Width = 70
			' 
			' c8
			' 
			Me.c8.Text = "Đơn Giá Chuyến"
			Me.c8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.c8.Width = 150
			' 
			' c9
			' 
			Me.c9.Text = "Đơn Giá Tấn"
			Me.c9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.c9.Width = 150
			' 
			' c10
			' 
			Me.c10.Text = "Thành Tiền"
			Me.c10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.c10.Width = 200
			' 
			' c11
			' 
			Me.c11.Text = "Ghi Chú"
			Me.c11.Width = 300
			' 
			' cmsbangke
			' 
			Me.cmsbangke.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnxoa})
			Me.cmsbangke.Name = "cmsbangke"
			Me.cmsbangke.Size = New System.Drawing.Size(95, 26)
			' 
			' mnxoa
			' 
			Me.mnxoa.Name = "mnxoa"
			Me.mnxoa.Size = New System.Drawing.Size(94, 22)
			Me.mnxoa.Text = "Xóa"
			AddHandler Me.mnxoa.Click, New System.EventHandler(AddressOf Me.mnxoa_Click)
			' 
			' btnluu
			' 
			Me.btnluu.Location = New System.Drawing.Point(79, 184)
			Me.btnluu.Name = "btnluu"
			Me.btnluu.Size = New System.Drawing.Size(75, 23)
			Me.btnluu.TabIndex = 24
			Me.btnluu.Text = "Thêm"
			Me.btnluu.UseVisualStyleBackColor = True
			AddHandler Me.btnluu.Click, New System.EventHandler(AddressOf Me.btnluu_Click)
			' 
			' btnxoa
			' 
			Me.btnxoa.Location = New System.Drawing.Point(167, 184)
			Me.btnxoa.Name = "btnxoa"
			Me.btnxoa.Size = New System.Drawing.Size(75, 23)
			Me.btnxoa.TabIndex = 25
			Me.btnxoa.Text = "Xóa"
			Me.btnxoa.UseVisualStyleBackColor = True
			AddHandler Me.btnxoa.Click, New System.EventHandler(AddressOf Me.btnxoa_Click)
			' 
			' btncapnhat
			' 
			Me.btncapnhat.Location = New System.Drawing.Point(840, 184)
			Me.btncapnhat.Name = "btncapnhat"
			Me.btncapnhat.Size = New System.Drawing.Size(75, 23)
			Me.btncapnhat.TabIndex = 26
			Me.btncapnhat.Text = "Sửa"
			Me.btncapnhat.UseVisualStyleBackColor = True
			Me.btncapnhat.Visible = False
			AddHandler Me.btncapnhat.Click, New System.EventHandler(AddressOf Me.btncapnhat_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(921, 184)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 27
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' btntim
			' 
			Me.btntim.Location = New System.Drawing.Point(254, 184)
			Me.btntim.Name = "btntim"
			Me.btntim.Size = New System.Drawing.Size(75, 23)
			Me.btntim.TabIndex = 28
			Me.btntim.Text = "Tìm"
			Me.btntim.UseVisualStyleBackColor = True
			AddHandler Me.btntim.Click, New System.EventHandler(AddressOf Me.btntim_Click)
			' 
			' btntaoma
			' 
			Me.btntaoma.Location = New System.Drawing.Point(292, 73)
			Me.btntaoma.Name = "btntaoma"
			Me.btntaoma.Size = New System.Drawing.Size(37, 21)
			Me.btntaoma.TabIndex = 29
			Me.btntaoma.Text = "+"
			Me.btntaoma.UseVisualStyleBackColor = True
			AddHandler Me.btntaoma.Click, New System.EventHandler(AddressOf Me.btntaoma_Click)
			' 
			' txtkhoiluong
			' 
			Me.txtkhoiluong.Location = New System.Drawing.Point(79, 128)
			Me.txtkhoiluong.MaxLength = 100
			Me.txtkhoiluong.Name = "txtkhoiluong"
			Me.txtkhoiluong.Size = New System.Drawing.Size(250, 20)
			Me.txtkhoiluong.TabIndex = 31
			AddHandler Me.txtkhoiluong.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtkhoiluong_KeyPress)
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Location = New System.Drawing.Point(0, 131)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(77, 13)
			Me.label13.TabIndex = 32
			Me.label13.Text = "T Khối Lượng :"
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(4, 52)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(73, 13)
			Me.label14.TabIndex = 33
			Me.label14.Text = "Khách Hàng :"
			' 
			' cbkhachhang
			' 
			Me.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbkhachhang.FormattingEnabled = True
			Me.cbkhachhang.Location = New System.Drawing.Point(79, 49)
			Me.cbkhachhang.Name = "cbkhachhang"
			Me.cbkhachhang.Size = New System.Drawing.Size(250, 21)
			Me.cbkhachhang.TabIndex = 34
			AddHandler Me.cbkhachhang.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbkhachhang_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(357, 73)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(69, 13)
			Me.label3.TabIndex = 35
			Me.label3.Text = "Mã Điều Xe :"
			' 
			' cbmadieuxe
			' 
			Me.cbmadieuxe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbmadieuxe.FormattingEnabled = True
			Me.cbmadieuxe.Location = New System.Drawing.Point(432, 70)
			Me.cbmadieuxe.Name = "cbmadieuxe"
			Me.cbmadieuxe.Size = New System.Drawing.Size(250, 21)
			Me.cbmadieuxe.TabIndex = 36
			AddHandler Me.cbmadieuxe.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbmadieuxe_SelectedIndexChanged)
			' 
			' c22
			' 
			Me.c22.Text = "Mã Điều Xe"
			Me.c22.Width = 100
			' 
			' frmBangKe
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.cbmadieuxe)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.cbkhachhang)
			Me.Controls.Add(Me.label14)
			Me.Controls.Add(Me.label13)
			Me.Controls.Add(Me.txtkhoiluong)
			Me.Controls.Add(Me.lvthongtin)
			Me.Controls.Add(Me.btntaoma)
			Me.Controls.Add(Me.btntim)
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btncapnhat)
			Me.Controls.Add(Me.btnxoa)
			Me.Controls.Add(Me.btnluu)
			Me.Controls.Add(Me.rtbghichu)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.txtdongiachuyen)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.txtdongiatan)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.txtnoigiao)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.txtnoinhan)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.txtmasoxe)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.dtpngayvanchuyen)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.txtmabangke)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.cbhopdong)
			Me.Controls.Add(Me.txtmakhachhang)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmBangKe"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "BẢNG KÊ VẬN CHUYỂN"
			Me.cmsbangke.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private txtmakhachhang As System.Windows.Forms.TextBox
		Private cbhopdong As System.Windows.Forms.ComboBox
		Private label5 As System.Windows.Forms.Label
		Private txtmabangke As System.Windows.Forms.TextBox
		Private label6 As System.Windows.Forms.Label
		Private dtpngayvanchuyen As System.Windows.Forms.DateTimePicker
		Private label7 As System.Windows.Forms.Label
		Private txtmasoxe As System.Windows.Forms.TextBox
		Private label8 As System.Windows.Forms.Label
		Private txtnoinhan As System.Windows.Forms.TextBox
		Private label9 As System.Windows.Forms.Label
		Private txtnoigiao As System.Windows.Forms.TextBox
		Private label10 As System.Windows.Forms.Label
		Private txtdongiatan As System.Windows.Forms.TextBox
		Private label11 As System.Windows.Forms.Label
		Private txtdongiachuyen As System.Windows.Forms.TextBox
		Private label12 As System.Windows.Forms.Label
		Private rtbghichu As System.Windows.Forms.RichTextBox
		Private btnluu As System.Windows.Forms.Button
		Private btnxoa As System.Windows.Forms.Button
		Private btncapnhat As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
		Private lvthongtin As System.Windows.Forms.ListView
		Private c1 As System.Windows.Forms.ColumnHeader
		Private c2 As System.Windows.Forms.ColumnHeader
		Private c3 As System.Windows.Forms.ColumnHeader
		Private c4 As System.Windows.Forms.ColumnHeader
		Private c5 As System.Windows.Forms.ColumnHeader
		Private c6 As System.Windows.Forms.ColumnHeader
		Private c7 As System.Windows.Forms.ColumnHeader
		Private c8 As System.Windows.Forms.ColumnHeader
		Private c9 As System.Windows.Forms.ColumnHeader
		Private c10 As System.Windows.Forms.ColumnHeader
		Private c11 As System.Windows.Forms.ColumnHeader
		Private btntim As System.Windows.Forms.Button
		Private btntaoma As System.Windows.Forms.Button
		Private txtkhoiluong As System.Windows.Forms.TextBox
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private cbkhachhang As System.Windows.Forms.ComboBox
		Private cmsbangke As System.Windows.Forms.ContextMenuStrip
		Private mnxoa As System.Windows.Forms.ToolStripMenuItem
		Private label3 As System.Windows.Forms.Label
		Private cbmadieuxe As System.Windows.Forms.ComboBox
		Private c22 As System.Windows.Forms.ColumnHeader
	End Class
End Namespace
