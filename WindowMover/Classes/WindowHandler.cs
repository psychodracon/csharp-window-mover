using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes
{
    [Serializable]
    public class WindowHandler : ICloneable
    {
        public string handlerName { get; set; }

        public bool handlerActive { get; set; }

        public string windowTitle { get; set; }
        public WindowCompareTemplate windowTitleModifier { get; set; }
        public string windowClass { get; set; }
        public bool useWindowClass { get; set; }

        public string processName { get; set; }
        public bool useProcessName { get; set; }

        public bool useParent { get; set; }

        public string parentWindowTitle { get; set; }
        public WindowCompareTemplate parentWindowTitleModifier { get; set; }
        public string parentWindowClass { get; set; }
        public bool useParentWindowClass { get; set; }

        public string parentProcessName { get; set; }
        public bool useParentProcessName { get; set; }

        public bool changePosition { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
        public bool changeSize { get; set; }
        public int sizeX { get; set; }
        public int sizeY { get; set; }
        public bool alwaysOnTop { get; set; }
        public bool borderless { get; set; }

        public IntPtr lastHandle { get; set; }
        public WindowHandler()
        {
            handlerActive = true;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
