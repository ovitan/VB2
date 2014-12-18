Namespace UI
	Partial Class frmDichVu
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
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.txt_dongiachuyen = New System.Windows.Forms.TextBox()
			Me.label9 = New System.Windows.Forms.Label()
			Me.txt_dongiatan = New System.Windows.Forms.TextBox()
			Me.txt_khuvuc = New System.Windows.Forms.TextBox()
			Me.txt_phanvung = New System.Windows.Forms.TextBox()
			Me.btn_thoat = New System.Windows.Forms.Button()
			Me.btn_luu = New System.Windows.Forms.Button()
			Me.btn_xoa = New System.Windows.Forms.Button()
			Me.btn_sua = New System.Windows.Forms.Button()
			Me.btn_them = New System.Windows.Forms.Button()
			Me.grv_dichvu = New System.Windows.Forms.DataGridView()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			DirectCast(Me.grv_dichvu, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(241, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(318, 23)
			Me.label1.TabIndex = 1
			Me.label1.Text = "BÁO GIÁ DỊCH VỤ VẬN CHUYỂN"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(60, 64)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(54, 13)
			Me.label5.TabIndex = 8
			Me.label5.Text = "Khu Vực :"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(374, 64)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(66, 13)
			Me.label6.TabIndex = 11
			Me.label6.Text = "Phân Vùng :"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(355, 107)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(85, 13)
			Me.label8.TabIndex = 15
			Me.label8.Text = "Đơn Giá Chuyến"
			' 
			' txt_dongiachuyen
			' 
			Me.txt_dongiachuyen.Location = New System.Drawing.Point(446, 101)
			Me.txt_dongiachuyen.MaxLength = 100
			Me.txt_dongiachuyen.Name = "txt_dongiachuyen"
			Me.txt_dongiachuyen.Size = New System.Drawing.Size(200, 20)
			Me.txt_dongiachuyen.TabIndex = 16
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(46, 111)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(68, 13)
			Me.label9.TabIndex = 17
			Me.label9.Text = "Đơn Giá Tấn"
			' 
			' txt_dongiatan
			' 
			Me.txt_dongiatan.Location = New System.Drawing.Point(120, 105)
			Me.txt_dongiatan.MaxLength = 100
			Me.txt_dongiatan.Name = "txt_dongiatan"
			Me.txt_dongiatan.Size = New System.Drawing.Size(200, 20)
			Me.txt_dongiatan.TabIndex = 18
			' 
			' txt_khuvuc
			' 
			Me.txt_khuvuc.Location = New System.Drawing.Point(120, 61)
			Me.txt_khuvuc.MaxLength = 100
			Me.txt_khuvuc.Name = "txt_khuvuc"
			Me.txt_khuvuc.Size = New System.Drawing.Size(200, 20)
			Me.txt_khuvuc.TabIndex = 24
			' 
			' txt_phanvung
			' 
			Me.txt_phanvung.Location = New System.Drawing.Point(446, 61)
			Me.txt_phanvung.MaxLength = 100
			Me.txt_phanvung.Name = "txt_phanvung"
			Me.txt_phanvung.Size = New System.Drawing.Size(200, 20)
			Me.txt_phanvung.TabIndex = 25
			' 
			' btn_thoat
			' 
			Me.btn_thoat.Location = New System.Drawing.Point(591, 163)
			Me.btn_thoat.Name = "btn_thoat"
			Me.btn_thoat.Size = New System.Drawing.Size(75, 23)
			Me.btn_thoat.TabIndex = 30
			Me.btn_thoat.Text = "Thoát"
			Me.btn_thoat.UseVisualStyleBackColor = True
			AddHandler Me.btn_thoat.Click, New System.EventHandler(AddressOf Me.btn_thoat_Click)
			' 
			' btn_luu
			' 
			Me.btn_luu.Location = New System.Drawing.Point(461, 163)
			Me.btn_luu.Name = "btn_luu"
			Me.btn_luu.Size = New System.Drawing.Size(75, 23)
			Me.btn_luu.TabIndex = 29
			Me.btn_luu.Text = "Lưu"
			Me.btn_luu.UseVisualStyleBackColor = True
			AddHandler Me.btn_luu.Click, New System.EventHandler(AddressOf Me.btn_luu_Click)
			' 
			' btn_xoa
			' 
			Me.btn_xoa.Location = New System.Drawing.Point(335, 163)
			Me.btn_xoa.Name = "btn_xoa"
			Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
			Me.btn_xoa.TabIndex = 28
			Me.btn_xoa.Text = "Xóa"
			Me.btn_xoa.UseVisualStyleBackColor = True
			AddHandler Me.btn_xoa.Click, New System.EventHandler(AddressOf Me.btn_xoa_Click)
			' 
			' btn_sua
			' 
			Me.btn_sua.Location = New System.Drawing.Point(213, 163)
			Me.btn_sua.Name = "btn_sua"
			Me.btn_sua.Size = New System.Drawing.Size(75, 23)
			Me.btn_sua.TabIndex = 27
			Me.btn_sua.Text = "Sửa"
			Me.btn_sua.UseVisualStyleBackColor = True
			AddHandler Me.btn_sua.Click, New System.EventHandler(AddressOf Me.btn_sua_Click)
			' 
			' btn_them
			' 
			Me.btn_them.Location = New System.Drawing.Point(94, 163)
			Me.btn_them.Name = "btn_them"
			Me.btn_them.Size = New System.Drawing.Size(75, 23)
			Me.btn_them.TabIndex = 26
			Me.btn_them.Text = "Thêm"
			Me.btn_them.UseVisualStyleBackColor = True
			AddHandler Me.btn_them.Click, New System.EventHandler(AddressOf Me.btn_them_Click)
			' 
			' grv_dichvu
			' 
			Me.grv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_dichvu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3})
			Me.grv_dichvu.Location = New System.Drawing.Point(141, 225)
			Me.grv_dichvu.Name = "grv_dichvu"
			Me.grv_dichvu.Size = New System.Drawing.Size(453, 206)
			Me.grv_dichvu.TabIndex = 31
			AddHandler Me.grv_dichvu.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_dichvu_CellClick)
			AddHandler Me.grv_dichvu.CellContentClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_dichvu_CellContentClick)
			' 
			' Column1
			' 
			Me.Column1.DataPropertyName = "khu_vuc"
			Me.Column1.HeaderText = "Khu vực"
			Me.Column1.Name = "Column1"
			' 
			' Column2
			' 
			Me.Column2.DataPropertyName = "phan_vung"
			Me.Column2.HeaderText = "Phân vùng"
			Me.Column2.Name = "Column2"
			' 
			' Column4
			' 
			Me.Column4.DataPropertyName = "don_gia_tan"
			Me.Column4.HeaderText = "Đơn giá tấn"
			Me.Column4.Name = "Column4"
			' 
			' Column3
			' 
			Me.Column3.DataPropertyName = "don_gia_chuyen"
			Me.Column3.HeaderText = "Đơn giá chuyến"
			Me.Column3.Name = "Column3"
			' 
			' frmDichVu
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(779, 489)
			Me.Controls.Add(Me.grv_dichvu)
			Me.Controls.Add(Me.btn_thoat)
			Me.Controls.Add(Me.btn_luu)
			Me.Controls.Add(Me.btn_xoa)
			Me.Controls.Add(Me.btn_sua)
			Me.Controls.Add(Me.btn_them)
			Me.Controls.Add(Me.txt_phanvung)
			Me.Controls.Add(Me.txt_khuvuc)
			Me.Controls.Add(Me.txt_dongiatan)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.txt_dongiachuyen)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmDichVu"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "GIÁ DỊCH VỤ"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmDichVu_Load)
			DirectCast(Me.grv_dichvu, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private txt_dongiachuyen As System.Windows.Forms.TextBox
		Private label9 As System.Windows.Forms.Label
		Private txt_dongiatan As System.Windows.Forms.TextBox
		Private txt_khuvuc As System.Windows.Forms.TextBox
		Private txt_phanvung As System.Windows.Forms.TextBox
		Private btn_thoat As System.Windows.Forms.Button
		Private btn_luu As System.Windows.Forms.Button
		Private btn_xoa As System.Windows.Forms.Button
		Private btn_sua As System.Windows.Forms.Button
		Private btn_them As System.Windows.Forms.Button
		Private grv_dichvu As System.Windows.Forms.DataGridView
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace
