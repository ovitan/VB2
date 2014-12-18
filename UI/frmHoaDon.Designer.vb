Namespace UI
	Partial Class frmHoaDon
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
			Me.cbkhachhang = New System.Windows.Forms.ComboBox()
			Me.lvhoadon = New System.Windows.Forms.ListView()
			Me.c1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c2 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c5 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c55 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c56 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c6 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cmsmenulv = New System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.mntsxoalv = New System.Windows.Forms.ToolStripMenuItem()
			Me.label3 = New System.Windows.Forms.Label()
			Me.txtmakhachhang = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.cbmahopdong = New System.Windows.Forms.ComboBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.txtmahoadon = New System.Windows.Forms.TextBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.dtvngayxuathoadon = New System.Windows.Forms.DateTimePicker()
			Me.btnthem = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.btnxoa = New System.Windows.Forms.Button()
			Me.btntaoma = New System.Windows.Forms.Button()
			Me.btntim = New System.Windows.Forms.Button()
			Me.lvchitiethoadon = New System.Windows.Forms.ListView()
			Me.columnHeader1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.columnHeader2 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.columnHeader3 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.columnHeader4 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.columnHeader5 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.columnHeader6 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.columnHeader7 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.columnHeader8 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c9 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c10 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c11 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.btncongno = New System.Windows.Forms.Button()
			Me.columnHeader9 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cmsmenulv.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(358, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(299, 24)
			Me.label1.TabIndex = 1
			Me.label1.Text = "LẬP HÓA ĐƠN VẬN CHUYỂN"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(3, 46)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(101, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Chọn Khách Hàng :"
			' 
			' cbkhachhang
			' 
			Me.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbkhachhang.FormattingEnabled = True
			Me.cbkhachhang.Location = New System.Drawing.Point(110, 41)
			Me.cbkhachhang.Name = "cbkhachhang"
			Me.cbkhachhang.Size = New System.Drawing.Size(229, 21)
			Me.cbkhachhang.TabIndex = 3
			AddHandler Me.cbkhachhang.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbkhachhang_SelectedIndexChanged)
			' 
			' lvhoadon
			' 
			Me.lvhoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1, Me.c2, Me.c5, Me.c55, Me.c56, Me.c6})
			Me.lvhoadon.ContextMenuStrip = Me.cmsmenulv
			Me.lvhoadon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lvhoadon.FullRowSelect = True
			Me.lvhoadon.Location = New System.Drawing.Point(1, 122)
			Me.lvhoadon.Name = "lvhoadon"
			Me.lvhoadon.Size = New System.Drawing.Size(1004, 200)
			Me.lvhoadon.TabIndex = 4
			Me.lvhoadon.UseCompatibleStateImageBehavior = False
			Me.lvhoadon.View = System.Windows.Forms.View.Details
			Me.lvhoadon.VirtualListSize = 1000
			AddHandler Me.lvhoadon.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lvhoadon_SelectedIndexChanged)
			' 
			' c1
			' 
			Me.c1.Text = "STT"
			Me.c1.Width = 71
			' 
			' c2
			' 
			Me.c2.Text = "Mã Hóa Đơn"
			Me.c2.Width = 110
			' 
			' c5
			' 
			Me.c5.Text = "Tổng Giá  Vận Chuyển"
			Me.c5.Width = 177
			' 
			' c55
			' 
			Me.c55.Text = "Thếu 10%"
			Me.c55.Width = 130
			' 
			' c56
			' 
			Me.c56.Text = "Tổng Cộng"
			Me.c56.Width = 154
			' 
			' c6
			' 
			Me.c6.Text = "Ngày Xuất Hóa Đơn"
			Me.c6.Width = 150
			' 
			' cmsmenulv
			' 
			Me.cmsmenulv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mntsxoalv})
			Me.cmsmenulv.Name = "cmsmenulv"
			Me.cmsmenulv.Size = New System.Drawing.Size(95, 26)
			' 
			' mntsxoalv
			' 
			Me.mntsxoalv.Name = "mntsxoalv"
			Me.mntsxoalv.Size = New System.Drawing.Size(94, 22)
			Me.mntsxoalv.Text = "Xóa"
			AddHandler Me.mntsxoalv.Click, New System.EventHandler(AddressOf Me.mntsxoalv_Click)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(345, 46)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(91, 13)
			Me.label3.TabIndex = 6
			Me.label3.Text = "Mã Khách Hàng :"
			' 
			' txtmakhachhang
			' 
			Me.txtmakhachhang.Location = New System.Drawing.Point(442, 42)
			Me.txtmakhachhang.Name = "txtmakhachhang"
			Me.txtmakhachhang.Size = New System.Drawing.Size(229, 20)
			Me.txtmakhachhang.TabIndex = 7
			AddHandler Me.txtmakhachhang.TextChanged, New System.EventHandler(AddressOf Me.txtmakhachhang_TextChanged)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(677, 44)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(80, 13)
			Me.label4.TabIndex = 8
			Me.label4.Text = "Mã Hợp Đồng :"
			' 
			' cbmahopdong
			' 
			Me.cbmahopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbmahopdong.FormattingEnabled = True
			Me.cbmahopdong.Location = New System.Drawing.Point(763, 38)
			Me.cbmahopdong.Name = "cbmahopdong"
			Me.cbmahopdong.Size = New System.Drawing.Size(229, 21)
			Me.cbmahopdong.TabIndex = 9
			AddHandler Me.cbmahopdong.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbmahopdong_SelectedIndexChanged)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(30, 70)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(74, 13)
			Me.label5.TabIndex = 10
			Me.label5.Text = "Mã Hóa Đơn :"
			' 
			' txtmahoadon
			' 
			Me.txtmahoadon.BackColor = System.Drawing.SystemColors.InactiveCaption
			Me.txtmahoadon.Location = New System.Drawing.Point(110, 68)
			Me.txtmahoadon.Name = "txtmahoadon"
			Me.txtmahoadon.Size = New System.Drawing.Size(192, 20)
			Me.txtmahoadon.TabIndex = 11
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(398, 70)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(38, 13)
			Me.label6.TabIndex = 12
			Me.label6.Text = "Ngày :"
			' 
			' dtvngayxuathoadon
			' 
			Me.dtvngayxuathoadon.Location = New System.Drawing.Point(442, 68)
			Me.dtvngayxuathoadon.Name = "dtvngayxuathoadon"
			Me.dtvngayxuathoadon.Size = New System.Drawing.Size(229, 20)
			Me.dtvngayxuathoadon.TabIndex = 13
			' 
			' btnthem
			' 
			Me.btnthem.Location = New System.Drawing.Point(110, 94)
			Me.btnthem.Name = "btnthem"
			Me.btnthem.Size = New System.Drawing.Size(67, 23)
			Me.btnthem.TabIndex = 16
			Me.btnthem.Text = "Xuất"
			Me.btnthem.UseVisualStyleBackColor = True
			AddHandler Me.btnthem.Click, New System.EventHandler(AddressOf Me.btnthem_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(930, 94)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 18
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' btnxoa
			' 
			Me.btnxoa.Location = New System.Drawing.Point(191, 94)
			Me.btnxoa.Name = "btnxoa"
			Me.btnxoa.Size = New System.Drawing.Size(67, 23)
			Me.btnxoa.TabIndex = 19
			Me.btnxoa.Text = "Xóa"
			Me.btnxoa.UseVisualStyleBackColor = True
			AddHandler Me.btnxoa.Click, New System.EventHandler(AddressOf Me.btnxoa_Click)
			' 
			' btntaoma
			' 
			Me.btntaoma.Location = New System.Drawing.Point(302, 66)
			Me.btntaoma.Name = "btntaoma"
			Me.btntaoma.Size = New System.Drawing.Size(37, 21)
			Me.btntaoma.TabIndex = 20
			Me.btntaoma.Text = "+"
			Me.btntaoma.UseVisualStyleBackColor = True
			AddHandler Me.btntaoma.Click, New System.EventHandler(AddressOf Me.btntaoma_Click)
			' 
			' btntim
			' 
			Me.btntim.Location = New System.Drawing.Point(273, 94)
			Me.btntim.Name = "btntim"
			Me.btntim.Size = New System.Drawing.Size(67, 23)
			Me.btntim.TabIndex = 23
			Me.btntim.Text = "Tìm"
			Me.btntim.UseVisualStyleBackColor = True
			AddHandler Me.btntim.Click, New System.EventHandler(AddressOf Me.btntim_Click)
			' 
			' lvchitiethoadon
			' 
			Me.lvchitiethoadon.Activation = System.Windows.Forms.ItemActivation.OneClick
			Me.lvchitiethoadon.Alignment = System.Windows.Forms.ListViewAlignment.Left
			Me.lvchitiethoadon.BackColor = System.Drawing.SystemColors.Window
			Me.lvchitiethoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader9, Me.columnHeader4, Me.columnHeader5, _
				Me.columnHeader6, Me.columnHeader7, Me.columnHeader8, Me.c9, Me.c10, Me.c11})
			Me.lvchitiethoadon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lvchitiethoadon.FullRowSelect = True
			Me.lvchitiethoadon.Location = New System.Drawing.Point(1, 321)
			Me.lvchitiethoadon.Name = "lvchitiethoadon"
			Me.lvchitiethoadon.ShowItemToolTips = True
			Me.lvchitiethoadon.Size = New System.Drawing.Size(1004, 311)
			Me.lvchitiethoadon.TabIndex = 24
			Me.lvchitiethoadon.UseCompatibleStateImageBehavior = False
			Me.lvchitiethoadon.View = System.Windows.Forms.View.Details
			Me.lvchitiethoadon.VirtualListSize = 10000
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "STT"
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = "Mã Bảng Kê"
			Me.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.columnHeader2.Width = 100
			' 
			' columnHeader3
			' 
			Me.columnHeader3.Text = "Ngày Vận Chuyển"
			Me.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.columnHeader3.Width = 117
			' 
			' columnHeader4
			' 
			Me.columnHeader4.Text = "Mã Số Xe"
			Me.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.columnHeader4.Width = 115
			' 
			' columnHeader5
			' 
			Me.columnHeader5.Text = "Nơi Nhận"
			Me.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.columnHeader5.Width = 119
			' 
			' columnHeader6
			' 
			Me.columnHeader6.Text = "Nơi Giao"
			Me.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.columnHeader6.Width = 121
			' 
			' columnHeader7
			' 
			Me.columnHeader7.Text = "Số Tấn"
			Me.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.columnHeader7.Width = 70
			' 
			' columnHeader8
			' 
			Me.columnHeader8.Text = "Đơn Giá Chuyến"
			Me.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.columnHeader8.Width = 150
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
			' btncongno
			' 
			Me.btncongno.Location = New System.Drawing.Point(442, 94)
			Me.btncongno.Name = "btncongno"
			Me.btncongno.Size = New System.Drawing.Size(229, 23)
			Me.btncongno.TabIndex = 25
			Me.btncongno.Text = "Thêm Hóa Đơn Vào Công Nợ"
			Me.btncongno.UseVisualStyleBackColor = True
			AddHandler Me.btncongno.Click, New System.EventHandler(AddressOf Me.btncongno_Click)
			' 
			' columnHeader9
			' 
			Me.columnHeader9.Text = "Mã Điều Xe"
			Me.columnHeader9.Width = 104
			' 
			' frmHoaDon
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.btncongno)
			Me.Controls.Add(Me.lvchitiethoadon)
			Me.Controls.Add(Me.btntim)
			Me.Controls.Add(Me.btntaoma)
			Me.Controls.Add(Me.btnxoa)
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btnthem)
			Me.Controls.Add(Me.dtvngayxuathoadon)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.txtmahoadon)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.cbmahopdong)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.txtmakhachhang)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.lvhoadon)
			Me.Controls.Add(Me.cbkhachhang)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "frmHoaDon"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "HÓA ĐƠN"
			Me.cmsmenulv.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private cbkhachhang As System.Windows.Forms.ComboBox
		Private lvhoadon As System.Windows.Forms.ListView
		Private label3 As System.Windows.Forms.Label
		Private txtmakhachhang As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private cbmahopdong As System.Windows.Forms.ComboBox
		Private label5 As System.Windows.Forms.Label
		Private txtmahoadon As System.Windows.Forms.TextBox
		Private label6 As System.Windows.Forms.Label
		Private dtvngayxuathoadon As System.Windows.Forms.DateTimePicker
		Private c1 As System.Windows.Forms.ColumnHeader
		Private c2 As System.Windows.Forms.ColumnHeader
		Private c5 As System.Windows.Forms.ColumnHeader
		Private c6 As System.Windows.Forms.ColumnHeader
		Private btnthem As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
		Private btnxoa As System.Windows.Forms.Button
		Private btntaoma As System.Windows.Forms.Button
		Private btntim As System.Windows.Forms.Button
		Private lvchitiethoadon As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private columnHeader3 As System.Windows.Forms.ColumnHeader
		Private columnHeader4 As System.Windows.Forms.ColumnHeader
		Private columnHeader5 As System.Windows.Forms.ColumnHeader
		Private columnHeader6 As System.Windows.Forms.ColumnHeader
		Private columnHeader7 As System.Windows.Forms.ColumnHeader
		Private columnHeader8 As System.Windows.Forms.ColumnHeader
		Private c9 As System.Windows.Forms.ColumnHeader
		Private c10 As System.Windows.Forms.ColumnHeader
		Private c11 As System.Windows.Forms.ColumnHeader
		Private cmsmenulv As System.Windows.Forms.ContextMenuStrip
		Private mntsxoalv As System.Windows.Forms.ToolStripMenuItem
		Private c55 As System.Windows.Forms.ColumnHeader
		Private c56 As System.Windows.Forms.ColumnHeader
		Private btncongno As System.Windows.Forms.Button
		Private columnHeader9 As System.Windows.Forms.ColumnHeader
	End Class
End Namespace
