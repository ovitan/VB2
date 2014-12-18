Namespace UI
	Partial Class frmDieuXe
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
			Me.txt_madieuxe = New System.Windows.Forms.TextBox()
			Me.grv_dieuxe = New System.Windows.Forms.DataGridView()
			Me.dataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.col_sx = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ngay_ve = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.tinh_trang_thanh_toan = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.data_ngaydieuxe = New System.Windows.Forms.DateTimePicker()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.cbb_soxe = New System.Windows.Forms.ComboBox()
			Me.label8 = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.cbtinhtrangthanhtoan = New System.Windows.Forms.ComboBox()
			Me.label9 = New System.Windows.Forms.Label()
			Me.dtpngayve = New System.Windows.Forms.DateTimePicker()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.txt_sotan = New System.Windows.Forms.TextBox()
			Me.txt_noigiao = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.txt_noinhan = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.cbb_khachhang = New System.Windows.Forms.ComboBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.groupBox4 = New System.Windows.Forms.GroupBox()
			Me.grv_NV = New System.Windows.Forms.DataGridView()
			Me.dataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btn_thoat = New System.Windows.Forms.Button()
			Me.btn_them = New System.Windows.Forms.Button()
			Me.btn_sua = New System.Windows.Forms.Button()
			Me.btn_xoa = New System.Windows.Forms.Button()
			Me.btn_luu = New System.Windows.Forms.Button()
			Me.grv_TTxe = New System.Windows.Forms.DataGridView()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.coltrongluong = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.grv_KH = New System.Windows.Forms.DataGridView()
			Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.txt_trongluongxe = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label = New System.Windows.Forms.Label()
			DirectCast(Me.grv_dieuxe, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox3.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.groupBox4.SuspendLayout()
			DirectCast(Me.grv_NV, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.grv_TTxe, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.grv_KH, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' txt_madieuxe
			' 
			Me.txt_madieuxe.Location = New System.Drawing.Point(857, 434)
			Me.txt_madieuxe.Name = "txt_madieuxe"
			Me.txt_madieuxe.Size = New System.Drawing.Size(175, 20)
			Me.txt_madieuxe.TabIndex = 46
			' 
			' grv_dieuxe
			' 
			Me.grv_dieuxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_dieuxe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewTextBoxColumn1, Me.col_sx, Me.dataGridViewTextBoxColumn3, Me.Column15, Me.Column6, Me.Column7, _
				Me.Column8, Me.Column20, Me.ngay_ve, Me.tinh_trang_thanh_toan})
			Me.grv_dieuxe.Dock = System.Windows.Forms.DockStyle.Fill
			Me.grv_dieuxe.Location = New System.Drawing.Point(3, 16)
			Me.grv_dieuxe.Name = "grv_dieuxe"
			Me.grv_dieuxe.Size = New System.Drawing.Size(697, 138)
			Me.grv_dieuxe.TabIndex = 11
			AddHandler Me.grv_dieuxe.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_dieuxe_CellClick)
			' 
			' dataGridViewTextBoxColumn1
			' 
			Me.dataGridViewTextBoxColumn1.DataPropertyName = "ma_dieu_xe"
			Me.dataGridViewTextBoxColumn1.HeaderText = "Mã Điều Xe"
			Me.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"
			Me.dataGridViewTextBoxColumn1.Width = 90
			' 
			' col_sx
			' 
			Me.col_sx.DataPropertyName = "ma_so_xe"
			Me.col_sx.HeaderText = "Số Xe"
			Me.col_sx.Name = "col_sx"
			Me.col_sx.Width = 90
			' 
			' dataGridViewTextBoxColumn3
			' 
			Me.dataGridViewTextBoxColumn3.DataPropertyName = "ma_khach_hang"
			Me.dataGridViewTextBoxColumn3.HeaderText = "Mã Khách Hàng"
			Me.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3"
			Me.dataGridViewTextBoxColumn3.Visible = False
			Me.dataGridViewTextBoxColumn3.Width = 90
			' 
			' Column15
			' 
			Me.Column15.DataPropertyName = "ten_khach_hang"
			Me.Column15.HeaderText = "Tên khách hàng"
			Me.Column15.Name = "Column15"
			' 
			' Column6
			' 
			Me.Column6.DataPropertyName = "noi_nhan"
			Me.Column6.HeaderText = "Nơi Nhận"
			Me.Column6.Name = "Column6"
			Me.Column6.Width = 90
			' 
			' Column7
			' 
			Me.Column7.DataPropertyName = "noi_giao"
			Me.Column7.HeaderText = "Nơi Giao"
			Me.Column7.Name = "Column7"
			Me.Column7.Width = 90
			' 
			' Column8
			' 
			Me.Column8.DataPropertyName = "so_tan"
			Me.Column8.HeaderText = "Số tấn"
			Me.Column8.Name = "Column8"
			Me.Column8.Width = 90
			' 
			' Column20
			' 
			Me.Column20.DataPropertyName = "ngay_dieu_xe"
			Me.Column20.HeaderText = "Ngày điều xe"
			Me.Column20.Name = "Column20"
			' 
			' ngay_ve
			' 
			Me.ngay_ve.DataPropertyName = "ngay_ve"
			Me.ngay_ve.HeaderText = "Ngày Về"
			Me.ngay_ve.Name = "ngay_ve"
			' 
			' tinh_trang_thanh_toan
			' 
			Me.tinh_trang_thanh_toan.DataPropertyName = "tinh_trang_thanh_toan"
			Me.tinh_trang_thanh_toan.HeaderText = "Tình Trạng Thanh Toán"
			Me.tinh_trang_thanh_toan.Name = "tinh_trang_thanh_toan"
			' 
			' data_ngaydieuxe
			' 
			Me.data_ngaydieuxe.Location = New System.Drawing.Point(105, 52)
			Me.data_ngaydieuxe.Name = "data_ngaydieuxe"
			Me.data_ngaydieuxe.Size = New System.Drawing.Size(200, 20)
			Me.data_ngaydieuxe.TabIndex = 13
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.grv_dieuxe)
			Me.groupBox3.Location = New System.Drawing.Point(15, 419)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(703, 157)
			Me.groupBox3.TabIndex = 36
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Điều Xe"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(759, 437)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(92, 13)
			Me.label10.TabIndex = 45
			Me.label10.Text = "Nhập Mã Điều Xe"
			' 
			' cbb_soxe
			' 
			Me.cbb_soxe.DisplayMember = "ma_so_xe"
			Me.cbb_soxe.FormattingEnabled = True
			Me.cbb_soxe.Location = New System.Drawing.Point(85, 241)
			Me.cbb_soxe.Name = "cbb_soxe"
			Me.cbb_soxe.Size = New System.Drawing.Size(108, 21)
			Me.cbb_soxe.TabIndex = 44
			Me.cbb_soxe.ValueMember = "ma_so_xe"
			AddHandler Me.cbb_soxe.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbb_soxe_SelectedIndexChanged)
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(15, 242)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(64, 13)
			Me.label8.TabIndex = 43
			Me.label8.Text = "Chọn Số Xe"
			AddHandler Me.label8.Click, New System.EventHandler(AddressOf Me.label8_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.cbtinhtrangthanhtoan)
			Me.groupBox1.Controls.Add(Me.label9)
			Me.groupBox1.Controls.Add(Me.dtpngayve)
			Me.groupBox1.Controls.Add(Me.label5)
			Me.groupBox1.Controls.Add(Me.data_ngaydieuxe)
			Me.groupBox1.Controls.Add(Me.label7)
			Me.groupBox1.Controls.Add(Me.txt_sotan)
			Me.groupBox1.Controls.Add(Me.txt_noigiao)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label6)
			Me.groupBox1.Controls.Add(Me.txt_noinhan)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Location = New System.Drawing.Point(429, 173)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(610, 104)
			Me.groupBox1.TabIndex = 41
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Thông Tin Chuyến Hàng"
			' 
			' cbtinhtrangthanhtoan
			' 
			Me.cbtinhtrangthanhtoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbtinhtrangthanhtoan.FormattingEnabled = True
			Me.cbtinhtrangthanhtoan.Location = New System.Drawing.Point(341, 77)
			Me.cbtinhtrangthanhtoan.Name = "cbtinhtrangthanhtoan"
			Me.cbtinhtrangthanhtoan.Size = New System.Drawing.Size(238, 21)
			Me.cbtinhtrangthanhtoan.TabIndex = 17
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(311, 52)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(127, 13)
			Me.label9.TabIndex = 16
			Me.label9.Text = "Tình Trạng Thanh Toán :"
			' 
			' dtpngayve
			' 
			Me.dtpngayve.Location = New System.Drawing.Point(105, 80)
			Me.dtpngayve.Name = "dtpngayve"
			Me.dtpngayve.Size = New System.Drawing.Size(200, 20)
			Me.dtpngayve.TabIndex = 15
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(38, 80)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(54, 13)
			Me.label5.TabIndex = 14
			Me.label5.Text = "Ngày Về :"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(6, 52)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(86, 13)
			Me.label7.TabIndex = 12
			Me.label7.Text = "Ngày chở hàng :"
			' 
			' txt_sotan
			' 
			Me.txt_sotan.Location = New System.Drawing.Point(105, 22)
			Me.txt_sotan.Name = "txt_sotan"
			Me.txt_sotan.Size = New System.Drawing.Size(80, 20)
			Me.txt_sotan.TabIndex = 4
			' 
			' txt_noigiao
			' 
			Me.txt_noigiao.Location = New System.Drawing.Point(481, 19)
			Me.txt_noigiao.Name = "txt_noigiao"
			Me.txt_noigiao.Size = New System.Drawing.Size(123, 20)
			Me.txt_noigiao.TabIndex = 3
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(428, 22)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(46, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Nơi giao"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(48, 25)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(44, 13)
			Me.label6.TabIndex = 11
			Me.label6.Text = "Số tấn :"
			' 
			' txt_noinhan
			' 
			Me.txt_noinhan.Location = New System.Drawing.Point(279, 19)
			Me.txt_noinhan.Name = "txt_noinhan"
			Me.txt_noinhan.Size = New System.Drawing.Size(134, 20)
			Me.txt_noinhan.TabIndex = 5
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(218, 22)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(50, 13)
			Me.label3.TabIndex = 4
			Me.label3.Text = "Nơi nhận"
			' 
			' cbb_khachhang
			' 
			Me.cbb_khachhang.FormattingEnabled = True
			Me.cbb_khachhang.Location = New System.Drawing.Point(86, 9)
			Me.cbb_khachhang.Name = "cbb_khachhang"
			Me.cbb_khachhang.Size = New System.Drawing.Size(310, 21)
			Me.cbb_khachhang.TabIndex = 7
			AddHandler Me.cbb_khachhang.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbb_khachhang_SelectedIndexChanged)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(15, 9)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(65, 13)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Khách hàng"
			' 
			' groupBox4
			' 
			Me.groupBox4.Controls.Add(Me.grv_NV)
			Me.groupBox4.Location = New System.Drawing.Point(15, 276)
			Me.groupBox4.Name = "groupBox4"
			Me.groupBox4.Size = New System.Drawing.Size(1025, 132)
			Me.groupBox4.TabIndex = 48
			Me.groupBox4.TabStop = False
			Me.groupBox4.Text = "Thông tin nhân viên"
			AddHandler Me.groupBox4.Enter, New System.EventHandler(AddressOf Me.groupBox4_Enter)
			' 
			' grv_NV
			' 
			Me.grv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_NV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewTextBoxColumn4, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, _
				Me.Column14, Me.dataGridViewTextBoxColumn5, Me.dataGridViewTextBoxColumn6})
			Me.grv_NV.Dock = System.Windows.Forms.DockStyle.Fill
			Me.grv_NV.Location = New System.Drawing.Point(3, 16)
			Me.grv_NV.Name = "grv_NV"
			Me.grv_NV.Size = New System.Drawing.Size(1019, 113)
			Me.grv_NV.TabIndex = 10
			' 
			' dataGridViewTextBoxColumn4
			' 
			Me.dataGridViewTextBoxColumn4.DataPropertyName = "ma_nhan_vien"
			Me.dataGridViewTextBoxColumn4.HeaderText = "Mã nhân viên"
			Me.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4"
			' 
			' Column9
			' 
			Me.Column9.DataPropertyName = "ten_nhan_vien"
			Me.Column9.HeaderText = "Tên nhân viên"
			Me.Column9.Name = "Column9"
			' 
			' Column10
			' 
			Me.Column10.DataPropertyName = "ma_so_xe"
			Me.Column10.HeaderText = "Số xe"
			Me.Column10.Name = "Column10"
			' 
			' Column11
			' 
			Me.Column11.DataPropertyName = "cmnd"
			Me.Column11.HeaderText = "CMND"
			Me.Column11.Name = "Column11"
			' 
			' Column12
			' 
			Me.Column12.DataPropertyName = "dia_chi"
			Me.Column12.HeaderText = "Địa chỉ"
			Me.Column12.Name = "Column12"
			' 
			' Column13
			' 
			Me.Column13.DataPropertyName = "dien_thoai"
			Me.Column13.HeaderText = "Điện thoại"
			Me.Column13.Name = "Column13"
			' 
			' Column14
			' 
			Me.Column14.DataPropertyName = "nam_sinh"
			Me.Column14.HeaderText = "Năm sinh"
			Me.Column14.Name = "Column14"
			' 
			' dataGridViewTextBoxColumn5
			' 
			Me.dataGridViewTextBoxColumn5.DataPropertyName = "chucvu"
			Me.dataGridViewTextBoxColumn5.HeaderText = "Chức vụ"
			Me.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5"
			' 
			' dataGridViewTextBoxColumn6
			' 
			Me.dataGridViewTextBoxColumn6.DataPropertyName = "ngay_tao"
			Me.dataGridViewTextBoxColumn6.HeaderText = "Ngày tạo"
			Me.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6"
			Me.dataGridViewTextBoxColumn6.Width = 190
			' 
			' btn_thoat
			' 
			Me.btn_thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_thoat.Location = New System.Drawing.Point(957, 524)
			Me.btn_thoat.Name = "btn_thoat"
			Me.btn_thoat.Size = New System.Drawing.Size(75, 27)
			Me.btn_thoat.TabIndex = 25
			Me.btn_thoat.Text = "Thoát"
			Me.btn_thoat.UseVisualStyleBackColor = True
			AddHandler Me.btn_thoat.Click, New System.EventHandler(AddressOf Me.btn_thoat_Click)
			' 
			' btn_them
			' 
			Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_them.Location = New System.Drawing.Point(767, 476)
			Me.btn_them.Name = "btn_them"
			Me.btn_them.Size = New System.Drawing.Size(75, 23)
			Me.btn_them.TabIndex = 24
			Me.btn_them.Text = "Thêm"
			Me.btn_them.UseVisualStyleBackColor = True
			AddHandler Me.btn_them.Click, New System.EventHandler(AddressOf Me.btn_them_Click)
			' 
			' btn_sua
			' 
			Me.btn_sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_sua.Location = New System.Drawing.Point(767, 524)
			Me.btn_sua.Name = "btn_sua"
			Me.btn_sua.Size = New System.Drawing.Size(75, 27)
			Me.btn_sua.TabIndex = 23
			Me.btn_sua.Text = "Sửa"
			Me.btn_sua.UseVisualStyleBackColor = True
			AddHandler Me.btn_sua.Click, New System.EventHandler(AddressOf Me.btn_sua_Click_1)
			' 
			' btn_xoa
			' 
			Me.btn_xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_xoa.Location = New System.Drawing.Point(858, 524)
			Me.btn_xoa.Name = "btn_xoa"
			Me.btn_xoa.Size = New System.Drawing.Size(75, 27)
			Me.btn_xoa.TabIndex = 22
			Me.btn_xoa.Text = "Xóa"
			Me.btn_xoa.UseVisualStyleBackColor = True
			AddHandler Me.btn_xoa.Click, New System.EventHandler(AddressOf Me.btn_xoa_Click)
			' 
			' btn_luu
			' 
			Me.btn_luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_luu.Location = New System.Drawing.Point(858, 476)
			Me.btn_luu.Name = "btn_luu"
			Me.btn_luu.Size = New System.Drawing.Size(75, 23)
			Me.btn_luu.TabIndex = 21
			Me.btn_luu.Text = "Lưu"
			Me.btn_luu.UseVisualStyleBackColor = True
			AddHandler Me.btn_luu.Click, New System.EventHandler(AddressOf Me.btn_luu_Click)
			' 
			' grv_TTxe
			' 
			Me.grv_TTxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_TTxe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.coltrongluong, Me.Column3, Me.Column4, Me.Column5})
			Me.grv_TTxe.Location = New System.Drawing.Point(430, 37)
			Me.grv_TTxe.Name = "grv_TTxe"
			Me.grv_TTxe.Size = New System.Drawing.Size(610, 136)
			Me.grv_TTxe.TabIndex = 10
			AddHandler Me.grv_TTxe.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_TTxe_CellClick)
			' 
			' Column1
			' 
			Me.Column1.DataPropertyName = "ma_so_xe"
			Me.Column1.HeaderText = "Số Xe"
			Me.Column1.Name = "Column1"
			' 
			' coltrongluong
			' 
			Me.coltrongluong.DataPropertyName = "trong_luong"
			Me.coltrongluong.HeaderText = "Trọng lượng"
			Me.coltrongluong.Name = "coltrongluong"
			' 
			' Column3
			' 
			Me.Column3.DataPropertyName = "ten_tinh_trang"
			Me.Column3.HeaderText = "Tình trạng xe"
			Me.Column3.Name = "Column3"
			Me.Column3.Width = 190
			' 
			' Column4
			' 
			Me.Column4.DataPropertyName = "ma_tinh_trang"
			Me.Column4.HeaderText = "Ma tình trạng"
			Me.Column4.Name = "Column4"
			Me.Column4.Visible = False
			' 
			' Column5
			' 
			Me.Column5.DataPropertyName = "loai_xe"
			Me.Column5.HeaderText = "Loại xe"
			Me.Column5.Name = "Column5"
			' 
			' grv_KH
			' 
			Me.grv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_KH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column16, Me.Column17, Me.Column18, Me.Column19})
			Me.grv_KH.Location = New System.Drawing.Point(18, 36)
			Me.grv_KH.Name = "grv_KH"
			Me.grv_KH.Size = New System.Drawing.Size(378, 195)
			Me.grv_KH.TabIndex = 49
			' 
			' Column16
			' 
			Me.Column16.DataPropertyName = "ten_khach_hang"
			Me.Column16.HeaderText = "Tên khách hàng"
			Me.Column16.Name = "Column16"
			' 
			' Column17
			' 
			Me.Column17.DataPropertyName = "ma_khach_hang"
			Me.Column17.HeaderText = "Mã khách hàng"
			Me.Column17.Name = "Column17"
			Me.Column17.Visible = False
			' 
			' Column18
			' 
			Me.Column18.DataPropertyName = "ma_hop_dong"
			Me.Column18.HeaderText = "Mã hợp đồng"
			Me.Column18.Name = "Column18"
			' 
			' Column19
			' 
			Me.Column19.DataPropertyName = "loaihanghoa"
			Me.Column19.HeaderText = "Loại hàng hóa"
			Me.Column19.Name = "Column19"
			' 
			' txt_trongluongxe
			' 
			Me.txt_trongluongxe.Location = New System.Drawing.Point(293, 237)
			Me.txt_trongluongxe.Name = "txt_trongluongxe"
			Me.txt_trongluongxe.Size = New System.Drawing.Size(103, 20)
			Me.txt_trongluongxe.TabIndex = 14
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(199, 244)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(78, 13)
			Me.label1.TabIndex = 15
			Me.label1.Text = "Trọng lượng xe"
			' 
			' label
			' 
			Me.label.AutoSize = True
			Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label.Location = New System.Drawing.Point(446, 3)
			Me.label.Name = "label"
			Me.label.Size = New System.Drawing.Size(117, 31)
			Me.label.TabIndex = 50
			Me.label.Text = "Điều Xe"
			AddHandler Me.label.Click, New System.EventHandler(AddressOf Me.label5_Click)
			' 
			' frmDieuXe
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1050, 588)
			Me.Controls.Add(Me.label)
			Me.Controls.Add(Me.txt_trongluongxe)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.grv_KH)
			Me.Controls.Add(Me.grv_TTxe)
			Me.Controls.Add(Me.btn_thoat)
			Me.Controls.Add(Me.groupBox4)
			Me.Controls.Add(Me.btn_them)
			Me.Controls.Add(Me.txt_madieuxe)
			Me.Controls.Add(Me.btn_sua)
			Me.Controls.Add(Me.btn_xoa)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.btn_luu)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.cbb_khachhang)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.cbb_soxe)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "frmDieuXe"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "frmDieuXe"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmDieuXe_Load)
			DirectCast(Me.grv_dieuxe, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox4.ResumeLayout(False)
			DirectCast(Me.grv_NV, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.grv_TTxe, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.grv_KH, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private txt_madieuxe As System.Windows.Forms.TextBox
		Private grv_dieuxe As System.Windows.Forms.DataGridView
		Private data_ngaydieuxe As System.Windows.Forms.DateTimePicker
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private label10 As System.Windows.Forms.Label
		Private cbb_soxe As System.Windows.Forms.ComboBox
		Private label8 As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label7 As System.Windows.Forms.Label
		Private txt_sotan As System.Windows.Forms.TextBox
		Private txt_noigiao As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private txt_noinhan As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private cbb_khachhang As System.Windows.Forms.ComboBox
		Private label4 As System.Windows.Forms.Label
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private grv_NV As System.Windows.Forms.DataGridView
		Private btn_thoat As System.Windows.Forms.Button
		Private btn_them As System.Windows.Forms.Button
		Private btn_sua As System.Windows.Forms.Button
		Private btn_xoa As System.Windows.Forms.Button
		Private btn_luu As System.Windows.Forms.Button
		Private dataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private dataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private dataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private grv_TTxe As System.Windows.Forms.DataGridView
		Private grv_KH As System.Windows.Forms.DataGridView
		Private Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private txt_trongluongxe As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private coltrongluong As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private label5 As System.Windows.Forms.Label
		Private dtpngayve As System.Windows.Forms.DateTimePicker
		Private label9 As System.Windows.Forms.Label
		Private cbtinhtrangthanhtoan As System.Windows.Forms.ComboBox
		Private dataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private col_sx As System.Windows.Forms.DataGridViewTextBoxColumn
		Private dataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private ngay_ve As System.Windows.Forms.DataGridViewTextBoxColumn
		Private tinh_trang_thanh_toan As System.Windows.Forms.DataGridViewTextBoxColumn
		Private label As System.Windows.Forms.Label

	End Class
End Namespace
