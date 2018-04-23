Imports Microsoft.VisualBasic
Imports System
Namespace CheckedComboBoxBoundToCollection
	Public Class Order
		Private Shared cnt As Integer

		Public Sub New(ByVal orderName As String)
			cnt += 1
			fId = cnt
			fOrderName = orderName
			EntityCache.Orders.Add(fId, Me)
		End Sub

		Private fId As Integer
		Public ReadOnly Property ID() As Integer
			Get
				Return fId
			End Get
		End Property

		Private fOrderName As String
		Public Property OrderName() As String
			Get
				Return fOrderName
			End Get
			Set(ByVal value As String)
				fOrderName = value
			End Set
		End Property
	End Class
End Namespace
