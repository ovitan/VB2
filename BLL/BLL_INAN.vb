Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Namespace BLL
	Public Class BLL_INAN
		Public Function _Luu_Data_Khach_Hang_Rpt() As Integer
			Return New DAL_INAN()._Luu_Data_Khach_Hang_Rpt()
		End Function
		Public Function _Luu_Data_Nhan_Vien_Rpt() As Integer
			Return New DAL_INAN()._Luu_Data_Khach_Hang_Rpt()
		End Function
		Public Function _Luu_Data_Xe_Rpt() As Integer
			Return New DAL_INAN()._Luu_Data_Xe_Rpt()
		End Function
		Public Function _Luu_Data_Hoa_Don(dto As DTO_HoaDon) As Integer
			Return New DAL_INAN()._Luu_Data_Hoa_Don(dto)
		End Function
	End Class
End Namespace
