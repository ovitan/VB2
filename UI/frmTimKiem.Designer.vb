Namespace UI
	Partial Class frmTimKiem
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private m_components As System.ComponentModel.IContainer = Nothing

		Public Property Components() As System.ComponentModel.IContainer
			Get
				Return m_components
			End Get
			Set
				m_components = value
			End Set
		End Property
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		'protected override void Dispose(bool disposing)
		'{
		'    if (disposing && (components != null))
		'    {
		'        components.Dispose();
		'    }
		'    base.Dispose(disposing);
		'}

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.button1 = New System.Windows.Forms.Button()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' Column2
			' 
			Me.Column2.HeaderText = "Mã Khách Hàng"
			Me.Column2.Name = "Column2"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(76, 219)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 10
			Me.button1.Text = "Tìm Kiếm"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' Column3
			' 
			Me.Column3.HeaderText = "Mã Hợp Đồng"
			Me.Column3.Name = "Column3"
			' 
			' Column1
			' 
			Me.Column1.HeaderText = "Số Hóa Đơn"
			Me.Column1.Name = "Column1"
			' 
			' Column4
			' 
			Me.Column4.HeaderText = "Ngày Xuất"
			Me.Column4.Name = "Column4"
			' 
			' Column7
			' 
			Me.Column7.HeaderText = "Tổng cộng"
			Me.Column7.Name = "Column7"
			' 
			' Column5
			' 
			Me.Column5.HeaderText = "Tổng Cước"
			Me.Column5.Name = "Column5"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, _
				Me.Column7})
			Me.dataGridView1.Location = New System.Drawing.Point(9, 16)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(754, 84)
			Me.dataGridView1.TabIndex = 0
			' 
			' Column6
			' 
			Me.Column6.HeaderText = "Thuế"
			Me.Column6.Name = "Column6"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(115, 76)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(100, 20)
			Me.textBox1.TabIndex = 4
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.dataGridView1)
			Me.groupBox2.Location = New System.Drawing.Point(42, 258)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(784, 135)
			Me.groupBox2.TabIndex = 9
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Hóa Đơn"
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.Controls.Add(Me.dateTimePicker1)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.Controls.Add(Me.label4)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Location = New System.Drawing.Point(42, 87)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(784, 126)
			Me.groupBox1.TabIndex = 8
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Tìm theo"
			' 
			' dateTimePicker1
			' 
			Me.dateTimePicker1.Location = New System.Drawing.Point(115, 46)
			Me.dateTimePicker1.Name = "dateTimePicker1"
			Me.dateTimePicker1.Size = New System.Drawing.Size(200, 20)
			Me.dateTimePicker1.TabIndex = 2
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(115, 13)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.TabIndex = 3
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(6, 83)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(66, 13)
			Me.label4.TabIndex = 2
			Me.label4.Text = "Số Hóa Đơn"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(6, 46)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(103, 13)
			Me.label3.TabIndex = 1
			Me.label3.Text = "Ngày Xuất Hóa Đơn"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(3, 16)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(67, 13)
			Me.label2.TabIndex = 0
			Me.label2.Text = "Khách Hàng"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.label1.Location = New System.Drawing.Point(233, 47)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(304, 37)
			Me.label1.TabIndex = 7
			Me.label1.Text = "Tìm Kiếm Hóa Đơn"
			' 
			' frmTimKiem
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(868, 440)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.label1)
			Me.MaximizeBox = False
			Me.Name = "frmTimKiem"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "TRƯU CỨU THÔNG TIN"
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private button1 As System.Windows.Forms.Button
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private textBox1 As System.Windows.Forms.TextBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label

	End Class
End Namespace
