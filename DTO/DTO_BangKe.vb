Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_BangKe
		Private _ma_bang_ke As String
		Private _ma_khach_hang As String
		Private _ngay_van_chuyen As DateTime
		Private _khoi_luong As Single
		Private _don_gia_tan As Single
		Private _don_gia_chuyen As Single
		Private _noi_nhan As String
		Private _noi_giao As String
		Private _so_xe As String
		Private _ngay_tao As DateTime
		Private _ngay_cap_nhat As DateTime
		Private _ghi_chu As String
		Private _ma_dieu_xe As String

		Public Property ma_dieu_xe() As String
			Get
				Return _ma_dieu_xe
			End Get
			Set
				_ma_dieu_xe = value
			End Set
		End Property
		Public Property ma_bang_ke() As String
			Get
				Return _ma_bang_ke
			End Get
			Set
				_ma_bang_ke = value
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
		Public Property ngay_van_chuyen() As DateTime
			Get
				Return _ngay_van_chuyen
			End Get
			Set
				_ngay_van_chuyen = value
			End Set
		End Property
		Public Property khoi_luong() As Single
			Get
				Return _khoi_luong
			End Get
			Set
				_khoi_luong = value
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
		Public Property don_gia_chuyen() As Single
			Get
				Return _don_gia_chuyen
			End Get
			Set
				_don_gia_chuyen = value
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
		Public Property ngay_tao() As DateTime
			Get
				Return _ngay_tao
			End Get
			Set
				_ngay_tao = value
			End Set
		End Property
		Public Property ngay_cap_nhat() As DateTime
			Get
				Return _ngay_cap_nhat
			End Get
			Set
				_ngay_cap_nhat = value
			End Set
		End Property
		Public Property ghi_chu() As String
			Get
				Return _ghi_chu
			End Get
			Set
				_ghi_chu = value
			End Set
		End Property
		Public Property so_xe() As String
			Get
				Return _so_xe
			End Get
			Set
				_so_xe = value
			End Set
		End Property
	End Class
End Namespace
