Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace SmartTagCustomization
	<ToolboxItem(True)>
	Public Class XRProgressBar
		Inherits XRControl

'INSTANT VB NOTE: The field progress was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private progress_Conflict As Single = 0
		Private maxVal As Single = 100

		<DefaultValue(100), XtraSerializableProperty>
		Public Property MaxValue() As Single
			Get
				Return Me.maxVal
			End Get
			Set(ByVal value As Single)
				If value <= 0 Then
					Return
				End If
				Me.maxVal = value
			End Set
		End Property

		<DefaultValue(0), Bindable(True), XtraSerializableProperty>
		Public Property Progress() As Single
			Get
				Return Me.progress_Conflict
			End Get
			Set(ByVal value As Single)
				If value < 0 OrElse value > maxVal Then
					Return
				End If
				Me.progress_Conflict = value
			End Set
		End Property
		<Browsable(False)>
		Public Overrides Property Text() As String
			Get
				Return MyBase.Text
			End Get
			Set(ByVal value As String)
				MyBase.Text = value
			End Set
		End Property

		Public Sub New()
			Me.ForeColor = SystemColors.Highlight
			Me.Progress = 20.0F
		End Sub

		Protected Overrides Function CreateBrick(ByVal childrenBricks() As VisualBrick) As VisualBrick
			Return New PanelBrick(Me)
		End Function

		Protected Overrides Sub PutStateToBrick(ByVal brick As VisualBrick, ByVal ps As PrintingSystemBase)
			MyBase.PutStateToBrick(brick, ps)
			Dim panel As PanelBrick = CType(brick, PanelBrick)
			Dim progressBar As New VisualBrick(Me)
			progressBar.Sides = BorderSide.None
			progressBar.BackColor = panel.Style.ForeColor
			progressBar.Rect = New RectangleF(0, 0, panel.Rect.Width * (Progress / MaxValue), panel.Rect.Height)
			panel.Bricks.Add(progressBar)
		End Sub
	End Class
End Namespace
