using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes.Managers
{
    using System.Windows.Forms;
    using HWND = IntPtr;

    public static class WindowHandlerManager
    {
        public static List<WindowHandler> windowHandlers = new List<WindowHandler>();

        static WindowHandlerManager()
        {
            Load();
        }

        public static string Add(WindowHandler handler)
        {
            WindowHandler existing = windowHandlers.Where(x => x.handlerName == handler.handlerName).FirstOrDefault();
            if (existing != null)
                return "Element istnieje";
            else
                windowHandlers.Add(handler);

            return String.Empty;
        }

        public static string Remove(WindowHandler handler)
        {
            WindowHandler existing = windowHandlers.Where(x => x.handlerName == handler.handlerName).FirstOrDefault();
            if (existing != null)
                windowHandlers.Remove(handler);

            return String.Empty;
        }


        public static bool Save()
        {
            string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            byte[] arrayToSave = Helpers.ObjectToByteArray(windowHandlers);
            bool done = Helpers.ByteArrayToFile(String.Format("{0}\\data.dat", currentDirectory), arrayToSave);

            return done;
        }

        public static bool Load()
        {
            string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            byte[] arrayToSave = Helpers.FileToByteArray(String.Format("{0}\\data.dat", currentDirectory));
            if (arrayToSave != null)
                windowHandlers = (List<WindowHandler>)Helpers.ByteArrayToObject(arrayToSave);
            else
                return false;

            return true;
        }

        public static List<Window> GetHandleByCriteria(WindowHandler windowHandler)
        {
            List<Window> windows = new List<Window>();

            switch (windowHandler.windowTitleModifier)
            {
                case WindowCompareTemplate.Match:
                    if (!windowHandler.useWindowClass)
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().Equals(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().Equals(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
                    break;
                case WindowCompareTemplate.BeginWith:
                    if (!windowHandler.useWindowClass)
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().StartsWith(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().StartsWith(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
                    break;
                case WindowCompareTemplate.EndWith:
                    if (!windowHandler.useWindowClass)
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().EndsWith(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().EndsWith(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
                    break;
                case WindowCompareTemplate.Contains:
                    if (!windowHandler.useWindowClass)
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().Contains(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = WindowManager.openedWindows.Where(x => x.windowCaption.ToLower().Contains(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
                    break;
                default:
                    break;
            }

            if (windowHandler.useProcessName)
                windows = windows.Where(x => x.processName.ToLower().Equals(windowHandler.processName.ToLower())).ToList();

            if (windowHandler.useParent)
            {
                if (windows.Count > 0 && windows[0].windowParent != null)
                {
                    switch (windowHandler.parentWindowTitleModifier)
                    {
                        case WindowCompareTemplate.Match:
                            if (!windowHandler.useParentWindowClass)
                                windows = windows.Where(x => x.windowParent.windowCaption.ToLower().Equals(windowHandler.parentWindowTitle.ToLower())).ToList();
                            else
                                windows = windows.Where(x => x.windowParent.windowCaption.ToLower().Equals(windowHandler.parentWindowTitle.ToLower()) && x.windowParent.windowClass.ToLower().Equals(windowHandler.parentWindowClass.ToLower())).ToList();
                            break;
                        case WindowCompareTemplate.BeginWith:
                            if (!windowHandler.useParentWindowClass)
                                windows = windows.Where(x => x.windowParent.windowCaption.ToLower().StartsWith(windowHandler.parentWindowTitle.ToLower())).ToList();
                            else
                                windows = windows.Where(x => x.windowParent.windowCaption.ToLower().StartsWith(windowHandler.parentWindowTitle.ToLower()) && x.windowParent.windowClass.ToLower().Equals(windowHandler.parentWindowClass.ToLower())).ToList();
                            break;
                        case WindowCompareTemplate.EndWith:
                            if (!windowHandler.useParentWindowClass)
                                windows = windows.Where(x => x.windowCaption.ToLower().EndsWith(windowHandler.parentWindowTitle.ToLower())).ToList();
                            else
                                windows = windows.Where(x => x.windowCaption.ToLower().EndsWith(windowHandler.parentWindowTitle.ToLower()) && x.windowParent.windowClass.ToLower().Equals(windowHandler.parentWindowClass.ToLower())).ToList();
                            break;
                        case WindowCompareTemplate.Contains:
                            if (!windowHandler.useParentWindowClass)
                                windows = windows.Where(x => x.windowParent.windowCaption.ToLower().Contains(windowHandler.parentWindowTitle.ToLower())).ToList();
                            else
                                windows = windows.Where(x => x.windowParent.windowCaption.ToLower().Contains(windowHandler.parentWindowTitle.ToLower()) && x.windowParent.windowClass.ToLower().Equals(windowHandler.parentWindowClass.ToLower())).ToList();
                            break;
                        default:
                            break;
                    }

                    if (windowHandler.useParentProcessName)
                        windows = windows.Where(x => x.windowParent.processName.ToLower().Equals(windowHandler.parentProcessName.ToLower())).ToList();
                }
            }

            return windows;
        }

        public static void SetPositions()
        {
            foreach (var handler in Classes.Managers.WindowHandlerManager.windowHandlers.Where(x => x.handlerActive == true).ToList())
            {
                List<Classes.Window> windows = new List<Classes.Window>();

                windows = Classes.Managers.WindowHandlerManager.GetHandleByCriteria(handler);

                foreach (var window in windows)
                {
                    Console.WriteLine(window.windowCaption);
                    if (handler.nonTopmost)
                    {
                        Console.WriteLine("Active window: {0}", WinApiWrapper.GetActiveWindow());
                        WindowManager.SetWindowPos(window, (int)WinApiWrapper.ZOrder.HWND_NOTOPMOST, (uint)WinApiWrapper.WindowSPFlags.SWP_FRAMECHANGED |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOMOVE |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOSIZE
                            );
                    }
                    if (handler.alwaysOnTop)
                    {
                        WindowManager.SetWindowPos(window, (int)WinApiWrapper.ZOrder.HWND_TOPMOST, (uint)WinApiWrapper.WindowSPFlags.SWP_FRAMECHANGED |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOMOVE |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOSIZE
                            );
                    }
                    if (handler.borderless)
                    {
                        long currentStyle = WindowManager.GetWindowLongPtr(window, (int)WinApiWrapper.Offset.GWL_STYLE);
                        currentStyle &= ~((long)WinApiWrapper.WindowStyle.WS_CAPTION |
                            (long)WinApiWrapper.WindowStyle.WS_THICKFRAME |
                            (long)WinApiWrapper.WindowStyle.WS_MINIMIZE |
                            (long)WinApiWrapper.WindowStyle.WS_MAXIMIZE | (long)
                            WinApiWrapper.WindowStyle.WS_SYSMENU
                        );
                        WindowManager.SetWindowLongPtrA(window, (int)WinApiWrapper.Offset.GWL_STYLE, currentStyle);

                        long currentExtStyle = WindowManager.GetWindowLongPtr(window, (int)WinApiWrapper.Offset.GWL_EXSTYLE);
                        currentExtStyle &= ~((long)WinApiWrapper.WindowExtStyle.WS_EX_DLGMODALFRAME | (long)WinApiWrapper.WindowExtStyle.WS_EX_CLIENTEDGE | (long)WinApiWrapper.WindowExtStyle.WS_EX_STATICEDGE);
                        WindowManager.SetWindowLongPtrA(window, (int)WinApiWrapper.Offset.GWL_EXSTYLE, currentExtStyle);

                        WindowManager.SetWindowPos(window, 0, (uint)WinApiWrapper.WindowSPFlags.SWP_FRAMECHANGED |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOMOVE |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOSIZE |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOZORDER |
                            (uint)WinApiWrapper.WindowSPFlags.SWP_NOOWNERZORDER
                            );
                    }
                    if (!handler.changePosition && !handler.changeSize)
                    {
                        return;
                    }
                    else if (handler.changePosition && !handler.changeSize)
                    {
                        WindowManager.MoveWindowByWindowClass(window, handler.positionX, handler.positionY, window.sizeX, window.sizeY, true);
                    }
                    else if (!handler.changePosition && handler.changeSize)
                    {
                        WindowManager.MoveWindowByWindowClass(window, window.positionX, window.positionY, handler.sizeX, handler.sizeY, true);
                    }
                    else if (handler.changePosition && handler.changeSize)
                    {
                        WindowManager.MoveWindowByWindowClass(window, handler.positionX, handler.positionY, handler.sizeX, handler.sizeY, true);
                    }
                }
            }
        }
    }
}
