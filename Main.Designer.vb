Partial Class Main
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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.hệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mndangxuat = New System.Windows.Forms.ToolStripMenuItem()
		Me.mndangnhap = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnsaoluucsdl = New System.Windows.Forms.ToolStripMenuItem()
		Me.danhMụcQuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnquanlynhanvien = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnquanlykhachang = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnquanlyxe = New System.Windows.Forms.ToolStripMenuItem()
		Me.tìnhTrạngXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.dịchVụToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.nghiệpVụToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnlaphopdong = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnbaogia = New System.Windows.Forms.ToolStripMenuItem()
		Me.mndx = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnnhapbangke = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnlaphoadon = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnacongno = New System.Windows.Forms.ToolStripMenuItem()
		Me.ttmntimkiemthongtin = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnthongtinkhachhang = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnthongtinhanvien = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnthongtinxe = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnbangkevahoadon = New System.Windows.Forms.ToolStripMenuItem()
		Me.inBáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mndanhsachkhachhang = New System.Windows.Forms.ToolStripMenuItem()
		Me.mndanhsachnhanvien = New System.Windows.Forms.ToolStripMenuItem()
		Me.mndanhsachxe = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnxuathoadon = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnthongke = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnxemcongnokhachhang = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuStrip1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' menuStrip1
		' 
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hệThốngToolStripMenuItem, Me.danhMụcQuảnLýToolStripMenuItem, Me.nghiệpVụToolStripMenuItem, Me.ttmntimkiemthongtin, Me.inBáoCáoToolStripMenuItem, Me.mnthongke})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(1008, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' hệThốngToolStripMenuItem
		' 
		Me.hệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mndangxuat, Me.mndangnhap, Me.mnsaoluucsdl})
		Me.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem"
		Me.hệThốngToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
		Me.hệThốngToolStripMenuItem.Text = "Hệ Thống"
		' 
		' mndangxuat
		' 
		Me.mndangxuat.Name = "mndangxuat"
		Me.mndangxuat.Size = New System.Drawing.Size(159, 22)
		Me.mndangxuat.Text = "Đăng Xuất"
		' 
		' mndangnhap
		' 
		Me.mndangnhap.Name = "mndangnhap"
		Me.mndangnhap.Size = New System.Drawing.Size(159, 22)
		Me.mndangnhap.Text = "Đăng Nhập"
		' 
		' mnsaoluucsdl
		' 
		Me.mnsaoluucsdl.Name = "mnsaoluucsdl"
		Me.mnsaoluucsdl.Size = New System.Drawing.Size(159, 22)
		Me.mnsaoluucsdl.Text = "Sao Lưu Dữ Liệu"
		AddHandler Me.mnsaoluucsdl.Click, New System.EventHandler(AddressOf Me.mnsaoluucsdl_Click)
		' 
		' danhMụcQuảnLýToolStripMenuItem
		' 
		Me.danhMụcQuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnquanlynhanvien, Me.mnquanlykhachang, Me.mnquanlyxe, Me.tìnhTrạngXeToolStripMenuItem, Me.dịchVụToolStripMenuItem})
		Me.danhMụcQuảnLýToolStripMenuItem.Name = "danhMụcQuảnLýToolStripMenuItem"
		Me.danhMụcQuảnLýToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
		Me.danhMụcQuảnLýToolStripMenuItem.Text = "Danh Mục Quản Lý"
		' 
		' mnquanlynhanvien
		' 
		Me.mnquanlynhanvien.Name = "mnquanlynhanvien"
		Me.mnquanlynhanvien.Size = New System.Drawing.Size(143, 22)
		Me.mnquanlynhanvien.Text = "Nhân Viên"
		AddHandler Me.mnquanlynhanvien.Click, New System.EventHandler(AddressOf Me.mnquanlynhanvien_Click)
		' 
		' mnquanlykhachang
		' 
		Me.mnquanlykhachang.Name = "mnquanlykhachang"
		Me.mnquanlykhachang.Size = New System.Drawing.Size(143, 22)
		Me.mnquanlykhachang.Text = "Khách Hàng"
		AddHandler Me.mnquanlykhachang.Click, New System.EventHandler(AddressOf Me.mnquanlykhachang_Click)
		' 
		' mnquanlyxe
		' 
		Me.mnquanlyxe.Name = "mnquanlyxe"
		Me.mnquanlyxe.Size = New System.Drawing.Size(143, 22)
		Me.mnquanlyxe.Text = "Xe"
		AddHandler Me.mnquanlyxe.Click, New System.EventHandler(AddressOf Me.mnquanlyxe_Click)
		' 
		' tìnhTrạngXeToolStripMenuItem
		' 
		Me.tìnhTrạngXeToolStripMenuItem.Name = "tìnhTrạngXeToolStripMenuItem"
		Me.tìnhTrạngXeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
		Me.tìnhTrạngXeToolStripMenuItem.Text = "Tình trạng xe"
		AddHandler Me.tìnhTrạngXeToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.tìnhTrạngXeToolStripMenuItem_Click)
		' 
		' dịchVụToolStripMenuItem
		' 
		Me.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem"
		Me.dịchVụToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
		Me.dịchVụToolStripMenuItem.Text = "Dịch vụ"
		AddHandler Me.dịchVụToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.dịchVụToolStripMenuItem_Click)
		' 
		' nghiệpVụToolStripMenuItem
		' 
		Me.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnlaphopdong, Me.mnbaogia, Me.mndx, Me.mnnhapbangke, Me.mnlaphoadon, Me.mnacongno})
		Me.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem"
		Me.nghiệpVụToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
		Me.nghiệpVụToolStripMenuItem.Text = "Nghiệp Vụ"
		' 
		' mnlaphopdong
		' 
		Me.mnlaphopdong.Name = "mnlaphopdong"
		Me.mnlaphopdong.Size = New System.Drawing.Size(132, 22)
		Me.mnlaphopdong.Text = "Hợp Đồng "
		AddHandler Me.mnlaphopdong.Click, New System.EventHandler(AddressOf Me.mnlaphopdong_Click)
		' 
		' mnbaogia
		' 
		Me.mnbaogia.Name = "mnbaogia"
		Me.mnbaogia.Size = New System.Drawing.Size(132, 22)
		Me.mnbaogia.Text = "Báo Giá "
		AddHandler Me.mnbaogia.Click, New System.EventHandler(AddressOf Me.mnbaogia_Click)
		' 
		' mndx
		' 
		Me.mndx.Name = "mndx"
		Me.mndx.Size = New System.Drawing.Size(132, 22)
		Me.mndx.Text = "Điều Xe"
		AddHandler Me.mndx.Click, New System.EventHandler(AddressOf Me.mndx_Click)
		' 
		' mnnhapbangke
		' 
		Me.mnnhapbangke.Name = "mnnhapbangke"
		Me.mnnhapbangke.Size = New System.Drawing.Size(132, 22)
		Me.mnnhapbangke.Text = "Bảng Kê "
		AddHandler Me.mnnhapbangke.Click, New System.EventHandler(AddressOf Me.mnnhapbangke_Click)
		' 
		' mnlaphoadon
		' 
		Me.mnlaphoadon.Name = "mnlaphoadon"
		Me.mnlaphoadon.Size = New System.Drawing.Size(132, 22)
		Me.mnlaphoadon.Text = "Hóa Đơn"
		AddHandler Me.mnlaphoadon.Click, New System.EventHandler(AddressOf Me.mnlaphoadon_Click)
		' 
		' mnacongno
		' 
		Me.mnacongno.Name = "mnacongno"
		Me.mnacongno.Size = New System.Drawing.Size(132, 22)
		Me.mnacongno.Text = "Công Nợ "
		AddHandler Me.mnacongno.Click, New System.EventHandler(AddressOf Me.mnacongno_Click)
		' 
		' ttmntimkiemthongtin
		' 
		Me.ttmntimkiemthongtin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnthongtinkhachhang, Me.mnthongtinhanvien, Me.mnthongtinxe, Me.mnbangkevahoadon})
		Me.ttmntimkiemthongtin.Name = "ttmntimkiemthongtin"
		Me.ttmntimkiemthongtin.Size = New System.Drawing.Size(119, 20)
		Me.ttmntimkiemthongtin.Text = "Tra Cứu Thông Tin"
		' 
		' mnthongtinkhachhang
		' 
		Me.mnthongtinkhachhang.Name = "mnthongtinkhachhang"
		Me.mnthongtinkhachhang.Size = New System.Drawing.Size(143, 22)
		Me.mnthongtinkhachhang.Text = "Khách Hàng"
		' 
		' mnthongtinhanvien
		' 
		Me.mnthongtinhanvien.Name = "mnthongtinhanvien"
		Me.mnthongtinhanvien.Size = New System.Drawing.Size(143, 22)
		Me.mnthongtinhanvien.Text = "Nhân Viên"
		' 
		' mnthongtinxe
		' 
		Me.mnthongtinxe.Name = "mnthongtinxe"
		Me.mnthongtinxe.Size = New System.Drawing.Size(143, 22)
		Me.mnthongtinxe.Text = "Xe && Điều Xe"
		' 
		' mnbangkevahoadon
		' 
		Me.mnbangkevahoadon.Name = "mnbangkevahoadon"
		Me.mnbangkevahoadon.Size = New System.Drawing.Size(143, 22)
		Me.mnbangkevahoadon.Text = "Hóa Đơn"
		' 
		' inBáoCáoToolStripMenuItem
		' 
		Me.inBáoCáoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mndanhsachkhachhang, Me.mndanhsachnhanvien, Me.mndanhsachxe, Me.mnxuathoadon})
		Me.inBáoCáoToolStripMenuItem.Name = "inBáoCáoToolStripMenuItem"
		Me.inBáoCáoToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
		Me.inBáoCáoToolStripMenuItem.Text = "In  Ấn"
		' 
		' mndanhsachkhachhang
		' 
		Me.mndanhsachkhachhang.Name = "mndanhsachkhachhang"
		Me.mndanhsachkhachhang.Size = New System.Drawing.Size(159, 22)
		Me.mndanhsachkhachhang.Text = "In  Khách Hàng"
		AddHandler Me.mndanhsachkhachhang.Click, New System.EventHandler(AddressOf Me.mndanhsachkhachhang_Click)
		' 
		' mndanhsachnhanvien
		' 
		Me.mndanhsachnhanvien.Name = "mndanhsachnhanvien"
		Me.mndanhsachnhanvien.Size = New System.Drawing.Size(159, 22)
		Me.mndanhsachnhanvien.Text = "In Nhân Viên"
		Me.mndanhsachnhanvien.Visible = False
		AddHandler Me.mndanhsachnhanvien.Click, New System.EventHandler(AddressOf Me.mndanhsachnhanvien_Click)
		' 
		' mndanhsachxe
		' 
		Me.mndanhsachxe.Name = "mndanhsachxe"
		Me.mndanhsachxe.Size = New System.Drawing.Size(159, 22)
		Me.mndanhsachxe.Text = "In Danh Sách Xe"
		Me.mndanhsachxe.Visible = False
		AddHandler Me.mndanhsachxe.Click, New System.EventHandler(AddressOf Me.mndanhsachxe_Click)
		' 
		' mnxuathoadon
		' 
		Me.mnxuathoadon.Name = "mnxuathoadon"
		Me.mnxuathoadon.Size = New System.Drawing.Size(159, 22)
		Me.mnxuathoadon.Text = "In Hóa Đơn"
		Me.mnxuathoadon.Visible = False
		AddHandler Me.mnxuathoadon.Click, New System.EventHandler(AddressOf Me.mnxuathoadon_Click)
		' 
		' mnthongke
		' 
		Me.mnthongke.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnxemcongnokhachhang})
		Me.mnthongke.Name = "mnthongke"
		Me.mnthongke.Size = New System.Drawing.Size(70, 20)
		Me.mnthongke.Text = "Thống Kê"
		' 
		' mnxemcongnokhachhang
		' 
		Me.mnxemcongnokhachhang.Name = "mnxemcongnokhachhang"
		Me.mnxemcongnokhachhang.Size = New System.Drawing.Size(125, 22)
		Me.mnxemcongnokhachhang.Text = "Công Nợ "
		AddHandler Me.mnxemcongnokhachhang.Click, New System.EventHandler(AddressOf Me.mnxemcongnokhachhang_Click)
		' 
		' Main
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1008, 662)
		Me.Controls.Add(Me.menuStrip1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "Main"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "QUẢN LÝ DỊCH VỤ VẬN TẢI HÀNG HÓA"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private danhMụcQuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mnquanlynhanvien As System.Windows.Forms.ToolStripMenuItem
	Private mnquanlykhachang As System.Windows.Forms.ToolStripMenuItem
	Private mnquanlyxe As System.Windows.Forms.ToolStripMenuItem
	Private nghiệpVụToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mnlaphopdong As System.Windows.Forms.ToolStripMenuItem
	Private ttmntimkiemthongtin As System.Windows.Forms.ToolStripMenuItem
	Private mnthongtinhanvien As System.Windows.Forms.ToolStripMenuItem
	Private mnthongtinkhachhang As System.Windows.Forms.ToolStripMenuItem
	Private mnthongtinxe As System.Windows.Forms.ToolStripMenuItem
	Private inBáoCáoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mndanhsachkhachhang As System.Windows.Forms.ToolStripMenuItem
	Private mndanhsachnhanvien As System.Windows.Forms.ToolStripMenuItem
	Private mndanhsachxe As System.Windows.Forms.ToolStripMenuItem
	Private mnxuathoadon As System.Windows.Forms.ToolStripMenuItem
	Private mnthongke As System.Windows.Forms.ToolStripMenuItem
	Private mnxemcongnokhachhang As System.Windows.Forms.ToolStripMenuItem
	Private mnbaogia As System.Windows.Forms.ToolStripMenuItem
	Private mnnhapbangke As System.Windows.Forms.ToolStripMenuItem
	Private mnlaphoadon As System.Windows.Forms.ToolStripMenuItem
	Private mnacongno As System.Windows.Forms.ToolStripMenuItem
	Private mnbangkevahoadon As System.Windows.Forms.ToolStripMenuItem
	Private tìnhTrạngXeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private dịchVụToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mndx As System.Windows.Forms.ToolStripMenuItem
	Private hệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mndangxuat As System.Windows.Forms.ToolStripMenuItem
	Private mndangnhap As System.Windows.Forms.ToolStripMenuItem
	Private mnsaoluucsdl As System.Windows.Forms.ToolStripMenuItem
End Class
