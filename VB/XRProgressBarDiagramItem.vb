Imports System
Imports DevExpress.Xpf.Reports.UserDesigner.SmartTags
Imports DevExpress.Xpf.Reports.UserDesigner.XRDiagram
Imports SmartTagCustomization

Namespace SmartTagCustomization
	Public Class XRProgressBarDiagramItem
		Inherits SimpleXRControlDiagramItem

		Public Sub New(ByVal supportInplaceEditing As Boolean)
			MyBase.New(supportInplaceEditing)
		End Sub

		Protected Overrides ReadOnly Property ShouldCreateSmartTag() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overrides Function GetSmartTagViewModel(ByVal reportModel As XtraReportDiagramItem) As SmartTagViewModelBase
			Return New XRProgressBarSmartTagViewModel(reportModel)
		End Function
	End Class
End Namespace
