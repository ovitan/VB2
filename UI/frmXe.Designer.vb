Namespace UI
	Partial Class frmXe
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
			Me.txt_ma_so_xe = New System.Windows.Forms.TextBox()
			Me.txt_loai_xe = New System.Windows.Forms.TextBox()
			Me.txt_trong_luong = New System.Windows.Forms.TextBox()
			Me.txt_nhan_hieu = New System.Windows.Forms.TextBox()
			Me.cbb_tinh_trang = New System.Windows.Forms.ComboBox()
			Me.grv_xe = New System.Windows.Forms.DataGridView()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btn_them = New System.Windows.Forms.Button()
			Me.btn_sua = New System.Windows.Forms.Button()
			Me.btn_xoa = New System.Windows.Forms.Button()
			Me.btn_luu = New System.Windows.Forms.Button()
			Me.btn_thoat = New System.Windows.Forms.Button()
			DirectCast(Me.grv_xe, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(42, 17)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(50, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Mã số xe"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(545, 13)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(41, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Loại xe"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(287, 13)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(64, 13)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Trọng lượng"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(36, 79)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(56, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Nhãn hiệu"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(359, 83)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(55, 13)
			Me.label5.TabIndex = 4
			Me.label5.Text = "Tình trạng"
			' 
			' txt_ma_so_xe
			' 
			Me.txt_ma_so_xe.Location = New System.Drawing.Point(117, 10)
			Me.txt_ma_so_xe.Name = "txt_ma_so_xe"
			Me.txt_ma_so_xe.Size = New System.Drawing.Size(140, 20)
			Me.txt_ma_so_xe.TabIndex = 5
			' 
			' txt_loai_xe
			' 
			Me.txt_loai_xe.Location = New System.Drawing.Point(623, 10)
			Me.txt_loai_xe.Name = "txt_loai_xe"
			Me.txt_loai_xe.Size = New System.Drawing.Size(139, 20)
			Me.txt_loai_xe.TabIndex = 6
			' 
			' txt_trong_luong
			' 
			Me.txt_trong_luong.Location = New System.Drawing.Point(367, 10)
			Me.txt_trong_luong.Name = "txt_trong_luong"
			Me.txt_trong_luong.Size = New System.Drawing.Size(143, 20)
			Me.txt_trong_luong.TabIndex = 7
			' 
			' txt_nhan_hieu
			' 
			Me.txt_nhan_hieu.Location = New System.Drawing.Point(117, 76)
			Me.txt_nhan_hieu.Name = "txt_nhan_hieu"
			Me.txt_nhan_hieu.Size = New System.Drawing.Size(140, 20)
			Me.txt_nhan_hieu.TabIndex = 8
			' 
			' cbb_tinh_trang
			' 
			Me.cbb_tinh_trang.FormattingEnabled = True
			Me.cbb_tinh_trang.Location = New System.Drawing.Point(437, 79)
			Me.cbb_tinh_trang.Name = "cbb_tinh_trang"
			Me.cbb_tinh_trang.Size = New System.Drawing.Size(249, 21)
			Me.cbb_tinh_trang.TabIndex = 9
			' 
			' grv_xe
			' 
			Me.grv_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_xe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, _
				Me.Column7})
			Me.grv_xe.Location = New System.Drawing.Point(39, 197)
			Me.grv_xe.Name = "grv_xe"
			Me.grv_xe.Size = New System.Drawing.Size(804, 258)
			Me.grv_xe.TabIndex = 10
			AddHandler Me.grv_xe.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_xe_CellClick)
			' 
			' Column1
			' 
			Me.Column1.DataPropertyName = "ma_so_xe"
			Me.Column1.HeaderText = "Mã số xe"
			Me.Column1.Name = "Column1"
			' 
			' Column2
			' 
			Me.Column2.DataPropertyName = "trong_luong"
			Me.Column2.HeaderText = "Trọng lượng"
			Me.Column2.Name = "Column2"
			' 
			' Column3
			' 
			Me.Column3.DataPropertyName = "loai_xe"
			Me.Column3.HeaderText = "Loại xe"
			Me.Column3.Name = "Column3"
			' 
			' Column4
			' 
			Me.Column4.DataPropertyName = "nhan_hieu"
			Me.Column4.HeaderText = "Nhãn hiệu"
			Me.Column4.Name = "Column4"
			' 
			' Column5
			' 
			Me.Column5.DataPropertyName = "ten_tinh_trang"
			Me.Column5.HeaderText = "Tình trạng"
			Me.Column5.Name = "Column5"
			' 
			' Column6
			' 
			Me.Column6.DataPropertyName = "ngay_tao"
			Me.Column6.HeaderText = "Ngày tạo"
			Me.Column6.Name = "Column6"
			' 
			' Column7
			' 
			Me.Column7.DataPropertyName = "ma_tinh_trang"
			Me.Column7.HeaderText = "Mã tình trạng"
			Me.Column7.Name = "Column7"
			Me.Column7.Visible = False
			' 
			' btn_them
			' 
			Me.btn_them.Location = New System.Drawing.Point(117, 137)
			Me.btn_them.Name = "btn_them"
			Me.btn_them.Size = New System.Drawing.Size(75, 23)
			Me.btn_them.TabIndex = 11
			Me.btn_them.Text = "Thêm"
			Me.btn_them.UseVisualStyleBackColor = True
			AddHandler Me.btn_them.Click, New System.EventHandler(AddressOf Me.btn_them_Click)
			' 
			' btn_sua
			' 
			Me.btn_sua.Location = New System.Drawing.Point(252, 137)
			Me.btn_sua.Name = "btn_sua"
			Me.btn_sua.Size = New System.Drawing.Size(75, 23)
			Me.btn_sua.TabIndex = 12
			Me.btn_sua.Text = "Sửa"
			Me.btn_sua.UseVisualStyleBackColor = True
			AddHandler Me.btn_sua.Click, New System.EventHandler(AddressOf Me.btn_sua_Click)
			' 
			' btn_xoa
			' 
			Me.btn_xoa.Location = New System.Drawing.Point(391, 137)
			Me.btn_xoa.Name = "btn_xoa"
			Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
			Me.btn_xoa.TabIndex = 13
			Me.btn_xoa.Text = "Xóa"
			Me.btn_xoa.UseVisualStyleBackColor = True
			AddHandler Me.btn_xoa.Click, New System.EventHandler(AddressOf Me.btn_xoa_Click)
			' 
			' btn_luu
			' 
			Me.btn_luu.Location = New System.Drawing.Point(518, 137)
			Me.btn_luu.Name = "btn_luu"
			Me.btn_luu.Size = New System.Drawing.Size(75, 23)
			Me.btn_luu.TabIndex = 14
			Me.btn_luu.Text = "Lưu"
			Me.btn_luu.UseVisualStyleBackColor = True
			AddHandler Me.btn_luu.Click, New System.EventHandler(AddressOf Me.btn_luu_Click)
			' 
			' btn_thoat
			' 
			Me.btn_thoat.Location = New System.Drawing.Point(641, 137)
			Me.btn_thoat.Name = "btn_thoat"
			Me.btn_thoat.Size = New System.Drawing.Size(75, 23)
			Me.btn_thoat.TabIndex = 15
			Me.btn_thoat.Text = "Thoát"
			Me.btn_thoat.UseVisualStyleBackColor = True
			AddHandler Me.btn_thoat.Click, New System.EventHandler(AddressOf Me.btn_thoat_Click)
			' 
			' frmXe
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(929, 485)
			Me.Controls.Add(Me.btn_thoat)
			Me.Controls.Add(Me.btn_luu)
			Me.Controls.Add(Me.btn_xoa)
			Me.Controls.Add(Me.btn_sua)
			Me.Controls.Add(Me.btn_them)
			Me.Controls.Add(Me.grv_xe)
			Me.Controls.Add(Me.cbb_tinh_trang)
			Me.Controls.Add(Me.txt_nhan_hieu)
			Me.Controls.Add(Me.txt_trong_luong)
			Me.Controls.Add(Me.txt_loai_xe)
			Me.Controls.Add(Me.txt_ma_so_xe)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmXe"
			Me.Text = "Tình trạng"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmXe_Load)
			DirectCast(Me.grv_xe, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private txt_ma_so_xe As System.Windows.Forms.TextBox
		Private txt_loai_xe As System.Windows.Forms.TextBox
		Private txt_trong_luong As System.Windows.Forms.TextBox
		Private txt_nhan_hieu As System.Windows.Forms.TextBox
		Private cbb_tinh_trang As System.Windows.Forms.ComboBox
		Private grv_xe As System.Windows.Forms.DataGridView
		Private btn_them As System.Windows.Forms.Button
		Private btn_sua As System.Windows.Forms.Button
		Private btn_xoa As System.Windows.Forms.Button
		Private btn_luu As System.Windows.Forms.Button
		Private btn_thoat As System.Windows.Forms.Button
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace
