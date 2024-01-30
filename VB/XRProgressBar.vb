Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace SmartTagCustomization

    <ToolboxItem(True)>
    Public Class XRProgressBar
        Inherits XRControl

        Private progressField As Single = 0

        Private maxVal As Single = 100

        <DefaultValue(100), XtraSerializableProperty>
        Public Property MaxValue As Single
            Get
                Return maxVal
            End Get

            Set(ByVal value As Single)
                If value <= 0 Then Return
                maxVal = value
            End Set
        End Property

        <DefaultValue(0), Bindable(True), XtraSerializableProperty>
        Public Property Progress As Single
            Get
                Return progressField
            End Get

            Set(ByVal value As Single)
                If value < 0 OrElse value > maxVal Then Return
                progressField = value
            End Set
        End Property

        <Browsable(False)>
        Public Overrides Property Text As String
            Get
                Return MyBase.Text
            End Get

            Set(ByVal value As String)
                MyBase.Text = value
            End Set
        End Property

        Public Sub New()
            ForeColor = SystemColors.Highlight
            Progress = 20.0F
        End Sub

        Protected Overrides Function CreateBrick(ByVal childrenBricks As VisualBrick()) As VisualBrick
            Return New PanelBrick(Me)
        End Function

        Protected Overrides Sub PutStateToBrick(ByVal brick As VisualBrick, ByVal ps As PrintingSystemBase)
            MyBase.PutStateToBrick(brick, ps)
            Dim panel As PanelBrick = CType(brick, PanelBrick)
            Dim progressBar As VisualBrick = New VisualBrick(Me)
            progressBar.Sides = BorderSide.None
            progressBar.BackColor = panel.Style.ForeColor
            progressBar.Rect = New RectangleF(0, 0, panel.Rect.Width * (Progress / MaxValue), panel.Rect.Height)
            panel.Bricks.Add(progressBar)
        End Sub
    End Class
End Namespace
