Namespace UI
	Partial Class frmInAn
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
			Me.cbdanhmuc = New System.Windows.Forms.ComboBox()
			Me.pndanhmuc = New System.Windows.Forms.Panel()
			Me.pncontrol = New System.Windows.Forms.Panel()
			Me.pndanhmuc.SuspendLayout()
			Me.SuspendLayout()
			' 
			' cbdanhmuc
			' 
			Me.cbdanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbdanhmuc.FormattingEnabled = True
			Me.cbdanhmuc.Location = New System.Drawing.Point(2, 3)
			Me.cbdanhmuc.Name = "cbdanhmuc"
			Me.cbdanhmuc.Size = New System.Drawing.Size(193, 21)
			Me.cbdanhmuc.TabIndex = 1
			AddHandler Me.cbdanhmuc.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbdanhmuc_SelectedIndexChanged)
			' 
			' pndanhmuc
			' 
			Me.pndanhmuc.Controls.Add(Me.cbdanhmuc)
			Me.pndanhmuc.Location = New System.Drawing.Point(0, 0)
			Me.pndanhmuc.Name = "pndanhmuc"
			Me.pndanhmuc.Size = New System.Drawing.Size(197, 27)
			Me.pndanhmuc.TabIndex = 2
			' 
			' pncontrol
			' 
			Me.pncontrol.Location = New System.Drawing.Point(0, 28)
			Me.pncontrol.Name = "pncontrol"
			Me.pncontrol.Size = New System.Drawing.Size(197, 187)
			Me.pncontrol.TabIndex = 3
			' 
			' frmInAn
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(198, 219)
			Me.Controls.Add(Me.pncontrol)
			Me.Controls.Add(Me.pndanhmuc)
			Me.MaximizeBox = False
			Me.Name = "frmInAn"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "IN ẤN"
			Me.pndanhmuc.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cbdanhmuc As System.Windows.Forms.ComboBox
		Private pndanhmuc As System.Windows.Forms.Panel
		Private pncontrol As System.Windows.Forms.Panel
	End Class
End Namespace
