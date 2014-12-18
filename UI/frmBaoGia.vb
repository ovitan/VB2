Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.Common
Imports QLDVVTHH.BLL
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL
Imports System.Text.RegularExpressions

Namespace UI
	Public Partial Class txt_mabaogia
		Inherits Form
		Private bll_bg As BLL_BangBaoGia = Nothing
		Private bll_hd As BLL_HopDong = Nothing
		Private bll_dv As BLL_DichVu = Nothing
		Public Sub New()
			bll_bg = New BLL_BangBaoGia()
			bll_hd = New BLL_HopDong()
			bll_dv = New BLL_DichVu()
			InitializeComponent()
			txt_ma_bao_gia.Text = bll_bg.Ma_BG()
		End Sub

		Private Sub frmBaoGia_Load(sender As Object, e As EventArgs)
			grv_BG.AutoGenerateColumns = False
			LoadGridview()
			_Load_Combobox_Hop_Dong()
			Load_cbb_khuvuc_phanvung()



			EnableControl(False)
			btn_luu.Enabled = False
			btn_sua.Enabled = False
		End Sub
		Private Sub LoadGridview()
			grv_BG.DataSource = bll_bg.GetALl_BG()
		End Sub
		Private Sub _Load_Combobox_Hop_Dong()
			Dim hd As New List(Of DTO_HopDong)()
			Dim groups = bll_hd.Ma_HD()
            hd.Add(New DTO_HopDong() With { _
                .ma_hop_dong = "Chọn hợp đồng" _
            })
			hd.AddRange(groups)
			cbb_hopdong.DataSource = hd
			cbb_hopdong.ValueMember = "ma_hop_dong"
			cbb_hopdong.DisplayMember = "ma_hop_dong"

		End Sub
		Private Sub Load_cbb_khuvuc_phanvung()
			Dim dv As New List(Of DTO_DichVu)()
			Dim groups = bll_dv.KV_2()
            dv.Add(New DTO_DichVu() With { _
                .khu_vuc = "Chọn Khu Vực" _
            })
			dv.AddRange(groups)
			cbb_khuvuc.DataSource = dv
			cbb_khuvuc.ValueMember = "khu_vuc"
			cbb_khuvuc.DisplayMember = "khu_vuc"
		End Sub
		Private Sub Load_cbb_phanvung(dv As DTO_DichVu)
			'List<DTO_DichVu> dv1 = new List<DTO_DichVu>();
			'var groups = bll_dv.PV_2(dv);
			'dv1.Add(new DTO_DichVu() { phan_vung = "Chọn Phân Vùng" });
			'dv1.AddRange(groups);
			cbb_phanvung.DataSource = bll_dv.PV_2(dv)
			cbb_phanvung.ValueMember = "phan_vung"
			cbb_phanvung.DisplayMember = "phan_vung"
		End Sub

		Private Sub cbb_khuvuc_SelectedIndexChanged(sender As Object, e As EventArgs)
			If cbb_khuvuc.SelectedText <> "Chọn Khu Vực" Then
				Dim dvv As New DTO_DichVu()
				dvv.khu_vuc = cbb_khuvuc.Text.Trim()

				Load_cbb_phanvung(dvv)
			End If
		End Sub
		Private Sub EnableControl(flag As Boolean)
			txt_ma_bao_gia.Enabled = flag
			cbb_khuvuc.Enabled = flag
			txt_dongiachuyen.Enabled = flag
			txt_noinhan.Enabled = flag
			txt_noigiao.Enabled = flag
			cbb_phanvung.Enabled = flag
			cbb_hopdong.Enabled = flag
			cbb_khuvuc.Enabled = flag
			dtptungay.Enabled = flag
			dtpdenngay.Enabled = flag
		End Sub
		Private Sub ResetControl()
			txt_ma_bao_gia.Text = String.Empty
			txt_dongiachuyen.Text = String.Empty
			txt_dongiatan.Text = String.Empty
			txt_noinhan.Text = String.Empty
			txt_noigiao.Text = String.Empty
			txt_ghichu.Text = String.Empty
			dtpdenngay.Value = DateTime.Now
			dtptungay.Value = DateTime.Now
			btn_luu.Enabled = True
			btn_xoa.Enabled = False
			btn_sua.Enabled = False
			MethodHelper.ClearErrorProvider()
		End Sub

		Private Sub btn_them_Click(sender As Object, e As EventArgs)
			EnableControl(True)
			ResetControl()
			txt_ma_bao_gia.Text = bll_bg.Ma_BG()
			btn_luu.Enabled = True
			btn_sua.Enabled = False
			btn_xoa.Enabled = False
		End Sub

		Private Sub btn_sua_Click(sender As Object, e As EventArgs)
			If txt_ma_bao_gia.Text.Length > 0 Then
				EnableControl(True)
				txt_ma_bao_gia.Enabled = False
				MethodHelper.ClearErrorProvider()

				btn_luu.Enabled = True
			End If
		End Sub

		Private Sub btn_xoa_Click(sender As Object, e As EventArgs)
			If txt_ma_bao_gia.Text.Length > 0 Then
				bll_bg.Delete_BG(txt_ma_bao_gia.Text.Trim())
				LoadGridview()
				ResetControl()

				btn_sua.Enabled = False
				btn_xoa.Enabled = False
			End If
		End Sub

		Private Sub btn_luu_Click(sender As Object, e As EventArgs)
			' txt_ma_bao_gia.Text = new BLL_BangBaoGia().Ma_BG();// Lay Ma Moi Nhat
			If Not CheckBeforeSave() Then
				Return
			End If
			Dim bg As New DTO_BangBaoGia()
			bg.ma_bao_gia = txt_ma_bao_gia.Text
			bg.noi_giao = txt_noigiao.Text
			bg.ma_hop_dong = cbb_hopdong.SelectedValue.ToString()
			bg.noi_nhan = txt_noinhan.Text
			bg.tu_ngay = dtptungay.Value
			bg.den_ngay = dtpdenngay.Value
			bg.ghi_chu = txt_ghichu.Text
			'bg.khu_vuc = cbb_khuvuc.SelectedValue.ToString();
			'bg.phan_vung = cbb_phanvung.SelectedValue.ToString();
			bg.don_gia_chuyen = Single.Parse(txt_dongiachuyen.Text)
			bg.don_gia_tan = Single.Parse(txt_dongiatan.Text)
			If dtptungay.Value >= dtpdenngay.Value Then
				MessageBox.Show("Thời Gian Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				If txt_ma_bao_gia.Enabled Then
					bll_bg.Create_BG(bg)
				Else
					bll_bg.Update_BG(bg)
				End If
				LoadGridview()
				ResetControl()
				txt_ma_bao_gia.Text = New BLL_BangBaoGia().Ma_BG()

				btn_sua.Enabled = False
				btn_xoa.Enabled = False
			End If


		End Sub
		Private Function CheckBeforeSave() As Boolean
			Dim flag As Boolean = True
			If txt_ma_bao_gia.Enabled AndAlso txt_ma_bao_gia.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_ma_bao_gia, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If txt_noigiao.Enabled AndAlso txt_noigiao.Text.Length = 0 Then
				MethodHelper.AddErrorProvider(txt_noigiao, [Const].EMPTY_MESSAGE)
				flag = False
			End If
			If Not txt_ma_bao_gia.Enabled AndAlso Not txt_noigiao.Enabled Then
				flag = False
			End If
			Return flag
		End Function

		Private Sub grv_BG_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim i As Integer = e.RowIndex
			If e.RowIndex < 0 Then
				Return
			End If
			Dim grvbg As DTO_BangBaoGia = TryCast(grv_BG.Rows(i).DataBoundItem, DTO_BangBaoGia)
			txt_ma_bao_gia.Text = grvbg.ma_bao_gia
			txt_dongiachuyen.Text = Convert.ToString(grvbg.don_gia_chuyen)
			txt_dongiatan.Text = Convert.ToString(grvbg.don_gia_tan)
			txt_ghichu.Text = grvbg.ghi_chu
			'cbb_hopdong.SelectedItem= grvbg.ma_hop_dong;
			cbb_hopdong.Text = grv_BG.Rows(i).Cells("colHD").Value.ToString()
			txt_noigiao.Text = grvbg.noi_giao
			txt_noinhan.Text = grvbg.noi_nhan
			'cbb_khuvuc.SelectedItem = grvbg.khu_vuc;
			'cbb_phanvung.SelectedItem = grvbg.phan_vung;
			dtpdenngay.Value = Convert.ToDateTime(grvbg.den_ngay)
			dtptungay.Value = Convert.ToDateTime(grvbg.tu_ngay)

			EnableControl(False)
			MethodHelper.ClearErrorProvider()

			btn_luu.Enabled = False
			btn_sua.Enabled = True
			btn_xoa.Enabled = True
		End Sub

		Private Sub btn_thoat_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub cbb_phanvung_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim chonkv As String = cbb_khuvuc.SelectedValue.ToString().Trim()
			If cbb_khuvuc.SelectedIndex = 0 Then
				txt_dongiachuyen.Text = ""
				txt_dongiatan.Text = ""
			Else
				Dim dto As New DTO_DichVu()
				dto.khu_vuc = cbb_khuvuc.SelectedValue.ToString()
				dto.phan_vung = cbb_phanvung.SelectedValue.ToString()
				Dim li As List(Of DTO_DichVu) = New BLL_DichVu().DOngia_2(dto)
				For Each dg As DTO_DichVu In li
					txt_dongiachuyen.Text = dg.don_gia_chuyen.ToString()
					txt_dongiatan.Text = dg.don_gia_tan.ToString()
				Next
			End If
		End Sub

		Private Sub cbb_hopdong_SelectedIndexChanged(sender As Object, e As EventArgs)

		End Sub
	End Class
End Namespace
