using System.Windows;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;
using Test1.Core;
using Test1.Views;

namespace Test1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ICommand Add { get; set; }
        public ICommand Closing { get; set; }
        public ICommand Search { get; set; }
        public ICommand Edit { get; set; }
        private Visibility _addSectionVisibility;
        public Visibility AddSectionVisibility
        {
            get { return _addSectionVisibility; }
            set { SetProperty(ref _addSectionVisibility, value); }
        }
        private Visibility _searchSectionVisibility;
        public Visibility SearchSectionVisibility
        {
            get { return _searchSectionVisibility; }
            set { SetProperty(ref _searchSectionVisibility, value); }
        }
        private Visibility _editSectionVisibility;
        public Visibility EditSectionVisibility
        {
            get { return _editSectionVisibility; }
            set { SetProperty(ref _editSectionVisibility, value); }
        }
        private readonly IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            Add = new DelegateCommand(OnAddCommand);
            //Edit = new DelegateCommand(OnEditCommand);
            Search =new DelegateCommand(OnSearchCommand);
        }

        private Prism.Commands.DelegateCommand _exitCommand;
        public Prism.Commands.DelegateCommand ExitCommand =>
            _exitCommand ?? (_exitCommand = new Prism.Commands.DelegateCommand(ExecuteExitCommand));

        void ExecuteExitCommand()
        {
            Application.Current.Shutdown();
        }
        private void OnAddCommand()
        {
            AddSectionVisibility = Visibility.Visible;
            EditSectionVisibility = Visibility.Collapsed;
            SearchSectionVisibility = Visibility.Collapsed;
            _regionManager.RegisterViewWithRegion(NameOfRegion.AddRegion, nameof(AddSection));
        }

        private void OnSearchCommand()
        {
            EditSectionVisibility = Visibility.Collapsed;
            AddSectionVisibility = Visibility.Collapsed;
            SearchSectionVisibility = Visibility.Visible;
            _regionManager.RegisterViewWithRegion(NameOfRegion.SearchRegion, nameof(SearchSection));
        }
        private void OnEditCommand()
        {
            EditSectionVisibility = Visibility.Visible;
            AddSectionVisibility = Visibility.Collapsed;
            SearchSectionVisibility = Visibility.Collapsed;
        }
    }

}
