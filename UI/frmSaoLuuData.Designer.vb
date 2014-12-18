Namespace UI
	Partial Class frmSaoLuuData
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
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.btnluu = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(143, 148)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 3
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' btnluu
			' 
			Me.btnluu.Location = New System.Drawing.Point(139, 19)
			Me.btnluu.Name = "btnluu"
			Me.btnluu.Size = New System.Drawing.Size(75, 23)
			Me.btnluu.TabIndex = 4
			Me.btnluu.Text = "Sao Lưu"
			Me.btnluu.UseVisualStyleBackColor = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.btnluu)
			Me.groupBox1.Location = New System.Drawing.Point(2, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(352, 53)
			Me.groupBox1.TabIndex = 5
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Sao Lưu Cơ Sở Dữ Liệu"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.button1)
			Me.groupBox2.Location = New System.Drawing.Point(2, 69)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(352, 62)
			Me.groupBox2.TabIndex = 6
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Phục Hồi Cơ Sở Dữ Liệu"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(140, 23)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 4
			Me.button1.Text = "Phục Hồi"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' frmSaoLuuData
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(355, 187)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.btnthoat)
			Me.MaximizeBox = False
			Me.Name = "frmSaoLuuData"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "SAO LƯU DỮ LIỆU PHẦN MỀM"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private btnthoat As System.Windows.Forms.Button
		Private btnluu As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private button1 As System.Windows.Forms.Button


	End Class
End Namespace
