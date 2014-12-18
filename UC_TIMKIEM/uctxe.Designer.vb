Namespace UC_TIMKIEM
	Partial Class uctxe
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
			Me.txtmasoxe = New System.Windows.Forms.TextBox()
			Me.btntruyvan = New System.Windows.Forms.Button()
			Me.Thoát = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(5, 12)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(89, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Nhập Mã Số Xe :"
			' 
			' txtmasoxe
			' 
			Me.txtmasoxe.Location = New System.Drawing.Point(16, 30)
			Me.txtmasoxe.MaxLength = 10
			Me.txtmasoxe.Name = "txtmasoxe"
			Me.txtmasoxe.Size = New System.Drawing.Size(252, 20)
			Me.txtmasoxe.TabIndex = 1
			AddHandler Me.txtmasoxe.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtmasoxe_KeyPress)
			' 
			' btntruyvan
			' 
			Me.btntruyvan.Location = New System.Drawing.Point(89, 63)
			Me.btntruyvan.Name = "btntruyvan"
			Me.btntruyvan.Size = New System.Drawing.Size(75, 23)
			Me.btntruyvan.TabIndex = 2
			Me.btntruyvan.Text = "Truy Vấn"
			Me.btntruyvan.UseVisualStyleBackColor = True
			AddHandler Me.btntruyvan.Click, New System.EventHandler(AddressOf Me.btntruyvan_Click)
			' 
			' Thoát
			' 
			Me.Thoát.Location = New System.Drawing.Point(89, 92)
			Me.Thoát.Name = "Thoát"
			Me.Thoát.Size = New System.Drawing.Size(75, 23)
			Me.Thoát.TabIndex = 3
			Me.Thoát.Text = "Thoát"
			Me.Thoát.UseVisualStyleBackColor = True
			AddHandler Me.Thoát.Click, New System.EventHandler(AddressOf Me.Thoát_Click)
			' 
			' uctxe
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.Thoát)
			Me.Controls.Add(Me.btntruyvan)
			Me.Controls.Add(Me.txtmasoxe)
			Me.Controls.Add(Me.label1)
			Me.Name = "uctxe"
			Me.Size = New System.Drawing.Size(281, 127)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txtmasoxe As System.Windows.Forms.TextBox
		Private btntruyvan As System.Windows.Forms.Button
		Private Thoát As System.Windows.Forms.Button
	End Class
End Namespace
