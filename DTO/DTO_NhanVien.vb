Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_NhanVien
		Private _ma_nhan_vien As String
		Private _ten_nhan_vien As String
		Public _ma_so_xe As String
		Private _cmnd As String
		Private _dia_chi As String
		Private _nam_sinh As DateTime
		Private _dien_thoai As String
		Private _chucvu As String
		Private _ngay_tao As DateTime
		Private _ma_hop_dong As String

		Public Property ma_nhan_vien() As String
			Get
				Return _ma_nhan_vien
			End Get
			Set
				_ma_nhan_vien = value
			End Set
		End Property
		Public Property ten_nhan_vien() As String
			Get
				Return _ten_nhan_vien
			End Get
			Set
				_ten_nhan_vien = value
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

		Public Property ngay_tao() As DateTime
			Get
				Return _ngay_tao
			End Get
			Set
				_ngay_tao = value
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
		Public Property ma_hop_dong() As String
			Get
				Return _ma_hop_dong
			End Get
			Set
				_ma_hop_dong = value
			End Set
		End Property
	End Class
End Namespace
