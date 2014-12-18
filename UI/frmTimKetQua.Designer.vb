Namespace UI
	Partial Class frmTimKetQua
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
			Me.lvthongtintimkiem = New System.Windows.Forms.ListView()
			Me.SuspendLayout()
			' 
			' lvthongtintimkiem
			' 
			Me.lvthongtintimkiem.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lvthongtintimkiem.FullRowSelect = True
			Me.lvthongtintimkiem.GridLines = True
			Me.lvthongtintimkiem.Location = New System.Drawing.Point(0, 0)
			Me.lvthongtintimkiem.MultiSelect = False
			Me.lvthongtintimkiem.Name = "lvthongtintimkiem"
			Me.lvthongtintimkiem.Size = New System.Drawing.Size(1008, 632)
			Me.lvthongtintimkiem.TabIndex = 0
			Me.lvthongtintimkiem.UseCompatibleStateImageBehavior = False
			Me.lvthongtintimkiem.View = System.Windows.Forms.View.Details
			' 
			' frmTimKetQua
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 632)
			Me.Controls.Add(Me.lvthongtintimkiem)
			Me.Location = New System.Drawing.Point(305, 0)
			Me.Name = "frmTimKetQua"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "KẾT QUẢ TRA CỨU"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmTimKetQua_Load)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lvthongtintimkiem As System.Windows.Forms.ListView
	End Class
End Namespace
