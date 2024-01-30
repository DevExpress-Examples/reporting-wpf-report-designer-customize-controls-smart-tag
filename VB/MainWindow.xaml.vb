Imports System.Windows
Imports System.Windows.Media.Imaging
Imports DevExpress.Utils
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.XtraReports.Expressions

Namespace SmartTagCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Call ExpressionBindingDescriptor.SetPropertyDescription(GetType(XRProgressBar), "Progress", New ExpressionBindingDescription({"BeforePrint"}, -1, New String(-1) {}, Nothing))
            Me.InitializeComponent()
            Dim icon = BitmapFrame.Create(AssemblyHelper.GetResourceUri([GetType]().Assembly, "progress.png"))
            ReportDesigner.RegisterControl(Of XRProgressBar)(Function() New XRProgressBarDiagramItem(False), icon)
            Me.reportDesigner.OpenDocument(New XtraReport1())
        End Sub
    End Class
End Namespace
