using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace SmartTagCustomization {
    public class BindingModeToPropertyTemplateConverter : IValueConverter {
        public DataTemplate BindingTemplate { get; set; }
        public DataTemplate ExpressionTemplate { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var mode = value as DataBindingMode?;
            if (!mode.HasValue)
                return null;
            if (mode.Value == DataBindingMode.Bindings)
                return BindingTemplate;
            else return ExpressionTemplate;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }
    }
}
