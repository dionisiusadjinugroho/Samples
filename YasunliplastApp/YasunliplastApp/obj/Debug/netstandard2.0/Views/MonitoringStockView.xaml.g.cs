//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("YasunliplastApp.Views.MonitoringStockView.xaml", "Views/MonitoringStockView.xaml", typeof(global::YasunliplastApp.Views.MonitoringStockView))]

namespace YasunliplastApp.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\MonitoringStockView.xaml")]
    public partial class MonitoringStockView : global::Syncfusion.XForms.Backdrop.SfBackdropPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.ComboBox.SfComboBox Combobox_SearchItem;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.ComboBox.SfComboBox Combobox_Position;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label labelTotal;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator busyindicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh sfPullToRefresh;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.SearchBar filterText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.ListView.XForms.SfListView sfListView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MonitoringStockView));
            Combobox_SearchItem = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.ComboBox.SfComboBox>(this, "Combobox_SearchItem");
            Combobox_Position = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.ComboBox.SfComboBox>(this, "Combobox_Position");
            labelTotal = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "labelTotal");
            busyindicator = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator>(this, "busyindicator");
            sfPullToRefresh = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh>(this, "sfPullToRefresh");
            filterText = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.SearchBar>(this, "filterText");
            sfListView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.ListView.XForms.SfListView>(this, "sfListView");
        }
    }
}
