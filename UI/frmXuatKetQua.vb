Imports Microsoft.Reporting.WinForms
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports QLDVVTHH.REPORT
Imports QLDVVTHH.BLL
Imports QLDVVTHH.DTO

Namespace UI
	Public Partial Class frmXuatKetQua
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Public strReport As String = ""
		Public strPrinter As String = ""
		Public bprint As Boolean = False
		Public bExport As Boolean = False
		Public typeExport As String = ""
		Public strDuongDan As String = ""
		Private m_currentPageIndex As Integer
		Private m_streams As IList(Of Stream)
		Private Sub frmXuatKetQua_Load(sender As Object, e As EventArgs)

			rpt.SetDisplayMode(DisplayMode.PrintLayout)
			rpt.ZoomMode = ZoomMode.PageWidth
			rpt.ZoomPercent = 100

			components = New Container()
			Dim datasource As New Microsoft.Reporting.WinForms.ReportDataSource()
			Me.rpt.LocalReport.ReportPath = Application.StartupPath & "\REPORT\" & strReport
			Dim ng As New REPORT.IN()
			Dim source As New BindingSource(Me.components)
			DirectCast(ng, ISupportInitialize).BeginInit()
			DirectCast(source, ISupportInitialize).BeginInit()
			source.DataSource = ng
			datasource.Name = "DataSet1"
			datasource.Value = source
			rpt.LocalReport.DataSources.Add(datasource)
			SetReportParameter(ng, source)
			DirectCast(source, ISupportInitialize).EndInit()
			DirectCast(ng, ISupportInitialize).EndInit()
			If bprint Then
				Print()
			ElseIf bExport Then
				Export()
			Else
				Me.rpt.RefreshReport()
			End If
		End Sub
		Private Sub Export()
			Dim bytes As Byte()
			If typeExport = "Xuất ra file Word" Then
					'typeExport = ".doc";
				bytes = rpt.LocalReport.Render("Word")
			ElseIf typeExport = "Xuất ra file Excel" Then
					'typeExport = ".xls";
				bytes = rpt.LocalReport.Render("Excel")
			Else
					'typeExport = ".pdf"; 
				bytes = rpt.LocalReport.Render("PDF")
			End If
			Dim fs As New FileStream(strDuongDan, FileMode.Create)
			fs.Write(bytes, 0, bytes.Length)
			fs.Close()
			Me.Close()
		End Sub

		Private Sub SetReportParameter(ia As [IN], source As BindingSource)

			Select Case strReport
				Case "rptkhachhang.rdlc"
					Dim ct As New REPORT.INTableAdapters.rpt_khachhangTableAdapter()
					ct.ClearBeforeFill = True
					source.DataMember = "rpt_khachhang"
					ct.Fill(ia.rpt_khachhang)
					Exit Select
				Case Else
					'case "rptnhanvien.rdlc":
					'    REPORT.INTableAdapters.rpt_nhanvienTableAdapter ct2 = new REPORT.INTableAdapters.rpt_nhanvienTableAdapter();
					'    ct2.ClearBeforeFill = true;
					'    source.DataMember = "rpt_nhanvien";
					'    ct2.Fill(ia.rpt_nhanvien);
					'    break;
					'case "rptxe.rdlc":
					'    REPORT.INTableAdapters.rpt_xeTableAdapter ct3 = new REPORT.INTableAdapters.rpt_xeTableAdapter();
					'    ct3.ClearBeforeFill = true;
					'    source.DataMember = "rpt_xe";
					'    ct3.Fill(ia.rpt_xe);
					'    break;
					'case "rpthoadon.rdlc":
					'    REPORT.INTableAdapters.rpt_hoadonTableAdapter ct4 = new REPORT.INTableAdapters.rpt_hoadonTableAdapter();
					'    ct4.ClearBeforeFill = true;
					'    source.DataMember = "rpt_hoadon";
					'    ct4.Fill(ia.rpt_hoadon);
					'    break;
					Exit Select
			End Select
		End Sub

		Private Function CreateStream(name As String, fileNameExtension As String, encoding As Encoding, mimeType As String, willSeek As Boolean) As Stream
			Dim stream As Stream = New MemoryStream()
			m_streams.Add(stream)
			Return stream
		End Function

		Private Sub PrintPage(sender As Object, ev As PrintPageEventArgs)
			Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

			Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(Math.Truncate(ev.PageSettings.HardMarginX)), ev.PageBounds.Top - CInt(Math.Truncate(ev.PageSettings.HardMarginY)), ev.PageBounds.Width, ev.PageBounds.Height)

			ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

			ev.Graphics.DrawImage(pageImage, adjustedRect)

			m_currentPageIndex += 1
			ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
		End Sub

		Private Sub Print()
			Dim deviceInfo As String = "<DeviceInfo><OutputFormat>EMF</OutputFormat>" & vbCr & vbLf & "            </DeviceInfo>"
			Dim warnings As Warning()
			m_streams = New List(Of Stream)()
			rpt.LocalReport.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
			For Each stream As Stream In m_streams
				stream.Position = 0
			Next
			If m_streams Is Nothing OrElse m_streams.Count = 0 Then
				MessageBox.Show("Error: no stream to print.")
			End If
			Dim printDoc As New PrintDocument()
			If Not printDoc.PrinterSettings.IsValid Then
				MessageBox.Show("Error: cannot find the default printer.")
			Else
				printDoc.PrinterSettings.PrinterName = strPrinter
				AddHandler printDoc.PrintPage, New PrintPageEventHandler(AddressOf PrintPage)
				m_currentPageIndex = 0
				printDoc.Print()
			End If
			If m_streams IsNot Nothing Then
				For Each stream As Stream In m_streams
					stream.Close()
				Next
				m_streams = Nothing
			End If
			Me.Close()
		End Sub
	End Class
End Namespace
