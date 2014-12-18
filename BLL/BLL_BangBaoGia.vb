Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports QLDVVTHH.DAL
Imports QLDVVTHH.DTO
Namespace BLL
	Public Class BLL_BangBaoGia
		Private bbg As New DAL_BangBaoGia()
		Public Function GetALl_BG() As List(Of DTO_BangBaoGia)
			Return bbg.GetALl_BG()
		End Function
		Public Function Create_BG(BG As DTO_BangBaoGia) As Boolean
			Return bbg.Create_BG(BG)
		End Function
		Public Function Update_BG(BG As DTO_BangBaoGia) As Boolean
			Return bbg.Update_BG(BG)
		End Function
		Public Function Delete_BG(ma_BG As String) As Boolean
			Return bbg.Delete_BG(ma_BG)
		End Function
		Public Function Ma_BG() As String
			Return bbg.Ma_BG()
		End Function
		'public string _Ma_Bang_Bao_Gia()
		'{
		'    return new DAL_BangBaoGia()._Ma_Bang_Bao_Gia();
		'}
		'public DTO_BangBaoGia[] _DS_Combobox_Noi_Nhan(DTO_BangBaoGia dto)
		'{
		'    return new DAL_BangBaoGia()._DS_Combobox_Noi_Nhan(dto);
		'}
		'public DTO_BangBaoGia[] _DS_Combobox_Noi_Giao(DTO_BangBaoGia dto)
		'{
		'    return new DAL_BangBaoGia()._DS_Combobox_Noi_Giao(dto);
		'}
		'public int _Them_BaoGia(DTO_BangBaoGia dto)
		'{
		'    return new DAL_BangBaoGia()._Them_BaoGia(dto);
		'}
		'public DTO_BangBaoGia[] _DS_ListView_BangBaoGia(DTO_BangBaoGia dto)
		'{
		'    return new DAL_BangBaoGia()._DS_ListView_BangBaoGia(dto);
		'}
		Public Function _DS_Date_ThoiGianHopDong(dto As DTO_HopDong) As DTO_HopDong()
			Return New DAL_BangBaoGia()._DS_Date_ThoiGianHopDong(dto)
		End Function
		'public int _Xoa_BaoGia(DTO_BangBaoGia dto)
		'{
		'    return new DAL_BangBaoGia()._Xoa_BaoGia(dto);
		'}
		'public int _CapNhat_BaoGia(DTO_BangBaoGia dto)
		'{
		'    return new DAL_BangBaoGia()._CapNhat_BaoGia(dto);
		'}
		'public int _ApDungBaoGia_BangKe(DTO_HopDong hopdong, DTO_BangBaoGia baogia)
		'{
		'    return new DAL_BangBaoGia()._ApDungBaoGia_BangKe(hopdong, baogia);
		'}
	End Class
End Namespace
