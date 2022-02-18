using CommunityToolkit.Mvvm.ComponentModel;

using HappyStudio.Mvvm.Input.Wpf;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyStudio.Mvvm.Demo.ViewModels
{
    public class CommandTestViewModel : ObservableRecipient
    {
        private bool _isAButton;

        public CommandTestViewModel()
        {
            AButtonCommand = new RelayCommand(() => _isAButton = true, () => !_isAButton);
            BButtonCommand = new RelayCommand(() => _isAButton = false, () => _isAButton);
        }

        public RelayCommand AButtonCommand { get; }
        public RelayCommand BButtonCommand { get; }

    }
}
