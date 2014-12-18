Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_DieuXe
		Private _ma_dieu_xe As String
		Private _ma_khach_hang As String
		Private _ten_khach_hang As String
		Private _noi_giao As String
		Private _noi_nhan As String
		Private _so_tan As String
		Private _ngay_dieu_xe As DateTime
		Private _ma_nhan_vien As String
		Private _ma_so_xe As String

		Public Property ma_dieu_xe() As String
			Get
				Return _ma_dieu_xe
			End Get
			Set
				_ma_dieu_xe = value
			End Set
		End Property
		Public Property ma_khach_hang() As String
			Get
				Return _ma_khach_hang
			End Get
			Set
				_ma_khach_hang = value
			End Set
		End Property
		Public Property ten_khach_hang() As String
			Get
				Return _ten_khach_hang
			End Get
			Set
				_ten_khach_hang = value
			End Set
		End Property
		Public Property so_tan() As String
			Get
				Return _so_tan
			End Get
			Set
				_so_tan = value
			End Set
		End Property
		Public Property noi_giao() As String
			Get
				Return _noi_giao
			End Get
			Set
				_noi_giao = value
			End Set
		End Property
		Public Property noi_nhan() As String
			Get
				Return _noi_nhan
			End Get
			Set
				_noi_nhan = value
			End Set
		End Property
		Public Property ngay_dieu_xe() As DateTime
			Get
				Return _ngay_dieu_xe
			End Get
			Set
				_ngay_dieu_xe = value
			End Set
		End Property
		Public Property ma_nhan_vien() As String
			Get
				Return _ma_nhan_vien
			End Get
			Set
				_ma_nhan_vien = value
			End Set
		End Property
		Public Property ma_so_xe() As String
			Get
				Return _ma_so_xe
			End Get
			Set
				_ma_so_xe = value
			End Set
		End Property

		Private _trong_luong As Single
		Private _loai_xe As String
		Private _nhan_hieu As String
		Private _ma_tinh_trang As Integer
		Private _ten_tinh_trang As String



		Public Property trong_luong() As Single
			Get
				Return _trong_luong
			End Get
			Set
				_trong_luong = value
			End Set
		End Property
		Public Property loai_xe() As String
			Get
				Return _loai_xe
			End Get
			Set
				_loai_xe = value
			End Set
		End Property
		Public Property nhan_hieu() As String
			Get
				Return _nhan_hieu
			End Get
			Set
				_nhan_hieu = value
			End Set
		End Property
		Public Property ma_tinh_trang() As Integer
			Get
				Return _ma_tinh_trang
			End Get
			Set
				_ma_tinh_trang = value
			End Set
		End Property

		Public Property ten_tinh_trang() As String
			Get
				Return _ten_tinh_trang
			End Get
			Set
				_ten_tinh_trang = value
			End Set
		End Property


		Private _ten_nhan_vien As String
		Private _cmnd As String
		Private _dia_chi As String
		Private _nam_sinh As DateTime
		Private _dien_thoai As String
		Private _chucvu As String



		Public Property ten_nhan_vien() As String
			Get
				Return _ten_nhan_vien
			End Get
			Set
				_ten_nhan_vien = value
			End Set
		End Property

		Public Property cmnd() As String
			Get
				Return _cmnd
			End Get
			Set
				_cmnd = value
			End Set
		End Property
		Public Property dia_chi() As String
			Get
				Return _dia_chi
			End Get
			Set
				_dia_chi = value
			End Set
		End Property
		Public Property nam_sinh() As DateTime
			Get
				Return _nam_sinh
			End Get
			Set
				_nam_sinh = value
			End Set
		End Property
		Public Property dien_thoai() As String
			Get
				Return _dien_thoai
			End Get
			Set
				_dien_thoai = value
			End Set
		End Property


		Public Property chucvu() As String
			Get
				Return _chucvu
			End Get
			Set
				_chucvu = value
			End Set
		End Property


		Private _ma_hop_dong As String
		Private _loaihanghoa As String
		Public Property ma_hop_dong() As String
			Get
				Return _ma_hop_dong
			End Get
			Set
				_ma_hop_dong = value
			End Set
		End Property
		Public Property loaihanghoa() As String
			Get
				Return _loaihanghoa
			End Get
			Set
				_loaihanghoa = value
			End Set
		End Property

		Private _don_gia_chuyen As Single
		Private _don_gia_tan As Single
		Public Property don_gia_chuyen() As Single
			Get
				Return _don_gia_chuyen
			End Get
			Set
				_don_gia_chuyen = value
			End Set
		End Property
		Public Property don_gia_tan() As Single
			Get
				Return _don_gia_tan
			End Get
			Set
				_don_gia_tan = value
			End Set
		End Property

		Private _ngay_ve As DateTime
		Private _ttt As Integer
		Private _tinh_trang_thanh_toan As String
		Public Property ngay_ve() As DateTime
			Get
				Return _ngay_ve
			End Get
			Set
				_ngay_ve = value
			End Set
		End Property
		Public Property tttt() As Integer
			Get
				Return _ttt
			End Get
			Set
				_ttt = value
			End Set
		End Property
		Public Property tinh_trang_thanh_toan() As String
			Get
				Return _tinh_trang_thanh_toan
			End Get
			Set
				_tinh_trang_thanh_toan = value
			End Set
		End Property
		Private _tai_trong_xe As Single
		Public Property tai_trong_xe() As Single
			Get
				Return _tai_trong_xe
			End Get
			Set
				_tai_trong_xe = value
			End Set
		End Property
	End Class
End Namespace
