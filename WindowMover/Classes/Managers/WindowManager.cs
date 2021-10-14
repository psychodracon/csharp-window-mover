using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes.Managers
{
    using System.Diagnostics;
    using System.Drawing;
    using HWND = IntPtr;

    public static class WindowManager
    {
        public static List<Window> openedWindows = WindowManager.GetOpenedWindows();

        public static void GetAllOpenedWindows()
        {
            openedWindows = GetOpenedWindows();
        }

        private static List<Window> GetOpenedWindows()
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

        public static Window GetWindowInfo(HWND hWnd)
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

        public static string GetCaptionOfWindow(IntPtr hwnd)
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

        public static string GetClassNameOfWindow(IntPtr hwnd)
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

        public static string GetProcessPathOfWindow(HWND hwnd)
        {
            string processFileName = String.Empty;

            try
            {
                uint pid = 0;
                WinApiWrapper.GetWindowThreadProcessId(hwnd, out pid);
                Process proc = Process.GetProcessById((int)pid);
                processFileName = proc.MainModule.FileName.ToString();
            }
            catch
            {
                
            }

            return processFileName;
        }

        public static Rectangle GetWindowRect(HWND hWnd)
        {
            Debug.Assert(hWnd != HWND.Zero);
            WinApiWrapper.RECT rect = new WinApiWrapper.RECT();
            if (WinApiWrapper.GetWindowRect(hWnd, ref rect) == false)
                throw new Exception("GetWindowRect failed");
            return rect.ToRectangle();
        }

        public static bool MoveWindowByHandle(HWND hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint)
        {
            return WinApiWrapper.MoveWindow(hWnd, X, Y, nWidth, nHeight, bRepaint);
        }

        public static bool MoveWindowByWindowClass(Window window, int X, int Y, int nWidth, int nHeight, bool bRepaint)
        {
            return MoveWindowByHandle(window.windowHandle, X, Y, nWidth, nHeight, bRepaint);
        }     
    }
}
