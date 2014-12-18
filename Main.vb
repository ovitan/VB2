Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.UI
Imports QLDVVTHH.DTO

Public Partial Class Main
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub mnquanlynhanvien_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmNhanVien" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmNhanVien()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mnlaphopdong_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmHopDong" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmHopDong()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mnnhapbangke_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmBangKe" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmBangKe()
		uc.Show()
		uc.MdiParent = Me
	End Sub



	Private Sub mnlaphoadon_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmHoaDon" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmHoaDon()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mnacongno_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmCongNo" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmCongNo()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mndanhsachkhachhang_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmInAn" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim rz As New DTO_ResizeForm()
		rz.CHIEU_CAO = 214
		rz.CHIEU_DAI = 130
		rz.Index = "0001"
		Dim uc As New frmInAn(rz)
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mnxuathoadon_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmInAn" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim rz As New DTO_ResizeForm()
		rz.CHIEU_CAO = 214
		rz.CHIEU_DAI = 250
		rz.Index = "0004"
		Dim uc As New frmInAn(rz)
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mndanhsachxe_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmInAn" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim rz As New DTO_ResizeForm()
		rz.CHIEU_CAO = 214
		rz.CHIEU_DAI = 100
		rz.Index = "0003"
		Dim uc As New frmInAn(rz)
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mndanhsachnhanvien_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmInAn" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim rz As New DTO_ResizeForm()
		rz.CHIEU_CAO = 214
		rz.CHIEU_DAI = 100
		rz.Index = "0002"
		Dim uc As New frmInAn(rz)
		uc.Show()
		uc.MdiParent = Me
	End Sub
	Private Sub mnxemcongnokhachhang_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmThongKeCongNo" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmThongKeCongNo()
		uc.Show()
		uc.MdiParent = Me
	End Sub
	Private Sub mnquanlykhachang_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmKhachHang" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmKhachHang()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub tìnhTrạngXeToolStripMenuItem_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmTinhTrangXe" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmTinhTrangXe()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mnquanlyxe_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmXe" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmXe()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub tìnhTrạngXeToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmTinhTrangXe" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmTinhTrangXe()
		uc.Show()
		uc.MdiParent = Me
	End Sub


	Private Sub dịchVụToolStripMenuItem_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmDịchVu" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmDichVu()
		uc.Show()
		uc.MdiParent = Me
	End Sub
	Private Sub mndx_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmTTDieuXe" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmTTDieuXe()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mnbaogia_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "txt_mabaogia" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New txt_mabaogia()
		uc.Show()
		uc.MdiParent = Me
	End Sub

	Private Sub mnsaoluucsdl_Click(sender As Object, e As EventArgs)
		For Each mdiChild As Form In Me.MdiChildren
			If mdiChild.Name = "frmSaoLuuData" Then
				mdiChild.Activate()
				Return
			End If
		Next
		Dim uc As New frmSaoLuuData()
		uc.Show()
		uc.MdiParent = Me
	End Sub
End Class
