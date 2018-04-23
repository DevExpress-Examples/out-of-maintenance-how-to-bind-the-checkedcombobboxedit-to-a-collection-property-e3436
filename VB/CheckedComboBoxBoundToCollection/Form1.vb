Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports System.Collections.Generic

Namespace CheckedComboBoxBoundToCollection
	Partial Public Class Form1
		Inherits XtraForm
		Private cnt As Integer

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnAddOrderButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			cnt += 1
			ordersSource.Add(New Order(String.Concat("Order ", cnt)))
		End Sub
	End Class
End Namespace