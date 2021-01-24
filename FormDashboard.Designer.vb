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
		Me.components = New System.ComponentModel.Container()
		Me.GBPerformance = New System.Windows.Forms.GroupBox()
		Me.TLPSUmmary = New System.Windows.Forms.TableLayoutPanel()
		Me.PnSalesToday = New System.Windows.Forms.Panel()
		Me.LbNominalSales = New System.Windows.Forms.Label()
		Me.LbSales = New System.Windows.Forms.Label()
		Me.PnProcessToday = New System.Windows.Forms.Panel()
		Me.LbJmlDiproses = New System.Windows.Forms.Label()
		Me.LbDiproses = New System.Windows.Forms.Label()
		Me.PnLastSales = New System.Windows.Forms.Panel()
		Me.LbNominalLastSales = New System.Windows.Forms.Label()
		Me.LbTglLastSales = New System.Windows.Forms.Label()
		Me.LbLastSales = New System.Windows.Forms.Label()
		Me.PnOrderToday = New System.Windows.Forms.Panel()
		Me.LbPesanan = New System.Windows.Forms.Label()
		Me.LbOrderToday = New System.Windows.Forms.Label()
		Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.DGVDone = New System.Windows.Forms.DataGridView()
		Me.MPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InvoiceOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ResiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TanggalSeleseiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MPCheckingOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.INVDataSet = New MarketPlace_CheckingOrder.INVDataSet()
		Me.MP_CheckingOrderTableAdapter = New MarketPlace_CheckingOrder.INVDataSetTableAdapters.MP_CheckingOrderTableAdapter()
		Me.GBPerformance.SuspendLayout()
		Me.TLPSUmmary.SuspendLayout()
		Me.PnSalesToday.SuspendLayout()
		Me.PnProcessToday.SuspendLayout()
		Me.PnLastSales.SuspendLayout()
		Me.PnOrderToday.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DGVDone, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MPCheckingOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GBPerformance
		'
		Me.GBPerformance.Controls.Add(Me.TLPSUmmary)
		Me.GBPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GBPerformance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GBPerformance.Location = New System.Drawing.Point(12, 4)
		Me.GBPerformance.Name = "GBPerformance"
		Me.GBPerformance.Size = New System.Drawing.Size(507, 181)
		Me.GBPerformance.TabIndex = 0
		Me.GBPerformance.TabStop = False
		Me.GBPerformance.Text = "Summary"
		'
		'TLPSUmmary
		'
		Me.TLPSUmmary.BackColor = System.Drawing.Color.Transparent
		Me.TLPSUmmary.ColumnCount = 4
		Me.TLPSUmmary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TLPSUmmary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TLPSUmmary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TLPSUmmary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TLPSUmmary.Controls.Add(Me.PnSalesToday, 3, 0)
		Me.TLPSUmmary.Controls.Add(Me.PnProcessToday, 2, 0)
		Me.TLPSUmmary.Controls.Add(Me.PnLastSales, 0, 0)
		Me.TLPSUmmary.Controls.Add(Me.PnOrderToday, 1, 0)
		Me.TLPSUmmary.Location = New System.Drawing.Point(6, 19)
		Me.TLPSUmmary.Name = "TLPSUmmary"
		Me.TLPSUmmary.RowCount = 1
		Me.TLPSUmmary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLPSUmmary.Size = New System.Drawing.Size(490, 151)
		Me.TLPSUmmary.TabIndex = 0
		'
		'PnSalesToday
		'
		Me.PnSalesToday.BackColor = System.Drawing.Color.Green
		Me.PnSalesToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnSalesToday.Controls.Add(Me.LbNominalSales)
		Me.PnSalesToday.Controls.Add(Me.LbSales)
		Me.PnSalesToday.Location = New System.Drawing.Point(369, 3)
		Me.PnSalesToday.Name = "PnSalesToday"
		Me.PnSalesToday.Size = New System.Drawing.Size(116, 145)
		Me.PnSalesToday.TabIndex = 3
		'
		'LbNominalSales
		'
		Me.LbNominalSales.AutoSize = True
		Me.LbNominalSales.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbNominalSales.Location = New System.Drawing.Point(3, 84)
		Me.LbNominalSales.Name = "LbNominalSales"
		Me.LbNominalSales.Size = New System.Drawing.Size(124, 19)
		Me.LbNominalSales.TabIndex = 8
		Me.LbNominalSales.Text = "Nominal Sales"
		'
		'LbSales
		'
		Me.LbSales.AutoSize = True
		Me.LbSales.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbSales.Location = New System.Drawing.Point(17, 8)
		Me.LbSales.Name = "LbSales"
		Me.LbSales.Size = New System.Drawing.Size(52, 19)
		Me.LbSales.TabIndex = 7
		Me.LbSales.Text = "Sales"
		'
		'PnProcessToday
		'
		Me.PnProcessToday.BackColor = System.Drawing.Color.Blue
		Me.PnProcessToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnProcessToday.Controls.Add(Me.LbJmlDiproses)
		Me.PnProcessToday.Controls.Add(Me.LbDiproses)
		Me.PnProcessToday.Location = New System.Drawing.Point(247, 3)
		Me.PnProcessToday.Name = "PnProcessToday"
		Me.PnProcessToday.Size = New System.Drawing.Size(116, 145)
		Me.PnProcessToday.TabIndex = 2
		'
		'LbJmlDiproses
		'
		Me.LbJmlDiproses.AutoSize = True
		Me.LbJmlDiproses.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbJmlDiproses.Location = New System.Drawing.Point(5, 84)
		Me.LbJmlDiproses.Name = "LbJmlDiproses"
		Me.LbJmlDiproses.Size = New System.Drawing.Size(114, 19)
		Me.LbJmlDiproses.TabIndex = 6
		Me.LbJmlDiproses.Text = "Sdh Diproses"
		'
		'LbDiproses
		'
		Me.LbDiproses.AutoSize = True
		Me.LbDiproses.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbDiproses.Location = New System.Drawing.Point(14, 8)
		Me.LbDiproses.Name = "LbDiproses"
		Me.LbDiproses.Size = New System.Drawing.Size(79, 19)
		Me.LbDiproses.TabIndex = 5
		Me.LbDiproses.Text = "Diproses"
		'
		'PnLastSales
		'
		Me.PnLastSales.BackColor = System.Drawing.Color.Yellow
		Me.PnLastSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnLastSales.Controls.Add(Me.LbNominalLastSales)
		Me.PnLastSales.Controls.Add(Me.LbTglLastSales)
		Me.PnLastSales.Controls.Add(Me.LbLastSales)
		Me.PnLastSales.Location = New System.Drawing.Point(3, 3)
		Me.PnLastSales.Name = "PnLastSales"
		Me.PnLastSales.Size = New System.Drawing.Size(116, 145)
		Me.PnLastSales.TabIndex = 0
		'
		'LbNominalLastSales
		'
		Me.LbNominalLastSales.AutoSize = True
		Me.LbNominalLastSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbNominalLastSales.Location = New System.Drawing.Point(-2, 80)
		Me.LbNominalLastSales.Name = "LbNominalLastSales"
		Me.LbNominalLastSales.Size = New System.Drawing.Size(97, 25)
		Me.LbNominalLastSales.TabIndex = 3
		Me.LbNominalLastSales.Text = "Nominal"
		'
		'LbTglLastSales
		'
		Me.LbTglLastSales.AutoSize = True
		Me.LbTglLastSales.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbTglLastSales.Location = New System.Drawing.Point(15, 26)
		Me.LbTglLastSales.Name = "LbTglLastSales"
		Me.LbTglLastSales.Size = New System.Drawing.Size(78, 18)
		Me.LbTglLastSales.TabIndex = 3
		Me.LbTglLastSales.Text = "tgl kemaren"
		'
		'LbLastSales
		'
		Me.LbLastSales.AutoSize = True
		Me.LbLastSales.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbLastSales.Location = New System.Drawing.Point(11, 8)
		Me.LbLastSales.Name = "LbLastSales"
		Me.LbLastSales.Size = New System.Drawing.Size(91, 19)
		Me.LbLastSales.TabIndex = 3
		Me.LbLastSales.Text = "Last Sales"
		'
		'PnOrderToday
		'
		Me.PnOrderToday.BackColor = System.Drawing.Color.Red
		Me.PnOrderToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnOrderToday.Controls.Add(Me.LbPesanan)
		Me.PnOrderToday.Controls.Add(Me.LbOrderToday)
		Me.PnOrderToday.Location = New System.Drawing.Point(125, 3)
		Me.PnOrderToday.Name = "PnOrderToday"
		Me.PnOrderToday.Size = New System.Drawing.Size(116, 145)
		Me.PnOrderToday.TabIndex = 1
		'
		'LbPesanan
		'
		Me.LbPesanan.AutoSize = True
		Me.LbPesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbPesanan.Location = New System.Drawing.Point(-6, 80)
		Me.LbPesanan.Name = "LbPesanan"
		Me.LbPesanan.Size = New System.Drawing.Size(147, 25)
		Me.LbPesanan.TabIndex = 4
		Me.LbPesanan.Text = "Jml Pesanan"
		'
		'LbOrderToday
		'
		Me.LbOrderToday.AutoSize = True
		Me.LbOrderToday.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbOrderToday.Location = New System.Drawing.Point(10, 8)
		Me.LbOrderToday.Name = "LbOrderToday"
		Me.LbOrderToday.Size = New System.Drawing.Size(78, 19)
		Me.LbOrderToday.TabIndex = 4
		Me.LbOrderToday.Text = "Pesanan"
		'
		'MonthCalendar
		'
		Me.MonthCalendar.BackColor = System.Drawing.Color.LightSeaGreen
		Me.MonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday
		Me.MonthCalendar.Location = New System.Drawing.Point(547, 12)
		Me.MonthCalendar.Name = "MonthCalendar"
		Me.MonthCalendar.TabIndex = 1
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.DGVDone)
		Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox1.Location = New System.Drawing.Point(12, 191)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(689, 289)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "GBDataGrid"
		'
		'DGVDone
		'
		Me.DGVDone.AllowUserToAddRows = False
		Me.DGVDone.AllowUserToDeleteRows = False
		Me.DGVDone.AutoGenerateColumns = False
		Me.DGVDone.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DGVDone.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
		Me.DGVDone.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DGVDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVDone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MPDataGridViewTextBoxColumn, Me.InvoiceOrderIDDataGridViewTextBoxColumn, Me.ResiDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.TanggalSeleseiDataGridViewTextBoxColumn})
		Me.DGVDone.DataSource = Me.MPCheckingOrderBindingSource
		Me.DGVDone.Location = New System.Drawing.Point(9, 19)
		Me.DGVDone.Name = "DGVDone"
		Me.DGVDone.ReadOnly = True
		Me.DGVDone.RowHeadersVisible = False
		Me.DGVDone.Size = New System.Drawing.Size(660, 250)
		Me.DGVDone.TabIndex = 0
		'
		'MPDataGridViewTextBoxColumn
		'
		Me.MPDataGridViewTextBoxColumn.DataPropertyName = "MP"
		Me.MPDataGridViewTextBoxColumn.HeaderText = "MP"
		Me.MPDataGridViewTextBoxColumn.Name = "MPDataGridViewTextBoxColumn"
		Me.MPDataGridViewTextBoxColumn.ReadOnly = True
		Me.MPDataGridViewTextBoxColumn.Width = 75
		'
		'InvoiceOrderIDDataGridViewTextBoxColumn
		'
		Me.InvoiceOrderIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_OrderID"
		Me.InvoiceOrderIDDataGridViewTextBoxColumn.HeaderText = "Invoice_OrderID"
		Me.InvoiceOrderIDDataGridViewTextBoxColumn.Name = "InvoiceOrderIDDataGridViewTextBoxColumn"
		Me.InvoiceOrderIDDataGridViewTextBoxColumn.ReadOnly = True
		Me.InvoiceOrderIDDataGridViewTextBoxColumn.Width = 175
		'
		'ResiDataGridViewTextBoxColumn
		'
		Me.ResiDataGridViewTextBoxColumn.DataPropertyName = "Resi"
		Me.ResiDataGridViewTextBoxColumn.HeaderText = "Resi"
		Me.ResiDataGridViewTextBoxColumn.Name = "ResiDataGridViewTextBoxColumn"
		Me.ResiDataGridViewTextBoxColumn.ReadOnly = True
		'
		'JudulDataGridViewTextBoxColumn
		'
		Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "Judul"
		Me.JudulDataGridViewTextBoxColumn.HeaderText = "Judul"
		Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
		Me.JudulDataGridViewTextBoxColumn.ReadOnly = True
		Me.JudulDataGridViewTextBoxColumn.Width = 175
		'
		'TanggalSeleseiDataGridViewTextBoxColumn
		'
		Me.TanggalSeleseiDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Selesei"
		Me.TanggalSeleseiDataGridViewTextBoxColumn.HeaderText = "Tanggal_Selesei"
		Me.TanggalSeleseiDataGridViewTextBoxColumn.Name = "TanggalSeleseiDataGridViewTextBoxColumn"
		Me.TanggalSeleseiDataGridViewTextBoxColumn.ReadOnly = True
		Me.TanggalSeleseiDataGridViewTextBoxColumn.Width = 115
		'
		'MPCheckingOrderBindingSource
		'
		Me.MPCheckingOrderBindingSource.DataMember = "MP_CheckingOrder"
		Me.MPCheckingOrderBindingSource.DataSource = Me.INVDataSet
		'
		'INVDataSet
		'
		Me.INVDataSet.DataSetName = "INVDataSet"
		Me.INVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'MP_CheckingOrderTableAdapter
		'
		Me.MP_CheckingOrderTableAdapter.ClearBeforeFill = True
		'
		'FormDashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightSkyBlue
		Me.ClientSize = New System.Drawing.Size(844, 519)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.MonthCalendar)
		Me.Controls.Add(Me.GBPerformance)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormDashboard"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormDashboard"
		Me.GBPerformance.ResumeLayout(False)
		Me.TLPSUmmary.ResumeLayout(False)
		Me.PnSalesToday.ResumeLayout(False)
		Me.PnSalesToday.PerformLayout()
		Me.PnProcessToday.ResumeLayout(False)
		Me.PnProcessToday.PerformLayout()
		Me.PnLastSales.ResumeLayout(False)
		Me.PnLastSales.PerformLayout()
		Me.PnOrderToday.ResumeLayout(False)
		Me.PnOrderToday.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.DGVDone, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MPCheckingOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GBPerformance As GroupBox
	Friend WithEvents MonthCalendar As MonthCalendar
	Friend WithEvents TLPSUmmary As TableLayoutPanel
	Friend WithEvents PnSalesToday As Panel
	Friend WithEvents PnProcessToday As Panel
	Friend WithEvents PnLastSales As Panel
	Friend WithEvents PnOrderToday As Panel
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents DGVDone As DataGridView
	Friend WithEvents INVDataSet As INVDataSet
	Friend WithEvents MPCheckingOrderBindingSource As BindingSource
	Friend WithEvents MP_CheckingOrderTableAdapter As INVDataSetTableAdapters.MP_CheckingOrderTableAdapter
	Friend WithEvents MPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InvoiceOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ResiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TanggalSeleseiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Public WithEvents LbNominalSales As Label
	Public WithEvents LbSales As Label
	Public WithEvents LbJmlDiproses As Label
	Public WithEvents LbDiproses As Label
	Friend WithEvents LbNominalLastSales As Label
	Public WithEvents LbTglLastSales As Label
	Public WithEvents LbLastSales As Label
	Friend WithEvents LbPesanan As Label
	Public WithEvents LbOrderToday As Label
End Class
