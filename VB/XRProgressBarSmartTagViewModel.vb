Imports DevExpress.Xpf.Reports.UserDesigner.SmartTags
Imports DevExpress.Xpf.Reports.UserDesigner.XRDiagram

Namespace SmartTagCustomization

    Public Class XRProgressBarSmartTagViewModel
        Inherits SmartTagViewModelBase

        Public Sub New(ByVal reportModel As XtraReportDiagramItem)
            MyBase.New(reportModel)
        End Sub

        Public Property MaxValue As Single
            Get
                Return CSng(GetPropertyValue("MaxValue"))
            End Get

            Set(ByVal value As Single)
                SetPropertyValue("MaxValue", value)
            End Set
        End Property

        Public Property Progress As Single
            Get
                Return CSng(GetPropertyValue("Progress"))
            End Get

            Set(ByVal value As Single)
                SetPropertyValue("Progress", value)
            End Set
        End Property

        Public Property ProgressBinding As Object
            Get
                Return GetBindingValue("Progress")
            End Get

            Set(ByVal value As Object)
                SetBindingValue("Progress", value)
            End Set
        End Property
    End Class
End Namespace
