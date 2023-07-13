Imports System.Windows
Imports System.Windows.Media.Imaging
Imports DevExpress.Utils
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.XtraReports.UI
Imports SmartTagCustomization
Imports DevExpress.XtraReports.Configuration
Imports DevExpress.XtraReports.Expressions

Namespace SmartTagCustomization
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            ExpressionBindingDescriptor.SetPropertyDescription(GetType(XRProgressBar), "Progress", New ExpressionBindingDescription( { "BeforePrint" }, -1, New String(){}, Nothing))
            InitializeComponent()


            Dim icon_Renamed = BitmapFrame.Create(AssemblyHelper.GetResourceUri(Me.GetType().Assembly, "progress.png"))
            DevExpress.Xpf.Reports.UserDesigner.ReportDesigner.RegisterControl(Of XRProgressBar)(Function() New XRProgressBarDiagramItem(False), icon_Renamed)
            reportDesigner.OpenDocument(New XtraReport1())
        End Sub
    End Class
End Namespace
