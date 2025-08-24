using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Test1.Core;
using Test1.Views;

namespace Test1.ViewModels
{
    public class AddSectionViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        public ICommand Edit { get; set; }
        public AddSectionViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            Edit = new DelegateCommand(OnEditCommand);
        }
        private void OnEditCommand()
        {
            // Navigate to EditSection view in the EditRegion
            _regionManager.RequestNavigate(NameOfRegion.EditRegion, nameof(EditSection));
        }
    }
}
