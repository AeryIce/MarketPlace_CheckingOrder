<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.GBImport = New System.Windows.Forms.GroupBox()
		Me.BtImport = New System.Windows.Forms.Button()
		Me.BGAnalyze = New System.Windows.Forms.GroupBox()
		Me.BtAnalyze = New System.Windows.Forms.Button()
		Me.GBMother = New System.Windows.Forms.GroupBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.DGVBestDay = New System.Windows.Forms.DataGridView()
		Me.GBBestCustomer = New System.Windows.Forms.GroupBox()
		Me.DGVLoyalCust = New System.Windows.Forms.DataGridView()
		Me.GBKat = New System.Windows.Forms.GroupBox()
		Me.DGVBestKat = New System.Windows.Forms.DataGridView()
		Me.GBAuthor = New System.Windows.Forms.GroupBox()
		Me.DGVBestAuthor = New System.Windows.Forms.DataGridView()
		Me.GBBestSeller = New System.Windows.Forms.GroupBox()
		Me.DGVBestSeller = New System.Windows.Forms.DataGridView()
		Me.GBParameter = New System.Windows.Forms.GroupBox()
		Me.LbUntil = New System.Windows.Forms.Label()
		Me.LbEndMonth = New System.Windows.Forms.Label()
		Me.LbStartMonth = New System.Windows.Forms.Label()
		Me.CBEndMonthly = New System.Windows.Forms.ComboBox()
		Me.CBStartMonthly = New System.Windows.Forms.ComboBox()
		Me.CBMonthly = New System.Windows.Forms.ComboBox()
		Me.RBSpecific = New System.Windows.Forms.RadioButton()
		Me.RBMonthly = New System.Windows.Forms.RadioButton()
		Me.RBALL = New System.Windows.Forms.RadioButton()
		Me.LbTest = New System.Windows.Forms.Label()
		Me.GBImport.SuspendLayout()
		Me.BGAnalyze.SuspendLayout()
		Me.GBMother.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DGVBestDay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBBestCustomer.SuspendLayout()
		CType(Me.DGVLoyalCust, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBKat.SuspendLayout()
		CType(Me.DGVBestKat, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBAuthor.SuspendLayout()
		CType(Me.DGVBestAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBBestSeller.SuspendLayout()
		CType(Me.DGVBestSeller, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBParameter.SuspendLayout()
		Me.SuspendLayout()
		'
		'GBImport
		'
		Me.GBImport.Controls.Add(Me.BtImport)
		Me.GBImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GBImport.Location = New System.Drawing.Point(12, 12)
		Me.GBImport.Name = "GBImport"
		Me.GBImport.Size = New System.Drawing.Size(111, 128)
		Me.GBImport.TabIndex = 5
		Me.GBImport.TabStop = False
		Me.GBImport.Text = "Import Data"
		'
		'BtImport
		'
		Me.BtImport.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.database_import_64px
		Me.BtImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.BtImport.FlatAppearance.BorderSize = 0
		Me.BtImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtImport.Location = New System.Drawing.Point(17, 28)
		Me.BtImport.Name = "BtImport"
		Me.BtImport.Size = New System.Drawing.Size(83, 77)
		Me.BtImport.TabIndex = 3
		Me.BtImport.UseVisualStyleBackColor = True
		'
		'BGAnalyze
		'
		Me.BGAnalyze.Controls.Add(Me.BtAnalyze)
		Me.BGAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BGAnalyze.Location = New System.Drawing.Point(575, 12)
		Me.BGAnalyze.Name = "BGAnalyze"
		Me.BGAnalyze.Size = New System.Drawing.Size(102, 128)
		Me.BGAnalyze.TabIndex = 6
		Me.BGAnalyze.TabStop = False
		Me.BGAnalyze.Text = "Analyze"
		'
		'BtAnalyze
		'
		Me.BtAnalyze.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.learning_50px
		Me.BtAnalyze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.BtAnalyze.FlatAppearance.BorderSize = 0
		Me.BtAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtAnalyze.Location = New System.Drawing.Point(12, 29)
		Me.BtAnalyze.Name = "BtAnalyze"
		Me.BtAnalyze.Size = New System.Drawing.Size(83, 77)
		Me.BtAnalyze.TabIndex = 4
		Me.BtAnalyze.UseVisualStyleBackColor = True
		'
		'GBMother
		'
		Me.GBMother.Controls.Add(Me.GroupBox1)
		Me.GBMother.Controls.Add(Me.GBBestCustomer)
		Me.GBMother.Controls.Add(Me.GBKat)
		Me.GBMother.Controls.Add(Me.GBAuthor)
		Me.GBMother.Controls.Add(Me.GBBestSeller)
		Me.GBMother.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GBMother.Location = New System.Drawing.Point(12, 146)
		Me.GBMother.Name = "GBMother"
		Me.GBMother.Size = New System.Drawing.Size(665, 481)
		Me.GBMother.TabIndex = 7
		Me.GBMother.TabStop = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.DGVBestDay)
		Me.GroupBox1.Location = New System.Drawing.Point(330, 328)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(314, 148)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "BestDay"
		'
		'DGVBestDay
		'
		Me.DGVBestDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGVBestDay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.DGVBestDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVBestDay.Location = New System.Drawing.Point(6, 19)
		Me.DGVBestDay.Name = "DGVBestDay"
		Me.DGVBestDay.RowHeadersVisible = False
		Me.DGVBestDay.Size = New System.Drawing.Size(302, 123)
		Me.DGVBestDay.TabIndex = 0
		'
		'GBBestCustomer
		'
		Me.GBBestCustomer.Controls.Add(Me.DGVLoyalCust)
		Me.GBBestCustomer.Location = New System.Drawing.Point(12, 328)
		Me.GBBestCustomer.Name = "GBBestCustomer"
		Me.GBBestCustomer.Size = New System.Drawing.Size(306, 148)
		Me.GBBestCustomer.TabIndex = 2
		Me.GBBestCustomer.TabStop = False
		Me.GBBestCustomer.Text = "Best Customers"
		'
		'DGVLoyalCust
		'
		Me.DGVLoyalCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGVLoyalCust.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.DGVLoyalCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVLoyalCust.Location = New System.Drawing.Point(6, 19)
		Me.DGVLoyalCust.Name = "DGVLoyalCust"
		Me.DGVLoyalCust.RowHeadersVisible = False
		Me.DGVLoyalCust.Size = New System.Drawing.Size(278, 123)
		Me.DGVLoyalCust.TabIndex = 0
		'
		'GBKat
		'
		Me.GBKat.Controls.Add(Me.DGVBestKat)
		Me.GBKat.Location = New System.Drawing.Point(324, 174)
		Me.GBKat.Name = "GBKat"
		Me.GBKat.Size = New System.Drawing.Size(320, 148)
		Me.GBKat.TabIndex = 2
		Me.GBKat.TabStop = False
		Me.GBKat.Text = "Category Favorites"
		'
		'DGVBestKat
		'
		Me.DGVBestKat.AllowUserToAddRows = False
		Me.DGVBestKat.AllowUserToDeleteRows = False
		Me.DGVBestKat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGVBestKat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.DGVBestKat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVBestKat.Location = New System.Drawing.Point(6, 19)
		Me.DGVBestKat.Name = "DGVBestKat"
		Me.DGVBestKat.ReadOnly = True
		Me.DGVBestKat.RowHeadersVisible = False
		Me.DGVBestKat.Size = New System.Drawing.Size(308, 123)
		Me.DGVBestKat.TabIndex = 0
		'
		'GBAuthor
		'
		Me.GBAuthor.Controls.Add(Me.DGVBestAuthor)
		Me.GBAuthor.Location = New System.Drawing.Point(12, 174)
		Me.GBAuthor.Name = "GBAuthor"
		Me.GBAuthor.Size = New System.Drawing.Size(306, 148)
		Me.GBAuthor.TabIndex = 1
		Me.GBAuthor.TabStop = False
		Me.GBAuthor.Text = "Author Favorites"
		'
		'DGVBestAuthor
		'
		Me.DGVBestAuthor.AllowUserToAddRows = False
		Me.DGVBestAuthor.AllowUserToDeleteRows = False
		Me.DGVBestAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGVBestAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGVBestAuthor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.DGVBestAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVBestAuthor.Location = New System.Drawing.Point(6, 19)
		Me.DGVBestAuthor.Name = "DGVBestAuthor"
		Me.DGVBestAuthor.ReadOnly = True
		Me.DGVBestAuthor.RowHeadersVisible = False
		Me.DGVBestAuthor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.DGVBestAuthor.Size = New System.Drawing.Size(278, 123)
		Me.DGVBestAuthor.TabIndex = 0
		'
		'GBBestSeller
		'
		Me.GBBestSeller.Controls.Add(Me.DGVBestSeller)
		Me.GBBestSeller.Location = New System.Drawing.Point(12, 19)
		Me.GBBestSeller.Name = "GBBestSeller"
		Me.GBBestSeller.Size = New System.Drawing.Size(632, 149)
		Me.GBBestSeller.TabIndex = 0
		Me.GBBestSeller.TabStop = False
		Me.GBBestSeller.Text = "TOP25 BestSeller"
		'
		'DGVBestSeller
		'
		Me.DGVBestSeller.AllowUserToAddRows = False
		Me.DGVBestSeller.AllowUserToDeleteRows = False
		Me.DGVBestSeller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DGVBestSeller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGVBestSeller.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
		Me.DGVBestSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DGVBestSeller.DefaultCellStyle = DataGridViewCellStyle6
		Me.DGVBestSeller.GridColor = System.Drawing.Color.Black
		Me.DGVBestSeller.Location = New System.Drawing.Point(6, 19)
		Me.DGVBestSeller.Name = "DGVBestSeller"
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGVBestSeller.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.DGVBestSeller.RowHeadersVisible = False
		Me.DGVBestSeller.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.DGVBestSeller.Size = New System.Drawing.Size(620, 116)
		Me.DGVBestSeller.TabIndex = 0
		'
		'GBParameter
		'
		Me.GBParameter.Controls.Add(Me.LbTest)
		Me.GBParameter.Controls.Add(Me.LbUntil)
		Me.GBParameter.Controls.Add(Me.LbEndMonth)
		Me.GBParameter.Controls.Add(Me.LbStartMonth)
		Me.GBParameter.Controls.Add(Me.CBEndMonthly)
		Me.GBParameter.Controls.Add(Me.CBStartMonthly)
		Me.GBParameter.Controls.Add(Me.CBMonthly)
		Me.GBParameter.Controls.Add(Me.RBSpecific)
		Me.GBParameter.Controls.Add(Me.RBMonthly)
		Me.GBParameter.Controls.Add(Me.RBALL)
		Me.GBParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GBParameter.Location = New System.Drawing.Point(129, 20)
		Me.GBParameter.Name = "GBParameter"
		Me.GBParameter.Size = New System.Drawing.Size(440, 120)
		Me.GBParameter.TabIndex = 8
		Me.GBParameter.TabStop = False
		Me.GBParameter.Text = "Parameter"
		'
		'LbUntil
		'
		Me.LbUntil.AutoSize = True
		Me.LbUntil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbUntil.Location = New System.Drawing.Point(247, 70)
		Me.LbUntil.Name = "LbUntil"
		Me.LbUntil.Size = New System.Drawing.Size(21, 24)
		Me.LbUntil.TabIndex = 8
		Me.LbUntil.Text = "x"
		'
		'LbEndMonth
		'
		Me.LbEndMonth.AutoSize = True
		Me.LbEndMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbEndMonth.Location = New System.Drawing.Point(338, 93)
		Me.LbEndMonth.Name = "LbEndMonth"
		Me.LbEndMonth.Size = New System.Drawing.Size(16, 18)
		Me.LbEndMonth.TabIndex = 7
		Me.LbEndMonth.Text = "x"
		'
		'LbStartMonth
		'
		Me.LbStartMonth.AutoSize = True
		Me.LbStartMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbStartMonth.Location = New System.Drawing.Point(144, 93)
		Me.LbStartMonth.Name = "LbStartMonth"
		Me.LbStartMonth.Size = New System.Drawing.Size(16, 18)
		Me.LbStartMonth.TabIndex = 6
		Me.LbStartMonth.Text = "x"
		'
		'CBEndMonthly
		'
		Me.CBEndMonthly.FormattingEnabled = True
		Me.CBEndMonthly.Location = New System.Drawing.Point(287, 67)
		Me.CBEndMonthly.Name = "CBEndMonthly"
		Me.CBEndMonthly.Size = New System.Drawing.Size(121, 21)
		Me.CBEndMonthly.TabIndex = 5
		'
		'CBStartMonthly
		'
		Me.CBStartMonthly.FormattingEnabled = True
		Me.CBStartMonthly.Location = New System.Drawing.Point(97, 67)
		Me.CBStartMonthly.Name = "CBStartMonthly"
		Me.CBStartMonthly.Size = New System.Drawing.Size(121, 21)
		Me.CBStartMonthly.TabIndex = 4
		'
		'CBMonthly
		'
		Me.CBMonthly.FormattingEnabled = True
		Me.CBMonthly.Location = New System.Drawing.Point(97, 41)
		Me.CBMonthly.Name = "CBMonthly"
		Me.CBMonthly.Size = New System.Drawing.Size(121, 21)
		Me.CBMonthly.TabIndex = 3
		'
		'RBSpecific
		'
		Me.RBSpecific.AutoSize = True
		Me.RBSpecific.Location = New System.Drawing.Point(15, 65)
		Me.RBSpecific.Name = "RBSpecific"
		Me.RBSpecific.Size = New System.Drawing.Size(63, 17)
		Me.RBSpecific.TabIndex = 2
		Me.RBSpecific.TabStop = True
		Me.RBSpecific.Text = "Specific"
		Me.RBSpecific.UseVisualStyleBackColor = True
		'
		'RBMonthly
		'
		Me.RBMonthly.AutoSize = True
		Me.RBMonthly.Location = New System.Drawing.Point(15, 42)
		Me.RBMonthly.Name = "RBMonthly"
		Me.RBMonthly.Size = New System.Drawing.Size(62, 17)
		Me.RBMonthly.TabIndex = 1
		Me.RBMonthly.TabStop = True
		Me.RBMonthly.Text = "Monthly"
		Me.RBMonthly.UseVisualStyleBackColor = True
		'
		'RBALL
		'
		Me.RBALL.AutoSize = True
		Me.RBALL.Location = New System.Drawing.Point(15, 19)
		Me.RBALL.Name = "RBALL"
		Me.RBALL.Size = New System.Drawing.Size(36, 17)
		Me.RBALL.TabIndex = 0
		Me.RBALL.TabStop = True
		Me.RBALL.Text = "All"
		Me.RBALL.UseVisualStyleBackColor = True
		'
		'LbTest
		'
		Me.LbTest.AutoSize = True
		Me.LbTest.Location = New System.Drawing.Point(284, 41)
		Me.LbTest.Name = "LbTest"
		Me.LbTest.Size = New System.Drawing.Size(28, 13)
		Me.LbTest.TabIndex = 9
		Me.LbTest.Text = "Test"
		'
		'FormDashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightBlue
		Me.ClientSize = New System.Drawing.Size(696, 639)
		Me.Controls.Add(Me.GBParameter)
		Me.Controls.Add(Me.GBMother)
		Me.Controls.Add(Me.BGAnalyze)
		Me.Controls.Add(Me.GBImport)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormDashboard"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormDashboard"
		Me.GBImport.ResumeLayout(False)
		Me.BGAnalyze.ResumeLayout(False)
		Me.GBMother.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.DGVBestDay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBBestCustomer.ResumeLayout(False)
		CType(Me.DGVLoyalCust, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBKat.ResumeLayout(False)
		CType(Me.DGVBestKat, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBAuthor.ResumeLayout(False)
		CType(Me.DGVBestAuthor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBBestSeller.ResumeLayout(False)
		CType(Me.DGVBestSeller, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBParameter.ResumeLayout(False)
		Me.GBParameter.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents BtImport As Button
	Friend WithEvents BtAnalyze As Button
	Friend WithEvents GBImport As GroupBox
	Friend WithEvents BGAnalyze As GroupBox
	Friend WithEvents GBMother As GroupBox
	Friend WithEvents GBBestSeller As GroupBox
	Friend WithEvents GBAuthor As GroupBox
	Friend WithEvents DGVBestSeller As DataGridView
	Friend WithEvents GBKat As GroupBox
	Friend WithEvents DGVBestKat As DataGridView
	Friend WithEvents DGVBestAuthor As DataGridView
	Friend WithEvents GBParameter As GroupBox
	Friend WithEvents CBEndMonthly As ComboBox
	Friend WithEvents CBStartMonthly As ComboBox
	Friend WithEvents CBMonthly As ComboBox
	Friend WithEvents RBSpecific As RadioButton
	Friend WithEvents RBMonthly As RadioButton
	Friend WithEvents RBALL As RadioButton
	Public WithEvents LbEndMonth As Label
	Public WithEvents LbStartMonth As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents DGVBestDay As DataGridView
	Friend WithEvents GBBestCustomer As GroupBox
	Friend WithEvents DGVLoyalCust As DataGridView
	Public WithEvents LbUntil As Label
	Friend WithEvents LbTest As Label
End Class
