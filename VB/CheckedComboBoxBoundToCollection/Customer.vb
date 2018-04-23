Imports Microsoft.VisualBasic
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Repository

Namespace CheckedComboBoxBoundToCollection
	Public Class Customer
		Private fName As String
		Public Property Name() As String
			Get
				Return fName
			End Get
			Set(ByVal value As String)
				fName = value
			End Set
		End Property

		Private fOrders As New List(Of Order)()
		Public ReadOnly Property Orders() As List(Of Order)
			Get
				Return fOrders
			End Get
		End Property

		Public Property OrdersForBinding() As String
			Get
				Dim result As New StringBuilder()
				For Each order As Order In Orders
					result.AppendFormat(" {0}{1}", order.ID, ","c)
				Next order
				Return result.ToString().TrimStart().TrimEnd(","c)
			End Get
			Set(ByVal value As String)
				Orders.Clear()
				For Each id As String In value.Split(","c)
					Orders.Add(EntityCache.Orders(Integer.Parse(id)))
				Next id
			End Set
		End Property
	End Class
End Namespace
