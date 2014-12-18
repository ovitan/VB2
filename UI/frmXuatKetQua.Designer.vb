Namespace UI
	Partial Class frmXuatKetQua
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.rpt = New Microsoft.Reporting.WinForms.ReportViewer()
			Me.SuspendLayout()
			' 
			' rpt
			' 
			Me.rpt.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rpt.Location = New System.Drawing.Point(0, 0)
			Me.rpt.Name = "rpt"
			Me.rpt.Size = New System.Drawing.Size(1008, 632)
			Me.rpt.TabIndex = 0
			' 
			' frmXuatKetQua
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.rpt)
			Me.Location = New System.Drawing.Point(250, 0)
			Me.Name = "frmXuatKetQua"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "KẾT QUẢ"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmXuatKetQua_Load)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private rpt As Microsoft.Reporting.WinForms.ReportViewer
	End Class
End Namespace
