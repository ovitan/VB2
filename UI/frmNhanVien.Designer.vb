Namespace UI
	Partial Class frmNhanVien
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
			Me.txt_ma_nhan_vien = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.txt_ten_nhan_vien = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.txt_cmnd = New System.Windows.Forms.TextBox()
			Me.txt_dia_chi = New System.Windows.Forms.TextBox()
			Me.txt_dien_thoai = New System.Windows.Forms.TextBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.grv_nhan_vien = New System.Windows.Forms.DataGridView()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.col_soxe = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.cbb_chuc_vu = New System.Windows.Forms.ComboBox()
			Me.btn_luu = New System.Windows.Forms.Button()
			Me.btn_xoa = New System.Windows.Forms.Button()
			Me.btn_sua = New System.Windows.Forms.Button()
			Me.btn_them = New System.Windows.Forms.Button()
			Me.dt_nam_sinh = New System.Windows.Forms.DateTimePicker()
			Me.btn_thoat = New System.Windows.Forms.Button()
			Me.label8 = New System.Windows.Forms.Label()
			Me.cbb_masoxe = New System.Windows.Forms.ComboBox()
			Me.label9 = New System.Windows.Forms.Label()
			DirectCast(Me.grv_nhan_vien, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(28, 72)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(75, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Mã Nhân Viên"
			' 
			' txt_ma_nhan_vien
			' 
			Me.txt_ma_nhan_vien.Location = New System.Drawing.Point(118, 65)
			Me.txt_ma_nhan_vien.Name = "txt_ma_nhan_vien"
			Me.txt_ma_nhan_vien.Size = New System.Drawing.Size(100, 20)
			Me.txt_ma_nhan_vien.TabIndex = 1
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(272, 76)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(79, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Tên Nhân Viên"
			' 
			' txt_ten_nhan_vien
			' 
			Me.txt_ten_nhan_vien.Location = New System.Drawing.Point(386, 73)
			Me.txt_ten_nhan_vien.Name = "txt_ten_nhan_vien"
			Me.txt_ten_nhan_vien.Size = New System.Drawing.Size(159, 20)
			Me.txt_ten_nhan_vien.TabIndex = 3
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(27, 104)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(39, 13)
			Me.label3.TabIndex = 4
			Me.label3.Text = "CMND"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(284, 112)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(41, 13)
			Me.label4.TabIndex = 5
			Me.label4.Text = "Địa Chỉ"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(635, 76)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(59, 13)
			Me.label5.TabIndex = 6
			Me.label5.Text = "Điện Thoại"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(635, 115)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(48, 13)
			Me.label6.TabIndex = 7
			Me.label6.Text = "Chức Vụ"
			' 
			' txt_cmnd
			' 
			Me.txt_cmnd.Location = New System.Drawing.Point(118, 101)
			Me.txt_cmnd.Name = "txt_cmnd"
			Me.txt_cmnd.Size = New System.Drawing.Size(100, 20)
			Me.txt_cmnd.TabIndex = 8
			' 
			' txt_dia_chi
			' 
			Me.txt_dia_chi.Location = New System.Drawing.Point(386, 112)
			Me.txt_dia_chi.Name = "txt_dia_chi"
			Me.txt_dia_chi.Size = New System.Drawing.Size(159, 20)
			Me.txt_dia_chi.TabIndex = 9
			' 
			' txt_dien_thoai
			' 
			Me.txt_dien_thoai.Location = New System.Drawing.Point(731, 73)
			Me.txt_dien_thoai.Name = "txt_dien_thoai"
			Me.txt_dien_thoai.Size = New System.Drawing.Size(175, 20)
			Me.txt_dien_thoai.TabIndex = 10
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(28, 171)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(51, 13)
			Me.label7.TabIndex = 12
			Me.label7.Text = "Năm sinh"
			' 
			' grv_nhan_vien
			' 
			Me.grv_nhan_vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_nhan_vien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.col_soxe, Me.Column2, Me.Column3, Me.Column4, Me.Column5, _
				Me.Column6, Me.Column7, Me.Column8})
			Me.grv_nhan_vien.Location = New System.Drawing.Point(12, 209)
			Me.grv_nhan_vien.Name = "grv_nhan_vien"
			Me.grv_nhan_vien.[ReadOnly] = True
			Me.grv_nhan_vien.Size = New System.Drawing.Size(943, 223)
			Me.grv_nhan_vien.TabIndex = 14
			AddHandler Me.grv_nhan_vien.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_nhan_vien_CellClick)
			' 
			' Column1
			' 
			Me.Column1.DataPropertyName = "ma_nhan_vien"
			Me.Column1.HeaderText = "Mã Nhân Viên"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			' 
			' col_soxe
			' 
			Me.col_soxe.DataPropertyName = "ma_so_xe"
			Me.col_soxe.HeaderText = "Số xe"
			Me.col_soxe.Name = "col_soxe"
			Me.col_soxe.[ReadOnly] = True
			' 
			' Column2
			' 
			Me.Column2.DataPropertyName = "ten_nhan_vien"
			Me.Column2.HeaderText = "Tên Nhân Viên"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			' 
			' Column3
			' 
			Me.Column3.DataPropertyName = "cmnd"
			Me.Column3.HeaderText = "CMND"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			' 
			' Column4
			' 
			Me.Column4.DataPropertyName = "dia_chi"
			Me.Column4.HeaderText = "Địa chỉ"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			' 
			' Column5
			' 
			Me.Column5.DataPropertyName = "dien_thoai"
			Me.Column5.HeaderText = "Điện thoại"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			' 
			' Column6
			' 
			Me.Column6.DataPropertyName = "nam_sinh"
			Me.Column6.HeaderText = "Năm sinh"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			' 
			' Column7
			' 
			Me.Column7.DataPropertyName = "chucvu"
			Me.Column7.HeaderText = "Chức vụ"
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			' 
			' Column8
			' 
			Me.Column8.DataPropertyName = "ngay_tao"
			Me.Column8.HeaderText = "Ngày tạo"
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			' 
			' cbb_chuc_vu
			' 
			Me.cbb_chuc_vu.FormattingEnabled = True
			Me.cbb_chuc_vu.Items.AddRange(New Object() {"Tài xế", "Phụ xế"})
			Me.cbb_chuc_vu.Location = New System.Drawing.Point(731, 112)
			Me.cbb_chuc_vu.Name = "cbb_chuc_vu"
			Me.cbb_chuc_vu.Size = New System.Drawing.Size(175, 21)
			Me.cbb_chuc_vu.TabIndex = 15
			' 
			' btn_luu
			' 
			Me.btn_luu.Location = New System.Drawing.Point(437, 171)
			Me.btn_luu.Name = "btn_luu"
			Me.btn_luu.Size = New System.Drawing.Size(75, 23)
			Me.btn_luu.TabIndex = 16
			Me.btn_luu.Text = "Lưu"
			Me.btn_luu.UseVisualStyleBackColor = True
			AddHandler Me.btn_luu.Click, New System.EventHandler(AddressOf Me.btn_luu_Click)
			' 
			' btn_xoa
			' 
			Me.btn_xoa.Location = New System.Drawing.Point(620, 169)
			Me.btn_xoa.Name = "btn_xoa"
			Me.btn_xoa.Size = New System.Drawing.Size(75, 27)
			Me.btn_xoa.TabIndex = 17
			Me.btn_xoa.Text = "Xóa"
			Me.btn_xoa.UseVisualStyleBackColor = True
			AddHandler Me.btn_xoa.Click, New System.EventHandler(AddressOf Me.btn_xoa_Click)
			' 
			' btn_sua
			' 
			Me.btn_sua.Location = New System.Drawing.Point(529, 169)
			Me.btn_sua.Name = "btn_sua"
			Me.btn_sua.Size = New System.Drawing.Size(75, 27)
			Me.btn_sua.TabIndex = 18
			Me.btn_sua.Text = "Sửa"
			Me.btn_sua.UseVisualStyleBackColor = True
			AddHandler Me.btn_sua.Click, New System.EventHandler(AddressOf Me.btn_sua_Click)
			' 
			' btn_them
			' 
			Me.btn_them.Location = New System.Drawing.Point(341, 171)
			Me.btn_them.Name = "btn_them"
			Me.btn_them.Size = New System.Drawing.Size(75, 23)
			Me.btn_them.TabIndex = 19
			Me.btn_them.Text = "Thêm"
			Me.btn_them.UseVisualStyleBackColor = True
			AddHandler Me.btn_them.Click, New System.EventHandler(AddressOf Me.btn_them_Click)
			' 
			' dt_nam_sinh
			' 
			Me.dt_nam_sinh.Location = New System.Drawing.Point(118, 171)
			Me.dt_nam_sinh.Name = "dt_nam_sinh"
			Me.dt_nam_sinh.Size = New System.Drawing.Size(195, 20)
			Me.dt_nam_sinh.TabIndex = 13
			' 
			' btn_thoat
			' 
			Me.btn_thoat.Location = New System.Drawing.Point(719, 169)
			Me.btn_thoat.Name = "btn_thoat"
			Me.btn_thoat.Size = New System.Drawing.Size(75, 27)
			Me.btn_thoat.TabIndex = 20
			Me.btn_thoat.Text = "Thoát"
			Me.btn_thoat.UseVisualStyleBackColor = True
			AddHandler Me.btn_thoat.Click, New System.EventHandler(AddressOf Me.btn_thoat_Click)
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(28, 139)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(34, 13)
			Me.label8.TabIndex = 21
			Me.label8.Text = "Số xe"
			' 
			' cbb_masoxe
			' 
			Me.cbb_masoxe.FormattingEnabled = True
			Me.cbb_masoxe.Items.AddRange(New Object() {"Tài xế", "Phụ xế"})
			Me.cbb_masoxe.Location = New System.Drawing.Point(117, 136)
			Me.cbb_masoxe.Name = "cbb_masoxe"
			Me.cbb_masoxe.Size = New System.Drawing.Size(123, 21)
			Me.cbb_masoxe.TabIndex = 22
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label9.Location = New System.Drawing.Point(335, 9)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(311, 36)
			Me.label9.TabIndex = 23
			Me.label9.Text = "Thông Tin Nhân Viên"
			' 
			' frmNhanVien
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.cbb_masoxe)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.btn_thoat)
			Me.Controls.Add(Me.btn_them)
			Me.Controls.Add(Me.btn_sua)
			Me.Controls.Add(Me.btn_xoa)
			Me.Controls.Add(Me.btn_luu)
			Me.Controls.Add(Me.cbb_chuc_vu)
			Me.Controls.Add(Me.grv_nhan_vien)
			Me.Controls.Add(Me.dt_nam_sinh)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.txt_dien_thoai)
			Me.Controls.Add(Me.txt_dia_chi)
			Me.Controls.Add(Me.txt_cmnd)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.txt_ten_nhan_vien)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txt_ma_nhan_vien)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmNhanVien"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Quản Lý Nhân Viên"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmNhanVien_Load)
			DirectCast(Me.grv_nhan_vien, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txt_ma_nhan_vien As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private txt_ten_nhan_vien As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private txt_cmnd As System.Windows.Forms.TextBox
		Private txt_dia_chi As System.Windows.Forms.TextBox
		Private txt_dien_thoai As System.Windows.Forms.TextBox
		Private label7 As System.Windows.Forms.Label
		Private grv_nhan_vien As System.Windows.Forms.DataGridView
		Private cbb_chuc_vu As System.Windows.Forms.ComboBox
		Private btn_luu As System.Windows.Forms.Button
		Private btn_xoa As System.Windows.Forms.Button
		Private btn_sua As System.Windows.Forms.Button
		Private btn_them As System.Windows.Forms.Button
		Private dt_nam_sinh As System.Windows.Forms.DateTimePicker
		Private btn_thoat As System.Windows.Forms.Button
		Private label8 As System.Windows.Forms.Label
		Private cbb_masoxe As System.Windows.Forms.ComboBox
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private col_soxe As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private label9 As System.Windows.Forms.Label
	End Class
End Namespace
