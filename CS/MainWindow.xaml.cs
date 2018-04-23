using System.Windows;
using System.Windows.Media.Imaging;
using DevExpress.Utils;
using DevExpress.Xpf.Reports.UserDesigner;
using DevExpress.XtraReports.UI;
using SmartTagCustomization;

namespace SmartTagCustomization {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            var icon = BitmapFrame.Create(AssemblyHelper.GetResourceUri(GetType().Assembly, "progress.png"));
            DevExpress.Xpf.Reports.UserDesigner.ReportDesigner.RegisterControl<XRProgressBar>(() => new XRProgressBarDiagramItem(false), icon);
            reportDesigner.OpenDocument(new XtraReport1());
        }
    }
}
