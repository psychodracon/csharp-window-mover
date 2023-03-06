using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApiEnums = WindowMover.Classes.Wrappers.Enums;

namespace WindowMover.Classes.Managers
{
    using System.Diagnostics;
    using System.Drawing;
    using HWND = IntPtr;

    public class WindowManager
    {
        private List<Window> openedWindows = new List<Window>();
        private Process[] processes;

        public WindowManager()
        {
            GetAllProcesses();
        }

        public Process[] GetAllProcesses()
        {
            return processes = Process.GetProcesses();
        }
        public List<Window> GetAllOpenedWindows()
        {
            openedWindows = GetOpenedWindows();

            return openedWindows;
        }

        private List<Window> GetOpenedWindows()
        {
            HWND shellWindow = WinApiWrapper.GetShellWindow();
            List<Window> windows = new List<Window>();

            WinApiWrapper.EnumWindows(delegate (HWND hWnd, int lParam)
            {
                if (hWnd == shellWindow) return true;
                if (!WinApiWrapper.IsWindowVisible(hWnd)) return true;

                Window window = GetWindowInfo(hWnd);
                windows.Add(window);

                return true;

            }, 0);

            return windows;
        }

        public Window GetWindowInfo(HWND hWnd)
        {
            Window window = new Window();

            window.windowHandle = hWnd;
            window.windowCaption = GetCaptionOfWindow(hWnd);
            window.windowClass = GetClassNameOfWindow(hWnd);
            window.processName = GetProcessPathOfWindow(hWnd);

            Rectangle rectangle = GetWindowRect(hWnd);

            window.positionX = rectangle.X;
            window.positionY = rectangle.Y;
            window.sizeX = rectangle.Width;
            window.sizeY = rectangle.Height;

            HWND hWndParent = WinApiWrapper.GetParent(hWnd);
            if (hWndParent != HWND.Zero)
            {
                Window parentWindow = new Window();

                parentWindow.windowHandle = hWndParent;
                parentWindow.windowCaption = GetCaptionOfWindow(hWndParent);
                parentWindow.windowClass = GetClassNameOfWindow(hWndParent);
                parentWindow.processName = GetProcessPathOfWindow(hWndParent);

                Rectangle parentRectangle = GetWindowRect(hWndParent);

                parentWindow.positionX = rectangle.X;
                parentWindow.positionY = rectangle.Y;
                parentWindow.sizeX = rectangle.Width;
                parentWindow.sizeY = rectangle.Height;

                window.windowParent = parentWindow;
            }

            return window;
        }

        public string GetCaptionOfWindow(IntPtr hwnd)
        {
            string caption = "";
            StringBuilder windowText = null;
            try
            {
                int max_length = WinApiWrapper.GetWindowTextLength(hwnd);
                windowText = new StringBuilder("", max_length + 5);
                WinApiWrapper.GetWindowText(hwnd, windowText, max_length + 2);

                if (!String.IsNullOrEmpty(windowText.ToString()) && !String.IsNullOrWhiteSpace(windowText.ToString()))
                    caption = windowText.ToString();
            }
            catch (Exception ex)
            {
                caption = ex.Message;
            }
            finally
            {
                windowText = null;
            }
            return caption;
        }

        public string GetClassNameOfWindow(IntPtr hwnd)
        {
            string className = "";
            StringBuilder classText = null;
            try
            {
                int cls_max_length = 1000;
                classText = new StringBuilder("", cls_max_length + 5);
                WinApiWrapper.GetClassName(hwnd, classText, cls_max_length + 2);

                if (!String.IsNullOrEmpty(classText.ToString()) && !String.IsNullOrWhiteSpace(classText.ToString()))
                    className = classText.ToString();
            }
            catch (Exception ex)
            {
                className = ex.Message;
            }
            finally
            {
                classText = null;
            }
            return className;
        }

        public string GetProcessPathOfWindow(HWND hwnd)
        {
            String processFileName = String.Empty;

            try
            {
                uint pid = 0;
                WinApiWrapper.GetWindowThreadProcessId(hwnd, out pid);
                Process proc = processes.Where(x => x.Id == pid).First();
                processFileName = proc.MainModule.FileName.ToString();
            }
            catch (Exception e) { }

            return processFileName;
        }

        public Rectangle GetWindowRect(HWND hWnd)
        {
            Debug.Assert(hWnd != HWND.Zero);
            WinApiWrapper.RECT rect = new WinApiWrapper.RECT();
            if (WinApiWrapper.GetWindowRect(hWnd, ref rect) == false)
                throw new Exception("GetWindowRect failed");
            return rect.ToRectangle();
        }

        public bool MoveWindowByHandle(HWND hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint)
        {
            return WinApiWrapper.MoveWindow(hWnd, X, Y, nWidth, nHeight, bRepaint);
        }

        public bool MoveWindowByWindowClass(Window window, int X, int Y, int nWidth, int nHeight, bool bRepaint)
        {
            return MoveWindowByHandle(window.windowHandle, X, Y, nWidth, nHeight, bRepaint);
        }

        public long SetWindowLongPtr(Window window, int index, long replacementValue)
        {
            return WinApiWrapper.SetWindowLongPtr(window.windowHandle, index, replacementValue);
        }

        public long GetWindowLongPtr(Window window, int index)
        {
            return WinApiWrapper.GetWindowLongPtr(window.windowHandle, index);
        }

        public bool SetWindowPos(Window window, int zOrder, uint flags)
        {
            return WinApiWrapper.SetWindowPos(window.windowHandle, zOrder, window.positionX, window.positionY, window.sizeX, window.sizeY, flags);
        }

        public bool IsWindowTopMost(Window window)
        {
            long windowExtStyle = GetWindowLongPtr(window, (int)WinApiEnums.Index.GWL_EXSTYLE);
            return (windowExtStyle & (int)WinApiEnums.WindowExtStyle.WS_EX_TOPMOST) == (int)WinApiEnums.WindowExtStyle.WS_EX_TOPMOST;
        }

        public HWND GetForegroundWindow()
        {
            return WinApiWrapper.GetForegroundWindow();
        }

        public HWND SetWinEventHook(int eventMin, int eventMax, IntPtr hmodWinEventProc, WinApiWrapper.WinEventProc lpfnWinEventProc, int idProcess, int idThread, WinApiEnums.WinEvents dwflags)
        {
            return WinApiWrapper.SetWinEventHook(eventMin, eventMax, hmodWinEventProc, lpfnWinEventProc, idProcess, idThread, dwflags);
        }

        public int UnhookWinEvent(IntPtr hWinEventHook)
        {
            return WinApiWrapper.UnhookWinEvent(hWinEventHook);
        }

        public int GetLastError()
        {
            return WinApiWrapper.GetLastError();
        }

        public IntPtr SetWindowsHookEx(WinApiEnums.Hooks idHook, WinApiWrapper.HookProc lpfn, IntPtr hMod, uint dwThreadId)
        {
            return WinApiWrapper.SetWindowsHookEx((int)idHook, lpfn, hMod, dwThreadId);
        }

        public int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam)
        {
            return WinApiWrapper.CallNextHookEx(hhk, nCode, wParam, lParam);
        }
    }
}
