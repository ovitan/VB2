Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.DTO
Imports QLDVVTHH.BLL

Namespace UI
	Public Partial Class frmThongKeCongNo
		Inherits Form
		Public Sub New()
			InitializeComponent()
			_Load_CongNo()
		End Sub

		Private Sub btnthoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub frmThongKeCongNo_Load(sender As Object, e As EventArgs)
			_Load_CongNo()
		End Sub
		Private Sub _Load_CongNo()
			Dim dto As New DTO_CongNo()
			lvthongkecongno.Items.Clear()
			If New BLL_CongNo()._Thong_Ke_Cong_No(dto) IsNot Nothing Then
				Dim STT As Integer = 1
				For Each cn As DTO_CongNo In New BLL_CongNo()._Thong_Ke_Cong_No(dto)
					Dim item As New ListViewItem(STT.ToString())

					Dim it1 As New ListViewItem.ListViewSubItem(item, cn.ma_khach_hang)
					item.SubItems.Add(it1)
					Dim it2 As New ListViewItem.ListViewSubItem(item, cn.tenkhachhang)
					item.SubItems.Add(it2)
					Dim it3 As New ListViewItem.ListViewSubItem(item, cn.ma_hop_dong)
					item.SubItems.Add(it3)
					Dim it4 As New ListViewItem.ListViewSubItem(item, cn.tongno.ToString("###,###,###"))
					item.SubItems.Add(it4)
					Dim it5 As New ListViewItem.ListViewSubItem(item, cn.tongtra.ToString("###,###,###"))
					item.SubItems.Add(it5)
					Dim it6 As New ListViewItem.ListViewSubItem(item, (cn.tongno - cn.tongtra).ToString("###,###,###"))
					item.SubItems.Add(it6)
					Dim it7 As New ListViewItem.ListViewSubItem(item, "VNĐ")
					item.SubItems.Add(it7)

					lvthongkecongno.Items.Add(item)
					STT += 1
				Next
			End If
		End Sub
	End Class
End Namespace
