Imports Microsoft.VisualBasic
Imports System
Namespace CheckedComboBoxBoundToCollection
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
			Me.components = New System.ComponentModel.Container()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.checkedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.ordersSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.customersSource = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.DataSource = Me.customersSource
			Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.dataNavigator1.Location = New System.Drawing.Point(0, 244)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(292, 24)
			Me.dataNavigator1.TabIndex = 0
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(31, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "&Name:"
			' 
			' textEdit1
			' 
			Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersSource, "Name", True))
			Me.textEdit1.Location = New System.Drawing.Point(55, 12)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(100, 20)
			Me.textEdit1.TabIndex = 2
			' 
			' checkedComboBoxEdit1
			' 
			Me.checkedComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersSource, "OrdersForBinding", True))
			Me.checkedComboBoxEdit1.EditValue = ""
			Me.checkedComboBoxEdit1.Location = New System.Drawing.Point(55, 40)
			Me.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1"
			Me.checkedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedComboBoxEdit1.Properties.DataSource = Me.ordersSource
			Me.checkedComboBoxEdit1.Properties.DisplayMember = "OrderName"
			Me.checkedComboBoxEdit1.Properties.ValueMember = "ID"
			Me.checkedComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
			Me.checkedComboBoxEdit1.TabIndex = 3
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 42)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(37, 13)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "&Orders:"
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.DataSource = Me.ordersSource
			Me.listBoxControl1.DisplayMember = "OrderName"
			Me.listBoxControl1.Location = New System.Drawing.Point(12, 66)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(268, 143)
			Me.listBoxControl1.TabIndex = 5
			Me.listBoxControl1.ValueMember = "ID"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(13, 215)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 6
			Me.simpleButton1.Text = "&Add Order"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnAddOrderButtonClick);
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(161, 42)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(37, 13)
			Me.labelControl3.TabIndex = 7
			Me.labelControl3.Text = "O&rders:"
			' 
			' ordersSource
			' 
			Me.ordersSource.DataSource = GetType(CheckedComboBoxBoundToCollection.Order)
			' 
			' customersSource
			' 
			Me.customersSource.DataSource = GetType(CheckedComboBoxBoundToCollection.Customer)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 268)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.checkedComboBoxEdit1)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private customersSource As System.Windows.Forms.BindingSource
		Private ordersSource As System.Windows.Forms.BindingSource
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private checkedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

