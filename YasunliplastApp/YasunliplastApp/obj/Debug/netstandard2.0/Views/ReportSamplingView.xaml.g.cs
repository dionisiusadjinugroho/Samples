//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("YasunliplastApp.Views.ReportSamplingView.xaml", "Views/ReportSamplingView.xaml", typeof(global::YasunliplastApp.Views.ReportSamplingView))]

namespace YasunliplastApp.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\ReportSamplingView.xaml")]
    public partial class ReportSamplingView : global::YasunliplastApp.Views.Base.BaseContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ToolbarItem ToolbarStartDate;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ToolbarItem ToolbarEndDate;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh sfPullToRefresh;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::YasunliplastApp.Utils.DateTimePicker dtimepicker_start;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::YasunliplastApp.Utils.DateTimePicker dtimepicker_end;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.SearchBar filterText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.ListView.XForms.SfListView sfListView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ReportSamplingView));
            ToolbarStartDate = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ToolbarItem>(this, "ToolbarStartDate");
            ToolbarEndDate = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ToolbarItem>(this, "ToolbarEndDate");
            sfPullToRefresh = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh>(this, "sfPullToRefresh");
            dtimepicker_start = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::YasunliplastApp.Utils.DateTimePicker>(this, "dtimepicker_start");
            dtimepicker_end = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::YasunliplastApp.Utils.DateTimePicker>(this, "dtimepicker_end");
            filterText = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.SearchBar>(this, "filterText");
            sfListView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.ListView.XForms.SfListView>(this, "sfListView");
        }
    }
}
