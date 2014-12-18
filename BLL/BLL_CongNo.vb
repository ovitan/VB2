Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DAL
Imports QLDVVTHH.DTO
Imports System.Data
Imports System.Data.SqlClient
Namespace BLL
	Public Class BLL_CongNo
		Public Function _Ma_Cong_No() As String
			Return New DAL_CongNo()._Ma_Cong_No()
		End Function
		Public Function _List_Hoa_Don(hoadon As DTO_HoaDon) As DTO_HoaDon()
			Return New DAL_CongNo()._List_Hoa_Don(hoadon)
		End Function
		Public Function _Them_Cong_No_Khach_Hang(hoadon As DTO_HoaDon, congno As DTO_CongNo) As Integer
			Return New DAL_CongNo()._Them_Cong_No_Khach_Hang(hoadon, congno)
		End Function
		Public Function _List_View_Cong_No_Khach_Hang(congno As DTO_CongNo) As DTO_CongNo()
			Return New DAL_CongNo()._List_View_Cong_No_Khach_Hang(congno)
		End Function
		Public Function _Xoa_Cong_No(congno As DTO_CongNo) As Integer
			Return New DAL_CongNo()._Xoa_Cong_No(congno)
		End Function
		Public Function _Them_Thanh_Toan_Cong_No(tt As DTO_ThanhToan) As Integer
			Return New DAL_CongNo()._Them_Thanh_Toan_Cong_No(tt)
		End Function
		Public Function _List_View_Thanh_Toan(tt As DTO_ThanhToan) As DTO_ThanhToan()
			Return New DAL_CongNo()._List_View_Thanh_Toan(tt)
		End Function
		Public Function _Xoa_So_Tien_Thanh_Toan(tt As DTO_ThanhToan) As Integer
			Return New DAL_CongNo()._Xoa_So_Tien_Thanh_Toan(tt)
		End Function
		Public Function _Thong_Ke_Cong_No(congno As DTO_CongNo) As DTO_CongNo()
			Return New DAL_CongNo()._Thong_Ke_Cong_No(congno)
		End Function
		Public Function _check_ma_hoa_don_cong_no(hd As DTO_HoaDon) As Integer
			Return New DAL_CongNo()._check_ma_hoa_don_cong_no(hd)
		End Function
	End Class
End Namespace
