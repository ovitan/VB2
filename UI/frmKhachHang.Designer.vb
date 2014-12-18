Namespace UI
	Partial Class frmKhachHang
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
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.txt_ma_khachhang = New System.Windows.Forms.TextBox()
			Me.txt_ten_khachhang = New System.Windows.Forms.TextBox()
			Me.txt_sothue = New System.Windows.Forms.TextBox()
			Me.txt_diachi = New System.Windows.Forms.TextBox()
			Me.txt_dienthoai = New System.Windows.Forms.TextBox()
			Me.txt_fax = New System.Windows.Forms.TextBox()
			Me.grv_khachhang = New System.Windows.Forms.DataGridView()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btn_them = New System.Windows.Forms.Button()
			Me.btn_xoa = New System.Windows.Forms.Button()
			Me.btn_sua = New System.Windows.Forms.Button()
			Me.btn_luu = New System.Windows.Forms.Button()
			Me.btn_thoat = New System.Windows.Forms.Button()
			Me.label7 = New System.Windows.Forms.Label()
			DirectCast(Me.grv_khachhang, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(81, 109)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(95, 16)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Mã khách hàng"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label2.Location = New System.Drawing.Point(361, 106)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(99, 16)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Tên khách hàng"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label3.Location = New System.Drawing.Point(656, 106)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(71, 16)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Mã số thuế"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label4.Location = New System.Drawing.Point(81, 139)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(48, 16)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Địa chỉ"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label5.Location = New System.Drawing.Point(361, 136)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(65, 16)
			Me.label5.TabIndex = 4
			Me.label5.Text = "Điện thoại"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label6.Location = New System.Drawing.Point(656, 139)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(29, 16)
			Me.label6.TabIndex = 5
			Me.label6.Text = "Fax"
			' 
			' txt_ma_khachhang
			' 
			Me.txt_ma_khachhang.Location = New System.Drawing.Point(185, 106)
			Me.txt_ma_khachhang.Name = "txt_ma_khachhang"
			Me.txt_ma_khachhang.Size = New System.Drawing.Size(100, 20)
			Me.txt_ma_khachhang.TabIndex = 6
			' 
			' txt_ten_khachhang
			' 
			Me.txt_ten_khachhang.Location = New System.Drawing.Point(463, 103)
			Me.txt_ten_khachhang.Name = "txt_ten_khachhang"
			Me.txt_ten_khachhang.Size = New System.Drawing.Size(135, 20)
			Me.txt_ten_khachhang.TabIndex = 7
			' 
			' txt_sothue
			' 
			Me.txt_sothue.Location = New System.Drawing.Point(737, 99)
			Me.txt_sothue.Name = "txt_sothue"
			Me.txt_sothue.Size = New System.Drawing.Size(135, 20)
			Me.txt_sothue.TabIndex = 8
			' 
			' txt_diachi
			' 
			Me.txt_diachi.Location = New System.Drawing.Point(185, 132)
			Me.txt_diachi.Name = "txt_diachi"
			Me.txt_diachi.Size = New System.Drawing.Size(100, 20)
			Me.txt_diachi.TabIndex = 9
			' 
			' txt_dienthoai
			' 
			Me.txt_dienthoai.Location = New System.Drawing.Point(463, 136)
			Me.txt_dienthoai.Name = "txt_dienthoai"
			Me.txt_dienthoai.Size = New System.Drawing.Size(135, 20)
			Me.txt_dienthoai.TabIndex = 10
			' 
			' txt_fax
			' 
			Me.txt_fax.Location = New System.Drawing.Point(737, 136)
			Me.txt_fax.Name = "txt_fax"
			Me.txt_fax.Size = New System.Drawing.Size(135, 20)
			Me.txt_fax.TabIndex = 11
			' 
			' grv_khachhang
			' 
			Me.grv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_khachhang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, _
				Me.Column7})
			Me.grv_khachhang.Location = New System.Drawing.Point(76, 242)
			Me.grv_khachhang.Name = "grv_khachhang"
			Me.grv_khachhang.Size = New System.Drawing.Size(813, 292)
			Me.grv_khachhang.TabIndex = 12
			AddHandler Me.grv_khachhang.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_khachhang_CellClick)
			' 
			' Column1
			' 
			Me.Column1.DataPropertyName = "ma_khach_hang"
			Me.Column1.HeaderText = "Mã khách hàng"
			Me.Column1.Name = "Column1"
			' 
			' Column2
			' 
			Me.Column2.DataPropertyName = "ten_khach_hang"
			Me.Column2.HeaderText = "Tên khách hàng"
			Me.Column2.Name = "Column2"
			' 
			' Column3
			' 
			Me.Column3.DataPropertyName = "ma_so_thue"
			Me.Column3.HeaderText = "Mã só thuế"
			Me.Column3.Name = "Column3"
			' 
			' Column4
			' 
			Me.Column4.DataPropertyName = "dia_chi"
			Me.Column4.HeaderText = "Địa chỉ"
			Me.Column4.Name = "Column4"
			' 
			' Column5
			' 
			Me.Column5.DataPropertyName = "dien_thoai"
			Me.Column5.HeaderText = "Điện thoại"
			Me.Column5.Name = "Column5"
			' 
			' Column6
			' 
			Me.Column6.DataPropertyName = "fax"
			Me.Column6.HeaderText = "Fax"
			Me.Column6.Name = "Column6"
			' 
			' Column7
			' 
			Me.Column7.DataPropertyName = "ngay_tao"
			Me.Column7.HeaderText = "Ngày tạo"
			Me.Column7.Name = "Column7"
			' 
			' btn_them
			' 
			Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_them.Location = New System.Drawing.Point(144, 188)
			Me.btn_them.Name = "btn_them"
			Me.btn_them.Size = New System.Drawing.Size(75, 23)
			Me.btn_them.TabIndex = 13
			Me.btn_them.Text = "Thêm"
			Me.btn_them.UseVisualStyleBackColor = True
			AddHandler Me.btn_them.Click, New System.EventHandler(AddressOf Me.btn_them_Click)
			' 
			' btn_xoa
			' 
			Me.btn_xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_xoa.Location = New System.Drawing.Point(372, 188)
			Me.btn_xoa.Name = "btn_xoa"
			Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
			Me.btn_xoa.TabIndex = 14
			Me.btn_xoa.Text = "Xóa"
			Me.btn_xoa.UseVisualStyleBackColor = True
			AddHandler Me.btn_xoa.Click, New System.EventHandler(AddressOf Me.btn_xoa_Click)
			' 
			' btn_sua
			' 
			Me.btn_sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_sua.Location = New System.Drawing.Point(483, 188)
			Me.btn_sua.Name = "btn_sua"
			Me.btn_sua.Size = New System.Drawing.Size(75, 23)
			Me.btn_sua.TabIndex = 15
			Me.btn_sua.Text = "Sửa"
			Me.btn_sua.UseVisualStyleBackColor = True
			AddHandler Me.btn_sua.Click, New System.EventHandler(AddressOf Me.btn_sua_Click)
			' 
			' btn_luu
			' 
			Me.btn_luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_luu.Location = New System.Drawing.Point(260, 188)
			Me.btn_luu.Name = "btn_luu"
			Me.btn_luu.Size = New System.Drawing.Size(75, 23)
			Me.btn_luu.TabIndex = 16
			Me.btn_luu.Text = "Lưu"
			Me.btn_luu.UseVisualStyleBackColor = True
			AddHandler Me.btn_luu.Click, New System.EventHandler(AddressOf Me.btn_luu_Click)
			' 
			' btn_thoat
			' 
			Me.btn_thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.btn_thoat.Location = New System.Drawing.Point(605, 188)
			Me.btn_thoat.Name = "btn_thoat"
			Me.btn_thoat.Size = New System.Drawing.Size(75, 23)
			Me.btn_thoat.TabIndex = 17
			Me.btn_thoat.Text = "Thoát"
			Me.btn_thoat.UseVisualStyleBackColor = True
			AddHandler Me.btn_thoat.Click, New System.EventHandler(AddressOf Me.btn_thoat_Click)
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Font = New System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label7.Location = New System.Drawing.Point(278, 26)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(341, 36)
			Me.label7.TabIndex = 18
			Me.label7.Text = "Thông Tin Khách Hàng"
			AddHandler Me.label7.Click, New System.EventHandler(AddressOf Me.label7_Click)
			' 
			' frmKhachHang
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.btn_thoat)
			Me.Controls.Add(Me.btn_luu)
			Me.Controls.Add(Me.btn_sua)
			Me.Controls.Add(Me.btn_xoa)
			Me.Controls.Add(Me.btn_them)
			Me.Controls.Add(Me.grv_khachhang)
			Me.Controls.Add(Me.txt_fax)
			Me.Controls.Add(Me.txt_dienthoai)
			Me.Controls.Add(Me.txt_diachi)
			Me.Controls.Add(Me.txt_sothue)
			Me.Controls.Add(Me.txt_ten_khachhang)
			Me.Controls.Add(Me.txt_ma_khachhang)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmKhachHang"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "THÔNG TIN KHÁCH HÀNG"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmKhachHang_Load)
			DirectCast(Me.grv_khachhang, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private txt_ma_khachhang As System.Windows.Forms.TextBox
		Private txt_ten_khachhang As System.Windows.Forms.TextBox
		Private txt_sothue As System.Windows.Forms.TextBox
		Private txt_diachi As System.Windows.Forms.TextBox
		Private txt_dienthoai As System.Windows.Forms.TextBox
		Private txt_fax As System.Windows.Forms.TextBox
		Private grv_khachhang As System.Windows.Forms.DataGridView
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private btn_them As System.Windows.Forms.Button
		Private btn_xoa As System.Windows.Forms.Button
		Private btn_sua As System.Windows.Forms.Button
		Private btn_luu As System.Windows.Forms.Button
		Private btn_thoat As System.Windows.Forms.Button
		Private label7 As System.Windows.Forms.Label
	End Class
End Namespace
