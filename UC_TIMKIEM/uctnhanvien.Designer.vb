Namespace UC_TIMKIEM
	Partial Class uctnhanvien
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.txttenhanvien = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.txtmanhanvien = New System.Windows.Forms.TextBox()
			Me.btntruyvan = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 2)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(114, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Nhập Tên Nhân Viên :"
			' 
			' txttenhanvien
			' 
			Me.txttenhanvien.Location = New System.Drawing.Point(16, 25)
			Me.txttenhanvien.MaxLength = 50
			Me.txttenhanvien.Name = "txttenhanvien"
			Me.txttenhanvien.Size = New System.Drawing.Size(251, 20)
			Me.txttenhanvien.TabIndex = 1
			AddHandler Me.txttenhanvien.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txttenhanvien_KeyPress)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(7, 59)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(110, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Nhập Mã Nhân Viên :"
			' 
			' txtmanhanvien
			' 
			Me.txtmanhanvien.Location = New System.Drawing.Point(16, 84)
			Me.txtmanhanvien.MaxLength = 10
			Me.txtmanhanvien.Name = "txtmanhanvien"
			Me.txtmanhanvien.Size = New System.Drawing.Size(251, 20)
			Me.txtmanhanvien.TabIndex = 3
			AddHandler Me.txtmanhanvien.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtmanhanvien_KeyPress)
			' 
			' btntruyvan
			' 
			Me.btntruyvan.Location = New System.Drawing.Point(92, 120)
			Me.btntruyvan.Name = "btntruyvan"
			Me.btntruyvan.Size = New System.Drawing.Size(75, 23)
			Me.btntruyvan.TabIndex = 4
			Me.btntruyvan.Text = "Truy Vấn"
			Me.btntruyvan.UseVisualStyleBackColor = True
			AddHandler Me.btntruyvan.Click, New System.EventHandler(AddressOf Me.btntruyvan_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(92, 149)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 5
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' uctnhanvien
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btntruyvan)
			Me.Controls.Add(Me.txtmanhanvien)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txttenhanvien)
			Me.Controls.Add(Me.label1)
			Me.Name = "uctnhanvien"
			Me.Size = New System.Drawing.Size(281, 183)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txttenhanvien As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private txtmanhanvien As System.Windows.Forms.TextBox
		Private btntruyvan As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
	End Class
End Namespace
