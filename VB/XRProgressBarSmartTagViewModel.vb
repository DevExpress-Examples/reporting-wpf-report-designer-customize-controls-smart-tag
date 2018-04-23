Imports DevExpress.Mvvm.Native
Imports DevExpress.Xpf.Reports.UserDesigner.SmartTags
Imports DevExpress.Xpf.Reports.UserDesigner.XRDiagram
Imports SmartTagCustomization

Namespace SmartTagCustomization
    Public Class XRProgressBarSmartTagViewModel
        Inherits SmartTagViewModelBase

        Public Sub New(ByVal reportModel As XtraReportDiagramItem)
            MyBase.New(reportModel)
        End Sub

        Public Property MaxValue() As Single
            Get
                Return CSng(GetPropertyValue(ExpressionHelper.GetPropertyName(Function(x As XRProgressBar) x.MaxValue)))
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(ExpressionHelper.GetPropertyName(Function(x As XRProgressBar) x.MaxValue), value)
            End Set
        End Property

        Public Property Progress() As Object
            Get
                Return DirectCast(GetPropertyValue(ExpressionHelper.GetPropertyName(Function(x As XRProgressBar) x.Progress)), Object)
            End Get
            Set(ByVal value As Object)
                SetPropertyValue(ExpressionHelper.GetPropertyName(Function(x As XRProgressBar) x.Progress), value)
            End Set
        End Property
    End Class
End Namespace
