Namespace UC_TIMKIEM
	Partial Class uchopdong
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
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.btntruyvan = New System.Windows.Forms.Button()
			Me.txtmahopdong = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(97, 91)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 7
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' btntruyvan
			' 
			Me.btntruyvan.Location = New System.Drawing.Point(97, 62)
			Me.btntruyvan.Name = "btntruyvan"
			Me.btntruyvan.Size = New System.Drawing.Size(75, 23)
			Me.btntruyvan.TabIndex = 6
			Me.btntruyvan.Text = "Truy Vấn"
			Me.btntruyvan.UseVisualStyleBackColor = True
			AddHandler Me.btntruyvan.Click, New System.EventHandler(AddressOf Me.btntruyvan_Click)
			' 
			' txtmahopdong
			' 
			Me.txtmahopdong.Location = New System.Drawing.Point(22, 31)
			Me.txtmahopdong.MaxLength = 10
			Me.txtmahopdong.Name = "txtmahopdong"
			Me.txtmahopdong.Size = New System.Drawing.Size(248, 20)
			Me.txtmahopdong.TabIndex = 5
			AddHandler Me.txtmahopdong.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtmahoadon_KeyPress)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(11, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(109, 13)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Nhập Mã Hợp Đồng :"
			' 
			' uchopdong
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btntruyvan)
			Me.Controls.Add(Me.txtmahopdong)
			Me.Controls.Add(Me.label1)
			Me.Name = "uchopdong"
			Me.Size = New System.Drawing.Size(281, 127)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private btnthoat As System.Windows.Forms.Button
		Private btntruyvan As System.Windows.Forms.Button
		Private txtmahopdong As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace
