using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes.Wrappers
{
    public static class GdiApiWrapper
    {
        public enum RopMode : int
        {
            R2_NOT = 6
        }
        [DllImport("GDI32.dll")]
        public static extern int SetROP2(IntPtr hdc, int fnDrawMode);

        public enum PenStyles : int
        {
            PS_INSIDEFRAME = 6
        }
        [DllImport("GDI32.dll")]
        public static extern IntPtr CreatePen(int fnPenStyle, int nWidth, uint crColor);

        [DllImport("GDI32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        public enum StockObjects : int
        {
            NULL_BRUSH = 5
        }
        [DllImport("GDI32.dll")]
        public static extern IntPtr GetStockObject(int fnObject);

        [DllImport("GDI32.dll")]
        public static extern uint Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        [DllImport("GDI32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
    }
}
