Namespace UC_TIMKIEM
	Partial Class ucthoadon
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
			Me.txtmahoadon = New System.Windows.Forms.TextBox()
			Me.btntruyvan = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(5, 11)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(103, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Nhập Mã Hóa Đơn :"
			' 
			' txtmahoadon
			' 
			Me.txtmahoadon.Location = New System.Drawing.Point(16, 29)
			Me.txtmahoadon.MaxLength = 10
			Me.txtmahoadon.Name = "txtmahoadon"
			Me.txtmahoadon.Size = New System.Drawing.Size(248, 20)
			Me.txtmahoadon.TabIndex = 1
			AddHandler Me.txtmahoadon.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtmahoadon_KeyPress)
			' 
			' btntruyvan
			' 
			Me.btntruyvan.Location = New System.Drawing.Point(91, 60)
			Me.btntruyvan.Name = "btntruyvan"
			Me.btntruyvan.Size = New System.Drawing.Size(75, 23)
			Me.btntruyvan.TabIndex = 2
			Me.btntruyvan.Text = "Truy Vấn"
			Me.btntruyvan.UseVisualStyleBackColor = True
			AddHandler Me.btntruyvan.Click, New System.EventHandler(AddressOf Me.btntruyvan_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(91, 89)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 3
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' ucthoadon
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btntruyvan)
			Me.Controls.Add(Me.txtmahoadon)
			Me.Controls.Add(Me.label1)
			Me.Name = "ucthoadon"
			Me.Size = New System.Drawing.Size(281, 127)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txtmahoadon As System.Windows.Forms.TextBox
		Private btntruyvan As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
	End Class
End Namespace
