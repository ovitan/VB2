Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DTO
	Class DTO_DichVu
		Private _khu_vuc As String
		Private _phan_vung As String
		Private _don_gia_chuyen As Single
		Private _don_gia_tan As Single

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
	End Class
End Namespace
