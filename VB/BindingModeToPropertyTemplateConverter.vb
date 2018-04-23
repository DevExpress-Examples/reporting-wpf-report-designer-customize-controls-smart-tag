Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Data

Namespace SmartTagCustomization
    Public Class BindingModeToPropertyTemplateConverter
        Implements IValueConverter

        Public Property BindingTemplate() As DataTemplate
        Public Property ExpressionTemplate() As DataTemplate
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim mode = CType(value, DataBindingMode?)
            If Not mode.HasValue Then
                Return Nothing
            End If
            If mode.Value Is DataBindingMode.Bindings Then
                Return BindingTemplate
            Else
                Return ExpressionTemplate
            End If
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function
    End Class
End Namespace
