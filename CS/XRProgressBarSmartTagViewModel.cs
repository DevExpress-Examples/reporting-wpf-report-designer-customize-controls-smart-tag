using DevExpress.Mvvm.Native;
using DevExpress.Xpf.Reports.UserDesigner.SmartTags;
using DevExpress.Xpf.Reports.UserDesigner.XRDiagram;
using SmartTagCustomization;

namespace SmartTagCustomization {
    public class XRProgressBarSmartTagViewModel : SmartTagViewModelBase {
        public XRProgressBarSmartTagViewModel(XtraReportDiagramItem reportModel) : base(reportModel) { }

        public float MaxValue {
            get { return (float)GetPropertyValue(ExpressionHelper.GetPropertyName((XRProgressBar x) => x.MaxValue)); }
            set { SetPropertyValue(ExpressionHelper.GetPropertyName((XRProgressBar x) => x.MaxValue), value); }
        }

        public object Progress {
            get { return (object)GetPropertyValue(ExpressionHelper.GetPropertyName((XRProgressBar x) => x.Progress)); }
            set { SetPropertyValue(ExpressionHelper.GetPropertyName((XRProgressBar x) => x.Progress), value); }
        }
    }
}
