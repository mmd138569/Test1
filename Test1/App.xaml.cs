using System.Windows;
using Prism.Ioc;
using Test1.ViewModels;
using Test1.Views;

namespace Test1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AddSection, AddSectionViewModel>();
            containerRegistry.RegisterForNavigation<SearchSection,SearchSectionViewModel>();
            containerRegistry.RegisterForNavigation<EditSection,EditSectionViewModel>();
        }
    }
}
