using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowMover.Classes;
using WindowMover.Classes.Managers;
using WindowMoverWPF.Core;

namespace WindowMoverWPF.Data.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand AnchorsViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }

        public AnchorsViewModel AnchorsViewModel { get; set; }
        public SettingsViewModel SettingsViewModel { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { 
                return _currentView;
            }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }

        }
        public MainViewModel()
        {
            Settings.Instance.Load();
            TimerManager.Mock();

            AnchorsViewModel = new AnchorsViewModel();
            SettingsViewModel = new SettingsViewModel();

            AnchorsViewCommand = new RelayCommand(o => {
                CurrentView = AnchorsViewModel;
            });

            SettingsViewCommand = new RelayCommand(o => {
                CurrentView = SettingsViewModel;
            });

            CurrentView = AnchorsViewModel;
        }
    }
}
