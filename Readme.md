<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128605225/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T554855)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Reporting for WPF - Customize a Control's Smart Tag

This example shows how to customize the standard smart tag of a report control. You need to override the diagram item's `SmartTagTemplate` property for this task. 

It also shows how to create a smart tag for a custom control. For this, set the `SmartTagTemplate` property and override the custom diagram item's `GetSmartTagViewModel` method.

## Files to Review

* [BindingModeToPropertyTemplateConverter.cs](./CS/BindingModeToPropertyTemplateConverter.cs) (VB: [BindingModeToPropertyTemplateConverter.vb](./VB/BindingModeToPropertyTemplateConverter.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [XRProgressBar.cs](./CS/XRProgressBar.cs) (VB: [XRProgressBarDiagramItem.vb](./VB/XRProgressBarDiagramItem.vb))
* [XRProgressBarDiagramItem.cs](./CS/XRProgressBarDiagramItem.cs) (VB: [XRProgressBarDiagramItem.vb](./VB/XRProgressBarDiagramItem.vb))
* [XRProgressBarSmartTagViewModel.cs](./CS/XRProgressBarSmartTagViewModel.cs) (VB: [XRProgressBarSmartTagViewModel.vb](./VB/XRProgressBarSmartTagViewModel.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))

## Documentation

- [WPF - Smart Tag Overview](https://docs.devexpress.com/WPF/18096/whats-installed/smart-tags/smart-tag-overview)
- [Reporting - Smart Tags](https://docs.devexpress.com/XtraReports/17560/web-reporting/end-user-report-designer-for-web/interface-elements/design-surface#smart-tags)
