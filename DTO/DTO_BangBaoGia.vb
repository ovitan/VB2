Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Public Class DTO_BangBaoGia
		Private _ma_bao_gia As String
		Private _ma_hop_dong As String
		Private _tu_ngay As DateTime
		Private _den_ngay As DateTime
		Private _noi_giao As String
		Private _noi_nhan As String
		Private _don_gia_tan As Single
		Private _don_gia_chuyen As Single
		Private _ghi_chu As String
		'private DateTime _ngay_tao;
		'private DateTime _ngay_cap_nhat;

		Public Property ma_bao_gia() As String
			Get
				Return _ma_bao_gia
			End Get
			Set
				_ma_bao_gia = value
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

		Public Property tu_ngay() As DateTime
			Get
				Return _tu_ngay
			End Get
			Set
				_tu_ngay = value
			End Set
		End Property
		Public Property den_ngay() As DateTime
			Get
				Return _den_ngay
			End Get
			Set
				_den_ngay = value
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
		'public DateTime ngay_tao
		'{
		'    get { return _ngay_tao; }
		'    set { _ngay_tao = value; }
		'}
		'public DateTime ngay_cap_nhat
		'{
		'    get { return _ngay_cap_nhat; }
		'    set { _ngay_cap_nhat = value; }
		'}
		Private _khu_vuc As String
		Private _phan_vung As String
		'private float _don_gia_chuyen;
		'private float _don_gia_tan;

		Public Property khu_vuc() As String
			Get
				Return _khu_vuc
			End Get
			Set
				_khu_vuc = value
			End Set
		End Property
		Public Property phan_vung() As String
			Get
				Return _phan_vung
			End Get
			Set
				_phan_vung = value
			End Set
		End Property
		'public float don_gia_chuyen
		'{
		'    get { return _don_gia_chuyen; }
		'    set { _don_gia_chuyen = value; }
		'}
		'public float don_gia_tan
		'{
		'    get { return _don_gia_tan; }
		'    set { _don_gia_tan = value; }
		'}

	End Class
End Namespace
