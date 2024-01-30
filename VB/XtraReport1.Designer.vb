Namespace SmartTagCustomization

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.TopMargin1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.checkBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.progressBar1 = New SmartTagCustomization.XRProgressBar()
            Me.customProgress = New DevExpress.XtraReports.Parameters.Parameter()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin1
            ' 
            Me.TopMargin1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.checkBox1})
            Me.TopMargin1.HeightF = 100F
            Me.TopMargin1.Name = "TopMargin1"
            ' 
            ' BottomMargin1
            ' 
            Me.BottomMargin1.HeightF = 100F
            Me.BottomMargin1.Name = "BottomMargin1"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.progressBar1})
            Me.Detail1.HeightF = 100F
            Me.Detail1.Name = "Detail1"
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.LocationFloat = New DevExpress.Utils.PointFloat(40F, 20F)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.SizeF = New System.Drawing.SizeF(400F, 50F)
            Me.checkBox1.Text = "Standart xrCheckBox control with custom smartTag template"
            ' 
            ' progressBar1
            ' 
            Me.progressBar1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((51)))))), (CInt(((CByte((153)))))), (CInt(((CByte((255)))))))
            Me.progressBar1.LocationFloat = New DevExpress.Utils.PointFloat(40F, 20F)
            Me.progressBar1.MaxValue = 100F
            Me.progressBar1.Name = "progressBar1"
            Me.progressBar1.Progress = 30F
            Me.progressBar1.SizeF = New System.Drawing.SizeF(400F, 50F)
            ' 
            ' customProgress
            ' 
            Me.customProgress.Type = GetType(Single)
            Me.customProgress.Value = 10F
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin1, Me.BottomMargin1, Me.Detail1})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.customProgress})
            Me.Version = "17.2"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private customProgress As DevExpress.XtraReports.Parameters.Parameter

        Private TopMargin1 As DevExpress.XtraReports.UI.TopMarginBand

        Private checkBox1 As DevExpress.XtraReports.UI.XRCheckBox

        Private BottomMargin1 As DevExpress.XtraReports.UI.BottomMarginBand

        Private progressBar1 As SmartTagCustomization.XRProgressBar

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
    End Class
End Namespace
