﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormValidasi
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
		Me.LabelFormValidasi = New System.Windows.Forms.Label()
		Me.GroupBoxDataInvoice = New System.Windows.Forms.GroupBox()
		Me.DGVInvoice = New System.Windows.Forms.DataGridView()
		Me.BtProses = New System.Windows.Forms.Button()
		Me.BtCancel = New System.Windows.Forms.Button()
		Me.TextBoxvalidasiisbn = New System.Windows.Forms.TextBox()
		Me.BtCari = New System.Windows.Forms.Button()
		Me.GroupBoxDataInvoice.SuspendLayout()
		CType(Me.DGVInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LabelFormValidasi
		'
		Me.LabelFormValidasi.AutoSize = True
		Me.LabelFormValidasi.Font = New System.Drawing.Font("Lucida Console", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
				Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelFormValidasi.Location = New System.Drawing.Point(79, 9)
		Me.LabelFormValidasi.Name = "LabelFormValidasi"
		Me.LabelFormValidasi.Size = New System.Drawing.Size(435, 32)
		Me.LabelFormValidasi.TabIndex = 0
		Me.LabelFormValidasi.Text = "Form Validasi Invoice"
		'
		'GroupBoxDataInvoice
		'
		Me.GroupBoxDataInvoice.Controls.Add(Me.DGVInvoice)
		Me.GroupBoxDataInvoice.Location = New System.Drawing.Point(12, 88)
		Me.GroupBoxDataInvoice.Name = "GroupBoxDataInvoice"
		Me.GroupBoxDataInvoice.Size = New System.Drawing.Size(656, 319)
		Me.GroupBoxDataInvoice.TabIndex = 1
		Me.GroupBoxDataInvoice.TabStop = False
		Me.GroupBoxDataInvoice.Text = "Data Invoice"
		'
		'DGVInvoice
		'
		Me.DGVInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVInvoice.Location = New System.Drawing.Point(6, 19)
		Me.DGVInvoice.Name = "DGVInvoice"
		Me.DGVInvoice.Size = New System.Drawing.Size(644, 294)
		Me.DGVInvoice.TabIndex = 0
		'
		'BtProses
		'
		Me.BtProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtProses.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.telegram_app_32px
		Me.BtProses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtProses.Location = New System.Drawing.Point(690, 176)
		Me.BtProses.Name = "BtProses"
		Me.BtProses.Size = New System.Drawing.Size(84, 40)
		Me.BtProses.TabIndex = 3
		Me.BtProses.Text = "Process"
		Me.BtProses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.BtProses.UseVisualStyleBackColor = True
		'
		'BtCancel
		'
		Me.BtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtCancel.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.close_window_32px
		Me.BtCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtCancel.Location = New System.Drawing.Point(690, 264)
		Me.BtCancel.Name = "BtCancel"
		Me.BtCancel.Size = New System.Drawing.Size(84, 40)
		Me.BtCancel.TabIndex = 2
		Me.BtCancel.Text = "Cancel"
		Me.BtCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.BtCancel.UseVisualStyleBackColor = True
		'
		'TextBoxvalidasiisbn
		'
		Me.TextBoxvalidasiisbn.Location = New System.Drawing.Point(12, 62)
		Me.TextBoxvalidasiisbn.Name = "TextBoxvalidasiisbn"
		Me.TextBoxvalidasiisbn.Size = New System.Drawing.Size(205, 20)
		Me.TextBoxvalidasiisbn.TabIndex = 4
		'
		'BtCari
		'
		Me.BtCari.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.search_16px
		Me.BtCari.Location = New System.Drawing.Point(223, 60)
		Me.BtCari.Name = "BtCari"
		Me.BtCari.Size = New System.Drawing.Size(31, 23)
		Me.BtCari.TabIndex = 5
		Me.BtCari.UseVisualStyleBackColor = True
		'
		'FormValidasi
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.BtCari)
		Me.Controls.Add(Me.TextBoxvalidasiisbn)
		Me.Controls.Add(Me.BtProses)
		Me.Controls.Add(Me.BtCancel)
		Me.Controls.Add(Me.LabelFormValidasi)
		Me.Controls.Add(Me.GroupBoxDataInvoice)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormValidasi"
		Me.Opacity = 0.95R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormValidasi"
		Me.GroupBoxDataInvoice.ResumeLayout(False)
		CType(Me.DGVInvoice, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelFormValidasi As Label
	Friend WithEvents GroupBoxDataInvoice As GroupBox
	Friend WithEvents BtCancel As Button
	Friend WithEvents BtProses As Button
	Friend WithEvents DGVInvoice As DataGridView
	Friend WithEvents TextBoxvalidasiisbn As TextBox
	Friend WithEvents BtCari As Button
End Class
