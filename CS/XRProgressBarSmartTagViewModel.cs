using DevExpress.Mvvm.Native;
using DevExpress.Xpf.Reports.UserDesigner.SmartTags;
using DevExpress.Xpf.Reports.UserDesigner.XRDiagram;
using SmartTagCustomization;

namespace SmartTagCustomization {
    public class XRProgressBarSmartTagViewModel : SmartTagViewModelBase {
        public XRProgressBarSmartTagViewModel(XtraReportDiagramItem reportModel) : base(reportModel) { }

        public float MaxValue {
            get { return (float)GetPropertyValue("MaxValue"); }
            set { SetPropertyValue("MaxValue", value); }
        }

        public float Progress {
            get { return (float)GetPropertyValue("Progress"); }
            set { SetPropertyValue("Progress", value); }
        }

        public object ProgressBinding {
            get { return GetBindingValue("Progress"); }
            set { SetBindingValue("Progress", value); }
        }
    }
}
