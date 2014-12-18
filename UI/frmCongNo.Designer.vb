Namespace UI
	Partial Class frmCongNo
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
			Me.cbkhachhang = New System.Windows.Forms.ComboBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.txtmakhachhang = New System.Windows.Forms.TextBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.dtpngayxuathoadon = New System.Windows.Forms.DateTimePicker()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.txtmacongno = New System.Windows.Forms.TextBox()
			Me.label8 = New System.Windows.Forms.Label()
			Me.cbhoadon = New System.Windows.Forms.ComboBox()
			Me.txtsotien = New System.Windows.Forms.TextBox()
			Me.lvcongno = New System.Windows.Forms.ListView()
			Me.c1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c3 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c4 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c5 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c6 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cms1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.mnxoa = New System.Windows.Forms.ToolStripMenuItem()
			Me.btnluucongno = New System.Windows.Forms.Button()
			Me.label9 = New System.Windows.Forms.Label()
			Me.dtpngaythanhtoan = New System.Windows.Forms.DateTimePicker()
			Me.label10 = New System.Windows.Forms.Label()
			Me.txtsotienthanhtoan = New System.Windows.Forms.TextBox()
			Me.btnthemthanhtoan = New System.Windows.Forms.Button()
			Me.lvthanhtoan = New System.Windows.Forms.ListView()
			Me.cc1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cc3 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cc4 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cc5 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.cc6 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.label11 = New System.Windows.Forms.Label()
			Me.cbmahopdong = New System.Windows.Forms.ComboBox()
			Me.btntaoma = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.cms1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' cbkhachhang
			' 
			Me.cbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbkhachhang.FormattingEnabled = True
			Me.cbkhachhang.Location = New System.Drawing.Point(119, 3)
			Me.cbkhachhang.Name = "cbkhachhang"
			Me.cbkhachhang.Size = New System.Drawing.Size(248, 21)
			Me.cbkhachhang.TabIndex = 3
			AddHandler Me.cbkhachhang.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbkhachhang_SelectedIndexChanged)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(22, 38)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(91, 13)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Mã Khách Hàng :"
			' 
			' txtmakhachhang
			' 
			Me.txtmakhachhang.Location = New System.Drawing.Point(119, 32)
			Me.txtmakhachhang.MaxLength = 10
			Me.txtmakhachhang.Name = "txtmakhachhang"
			Me.txtmakhachhang.Size = New System.Drawing.Size(248, 20)
			Me.txtmakhachhang.TabIndex = 7
			AddHandler Me.txtmakhachhang.TextChanged, New System.EventHandler(AddressOf Me.txtmakhachhang_TextChanged)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(4, 174)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(109, 13)
			Me.label5.TabIndex = 8
			Me.label5.Text = "Ngày Xuất Hóa Đơn :"
			' 
			' dtpngayxuathoadon
			' 
			Me.dtpngayxuathoadon.Location = New System.Drawing.Point(119, 170)
			Me.dtpngayxuathoadon.Name = "dtpngayxuathoadon"
			Me.dtpngayxuathoadon.Size = New System.Drawing.Size(248, 20)
			Me.dtpngayxuathoadon.TabIndex = 9
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(39, 139)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(74, 13)
			Me.label6.TabIndex = 10
			Me.label6.Text = "Mã Hóa Đơn :"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(39, 106)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(73, 13)
			Me.label7.TabIndex = 12
			Me.label7.Text = "Mã Công Nợ :"
			' 
			' txtmacongno
			' 
			Me.txtmacongno.BackColor = System.Drawing.SystemColors.InactiveCaption
			Me.txtmacongno.Location = New System.Drawing.Point(119, 100)
			Me.txtmacongno.MaxLength = 10
			Me.txtmacongno.Name = "txtmacongno"
			Me.txtmacongno.Size = New System.Drawing.Size(209, 20)
			Me.txtmacongno.TabIndex = 13
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(17, 208)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(96, 13)
			Me.label8.TabIndex = 14
			Me.label8.Text = "Số Tiền Hóa Đơn :"
			' 
			' cbhoadon
			' 
			Me.cbhoadon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbhoadon.FormattingEnabled = True
			Me.cbhoadon.Location = New System.Drawing.Point(119, 133)
			Me.cbhoadon.Name = "cbhoadon"
			Me.cbhoadon.Size = New System.Drawing.Size(248, 21)
			Me.cbhoadon.TabIndex = 15
			AddHandler Me.cbhoadon.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbhoadon_SelectedIndexChanged)
			' 
			' txtsotien
			' 
			Me.txtsotien.ForeColor = System.Drawing.Color.Black
			Me.txtsotien.Location = New System.Drawing.Point(119, 203)
			Me.txtsotien.Name = "txtsotien"
			Me.txtsotien.[ReadOnly] = True
			Me.txtsotien.Size = New System.Drawing.Size(248, 20)
			Me.txtsotien.TabIndex = 16
			' 
			' lvcongno
			' 
			Me.lvcongno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1, Me.c3, Me.c4, Me.c5, Me.c6})
			Me.lvcongno.ContextMenuStrip = Me.cms1
			Me.lvcongno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lvcongno.FullRowSelect = True
			Me.lvcongno.Location = New System.Drawing.Point(371, 3)
			Me.lvcongno.MultiSelect = False
			Me.lvcongno.Name = "lvcongno"
			Me.lvcongno.Size = New System.Drawing.Size(633, 306)
			Me.lvcongno.TabIndex = 17
			Me.lvcongno.UseCompatibleStateImageBehavior = False
			Me.lvcongno.View = System.Windows.Forms.View.Details
			Me.lvcongno.VirtualListSize = 10000
			' 
			' c1
			' 
			Me.c1.Text = "STT"
			Me.c1.Width = 73
			' 
			' c3
			' 
			Me.c3.Text = "Ngày Xuất Hóa Đơn"
			Me.c3.Width = 126
			' 
			' c4
			' 
			Me.c4.Text = "Mã Hóa Đơn"
			Me.c4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.c4.Width = 155
			' 
			' c5
			' 
			Me.c5.Text = "Số Tiền Nợ"
			Me.c5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.c5.Width = 139
			' 
			' c6
			' 
			Me.c6.Text = ""
			Me.c6.Width = 133
			' 
			' cms1
			' 
			Me.cms1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnxoa})
			Me.cms1.Name = "cms1"
			Me.cms1.Size = New System.Drawing.Size(95, 26)
			' 
			' mnxoa
			' 
			Me.mnxoa.Name = "mnxoa"
			Me.mnxoa.Size = New System.Drawing.Size(94, 22)
			Me.mnxoa.Text = "Xóa"
			AddHandler Me.mnxoa.Click, New System.EventHandler(AddressOf Me.mnxoa_Click)
			' 
			' btnluucongno
			' 
			Me.btnluucongno.Location = New System.Drawing.Point(119, 237)
			Me.btnluucongno.Name = "btnluucongno"
			Me.btnluucongno.Size = New System.Drawing.Size(105, 23)
			Me.btnluucongno.TabIndex = 18
			Me.btnluucongno.Text = "Thêm Công Nợ"
			Me.btnluucongno.UseVisualStyleBackColor = True
			AddHandler Me.btnluucongno.Click, New System.EventHandler(AddressOf Me.btnluucongno_Click)
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(13, 315)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(100, 13)
			Me.label9.TabIndex = 20
			Me.label9.Text = "Ngày Thanh Toán :"
			' 
			' dtpngaythanhtoan
			' 
			Me.dtpngaythanhtoan.Enabled = False
			Me.dtpngaythanhtoan.Location = New System.Drawing.Point(119, 313)
			Me.dtpngaythanhtoan.Name = "dtpngaythanhtoan"
			Me.dtpngaythanhtoan.Size = New System.Drawing.Size(248, 20)
			Me.dtpngaythanhtoan.TabIndex = 21
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(1, 354)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(112, 13)
			Me.label10.TabIndex = 22
			Me.label10.Text = "Số Tiền Thanh Toán :"
			' 
			' txtsotienthanhtoan
			' 
			Me.txtsotienthanhtoan.Location = New System.Drawing.Point(120, 351)
			Me.txtsotienthanhtoan.Name = "txtsotienthanhtoan"
			Me.txtsotienthanhtoan.Size = New System.Drawing.Size(248, 20)
			Me.txtsotienthanhtoan.TabIndex = 23
			' 
			' btnthemthanhtoan
			' 
			Me.btnthemthanhtoan.Location = New System.Drawing.Point(118, 389)
			Me.btnthemthanhtoan.Name = "btnthemthanhtoan"
			Me.btnthemthanhtoan.Size = New System.Drawing.Size(105, 23)
			Me.btnthemthanhtoan.TabIndex = 24
			Me.btnthemthanhtoan.Text = "Thêm Thanh Toán"
			Me.btnthemthanhtoan.UseVisualStyleBackColor = True
			AddHandler Me.btnthemthanhtoan.Click, New System.EventHandler(AddressOf Me.btnthemthanhtoan_Click)
			' 
			' lvthanhtoan
			' 
			Me.lvthanhtoan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cc1, Me.cc3, Me.cc4, Me.cc5, Me.cc6})
			Me.lvthanhtoan.ContextMenuStrip = Me.cms1
			Me.lvthanhtoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lvthanhtoan.FullRowSelect = True
			Me.lvthanhtoan.Location = New System.Drawing.Point(371, 315)
			Me.lvthanhtoan.MultiSelect = False
			Me.lvthanhtoan.Name = "lvthanhtoan"
			Me.lvthanhtoan.Size = New System.Drawing.Size(633, 315)
			Me.lvthanhtoan.TabIndex = 25
			Me.lvthanhtoan.UseCompatibleStateImageBehavior = False
			Me.lvthanhtoan.View = System.Windows.Forms.View.Details
			Me.lvthanhtoan.VirtualListSize = 1000
			' 
			' cc1
			' 
			Me.cc1.Text = "STT"
			Me.cc1.Width = 75
			' 
			' cc3
			' 
			Me.cc3.Text = "Ngày Thanh Toán"
			Me.cc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.cc3.Width = 287
			' 
			' cc4
			' 
			Me.cc4.Text = "Số Tiền Thanh Toán"
			Me.cc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.cc4.Width = 139
			' 
			' cc5
			' 
			Me.cc5.Text = ""
			Me.cc5.Width = 218
			' 
			' cc6
			' 
			Me.cc6.Text = ""
			Me.cc6.Width = 0
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(250, 389)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(105, 23)
			Me.btnthoat.TabIndex = 27
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(32, 70)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(80, 13)
			Me.label11.TabIndex = 28
			Me.label11.Text = "Mã Hợp Đồng :"
			' 
			' cbmahopdong
			' 
			Me.cbmahopdong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbmahopdong.FormattingEnabled = True
			Me.cbmahopdong.Location = New System.Drawing.Point(120, 67)
			Me.cbmahopdong.Name = "cbmahopdong"
			Me.cbmahopdong.Size = New System.Drawing.Size(248, 21)
			Me.cbmahopdong.TabIndex = 29
			AddHandler Me.cbmahopdong.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbmahopdong_SelectedIndexChanged)
			' 
			' btntaoma
			' 
			Me.btntaoma.Location = New System.Drawing.Point(331, 99)
			Me.btntaoma.Name = "btntaoma"
			Me.btntaoma.Size = New System.Drawing.Size(37, 21)
			Me.btntaoma.TabIndex = 30
			Me.btntaoma.Text = "+"
			Me.btntaoma.UseVisualStyleBackColor = True
			AddHandler Me.btntaoma.Click, New System.EventHandler(AddressOf Me.btntaoma_Click)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(11, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(101, 13)
			Me.label1.TabIndex = 31
			Me.label1.Text = "Chọn Khách Hàng :"
			' 
			' frmCongNo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.btntaoma)
			Me.Controls.Add(Me.cbmahopdong)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.lvthanhtoan)
			Me.Controls.Add(Me.btnthemthanhtoan)
			Me.Controls.Add(Me.txtsotienthanhtoan)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.dtpngaythanhtoan)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.btnluucongno)
			Me.Controls.Add(Me.lvcongno)
			Me.Controls.Add(Me.txtsotien)
			Me.Controls.Add(Me.cbhoadon)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.txtmacongno)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.dtpngayxuathoadon)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.txtmakhachhang)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.cbkhachhang)
			Me.Name = "frmCongNo"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "CÔNG NỢ"
			Me.cms1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private cbkhachhang As System.Windows.Forms.ComboBox
		Private label4 As System.Windows.Forms.Label
		Private txtmakhachhang As System.Windows.Forms.TextBox
		Private label5 As System.Windows.Forms.Label
		Private dtpngayxuathoadon As System.Windows.Forms.DateTimePicker
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private txtmacongno As System.Windows.Forms.TextBox
		Private label8 As System.Windows.Forms.Label
		Private cbhoadon As System.Windows.Forms.ComboBox
		Private txtsotien As System.Windows.Forms.TextBox
		Private lvcongno As System.Windows.Forms.ListView
		Private btnluucongno As System.Windows.Forms.Button
		Private c1 As System.Windows.Forms.ColumnHeader
		Private c3 As System.Windows.Forms.ColumnHeader
		Private c4 As System.Windows.Forms.ColumnHeader
		Private c5 As System.Windows.Forms.ColumnHeader
		Private c6 As System.Windows.Forms.ColumnHeader
		Private label9 As System.Windows.Forms.Label
		Private dtpngaythanhtoan As System.Windows.Forms.DateTimePicker
		Private label10 As System.Windows.Forms.Label
		Private txtsotienthanhtoan As System.Windows.Forms.TextBox
		Private btnthemthanhtoan As System.Windows.Forms.Button
		Private lvthanhtoan As System.Windows.Forms.ListView
		Private cc1 As System.Windows.Forms.ColumnHeader
		Private cc3 As System.Windows.Forms.ColumnHeader
		Private cc4 As System.Windows.Forms.ColumnHeader
		Private cc5 As System.Windows.Forms.ColumnHeader
		Private btnthoat As System.Windows.Forms.Button
		Private label11 As System.Windows.Forms.Label
		Private cbmahopdong As System.Windows.Forms.ComboBox
		Private btntaoma As System.Windows.Forms.Button
		Private cms1 As System.Windows.Forms.ContextMenuStrip
		Private mnxoa As System.Windows.Forms.ToolStripMenuItem
		Private cc6 As System.Windows.Forms.ColumnHeader
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace
