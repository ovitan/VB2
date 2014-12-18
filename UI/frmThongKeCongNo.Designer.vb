Namespace UI
	Partial Class frmThongKeCongNo
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.lvthongkecongno = New System.Windows.Forms.ListView()
			Me.c1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c2 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c3 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c33 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c4 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c5 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c6 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.c7 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(361, 4)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(225, 24)
			Me.label1.TabIndex = 5
			Me.label1.Text = "THỐNG KÊ CÔNG NỢ"
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(921, 605)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 6
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' lvthongkecongno
			' 
			Me.lvthongkecongno.Activation = System.Windows.Forms.ItemActivation.OneClick
			Me.lvthongkecongno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.c1, Me.c2, Me.c3, Me.c33, Me.c4, Me.c5, _
				Me.c6, Me.c7})
			Me.lvthongkecongno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lvthongkecongno.FullRowSelect = True
			Me.lvthongkecongno.GridLines = True
			Me.lvthongkecongno.HoverSelection = True
			Me.lvthongkecongno.Location = New System.Drawing.Point(0, 30)
			Me.lvthongkecongno.MultiSelect = False
			Me.lvthongkecongno.Name = "lvthongkecongno"
			Me.lvthongkecongno.ShowItemToolTips = True
			Me.lvthongkecongno.Size = New System.Drawing.Size(1008, 569)
			Me.lvthongkecongno.Sorting = System.Windows.Forms.SortOrder.Descending
			Me.lvthongkecongno.TabIndex = 4
			Me.lvthongkecongno.UseCompatibleStateImageBehavior = False
			Me.lvthongkecongno.View = System.Windows.Forms.View.Details
			Me.lvthongkecongno.VirtualListSize = 100000
			' 
			' c1
			' 
			Me.c1.Text = "STT"
			Me.c1.Width = 67
			' 
			' c2
			' 
			Me.c2.Text = "Mã Khách Hàng"
			Me.c2.Width = 108
			' 
			' c3
			' 
			Me.c3.Text = "Thông Tin Khách Hàng"
			Me.c3.Width = 204
			' 
			' c33
			' 
			Me.c33.Text = "Mã Hợp Đồng"
			Me.c33.Width = 98
			' 
			' c4
			' 
			Me.c4.Text = "Tổng  Nợ"
			Me.c4.Width = 138
			' 
			' c5
			' 
			Me.c5.Text = "Tổng Số Tiền Đã Trả"
			Me.c5.Width = 153
			' 
			' c6
			' 
			Me.c6.Text = "Số Tiền Còn Lại"
			Me.c6.Width = 132
			' 
			' c7
			' 
			Me.c7.Text = "Đơn Vị"
			Me.c7.Width = 110
			' 
			' frmThongKeCongNo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.lvthongkecongno)
			Me.Name = "frmThongKeCongNo"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "THỐNG KÊ CÔNG NỢ"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmThongKeCongNo_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private c1 As System.Windows.Forms.ColumnHeader
		Private c2 As System.Windows.Forms.ColumnHeader
		Private c3 As System.Windows.Forms.ColumnHeader
		Private c4 As System.Windows.Forms.ColumnHeader
		Private c5 As System.Windows.Forms.ColumnHeader
		Private c6 As System.Windows.Forms.ColumnHeader
		Private c7 As System.Windows.Forms.ColumnHeader
		Private c33 As System.Windows.Forms.ColumnHeader
		Private label1 As System.Windows.Forms.Label
		Private btnthoat As System.Windows.Forms.Button
		Private lvthongkecongno As System.Windows.Forms.ListView
	End Class
End Namespace
