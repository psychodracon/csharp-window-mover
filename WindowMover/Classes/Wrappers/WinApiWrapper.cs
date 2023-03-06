using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WinApiEnums = WindowMover.Classes.Wrappers.Enums;

namespace WindowMover.Classes
{
    using System.Drawing;
    using HWND = IntPtr;

    public class WinApiWrapper
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

            public POINT(Point pt) : this(pt.X, pt.Y) { }

            public static implicit operator Point(POINT p)
            {
                return new Point(p.X, p.Y);
            }

            public static implicit operator POINT(Point p)
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

        [StructLayout(LayoutKind.Sequential)]
        public class KBDLLHOOKSTRUCT
        {
            public uint vkCode;
            public uint scanCode;
            public KBDLLHOOKSTRUCTFlags flags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }

        [Flags]
        public enum KBDLLHOOKSTRUCTFlags : uint
        {
            LLKHF_EXTENDED = 0x01,
            LLKHF_INJECTED = 0x10,
            LLKHF_ALTDOWN = 0x20,
            LLKHF_UP = 0x80,
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
        public static extern long GetWindowLongPtr(HWND hWnd, int nIndex);

        [DllImport("USER32.DLL")]
        public static extern long SetWindowLongPtr(HWND hWnd, int nIndex, long dwNewLong);

        [DllImport("USER32.DLL")]
        public static extern bool SetWindowPos(HWND hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public delegate void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        [DllImport("USER32.DLL")]
        public static extern IntPtr SetWinEventHook(int eventMin, int eventMax, IntPtr hmodWinEventProc, WinEventProc lpfnWinEventProc, int idProcess, int idThread, WinApiEnums.WinEvents dwflags);

        [DllImport("USER32.DLL")]
        public static extern int UnhookWinEvent(IntPtr hWinEventHook);

        [DllImport("KERNEL32.DLL")]
        public static extern int GetLastError();

        public delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);

        [DllImport("USER32.DLL")]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("USER32.DLL")]
        public static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("USER32.DLL")]
        public static extern uint GetWindowModuleFileName(HWND hwnd, StringBuilder pszFileName, uint cchFileNameMax);
    }
}
