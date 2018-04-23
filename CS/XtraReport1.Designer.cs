namespace SmartTagCustomization {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TopMargin1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.checkBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
            this.progressBar1 = new SmartTagCustomization.XRProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin1
            // 
            this.TopMargin1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.checkBox1});
            this.TopMargin1.HeightF = 100F;
            this.TopMargin1.Name = "TopMargin1";
            // 
            // BottomMargin1
            // 
            this.BottomMargin1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.progressBar1});
            this.BottomMargin1.HeightF = 100F;
            this.BottomMargin1.Name = "BottomMargin1";
            // 
            // Detail1
            // 
            this.Detail1.HeightF = 100F;
            this.Detail1.Name = "Detail1";
            // 
            // checkBox1
            // 
            this.checkBox1.LocationFloat = new DevExpress.Utils.PointFloat(40F, 20F);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.SizeF = new System.Drawing.SizeF(400F, 50F);
            this.checkBox1.Text = "Standart xrCheckBox control with custom smartTag template";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.progressBar1.LocationFloat = new DevExpress.Utils.PointFloat(40F, 20F);
            this.progressBar1.MaxValue = 100F;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Progress = 30F;
            this.progressBar1.SizeF = new System.Drawing.SizeF(400F, 50F);
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin1,
            this.BottomMargin1,
            this.Detail1});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin1;
        private DevExpress.XtraReports.UI.XRCheckBox checkBox1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin1;
        private SmartTagCustomization.XRProgressBar progressBar1;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
    }
}
