Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Collections.Generic
Imports DevExpress.Xpf.Grid
Imports DevExpress.Data.Filtering

Namespace AutoFilterRow

	Partial Public Class Window1
		Inherits Window
		Private list As List(Of TestData)

		Public Sub New()
			InitializeComponent()

			list = New List(Of TestData)()
			For i As Integer = 0 To 999
				list.Add(New TestData() With {.Text = Guid.NewGuid().ToString(), .Number = i})
			Next i
			grid.ItemsSource = list
		End Sub
	End Class

	Public Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateNumber As Integer
		Public Property Number() As Integer
			Get
				Return privateNumber
			End Get
			Set(ByVal value As Integer)
				privateNumber = value
			End Set
		End Property
	End Class

End Namespace
