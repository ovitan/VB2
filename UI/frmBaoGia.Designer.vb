Namespace UI
	Partial Class txt_mabaogia
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
			Me.label8 = New System.Windows.Forms.Label()
			Me.grv_BG = New System.Windows.Forms.DataGridView()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.colHD = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.txt_noigiao = New System.Windows.Forms.TextBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.cbb_khuvuc = New System.Windows.Forms.ComboBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.cbb_phanvung = New System.Windows.Forms.ComboBox()
			Me.txt_ma_bao_gia = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.txt_dongiatan = New System.Windows.Forms.TextBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.txt_dongiachuyen = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.cbb_hopdong = New System.Windows.Forms.ComboBox()
			Me.dtpdenngay = New System.Windows.Forms.DateTimePicker()
			Me.label6 = New System.Windows.Forms.Label()
			Me.dtptungay = New System.Windows.Forms.DateTimePicker()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.txt_noinhan = New System.Windows.Forms.TextBox()
			Me.btn_thoat = New System.Windows.Forms.Button()
			Me.btn_them = New System.Windows.Forms.Button()
			Me.btn_sua = New System.Windows.Forms.Button()
			Me.btn_xoa = New System.Windows.Forms.Button()
			Me.btn_luu = New System.Windows.Forms.Button()
			Me.label9 = New System.Windows.Forms.Label()
			Me.txt_ghichu = New System.Windows.Forms.TextBox()
			DirectCast(Me.grv_BG, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(426, 50)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(58, 13)
			Me.label8.TabIndex = 97
			Me.label8.Text = "Nơi Nhận :"
			' 
			' grv_BG
			' 
			Me.grv_BG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_BG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.colHD, Me.Column3, Me.Column4, Me.Column5, Me.Column6, _
				Me.Column7, Me.Column8, Me.Column9})
			Me.grv_BG.Location = New System.Drawing.Point(14, 28)
			Me.grv_BG.Name = "grv_BG"
			Me.grv_BG.Size = New System.Drawing.Size(914, 205)
			Me.grv_BG.TabIndex = 32
			AddHandler Me.grv_BG.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_BG_CellClick)
			' 
			' Column1
			' 
			Me.Column1.DataPropertyName = "ma_bao_gia"
			Me.Column1.HeaderText = "Mã Báo Giá"
			Me.Column1.Name = "Column1"
			' 
			' colHD
			' 
			Me.colHD.DataPropertyName = "ma_hop_dong"
			Me.colHD.HeaderText = "Mã Hợp Đồng"
			Me.colHD.Name = "colHD"
			' 
			' Column3
			' 
			Me.Column3.DataPropertyName = "noi_nhan"
			Me.Column3.HeaderText = "Nơi Nhận"
			Me.Column3.Name = "Column3"
			' 
			' Column4
			' 
			Me.Column4.DataPropertyName = "noi_giao"
			Me.Column4.HeaderText = "Nơi Giao"
			Me.Column4.Name = "Column4"
			' 
			' Column5
			' 
			Me.Column5.DataPropertyName = "don_gia_chuyen"
			Me.Column5.HeaderText = "Đơn giá chuyến"
			Me.Column5.Name = "Column5"
			' 
			' Column6
			' 
			Me.Column6.DataPropertyName = "don_gia_tan"
			Me.Column6.HeaderText = "Đơn giá tấn"
			Me.Column6.Name = "Column6"
			' 
			' Column7
			' 
			Me.Column7.DataPropertyName = "ghi_chu"
			Me.Column7.HeaderText = "Ghi chú"
			Me.Column7.Name = "Column7"
			' 
			' Column8
			' 
			Me.Column8.DataPropertyName = "tu_ngay"
			Me.Column8.HeaderText = "Từ ngày"
			Me.Column8.Name = "Column8"
			' 
			' Column9
			' 
			Me.Column9.DataPropertyName = "den_ngay"
			Me.Column9.HeaderText = "Đến ngày"
			Me.Column9.Name = "Column9"
			' 
			' txt_noigiao
			' 
			Me.txt_noigiao.Location = New System.Drawing.Point(785, 43)
			Me.txt_noigiao.Name = "txt_noigiao"
			Me.txt_noigiao.Size = New System.Drawing.Size(145, 20)
			Me.txt_noigiao.TabIndex = 99
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(718, 50)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(54, 13)
			Me.label7.TabIndex = 98
			Me.label7.Text = "Nơi Giao :"
			' 
			' cbb_khuvuc
			' 
			Me.cbb_khuvuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbb_khuvuc.FormattingEnabled = True
			Me.cbb_khuvuc.Location = New System.Drawing.Point(129, 119)
			Me.cbb_khuvuc.Name = "cbb_khuvuc"
			Me.cbb_khuvuc.Size = New System.Drawing.Size(241, 21)
			Me.cbb_khuvuc.TabIndex = 96
			AddHandler Me.cbb_khuvuc.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbb_khuvuc_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(56, 119)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(54, 13)
			Me.label3.TabIndex = 95
			Me.label3.Text = "Khu Vực :"
			' 
			' cbb_phanvung
			' 
			Me.cbb_phanvung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbb_phanvung.FormattingEnabled = True
			Me.cbb_phanvung.Location = New System.Drawing.Point(129, 158)
			Me.cbb_phanvung.Name = "cbb_phanvung"
			Me.cbb_phanvung.Size = New System.Drawing.Size(241, 21)
			Me.cbb_phanvung.TabIndex = 94
			AddHandler Me.cbb_phanvung.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbb_phanvung_SelectedIndexChanged)
			' 
			' txt_ma_bao_gia
			' 
			Me.txt_ma_bao_gia.Location = New System.Drawing.Point(129, 40)
			Me.txt_ma_bao_gia.Name = "txt_ma_bao_gia"
			Me.txt_ma_bao_gia.Size = New System.Drawing.Size(121, 20)
			Me.txt_ma_bao_gia.TabIndex = 92
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(45, 163)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(66, 13)
			Me.label2.TabIndex = 93
			Me.label2.Text = "Phân Vùng :"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(38, 47)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(72, 13)
			Me.label12.TabIndex = 90
			Me.label12.Text = "Mã Báo Giá  :"
			' 
			' txt_dongiatan
			' 
			Me.txt_dongiatan.Location = New System.Drawing.Point(785, 82)
			Me.txt_dongiatan.Name = "txt_dongiatan"
			Me.txt_dongiatan.Size = New System.Drawing.Size(145, 20)
			Me.txt_dongiatan.TabIndex = 89
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(698, 82)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(74, 13)
			Me.label11.TabIndex = 88
			Me.label11.Text = "Đơn Giá Tấn :"
			' 
			' txt_dongiachuyen
			' 
			Me.txt_dongiachuyen.Location = New System.Drawing.Point(490, 79)
			Me.txt_dongiachuyen.Name = "txt_dongiachuyen"
			Me.txt_dongiachuyen.Size = New System.Drawing.Size(143, 20)
			Me.txt_dongiachuyen.TabIndex = 87
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(360, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(291, 24)
			Me.label1.TabIndex = 79
			Me.label1.Text = "LẬP BÁO GIÁ VẬN CHUYỂN"
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.grv_BG)
			Me.groupBox1.Location = New System.Drawing.Point(31, 294)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(934, 250)
			Me.groupBox1.TabIndex = 91
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Bảng Báo Giá"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(393, 82)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(91, 13)
			Me.label10.TabIndex = 86
			Me.label10.Text = "Đơn Giá Chuyến :"
			' 
			' cbb_hopdong
			' 
			Me.cbb_hopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbb_hopdong.FormattingEnabled = True
			Me.cbb_hopdong.Location = New System.Drawing.Point(129, 78)
			Me.cbb_hopdong.Name = "cbb_hopdong"
			Me.cbb_hopdong.Size = New System.Drawing.Size(241, 21)
			Me.cbb_hopdong.TabIndex = 81
			AddHandler Me.cbb_hopdong.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbb_hopdong_SelectedIndexChanged)
			' 
			' dtpdenngay
			' 
			Me.dtpdenngay.Location = New System.Drawing.Point(785, 122)
			Me.dtpdenngay.Name = "dtpdenngay"
			Me.dtpdenngay.Size = New System.Drawing.Size(210, 20)
			Me.dtpdenngay.TabIndex = 85
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(711, 129)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(61, 13)
			Me.label6.TabIndex = 84
			Me.label6.Text = "Đến Ngày :"
			' 
			' dtptungay
			' 
			Me.dtptungay.Location = New System.Drawing.Point(490, 120)
			Me.dtptungay.Name = "dtptungay"
			Me.dtptungay.Size = New System.Drawing.Size(209, 20)
			Me.dtptungay.TabIndex = 83
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(389, 124)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(95, 13)
			Me.label5.TabIndex = 82
			Me.label5.Text = "Báo Giá Từ Ngày :"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(45, 81)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(65, 13)
			Me.label4.TabIndex = 80
			Me.label4.Text = " Hợp Đồng :"
			' 
			' txt_noinhan
			' 
			Me.txt_noinhan.Location = New System.Drawing.Point(490, 43)
			Me.txt_noinhan.Name = "txt_noinhan"
			Me.txt_noinhan.Size = New System.Drawing.Size(145, 20)
			Me.txt_noinhan.TabIndex = 105
			' 
			' btn_thoat
			' 
			Me.btn_thoat.Location = New System.Drawing.Point(721, 243)
			Me.btn_thoat.Name = "btn_thoat"
			Me.btn_thoat.Size = New System.Drawing.Size(75, 27)
			Me.btn_thoat.TabIndex = 110
			Me.btn_thoat.Text = "Thoát"
			Me.btn_thoat.UseVisualStyleBackColor = True
			AddHandler Me.btn_thoat.Click, New System.EventHandler(AddressOf Me.btn_thoat_Click)
			' 
			' btn_them
			' 
			Me.btn_them.Location = New System.Drawing.Point(218, 245)
			Me.btn_them.Name = "btn_them"
			Me.btn_them.Size = New System.Drawing.Size(103, 23)
			Me.btn_them.TabIndex = 109
			Me.btn_them.Text = "Tạo báo giá mới"
			Me.btn_them.UseVisualStyleBackColor = True
			AddHandler Me.btn_them.Click, New System.EventHandler(AddressOf Me.btn_them_Click)
			' 
			' btn_sua
			' 
			Me.btn_sua.Location = New System.Drawing.Point(471, 241)
			Me.btn_sua.Name = "btn_sua"
			Me.btn_sua.Size = New System.Drawing.Size(75, 27)
			Me.btn_sua.TabIndex = 108
			Me.btn_sua.Text = "Sửa"
			Me.btn_sua.UseVisualStyleBackColor = True
			AddHandler Me.btn_sua.Click, New System.EventHandler(AddressOf Me.btn_sua_Click)
			' 
			' btn_xoa
			' 
			Me.btn_xoa.Location = New System.Drawing.Point(595, 241)
			Me.btn_xoa.Name = "btn_xoa"
			Me.btn_xoa.Size = New System.Drawing.Size(75, 27)
			Me.btn_xoa.TabIndex = 107
			Me.btn_xoa.Text = "Xóa"
			Me.btn_xoa.UseVisualStyleBackColor = True
			AddHandler Me.btn_xoa.Click, New System.EventHandler(AddressOf Me.btn_xoa_Click)
			' 
			' btn_luu
			' 
			Me.btn_luu.Location = New System.Drawing.Point(354, 245)
			Me.btn_luu.Name = "btn_luu"
			Me.btn_luu.Size = New System.Drawing.Size(75, 23)
			Me.btn_luu.TabIndex = 106
			Me.btn_luu.Text = "Lưu báo giá"
			Me.btn_luu.UseVisualStyleBackColor = True
			AddHandler Me.btn_luu.Click, New System.EventHandler(AddressOf Me.btn_luu_Click)
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(432, 166)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(51, 13)
			Me.label9.TabIndex = 111
			Me.label9.Text = "Ghi Chú :"
			' 
			' txt_ghichu
			' 
			Me.txt_ghichu.Location = New System.Drawing.Point(490, 163)
			Me.txt_ghichu.Multiline = True
			Me.txt_ghichu.Name = "txt_ghichu"
			Me.txt_ghichu.Size = New System.Drawing.Size(505, 62)
			Me.txt_ghichu.TabIndex = 112
			' 
			' txt_mabaogia
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 590)
			Me.Controls.Add(Me.txt_ghichu)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.btn_thoat)
			Me.Controls.Add(Me.btn_them)
			Me.Controls.Add(Me.btn_sua)
			Me.Controls.Add(Me.btn_xoa)
			Me.Controls.Add(Me.btn_luu)
			Me.Controls.Add(Me.txt_noinhan)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.txt_noigiao)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.cbb_khuvuc)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.cbb_phanvung)
			Me.Controls.Add(Me.txt_ma_bao_gia)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.txt_dongiatan)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.txt_dongiachuyen)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.cbb_hopdong)
			Me.Controls.Add(Me.dtpdenngay)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.dtptungay)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Name = "txt_mabaogia"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "frmBaoGia"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmBaoGia_Load)
			DirectCast(Me.grv_BG, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label8 As System.Windows.Forms.Label
		Private grv_BG As System.Windows.Forms.DataGridView
		Private txt_noigiao As System.Windows.Forms.TextBox
		Private label7 As System.Windows.Forms.Label
		Private cbb_khuvuc As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Private cbb_phanvung As System.Windows.Forms.ComboBox
		Private txt_ma_bao_gia As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private txt_dongiatan As System.Windows.Forms.TextBox
		Private label11 As System.Windows.Forms.Label
		Private txt_dongiachuyen As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label10 As System.Windows.Forms.Label
		Private cbb_hopdong As System.Windows.Forms.ComboBox
		Private dtpdenngay As System.Windows.Forms.DateTimePicker
		Private label6 As System.Windows.Forms.Label
		Private dtptungay As System.Windows.Forms.DateTimePicker
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private txt_noinhan As System.Windows.Forms.TextBox
		Private btn_thoat As System.Windows.Forms.Button
		Private btn_them As System.Windows.Forms.Button
		Private btn_sua As System.Windows.Forms.Button
		Private btn_xoa As System.Windows.Forms.Button
		Private btn_luu As System.Windows.Forms.Button
		Private label9 As System.Windows.Forms.Label
		Private txt_ghichu As System.Windows.Forms.TextBox
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private colHD As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace
