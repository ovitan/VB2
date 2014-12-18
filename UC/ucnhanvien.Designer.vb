Namespace UC
	Partial Class ucnhanvien
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
			Me.btnxuat = New System.Windows.Forms.Button()
			Me.btnthoat = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnxuat
			' 
			Me.btnxuat.Location = New System.Drawing.Point(14, 5)
			Me.btnxuat.Name = "btnxuat"
			Me.btnxuat.Size = New System.Drawing.Size(75, 23)
			Me.btnxuat.TabIndex = 0
			Me.btnxuat.Text = "Xuất"
			Me.btnxuat.UseVisualStyleBackColor = True
			AddHandler Me.btnxuat.Click, New System.EventHandler(AddressOf Me.btnxuat_Click)
			' 
			' btnthoat
			' 
			Me.btnthoat.Location = New System.Drawing.Point(108, 4)
			Me.btnthoat.Name = "btnthoat"
			Me.btnthoat.Size = New System.Drawing.Size(75, 23)
			Me.btnthoat.TabIndex = 1
			Me.btnthoat.Text = "Thoát"
			Me.btnthoat.UseVisualStyleBackColor = True
			AddHandler Me.btnthoat.Click, New System.EventHandler(AddressOf Me.btnthoat_Click)
			' 
			' ucnhanvien
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnthoat)
			Me.Controls.Add(Me.btnxuat)
			Me.Name = "ucnhanvien"
			Me.Size = New System.Drawing.Size(197, 33)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private btnxuat As System.Windows.Forms.Button
		Private btnthoat As System.Windows.Forms.Button
	End Class
End Namespace
