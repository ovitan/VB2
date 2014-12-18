Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Class DTO_Chi_Tiet_Dich_vu
		Private _khu_vuc As String
		Private _phan_vung As String
		Private _ma_bao_gia As String
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
		Public Property ma_bao_gia() As String
			Get
				Return _ma_bao_gia
			End Get
			Set
				_ma_bao_gia = value
			End Set
		End Property
	End Class
End Namespace
