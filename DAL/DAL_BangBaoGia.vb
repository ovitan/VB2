Imports System.Collections.Generic
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports QLDVVTHH.DTO
Imports QLDVVTHH.DAL

Namespace DAL
	Public Class DAL_BangBaoGia
		Private data As New ConnectData()
		Public Function GetALl_BG() As List(Of DTO_BangBaoGia)
			Dim sql As String = "select * from dm_bang_bao_gia"
			'SqlDataReader dr = data.ExcuteDataReader(sql, null);
			'return data.MapDataReaderToObject<DTO_BangBaoGia>(dr);
			Dim dt As DataTable = data.ExcuteDataTable(sql, Nothing)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim bg As New List(Of DTO_BangBaoGia)()
				For Each dr As DataRow In dt.Rows
					Dim bb As New DTO_BangBaoGia()
					bb.ma_bao_gia = dr("ma_bao_gia").ToString()
					bb.ma_hop_dong = dr("ma_hop_dong").ToString()
					bb.noi_nhan = dr("noi_nhan").ToString()
					bb.noi_giao = dr("noi_giao").ToString()
					bb.don_gia_chuyen = Single.Parse(dr("don_gia_chuyen").ToString())
					bb.don_gia_tan = Single.Parse(dr("don_gia_tan").ToString())
					bb.tu_ngay = Convert.ToDateTime(dr("tu_ngay").ToString())
					bb.den_ngay = Convert.ToDateTime(dr("den_ngay").ToString())
					bb.ghi_chu = dr("ghi_chu").ToString()
					bg.Add(bb)
				Next
				Return bg
			End If
			Return Nothing
		End Function
		Public Function Create_BG(BG As DTO_BangBaoGia) As Boolean
			Dim sql As String = "insert into dm_bang_bao_gia(ma_bao_gia,ma_hop_dong,noi_nhan,noi_giao,don_gia_chuyen,don_gia_tan,tu_ngay,den_ngay,ghi_chu) " & " values (@ma_bao_gia,@ma_hop_dong,@noi_nhan,@noi_giao,@don_gia_chuyen,@don_gia_tan,@tu_ngay,@den_ngay,@ghi_chu)"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_bao_gia", BG.ma_bao_gia.Trim()), New SqlParameter("@ma_hop_dong", BG.ma_hop_dong.Trim()), New SqlParameter("@noi_nhan", BG.noi_nhan), New SqlParameter("@noi_giao", BG.noi_giao), New SqlParameter("@don_gia_chuyen", BG.don_gia_chuyen), New SqlParameter("@don_gia_tan", BG.don_gia_tan), _
				New SqlParameter("@tu_ngay", BG.tu_ngay), New SqlParameter("@den_ngay", BG.den_ngay), New SqlParameter("@ghi_chu", BG.ghi_chu)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Update_BG(BG As DTO_BangBaoGia) As Boolean
			Dim sql As String = "update dm_bang_bao_gia set ma_hop_dong=@ma_hop_dong,noi_nhan=@noi_nhan,noi_giao=@noi_giao,don_gia_chuyen=@don_gia_chuyen,don_gia_tan=@don_gia_tan,tu_ngay=@tu_ngay,den_ngay=@den_ngay,ghi_chu=@ghi_chu where ma_bao_gia=@ma_bao_gia"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_bao_gia", BG.ma_bao_gia), New SqlParameter("@ma_hop_dong", BG.ma_hop_dong), New SqlParameter("@noi_nhan", BG.noi_nhan), New SqlParameter("@noi_giao", BG.noi_giao), New SqlParameter("@don_gia_chuyen", BG.don_gia_chuyen), New SqlParameter("@don_gia_tan", BG.don_gia_tan), _
				New SqlParameter("@tu_ngay", BG.tu_ngay), New SqlParameter("@den_ngay", BG.den_ngay), New SqlParameter("@ghi_chu", BG.ghi_chu)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Delete_BG(ma_BG As String) As Boolean
			Dim sql As String = "delete [dm_bang_bao_gia] where ma_bao_gia=@ma_bao_gia"
			Dim prs As SqlParameter() = {New SqlParameter("@ma_bao_gia", ma_BG)}
			Return data.ExcuteNonQuery(sql, prs)
		End Function
		Public Function Ma_BG() As String
			Return New DAL_Systems().CreateIDCode("BG", "ma_bao_gia", "dm_bang_bao_gia", 7)
		End Function
		'public string _Ma_Bang_Bao_Gia()
		'{
		'    return new DAL_Systems().CreateIDCode("BG", "ma_bao_gia", "dm_bang_bao_gia", 7);
		'}
		'public DTO_BangBaoGia[] _DS_Combobox_Noi_Nhan(DTO_BangBaoGia dto)
		'{
		'    string sql = "select distinct noi_nhan "
		'                +"from "
		'                +"(select noi_nhan,ngay_van_chuyen "
		'                + "from dm_hop_dong,dm_bang_ke "
		'                + "where dm_hop_dong.ma_khach_hang=dm_bang_ke.makhachhang "
		'                + "and dm_bang_ke.makhachhang=@mkh "
		'                + "and dm_hop_dong.ma_hop_dong=@mhd "
		'                + "and ngay_van_chuyen>=ngaybatdau and ngay_van_chuyen<=ngayketthuc) as KQ "
		'                + "where KQ.ngay_van_chuyen>=@tungay and KQ.ngay_van_chuyen <=@denngay "
		'                ;
		'    SqlParameter[] prs = 
		'    {
		'            new SqlParameter("@mkh",dto.ma_bao_gia.Trim()),
		'            new SqlParameter("@mhd",dto.ma_hop_dong.Trim()),
		'            new SqlParameter("@tungay",dto.tu_ngay),
		'            new SqlParameter("@denngay",dto.den_ngay)
		'    };
		'    DataTable dt = data.ExcuteDataTable(sql, prs);
		'    if (dt!=null && dt.Rows.Count > 0)
		'    {
		'        DTO_BangBaoGia[] BaoGia = new DTO_BangBaoGia[dt.Rows.Count];
		'        for (int i = 0; i < dt.Rows.Count; i++)
		'        {
		'            BaoGia[i] = new DTO_BangBaoGia();
		'            BaoGia[i].noi_nhan = dt.Rows[i]["noi_nhan"].ToString();
		'        }
		'        return BaoGia;
		'    }
		'    return null;
		'}
		'public DTO_BangBaoGia[] _DS_Combobox_Noi_Giao(DTO_BangBaoGia dto)
		'{
		'    string sql =
		'                "select noi_giao "
		'                + "from "
		'                +"(select distinct noi_nhan,noi_giao "
		'                + "from "
		'                + "(select noi_nhan,ngay_van_chuyen,noi_giao "
		'                + "from dm_hop_dong,dm_bang_ke "
		'                + "where dm_hop_dong.ma_khach_hang=dm_bang_ke.makhachhang "
		'                + "and dm_bang_ke.makhachhang=@mkh "
		'                + "and dm_hop_dong.ma_hop_dong=@mhd "
		'                + "and ngay_van_chuyen>=ngaybatdau and ngay_van_chuyen<=ngayketthuc) as KQ "
		'                + "where KQ.ngay_van_chuyen>=@tungay and KQ.ngay_van_chuyen <=@denngay) as QK "
		'                + "where noi_nhan=N'" + dto.noi_nhan.Trim() + "' and noi_giao not in (select noi_giao from dm_bang_bao_gia where tu_ngay>=@tungay and den_ngay<=@denngay) "
		'                ;
		'    SqlParameter[] prs = 
		'    {
		'            new SqlParameter("@mkh",dto.ma_bao_gia.Trim()),
		'            new SqlParameter("@mhd",dto.ma_hop_dong.Trim()),
		'            new SqlParameter("@tungay",dto.tu_ngay),
		'            new SqlParameter("@denngay",dto.den_ngay)
		'    };
		'    DataTable dt = data.ExcuteDataTable(sql, prs);
		'    if (dt != null && dt.Rows.Count > 0)
		'    {
		'        DTO_BangBaoGia[] BaoGia = new DTO_BangBaoGia[dt.Rows.Count];
		'        for (int i = 0; i < dt.Rows.Count; i++)
		'        {
		'            BaoGia[i] = new DTO_BangBaoGia();
		'            BaoGia[i].noi_giao = dt.Rows[i]["noi_giao"].ToString();
		'        }
		'        return BaoGia;
		'    }
		'    return null;
		'}
		'public int _Them_BaoGia(DTO_BangBaoGia dto)
		'{
		'    int i = 0;//THEM THANH CONG
		'    string query = "select ma_bao_gia from dm_bang_bao_gia where ma_bao_gia=@mbg";
		'    SqlParameter[] prsc = 
		'    {
		'        new SqlParameter("@mbg",dto.ma_bao_gia.Trim())
		'    };
		'    DataTable dt = data.ExcuteDataTable(query, prsc);
		'    if(dt!=null && dt.Rows.Count>0)
		'    {
		'        i = 1;//TRUNG ID
		'    }
		'    if (i == 0)
		'    {
		'        string sql = "insert into dm_bang_bao_gia(ma_bao_gia,mahopdong,tu_ngay,den_ngay,noi_nhan,noi_giao,don_gia_chuyen,don_gia_tan,ngay_tao,ngay_cap_nhat) values (@ma_bao_gia,@mahopdong,@tu_ngay,@den_ngay,@noi_nhan,@noi_giao,@don_gia_chuyen,@don_gia_tan,@ngay_tao,@ngay_cap_nhat)";
		'        SqlParameter[] prs = 
		'    {
		'        new SqlParameter("@ma_bao_gia",dto.ma_bao_gia.Trim()),
		'        new SqlParameter("@mahopdong",dto.ma_hop_dong.Trim()),
		'        new SqlParameter("@tu_ngay",dto.tu_ngay),
		'        new SqlParameter("@den_ngay",dto.den_ngay),
		'        new SqlParameter("@noi_nhan",dto.noi_nhan.Trim()),
		'        new SqlParameter("@noi_giao",dto.noi_giao.Trim()),
		'        new SqlParameter("@don_gia_chuyen",dto.don_gia_chuyen),
		'        new SqlParameter("@don_gia_tan",dto.don_gia_tan),
		'        new SqlParameter("@ngay_tao",dto.ngay_tao),
		'        new SqlParameter("@ngay_cap_nhat",dto.ngay_cap_nhat)

		'    };
		'        bool kq = data.ExcuteNonQuery(sql, prs);
		'        if (kq == false)
		'        {
		'            i = 2;// THEM THAT BAI
		'        }
		'    }
		'    return i;
		'}
		'public DTO_BangBaoGia[] _DS_ListView_BangBaoGia(DTO_BangBaoGia dto)
		'{
		'    string sql = "select dm_bang_bao_gia.* from dm_bang_bao_gia,dm_hop_dong  "
		'        + "where dm_bang_bao_gia.mahopdong=dm_hop_dong.ma_hop_dong "
		'        + "and ma_khach_hang=@mkh and ma_hop_dong=@mhd and dm_bang_bao_gia.tu_ngay>=dm_hop_dong.ngaybatdau and den_ngay<=ngayketthuc "
		'        + "order by dm_bang_bao_gia.ngay_tao desc,ngay_cap_nhat desc ";

		'    SqlParameter[] prs = 
		'    {
		'            new SqlParameter("@mkh",dto.ma_bao_gia.Trim()),
		'            new SqlParameter("@mhd",dto.ma_hop_dong.Trim())
		'    };
		'    DataTable dt = data.ExcuteDataTable(sql, prs);
		'    if (dt != null && dt.Rows.Count > 0)
		'    {
		'        DTO_BangBaoGia[] BaoGia = new DTO_BangBaoGia[dt.Rows.Count];
		'        for (int i = 0; i < dt.Rows.Count; i++)
		'        {
		'            BaoGia[i] = new DTO_BangBaoGia();
		'            BaoGia[i].ma_bao_gia = dt.Rows[i]["ma_bao_gia"].ToString();
		'            BaoGia[i].ma_hop_dong = dt.Rows[i]["mahopdong"].ToString();
		'            BaoGia[i].tu_ngay =Convert.ToDateTime(dt.Rows[i]["tu_ngay"].ToString());
		'            BaoGia[i].den_ngay=Convert.ToDateTime(dt.Rows[i]["den_ngay"].ToString());
		'            BaoGia[i].noi_nhan= dt.Rows[i]["noi_nhan"].ToString();
		'            BaoGia[i].noi_giao = dt.Rows[i]["noi_giao"].ToString();
		'            BaoGia[i].don_gia_chuyen =float.Parse(dt.Rows[i]["don_gia_chuyen"].ToString());
		'            BaoGia[i].don_gia_tan =float.Parse(dt.Rows[i]["don_gia_tan"].ToString());
		'            BaoGia[i].ngay_tao = Convert.ToDateTime(dt.Rows[i]["ngay_tao"].ToString());
		'            BaoGia[i].ngay_cap_nhat = Convert.ToDateTime(dt.Rows[i]["ngay_cap_nhat"].ToString());
		'        }
		'        return BaoGia;
		'    }
		'    return null;
		'}
		Public Function _DS_Date_ThoiGianHopDong(dto As DTO_HopDong) As DTO_HopDong()
			Dim sql As String = "select ngaybatdau,ngayketthuc from dm_hop_dong where ma_hop_dong=@mhd and ma_khach_hang=@mkh "
			Dim prs As SqlParameter() = {New SqlParameter("@mkh", dto.ma_khach_hang), New SqlParameter("@mhd", dto.ma_hop_dong)}
			Dim dt As DataTable = data.ExcuteDataTable(sql, prs)
			If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
				Dim HD As DTO_HopDong() = New DTO_HopDong(dt.Rows.Count - 1) {}
				For i As Integer = 0 To dt.Rows.Count - 1
					HD(i) = New DTO_HopDong()
					HD(i).ngay_bat_dau = Convert.ToDateTime(dt.Rows(i)("ngaybatdau").ToString())
					HD(i).ngay_ket_thuc = Convert.ToDateTime(dt.Rows(i)("ngayketthuc").ToString())
				Next
				Return HD
			End If
			Return Nothing
		End Function
		'public int _Xoa_BaoGia(DTO_BangBaoGia dto)
		'{
		'    int i = 0;
		'    string sql = "delete from dm_bang_bao_gia where ma_bao_gia=@mbg";
		'    SqlParameter[] prs = 
		'    {
		'        new SqlParameter("@mbg",dto.ma_bao_gia.Trim())

		'    };
		'    bool kq = data.ExcuteNonQuery(sql, prs);
		'    if (kq == false)
		'    {
		'        i = 1;// Xoa That Bai
		'    }
		'    return i;
		'}
		'public int _CapNhat_BaoGia(DTO_BangBaoGia dto)
		'{
		'    int i = 0;
		'    string sql = "update dm_bang_bao_gia set don_gia_chuyen=@dongiachuyen,don_gia_tan=@dongiatan,ngay_cap_nhat=@ngaycapnhat where ma_bao_gia=@mbg ";
		'    SqlParameter[] prs = 
		'    {
		'        new SqlParameter("@mbg",dto.ma_bao_gia.Trim()),
		'        new SqlParameter("@dongiachuyen",dto.don_gia_chuyen),
		'        new SqlParameter("@dongiatan",dto.don_gia_tan),
		'        new SqlParameter("@ngaycapnhat",DateTime.Now)

		'    };
		'    bool kq = data.ExcuteNonQuery(sql, prs);
		'    if (kq == false)
		'    {
		'        i = 1;// Update That Bai
		'    }
		'    return i;
		'}
		'public int _ApDungBaoGia_BangKe(DTO_HopDong hopdong,DTO_BangBaoGia baogia)
		'{
		'    int i = 0;
		'    try
		'    {
		'        string sql2 = "select * from dm_bang_bao_gia where ma_bao_gia=@mbg ";
		'        SqlParameter[] para2 = { 
		'                                new SqlParameter("@mbg",baogia.ma_bao_gia.Trim())
		'                           };
		'        DataTable Bang_Bao_Gia = data.ExcuteDataTable(sql2, para2);
		'        foreach (DataRow dr in Bang_Bao_Gia.Rows)
		'        {
		'            string sql1 = "select distinct ma_bang_ke "
		'                          + "from "
		'                          + "(select distinct * "
		'                          + "from  "
		'                          + "(select dm_bang_ke.* "
		'                          + "from dm_hop_dong,dm_bang_ke "
		'                          + "where dm_hop_dong.ma_khach_hang=dm_bang_ke.makhachhang "
		'                          + "and dm_bang_ke.makhachhang=@mkh "
		'                          + "and dm_hop_dong.ma_hop_dong=@mhd "
		'                          + "and ngay_van_chuyen>=ngaybatdau and ngay_van_chuyen<=ngayketthuc) as KQ "
		'                          + "where KQ.ngay_van_chuyen>=@tungay and KQ.ngay_van_chuyen <=@denngay) as QK "
		'                          + "where noi_nhan=N'" + dr["noi_nhan"].ToString() + "' and noi_giao=N'" + dr["noi_giao"].ToString() + "' "
		'                          ;
		'            SqlParameter[] para1 = 
		'                           { 
		'                                new SqlParameter("@mkh",hopdong.ma_khach_hang.Trim()),
		'                                new SqlParameter("@mhd",hopdong.ma_hop_dong.Trim()),
		'                                new SqlParameter("@tungay",Convert.ToDateTime(dr["tu_ngay"].ToString())),
		'                                new SqlParameter("@denngay",Convert.ToDateTime(dr["den_ngay"].ToString()))
		'                           };
		'            DataTable MaBangKe = data.ExcuteDataTable(sql1, para1);
		'            foreach (DataRow drin in MaBangKe.Rows)
		'            {
		'                string sql3 = "update dm_bang_ke set don_gia_chuyen=@dongiachuyen,don_gia_tan=@dongiatan where makhachhang=@mkh and ma_bang_ke=@mbk ";
		'                SqlParameter[] para3 = 
		'                           { 
		'                                new SqlParameter("@mkh",hopdong.ma_khach_hang.Trim()),
		'                                new SqlParameter("@mbk",drin["ma_bang_ke"].ToString()),
		'                                new SqlParameter("@dongiachuyen",dr["don_gia_chuyen"].ToString()),
		'                                new SqlParameter("@dongiatan",dr["don_gia_tan"].ToString())
		'                           };
		'                bool update = data.ExcuteNonQuery(sql3, para3);
		'                if (update == false)
		'                {
		'                    i = 1;
		'                }
		'            }
		'        }
		'    }
		'    catch (SqlException ex)
		'    {
		'        return i = 1;
		'    }
		'    return i;
		'}
	End Class
End Namespace
