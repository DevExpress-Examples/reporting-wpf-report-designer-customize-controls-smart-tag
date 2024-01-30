Imports DevExpress.XtraReports.UI
Imports System
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Data

Namespace SmartTagCustomization

    Public Class BindingModeToPropertyTemplateConverter
        Implements IValueConverter

        Public Property BindingTemplate As DataTemplate

        Public Property ExpressionTemplate As DataTemplate

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim mode = CType(value, DataBindingMode?)
            If Not mode.HasValue Then Return Nothing
            If mode.Value = DataBindingMode.Bindings Then
                Return BindingTemplate
            Else
                Return ExpressionTemplate
            End If
        End Function

        Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function
    End Class
End Namespace
