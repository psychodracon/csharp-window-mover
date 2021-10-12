using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowMover.Classes;
using WindowMover.Classes.Managers;

namespace WindowMoverWPF.Data.ViewModel
{

    class AnchorsViewModel
    {
        public ObservableCollection<WindowHandler> WindowHandlers { get; set; }
        public AnchorsViewModel()
        {
            WindowHandlers = new ObservableCollection<WindowHandler>(WindowHandlerManager.windowHandlers);
        }
    }
}
