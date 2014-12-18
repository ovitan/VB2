Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.BLL
Imports QLDVVTHH.DTO
Imports QLDVVTHH.UC_TIMKIEM

Namespace UI
	Public Partial Class frmTimKetQua
		Inherits Form
		Public _truyvan As String = ""
		Public _key_name As String = ""
		Public _Key_id As String = ""
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub _Load_Ket_Qua_Tim_Kiem(truyvan As String)
			Select Case truyvan
				Case "nhanvien"
					_NhanVien()
					Exit Select
				Case "khachhang"
					_KhachHang()
					Exit Select
				Case "xe"
					_Xe()
					Exit Select
				Case "hoadon"
					_HoaDon()
					Exit Select
				Case "hopdong"
					_HopDong()
					Exit Select
				Case Else
					Exit Select
			End Select
		End Sub
		Private Sub frmTimKetQua_Load(sender As Object, e As EventArgs)
			_Load_Ket_Qua_Tim_Kiem(_truyvan)
		End Sub
		Private Sub _NhanVien()
			lvthongtintimkiem.Items.Clear()

			lvthongtintimkiem.Columns.Add("STT", 60)
			lvthongtintimkiem.Columns.Add("Mã Nhân Viên", 100)
			lvthongtintimkiem.Columns.Add("Tên Nhân Viên", 150)
			lvthongtintimkiem.Columns.Add("CMND", 100)
			lvthongtintimkiem.Columns.Add("Năm Sinh", 100)
			lvthongtintimkiem.Columns.Add("Chức Vụ", 100)
			lvthongtintimkiem.Columns.Add("Điện Thoại", 100)
			lvthongtintimkiem.Columns.Add("Địa Chỉ", 400)
			Dim dto As New DTO_NhanVien()
			dto.ma_nhan_vien = _Key_id.Trim()
			dto.ten_nhan_vien = _key_name.Trim()
			Dim STT As Integer = 1
			If New BLL_TraCuu()._Tim_NhanVien(dto) IsNot Nothing Then
				For Each nv As DTO_NhanVien In New BLL_TraCuu()._Tim_NhanVien(dto)
					Dim item As New ListViewItem(STT.ToString())

					Dim ie1 As New ListViewItem.ListViewSubItem(item, nv.ma_nhan_vien)
					item.SubItems.Add(ie1)
					Dim ie2 As New ListViewItem.ListViewSubItem(item, nv.ten_nhan_vien)
					item.SubItems.Add(ie2)
					Dim ie3 As New ListViewItem.ListViewSubItem(item, nv.cmnd)
					item.SubItems.Add(ie3)
					Dim ie4 As New ListViewItem.ListViewSubItem(item, nv.nam_sinh.ToShortDateString())
					item.SubItems.Add(ie4)
					Dim ie5 As New ListViewItem.ListViewSubItem(item, nv.chucvu)
					item.SubItems.Add(ie5)
					Dim ie6 As New ListViewItem.ListViewSubItem(item, nv.dien_thoai)
					item.SubItems.Add(ie6)
					Dim ie7 As New ListViewItem.ListViewSubItem(item, nv.dia_chi)
					item.SubItems.Add(ie7)

					lvthongtintimkiem.Items.Add(item)

					STT += 1
				Next
			End If
		End Sub
		Private Sub _KhachHang()
			lvthongtintimkiem.Items.Clear()

			lvthongtintimkiem.Columns.Add("STT", 60)
			lvthongtintimkiem.Columns.Add("Mã Khách Hàng", 100)
			lvthongtintimkiem.Columns.Add("Thông Tin", 200)
			lvthongtintimkiem.Columns.Add("Mã Số Thếu", 100)
			lvthongtintimkiem.Columns.Add("Điện Thoại", 100)
			lvthongtintimkiem.Columns.Add("Fax", 120)
			lvthongtintimkiem.Columns.Add("Địa Chỉ", 500)

			Dim dto As New DTO_KhachHang()
			dto.ma_khach_hang = _Key_id.ToString()
			dto.ten_khach_hang = _key_name.ToString()
			Dim STT As Integer = 1
			If New BLL_TraCuu()._Tim_KhachHang(dto) IsNot Nothing Then
				For Each kh As DTO_KhachHang In New BLL_TraCuu()._Tim_KhachHang(dto)
					Dim item As New ListViewItem(STT.ToString())

					Dim ie1 As New ListViewItem.ListViewSubItem(item, kh.ma_khach_hang.ToString())
					item.SubItems.Add(ie1)
					Dim ie2 As New ListViewItem.ListViewSubItem(item, kh.ten_khach_hang.Trim())
					item.SubItems.Add(ie2)
					Dim ie3 As New ListViewItem.ListViewSubItem(item, kh.ma_so_thue)
					item.SubItems.Add(ie3)
					Dim ie4 As New ListViewItem.ListViewSubItem(item, kh.dien_thoai)
					item.SubItems.Add(ie4)
					Dim ie5 As New ListViewItem.ListViewSubItem(item, kh.fax)
					item.SubItems.Add(ie5)
					Dim ie6 As New ListViewItem.ListViewSubItem(item, kh.dia_chi)
					item.SubItems.Add(ie6)

					lvthongtintimkiem.Items.Add(item)
					STT += 1
				Next
			End If
		End Sub
		Private Sub _Xe()
			lvthongtintimkiem.Items.Clear()

			lvthongtintimkiem.Columns.Add("STT", 60)
			lvthongtintimkiem.Columns.Add("Mã Số Xe", 100)
			lvthongtintimkiem.Columns.Add("Loại Xe", 100)
			lvthongtintimkiem.Columns.Add("Tải Trọng", 100)
			lvthongtintimkiem.Columns.Add("Nhãn Hiệu", 150)
			lvthongtintimkiem.Columns.Add("Tình Trạng Xe", 220)
			lvthongtintimkiem.Columns.Add("Ngày Nhập Dữ Liệu", 500)

			Dim xx As New DTO_Xe()
			xx.ma_so_xe = _Key_id.Trim()
			Dim STT As Integer = 1
			If New BLL_TraCuu()._Tim_ThongTinXe(xx) IsNot Nothing Then
				For Each dto As DTO_Xe In New BLL_TraCuu()._Tim_ThongTinXe(xx)
					Dim item As New ListViewItem(STT.ToString())

					Dim ie1 As New ListViewItem.ListViewSubItem(item, dto.ma_so_xe)
					item.SubItems.Add(ie1)
					Dim ie2 As New ListViewItem.ListViewSubItem(item, dto.loai_xe)
					item.SubItems.Add(ie2)
					Dim ie3 As New ListViewItem.ListViewSubItem(item, dto.trong_luong.ToString("###,###"))
					item.SubItems.Add(ie3)
					Dim ie4 As New ListViewItem.ListViewSubItem(item, dto.nhan_hieu)
					item.SubItems.Add(ie4)
					Dim ie5 As New ListViewItem.ListViewSubItem(item, dto.ten_tinh_trang)
					item.SubItems.Add(ie5)
					Dim ie6 As New ListViewItem.ListViewSubItem(item, dto.ngay_tao.ToShortDateString())
					item.SubItems.Add(ie6)

					lvthongtintimkiem.Items.Add(item)
					STT += 1
				Next
			End If
		End Sub
		Private Sub _HoaDon()
			lvthongtintimkiem.Items.Clear()

			lvthongtintimkiem.Columns.Add("STT", 60)
			lvthongtintimkiem.Columns.Add("Mã Khách Hàng", 100)
			lvthongtintimkiem.Columns.Add("Thông Tin Khách Hàng", 150)
			lvthongtintimkiem.Columns.Add("Mã Hợp Đồng", 100)
			lvthongtintimkiem.Columns.Add("Mã Hóa Đơn", 100)
			lvthongtintimkiem.Columns.Add("Ngày Xuất Hóa Đơn", 150)
			lvthongtintimkiem.Columns.Add("Tổng Khối Lượng(Tấn)", 150)
			lvthongtintimkiem.Columns.Add("Tổng Cước Vận Chuyển(VNĐ)", 150)
			lvthongtintimkiem.Columns.Add("Hóa Đơn Tính Từ Ngày", 150)
			lvthongtintimkiem.Columns.Add("Đến Ngày", 150)

			Dim hd As New DTO_HoaDon()
			hd.ma_hoa_don = _Key_id.Trim()
			Dim STT As Integer = 1
			If New BLL_TraCuu()._Tim_HoaDon(hd) IsNot Nothing Then
				For Each dto As DTO_HoaDon In New BLL_TraCuu()._Tim_HoaDon(hd)
					Dim item As New ListViewItem(STT.ToString())

					Dim ie1 As New ListViewItem.ListViewSubItem(item, dto.ma_khach_hang)
					item.SubItems.Add(ie1)
					Dim ie2 As New ListViewItem.ListViewSubItem(item, dto.tenkhachhang)
					item.SubItems.Add(ie2)
					Dim ie3 As New ListViewItem.ListViewSubItem(item, dto.ma_hop_dong)
					item.SubItems.Add(ie3)
					Dim ie4 As New ListViewItem.ListViewSubItem(item, dto.ma_hoa_don)
					item.SubItems.Add(ie4)
					'ListViewItem.ListViewSubItem ie5 = new ListViewItem.ListViewSubItem(item, dto.ngay_tao.ToShortDateString());
					'item.SubItems.Add(ie5);
					Dim ie6 As New ListViewItem.ListViewSubItem(item, dto.tong_khoi_luong.ToString("###,###"))
					item.SubItems.Add(ie6)
					Dim ie7 As New ListViewItem.ListViewSubItem(item, dto.tong_cuot_van_chuyen.ToString("###,###,###"))
					item.SubItems.Add(ie7)
					' ListViewItem.ListViewSubItem ie8 = new ListViewItem.ListViewSubItem(item, dto.tu_ngay.ToShortDateString());
					' item.SubItems.Add(ie8);
					'ListViewItem.ListViewSubItem ie9 = new ListViewItem.ListViewSubItem(item, dto.den_ngay.ToShortDateString());
					' item.SubItems.Add(ie9);

					lvthongtintimkiem.Items.Add(item)
					STT += 1
				Next
			End If
		End Sub
		Private Sub _HopDong()
			lvthongtintimkiem.Items.Clear()

			lvthongtintimkiem.Columns.Add("STT", 60)
			lvthongtintimkiem.Columns.Add("Mã Khách Hàng", 100)
			lvthongtintimkiem.Columns.Add("Thông Tin Khách Hàng", 150)
			lvthongtintimkiem.Columns.Add("Mã Hợp Đồng", 100)
			lvthongtintimkiem.Columns.Add("Loại Hàng Hóa", 100)
			lvthongtintimkiem.Columns.Add("Lộ Trình Vận Chuyển", 150)
			lvthongtintimkiem.Columns.Add("Phương Thức Vận Chuyển", 150)
			lvthongtintimkiem.Columns.Add("Giá Trị Hợp Đồng", 150)
			lvthongtintimkiem.Columns.Add("Phương Thức Thanh Toán", 150)
			lvthongtintimkiem.Columns.Add("Ngày Bắt Đầu", 150)
			lvthongtintimkiem.Columns.Add("Ngày Kết Thúc", 150)
			lvthongtintimkiem.Columns.Add("Ngày Lập Hợp Đồng", 150)

			Dim hd As New DTO_HopDong()
			hd.ma_hop_dong = _Key_id.Trim()
			Dim STT As Integer = 1
			If New BLL_TraCuu()._Tim_HopDong(hd) IsNot Nothing Then
				For Each dto As DTO_HopDong In New BLL_TraCuu()._Tim_HopDong(hd)
					Dim item As New ListViewItem(STT.ToString())

					Dim ie1 As New ListViewItem.ListViewSubItem(item, dto.ma_khach_hang)
					item.SubItems.Add(ie1)
					Dim ie2 As New ListViewItem.ListViewSubItem(item, dto.ten_khach_hang)
					item.SubItems.Add(ie2)
					Dim ie3 As New ListViewItem.ListViewSubItem(item, dto.ma_hop_dong)
					item.SubItems.Add(ie3)
					Dim ie4 As New ListViewItem.ListViewSubItem(item, dto.loaihanghoa)
					item.SubItems.Add(ie4)
					Dim ie5 As New ListViewItem.ListViewSubItem(item, dto.lotrinhvanchuyen)
					item.SubItems.Add(ie5)
					Dim ie6 As New ListViewItem.ListViewSubItem(item, dto.phuongthucvanchuyen)
					item.SubItems.Add(ie6)
					Dim ie7 As New ListViewItem.ListViewSubItem(item, dto.giatrihopdong)
					item.SubItems.Add(ie7)
					Dim ie8 As New ListViewItem.ListViewSubItem(item, dto.phuongthucthanhtoan)
					item.SubItems.Add(ie8)
					Dim ie9 As New ListViewItem.ListViewSubItem(item, dto.ngay_bat_dau.ToShortDateString())
					item.SubItems.Add(ie9)
					Dim ie10 As New ListViewItem.ListViewSubItem(item, dto.ngay_ket_thuc.ToShortDateString())
					item.SubItems.Add(ie10)
					Dim ie11 As New ListViewItem.ListViewSubItem(item, dto.ngay_tao.ToShortDateString())
					item.SubItems.Add(ie11)

					lvthongtintimkiem.Items.Add(item)
					STT += 1
				Next
			End If
		End Sub
	End Class
End Namespace
