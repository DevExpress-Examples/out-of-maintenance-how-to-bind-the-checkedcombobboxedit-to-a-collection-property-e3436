Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Namespace CheckedComboBoxBoundToCollection
	Public NotInheritable Class EntityCache
		Public Shared Orders As New Dictionary(Of Integer, Order)()
	End Class
End Namespace
