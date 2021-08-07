using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes
{
    using HWND = IntPtr;
    
    public class Window
    {
        public HWND windowHandle;
        public string windowCaption;
        public string windowClass;
        public string processName;

        public int positionX;
        public int positionY;
        public int sizeX;
        public int sizeY;

        public Window windowParent;

        public Window()
        { }

        public Window(HWND windowHandle, string windowCaption, string windowClass, string processName, int positionX, int positionY, int sizeX, int sizeY)
        {
            this.windowHandle = windowHandle;
            this.windowCaption = windowCaption;
            this.windowClass = windowClass;
            this.processName = processName;
            this.positionX = positionX;
            this.positionY = positionY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }
    }
}
