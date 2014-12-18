Namespace UI
	Partial Class frmTinhTrangXe
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
			Me.grv_ttxe = New System.Windows.Forms.DataGridView()
			Me.colUnitId = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.colUnitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.label1 = New System.Windows.Forms.Label()
			Me.txt_matt = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.txt_tentt = New System.Windows.Forms.TextBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.btn_thoat = New System.Windows.Forms.Button()
			Me.btn_luu = New System.Windows.Forms.Button()
			Me.btn_sua = New System.Windows.Forms.Button()
			Me.btn_xoa = New System.Windows.Forms.Button()
			Me.btn_them = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			DirectCast(Me.grv_ttxe, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' grv_ttxe
			' 
			Me.grv_ttxe.AllowUserToAddRows = False
			Me.grv_ttxe.AllowUserToDeleteRows = False
			Me.grv_ttxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.grv_ttxe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUnitId, Me.colUnitName})
			Me.grv_ttxe.Location = New System.Drawing.Point(29, 8)
			Me.grv_ttxe.MultiSelect = False
			Me.grv_ttxe.Name = "grv_ttxe"
			Me.grv_ttxe.[ReadOnly] = True
			Me.grv_ttxe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
			Me.grv_ttxe.Size = New System.Drawing.Size(319, 338)
			Me.grv_ttxe.TabIndex = 2
			AddHandler Me.grv_ttxe.CellClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.grv_ttxe_CellClick)
			' 
			' colUnitId
			' 
			Me.colUnitId.DataPropertyName = "ma_tinh_trang"
			Me.colUnitId.HeaderText = "Mã tình trang"
			Me.colUnitId.Name = "colUnitId"
			Me.colUnitId.[ReadOnly] = True
			' 
			' colUnitName
			' 
			Me.colUnitName.DataPropertyName = "ten_tinh_trang"
			Me.colUnitName.HeaderText = "Tên tình trạng"
			Me.colUnitName.Name = "colUnitName"
			Me.colUnitName.[ReadOnly] = True
			Me.colUnitName.Width = 110
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(6, 21)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(69, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Mã tình trạng"
			' 
			' txt_matt
			' 
			Me.txt_matt.Location = New System.Drawing.Point(96, 18)
			Me.txt_matt.Name = "txt_matt"
			Me.txt_matt.Size = New System.Drawing.Size(182, 20)
			Me.txt_matt.TabIndex = 0
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(6, 50)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(73, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Tên tình trạng"
			' 
			' txt_tentt
			' 
			Me.txt_tentt.Location = New System.Drawing.Point(96, 46)
			Me.txt_tentt.Name = "txt_tentt"
			Me.txt_tentt.Size = New System.Drawing.Size(182, 20)
			Me.txt_tentt.TabIndex = 1
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.btn_thoat)
			Me.groupBox2.Controls.Add(Me.btn_luu)
			Me.groupBox2.Controls.Add(Me.btn_sua)
			Me.groupBox2.Controls.Add(Me.btn_xoa)
			Me.groupBox2.Controls.Add(Me.btn_them)
			Me.groupBox2.Location = New System.Drawing.Point(7, 82)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(314, 41)
			Me.groupBox2.TabIndex = 4
			Me.groupBox2.TabStop = False
			' 
			' btn_thoat
			' 
			Me.btn_thoat.Location = New System.Drawing.Point(247, 12)
			Me.btn_thoat.Name = "btn_thoat"
			Me.btn_thoat.Size = New System.Drawing.Size(54, 23)
			Me.btn_thoat.TabIndex = 4
			Me.btn_thoat.Text = "Thoát"
			Me.btn_thoat.UseVisualStyleBackColor = True
			AddHandler Me.btn_thoat.Click, New System.EventHandler(AddressOf Me.btn_thoat_Click)
			' 
			' btn_luu
			' 
			Me.btn_luu.Location = New System.Drawing.Point(187, 12)
			Me.btn_luu.Name = "btn_luu"
			Me.btn_luu.Size = New System.Drawing.Size(54, 23)
			Me.btn_luu.TabIndex = 0
			Me.btn_luu.Text = "Lưu"
			Me.btn_luu.UseVisualStyleBackColor = True
			AddHandler Me.btn_luu.Click, New System.EventHandler(AddressOf Me.btn_luu_Click)
			' 
			' btn_sua
			' 
			Me.btn_sua.Location = New System.Drawing.Point(127, 12)
			Me.btn_sua.Name = "btn_sua"
			Me.btn_sua.Size = New System.Drawing.Size(54, 23)
			Me.btn_sua.TabIndex = 3
			Me.btn_sua.Text = "Sửa"
			Me.btn_sua.UseVisualStyleBackColor = True
			AddHandler Me.btn_sua.Click, New System.EventHandler(AddressOf Me.btn_sua_Click)
			' 
			' btn_xoa
			' 
			Me.btn_xoa.Location = New System.Drawing.Point(67, 12)
			Me.btn_xoa.Name = "btn_xoa"
			Me.btn_xoa.Size = New System.Drawing.Size(54, 23)
			Me.btn_xoa.TabIndex = 2
			Me.btn_xoa.Text = "Xóa"
			Me.btn_xoa.UseVisualStyleBackColor = True
			AddHandler Me.btn_xoa.Click, New System.EventHandler(AddressOf Me.btn_xoa_Click)
			' 
			' btn_them
			' 
			Me.btn_them.Location = New System.Drawing.Point(7, 12)
			Me.btn_them.Name = "btn_them"
			Me.btn_them.Size = New System.Drawing.Size(54, 23)
			Me.btn_them.TabIndex = 1
			Me.btn_them.Text = "Thêm"
			Me.btn_them.UseVisualStyleBackColor = True
			AddHandler Me.btn_them.Click, New System.EventHandler(AddressOf Me.btn_them_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.groupBox2)
			Me.groupBox1.Controls.Add(Me.txt_tentt)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.txt_matt)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Location = New System.Drawing.Point(384, 24)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(335, 157)
			Me.groupBox1.TabIndex = 3
			Me.groupBox1.TabStop = False
			' 
			' frmTinhTrangXe
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(755, 377)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.grv_ttxe)
			Me.Name = "frmTinhTrangXe"
			Me.Text = "frmTinhTrangXe"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmTinhTrangXe_Load)
			DirectCast(Me.grv_ttxe, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private grv_ttxe As System.Windows.Forms.DataGridView
		Private label1 As System.Windows.Forms.Label
		Private txt_matt As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private txt_tentt As System.Windows.Forms.TextBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private btn_thoat As System.Windows.Forms.Button
		Private btn_luu As System.Windows.Forms.Button
		Private btn_sua As System.Windows.Forms.Button
		Private btn_xoa As System.Windows.Forms.Button
		Private btn_them As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private colUnitId As System.Windows.Forms.DataGridViewTextBoxColumn
		Private colUnitName As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace
