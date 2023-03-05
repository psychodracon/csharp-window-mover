using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes
{
    using System.Drawing;
    using HWND = IntPtr;

    public static class WinApiWrapper
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public POINT(System.Drawing.Point pt) : this(pt.X, pt.Y) { }

            public static implicit operator System.Drawing.Point(POINT p)
            {
                return new System.Drawing.Point(p.X, p.Y);
            }

            public static implicit operator POINT(System.Drawing.Point p)
            {
                return new POINT(p.X, p.Y);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public Rectangle ToRectangle()
            {
                return new Rectangle(Left, Top, Right - Left, Bottom - Top);
            }
        }

        public enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }

        public enum Offset : int
        {
            GWL_EXSTYLE = -20,
            GWLP_HINSTANCE = -6,
            GWLP_HWNDPARENT = -8,
            GWLP_ID = -12,
            GWL_STYLE = -16,
            GWLP_USERDATA = -21,
            GWLP_WNDPROC = -4
        }

        public enum ZOrder : int
        {
            HWND_BOTTOM = 1,
            HWND_NOTOPMOST = -2,
            HWND_TOP = 0,
            HWND_TOPMOST = -1
        }

        public enum WindowStyle : long
        {
            WS_BORDER = 0x00800000L,
            WS_CAPTION = 0x00C00000L,
            WS_CHILD = 0x40000000L,
            WS_CHILDWINDOW = 0x40000000L,
            WS_CLIPCHILDREN = 0x02000000L,
            WS_CLIPSIBLINGS = 0x04000000L,
            WS_DISABLED = 0x08000000L,
            WS_DLGFRAME = 0x00400000L,
            WS_GROUP = 0x00020000L,
            WS_HSCROLL = 0x00100000L,
            WS_ICONIC = 0x20000000L,
            WS_MAXIMIZE = 0x01000000L,
            WS_MAXIMIZEBOX = 0x00010000L,
            WS_MINIMIZE = 0x20000000L,
            WS_MINIMIZEBOX = 0x00020000L,
            WS_OVERLAPPED = 0x00000000L,
            WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
            WS_POPUP = 0x80000000L,
            WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),
            WS_SIZEBOX = 0x00040000L,
            WS_SYSMENU = 0x00080000L,
            WS_TABSTOP = 0x00010000L,
            WS_THICKFRAME = 0x00040000L,
            WS_TILED = 0x00000000L,
            WS_TILEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
            WS_VISIBLE = 0x10000000L,
            WS_VSCROLL = 0x00200000L
        }

        public enum WindowExtStyle : long
        {
            WS_EX_ACCEPTFILES = 0x00000010L,
            WS_EX_APPWINDOW = 0x00040000L,
            WS_EX_CLIENTEDGE = 0x00000200L,
            WS_EX_COMPOSITED = 0x02000000L,
            WS_EX_CONTEXTHELP = 0x00000400L,
            WS_EX_CONTROLPARENT = 0x00010000L,
            WS_EX_DLGMODALFRAME = 0x00000001L,
            WS_EX_LAYERED = 0x00080000,
            WS_EX_LAYOUTRTL = 0x00400000L,
            WS_EX_LEFT = 0x00000000L,
            WS_EX_LEFTSCROLLBAR = 0x00004000L,
            WS_EX_LTRREADING = 0x00000000L,
            WS_EX_MDICHILD = 0x00000040L,
            WS_EX_NOACTIVATE = 0x08000000L,
            WS_EX_NOINHERITLAYOUT = 0x00100000L,
            WS_EX_NOPARENTNOTIFY = 0x00000004L,
            WS_EX_NOREDIRECTIONBITMAP = 0x00200000L,
            WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE),
            WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST),
            WS_EX_RIGHT = 0x00001000L,
            WS_EX_RIGHTSCROLLBAR = 0x00000000L,
            WS_EX_RTLREADING = 0x00002000L,
            WS_EX_STATICEDGE = 0x00020000L,
            WS_EX_TOOLWINDOW = 0x00000080L,
            WS_EX_TOPMOST = 0x00000008L,
            WS_EX_TRANSPARENT = 0x00000020L,
            WS_EX_WINDOWEDGE = 0x00000100L
        }

        public enum WindowSPFlags : uint
        {
            SWP_ASYNCWINDOWPOS = 0x4000,
            SWP_DEFERERASE = 0x2000,
            SWP_DRAWFRAME = 0x0020,
            SWP_FRAMECHANGED = 0x0020,
            SWP_HIDEWINDOW = 0x0080,
            SWP_NOACTIVATE = 0x0010,
            SWP_NOCOPYBITS = 0x0100,
            SWP_NOMOVE = 0x0002,
            SWP_NOOWNERZORDER = 0x0200,
            SWP_NOREDRAW = 0x0008,
            SWP_NOREPOSITION = 0x0200,
            SWP_NOSENDCHANGING = 0x0400,
            SWP_NOSIZE = 0x0001,
            SWP_NOZORDER = 0x0004,
            SWP_SHOWWINDOW = 0x0040
        }

        public delegate bool EnumWindowsProc(HWND hWnd, int lParam);

        [DllImport("USER32.DLL")]
        public static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        [DllImport("USER32.DLL")]
        public static extern HWND GetForegroundWindow();

        [DllImport("USER32.DLL")]
        public static extern HWND GetShellWindow();

        [DllImport("USER32.DLL")]
        public static extern HWND GetWindow(HWND hWnd, uint uCmd);

        [DllImport("USER32.DLL")]
        public static extern HWND GetParent(HWND hwnd);

        [DllImport("USER32.DLL")]
        public static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        public static extern int GetWindowTextLength(HWND hWnd);

        [DllImport("USER32.DLL", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern long GetClassName(HWND hwnd, StringBuilder lpClassName, long nMaxCount);

        [DllImport("USER32.DLL", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(HWND hWnd, ref RECT lpRect);

        [DllImport("USER32.DLL")]
        public static extern HWND GetWindowDC(HWND hWnd);

        [DllImport("USER32.DLL")]
        public static extern HWND ReleaseDC(HWND hWnd, HWND hdc);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(HWND handle, out uint processId);

        [DllImport("USER32.DLL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(ref Point p);

        [DllImport("USER32.DLL")]
        public static extern HWND WindowFromPoint(Point p);

        [DllImport("USER32.DLL")]
        public static extern HWND ChildWindowFromPoint(HWND hWndParent, Point p);

        [DllImport("USER32.DLL")]
        public static extern HWND ChildWindowFromPointEx(HWND hWndParent, Point p, uint uFlags);

        [DllImport("USER32.DLL")]
        public static extern bool IsWindowVisible(HWND hWnd);

        [DllImport("USER32.DLL")]
        public static extern bool IsChild(HWND hWndParent, HWND hWnd);

        [DllImport("USER32.DLL", SetLastError = true)]
        public static extern bool MoveWindow(HWND hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("USER32.DLL")]
        public static extern bool ClientToScreen(HWND hwnd, ref Point lpPoint);

        [DllImport("USER32.DLL")]
        public static extern bool ScreenToClient(HWND handle, ref Point point);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(HWND handle);


        [DllImport("USER32.DLL")]
        public static extern long GetWindowLongPtr(HWND hWnd, int nIndex);

        [DllImport("USER32.DLL")]
        public static extern long SetWindowLongPtrA(HWND hWnd, int nIndex, long dwNewLong);

        [DllImport("USER32.DLL")]
        public static extern bool SetWindowPos(HWND hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetActiveWindow();
    }
}
