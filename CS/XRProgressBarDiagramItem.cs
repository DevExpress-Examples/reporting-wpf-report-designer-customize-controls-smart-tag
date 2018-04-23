using System;
using DevExpress.Xpf.Reports.UserDesigner.SmartTags;
using DevExpress.Xpf.Reports.UserDesigner.XRDiagram;
using SmartTagCustomization;

namespace SmartTagCustomization {
    public class XRProgressBarDiagramItem : SimpleXRControlDiagramItem {
        public XRProgressBarDiagramItem(bool supportInplaceEditing) : base(supportInplaceEditing) { }

        protected override bool ShouldCreateSmartTag {
            get { return true; }
        }
        protected override SmartTagViewModelBase GetSmartTagViewModel(XtraReportDiagramItem reportModel) {
            return new XRProgressBarSmartTagViewModel(reportModel);
        }
    }
}
