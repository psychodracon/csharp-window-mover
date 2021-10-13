using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using WindowMover.Classes;
using WindowMover.Classes.Managers;
using WindowMoverWPF.Core;

namespace WindowMoverWPF.Data.ViewModel
{

    class AnchorsViewModel
    {
        public ObservableCollection<WindowHandler> WindowHandlers { get; set; }
        public RelayCommand AnchorsViewCommand { get; set; }

        public AnchorsViewModel()
        {
            WindowHandlers = new ObservableCollection<WindowHandler>(WindowHandlerManager.windowHandlers);

            AnchorsViewCommand = new RelayCommand(o => {
                AnchorEditorWindow anchorEditorWindow = new AnchorEditorWindow();
                anchorEditorWindow.Show();
            });
        }
    }
}
