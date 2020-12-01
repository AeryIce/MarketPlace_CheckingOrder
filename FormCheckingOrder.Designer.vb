<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckingOrder
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.ComboBoxPilihMP = New System.Windows.Forms.ComboBox()
		Me.GroupBoxCariOrderId = New System.Windows.Forms.GroupBox()
		Me.ButtonCariOrderId = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.GroupBoxImport = New System.Windows.Forms.GroupBox()
		Me.ButtonImport = New System.Windows.Forms.Button()
		Me.GroupBoxCheckingOrder = New System.Windows.Forms.GroupBox()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonPass = New System.Windows.Forms.Button()
		Me.DGV_MPCheckingOrder = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LabelStatusKoneksi = New System.Windows.Forms.Label()
		Me.INVDataSet = New MarketPlace_CheckingOrder.INVDataSet()
		Me.MPCheckingOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.MP_CheckingOrderTableAdapter = New MarketPlace_CheckingOrder.INVDataSetTableAdapters.MP_CheckingOrderTableAdapter()
		Me.MPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OrderIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.InvoiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IsbnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OngkirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ProsesStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GroupBoxCariOrderId.SuspendLayout()
		Me.GroupBoxImport.SuspendLayout()
		Me.GroupBoxCheckingOrder.SuspendLayout()
		CType(Me.DGV_MPCheckingOrder, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MPCheckingOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ComboBoxPilihMP
		'
		Me.ComboBoxPilihMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboBoxPilihMP.FormattingEnabled = True
		Me.ComboBoxPilihMP.Location = New System.Drawing.Point(6, 18)
		Me.ComboBoxPilihMP.Name = "ComboBoxPilihMP"
		Me.ComboBoxPilihMP.Size = New System.Drawing.Size(163, 32)
		Me.ComboBoxPilihMP.TabIndex = 0
		'
		'GroupBoxCariOrderId
		'
		Me.GroupBoxCariOrderId.Controls.Add(Me.ButtonCariOrderId)
		Me.GroupBoxCariOrderId.Controls.Add(Me.TextBox1)
		Me.GroupBoxCariOrderId.Location = New System.Drawing.Point(12, 60)
		Me.GroupBoxCariOrderId.Name = "GroupBoxCariOrderId"
		Me.GroupBoxCariOrderId.Size = New System.Drawing.Size(260, 64)
		Me.GroupBoxCariOrderId.TabIndex = 1
		Me.GroupBoxCariOrderId.TabStop = False
		Me.GroupBoxCariOrderId.Text = "Cari Order ID"
		'
		'ButtonCariOrderId
		'
		Me.ButtonCariOrderId.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.search_16px
		Me.ButtonCariOrderId.Location = New System.Drawing.Point(218, 19)
		Me.ButtonCariOrderId.Name = "ButtonCariOrderId"
		Me.ButtonCariOrderId.Size = New System.Drawing.Size(28, 31)
		Me.ButtonCariOrderId.TabIndex = 1
		Me.ButtonCariOrderId.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(6, 19)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(206, 31)
		Me.TextBox1.TabIndex = 0
		'
		'GroupBoxImport
		'
		Me.GroupBoxImport.Controls.Add(Me.ButtonImport)
		Me.GroupBoxImport.Controls.Add(Me.ComboBoxPilihMP)
		Me.GroupBoxImport.Location = New System.Drawing.Point(278, 60)
		Me.GroupBoxImport.Name = "GroupBoxImport"
		Me.GroupBoxImport.Size = New System.Drawing.Size(290, 64)
		Me.GroupBoxImport.TabIndex = 2
		Me.GroupBoxImport.TabStop = False
		Me.GroupBoxImport.Text = "Import File"
		'
		'ButtonImport
		'
		Me.ButtonImport.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.add_file_32px
		Me.ButtonImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonImport.Location = New System.Drawing.Point(175, 15)
		Me.ButtonImport.Name = "ButtonImport"
		Me.ButtonImport.Size = New System.Drawing.Size(103, 43)
		Me.ButtonImport.TabIndex = 0
		Me.ButtonImport.Text = "Import Data"
		Me.ButtonImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonImport.UseVisualStyleBackColor = True
		'
		'GroupBoxCheckingOrder
		'
		Me.GroupBoxCheckingOrder.Controls.Add(Me.ButtonExit)
		Me.GroupBoxCheckingOrder.Controls.Add(Me.ButtonCancel)
		Me.GroupBoxCheckingOrder.Controls.Add(Me.ButtonPass)
		Me.GroupBoxCheckingOrder.Controls.Add(Me.DGV_MPCheckingOrder)
		Me.GroupBoxCheckingOrder.Location = New System.Drawing.Point(13, 131)
		Me.GroupBoxCheckingOrder.Name = "GroupBoxCheckingOrder"
		Me.GroupBoxCheckingOrder.Size = New System.Drawing.Size(555, 257)
		Me.GroupBoxCheckingOrder.TabIndex = 3
		Me.GroupBoxCheckingOrder.TabStop = False
		Me.GroupBoxCheckingOrder.Text = "Checking Order"
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(440, 201)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(103, 50)
		Me.ButtonExit.TabIndex = 3
		Me.ButtonExit.Text = "EXIT"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Location = New System.Drawing.Point(440, 142)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(103, 50)
		Me.ButtonCancel.TabIndex = 2
		Me.ButtonCancel.Text = "CANCEL"
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'ButtonPass
		'
		Me.ButtonPass.Location = New System.Drawing.Point(440, 19)
		Me.ButtonPass.Name = "ButtonPass"
		Me.ButtonPass.Size = New System.Drawing.Size(103, 117)
		Me.ButtonPass.TabIndex = 1
		Me.ButtonPass.Text = "PASS"
		Me.ButtonPass.UseVisualStyleBackColor = True
		'
		'DGV_MPCheckingOrder
		'
		Me.DGV_MPCheckingOrder.AllowUserToAddRows = False
		Me.DGV_MPCheckingOrder.AllowUserToDeleteRows = False
		Me.DGV_MPCheckingOrder.AutoGenerateColumns = False
		Me.DGV_MPCheckingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV_MPCheckingOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MPDataGridViewTextBoxColumn, Me.OrderIdDataGridViewTextBoxColumn, Me.InvoiceDataGridViewTextBoxColumn, Me.IsbnDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.OngkirDataGridViewTextBoxColumn, Me.ProsesStatusDataGridViewTextBoxColumn})
		Me.DGV_MPCheckingOrder.DataSource = Me.MPCheckingOrderBindingSource
		Me.DGV_MPCheckingOrder.Location = New System.Drawing.Point(6, 19)
		Me.DGV_MPCheckingOrder.Name = "DGV_MPCheckingOrder"
		Me.DGV_MPCheckingOrder.ReadOnly = True
		Me.DGV_MPCheckingOrder.RowHeadersVisible = False
		Me.DGV_MPCheckingOrder.Size = New System.Drawing.Size(428, 232)
		Me.DGV_MPCheckingOrder.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(76, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(426, 25)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Checking Order Tokopedia dan Shopee"
		'
		'LabelStatusKoneksi
		'
		Me.LabelStatusKoneksi.AutoSize = True
		Me.LabelStatusKoneksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusKoneksi.Location = New System.Drawing.Point(450, 391)
		Me.LabelStatusKoneksi.Name = "LabelStatusKoneksi"
		Me.LabelStatusKoneksi.Size = New System.Drawing.Size(0, 9)
		Me.LabelStatusKoneksi.TabIndex = 5
		'
		'INVDataSet
		'
		Me.INVDataSet.DataSetName = "INVDataSet"
		Me.INVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'MPCheckingOrderBindingSource
		'
		Me.MPCheckingOrderBindingSource.DataMember = "MP_CheckingOrder"
		Me.MPCheckingOrderBindingSource.DataSource = Me.INVDataSet
		'
		'MP_CheckingOrderTableAdapter
		'
		Me.MP_CheckingOrderTableAdapter.ClearBeforeFill = True
		'
		'MPDataGridViewTextBoxColumn
		'
		Me.MPDataGridViewTextBoxColumn.DataPropertyName = "MP"
		Me.MPDataGridViewTextBoxColumn.HeaderText = "MP"
		Me.MPDataGridViewTextBoxColumn.Name = "MPDataGridViewTextBoxColumn"
		Me.MPDataGridViewTextBoxColumn.ReadOnly = True
		'
		'OrderIdDataGridViewTextBoxColumn
		'
		Me.OrderIdDataGridViewTextBoxColumn.DataPropertyName = "Order_Id"
		Me.OrderIdDataGridViewTextBoxColumn.HeaderText = "Order_Id"
		Me.OrderIdDataGridViewTextBoxColumn.Name = "OrderIdDataGridViewTextBoxColumn"
		Me.OrderIdDataGridViewTextBoxColumn.ReadOnly = True
		'
		'InvoiceDataGridViewTextBoxColumn
		'
		Me.InvoiceDataGridViewTextBoxColumn.DataPropertyName = "Invoice"
		Me.InvoiceDataGridViewTextBoxColumn.HeaderText = "Invoice"
		Me.InvoiceDataGridViewTextBoxColumn.Name = "InvoiceDataGridViewTextBoxColumn"
		Me.InvoiceDataGridViewTextBoxColumn.ReadOnly = True
		'
		'IsbnDataGridViewTextBoxColumn
		'
		Me.IsbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn"
		Me.IsbnDataGridViewTextBoxColumn.HeaderText = "Isbn"
		Me.IsbnDataGridViewTextBoxColumn.Name = "IsbnDataGridViewTextBoxColumn"
		Me.IsbnDataGridViewTextBoxColumn.ReadOnly = True
		'
		'HargaDataGridViewTextBoxColumn
		'
		Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "Harga"
		Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
		Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
		Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
		'
		'OngkirDataGridViewTextBoxColumn
		'
		Me.OngkirDataGridViewTextBoxColumn.DataPropertyName = "Ongkir"
		Me.OngkirDataGridViewTextBoxColumn.HeaderText = "Ongkir"
		Me.OngkirDataGridViewTextBoxColumn.Name = "OngkirDataGridViewTextBoxColumn"
		Me.OngkirDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ProsesStatusDataGridViewTextBoxColumn
		'
		Me.ProsesStatusDataGridViewTextBoxColumn.DataPropertyName = "Proses_Status"
		Me.ProsesStatusDataGridViewTextBoxColumn.HeaderText = "Proses_Status"
		Me.ProsesStatusDataGridViewTextBoxColumn.Name = "ProsesStatusDataGridViewTextBoxColumn"
		Me.ProsesStatusDataGridViewTextBoxColumn.ReadOnly = True
		'
		'FormCheckingOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.SteelBlue
		Me.ClientSize = New System.Drawing.Size(596, 413)
		Me.Controls.Add(Me.LabelStatusKoneksi)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBoxCheckingOrder)
		Me.Controls.Add(Me.GroupBoxImport)
		Me.Controls.Add(Me.GroupBoxCariOrderId)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormCheckingOrder"
		Me.Opacity = 0.95R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Checking Order"
		Me.GroupBoxCariOrderId.ResumeLayout(False)
		Me.GroupBoxCariOrderId.PerformLayout()
		Me.GroupBoxImport.ResumeLayout(False)
		Me.GroupBoxCheckingOrder.ResumeLayout(False)
		CType(Me.DGV_MPCheckingOrder, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MPCheckingOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ComboBoxPilihMP As ComboBox
	Friend WithEvents GroupBoxCariOrderId As GroupBox
	Friend WithEvents ButtonCariOrderId As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents GroupBoxImport As GroupBox
	Friend WithEvents ButtonImport As Button
	Friend WithEvents GroupBoxCheckingOrder As GroupBox
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents ButtonPass As Button
	Friend WithEvents DGV_MPCheckingOrder As DataGridView
	Friend WithEvents Label1 As Label
	Public WithEvents LabelStatusKoneksi As Label
	Friend WithEvents INVDataSet As INVDataSet
	Friend WithEvents MPCheckingOrderBindingSource As BindingSource
	Friend WithEvents MP_CheckingOrderTableAdapter As INVDataSetTableAdapters.MP_CheckingOrderTableAdapter
	Friend WithEvents MPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents OrderIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents InvoiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents IsbnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents OngkirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ProsesStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
