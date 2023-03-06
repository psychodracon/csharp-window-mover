using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WinApiEnums = WindowMover.Classes.Wrappers.Enums;

namespace WindowMover.Classes.Managers
{

    public class WindowHandlerManager
    {
        private List<WindowHandler> windowHandlers = new List<WindowHandler>();
        private List<Window> topMostWindows = new List<Window>();

        public WindowHandlerManager()
        {
            Load();
        }

        public string Add(WindowHandler handler)
        {
            WindowHandler existing = windowHandlers.Where(x => x.handlerName == handler.handlerName).FirstOrDefault();
            if (existing != null)
                return "Element istnieje";
            else
                windowHandlers.Add(handler);

            return String.Empty;
        }

        public string Remove(WindowHandler handler)
        {
            WindowHandler existing = windowHandlers.Where(x => x.handlerName == handler.handlerName).FirstOrDefault();
            if (existing != null)
                windowHandlers.Remove(handler);

            return String.Empty;
        }


        public bool Save()
        {
            string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            byte[] arrayToSave = Helpers.ObjectToByteArray(windowHandlers);
            bool done = Helpers.ByteArrayToFile(String.Format("{0}\\data.dat", currentDirectory), arrayToSave);

            return done;
        }

        public bool Load()
        {
            string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            byte[] arrayToSave = Helpers.FileToByteArray(String.Format("{0}\\data.dat", currentDirectory));
            if (arrayToSave != null)
                windowHandlers = (List<WindowHandler>)Helpers.ByteArrayToObject(arrayToSave);
            else
                return false;

            return true;
        }

        public List<WindowHandler> GetWindowHandlers()
        {
            return windowHandlers;
        }

        public List<WindowHandler> ByteArrayToWindowHandler(byte[] dane)
        {
            List<WindowHandler> windowHandlers = new List<WindowHandler>();

            windowHandlers = (List<WindowHandler>)Helpers.ByteArrayToObject(dane);

            return windowHandlers;
        }

        public byte[] WindowHandlersToByteArray(List<WindowHandler> windowhandlers)
        {
            byte[] data = Helpers.ObjectToByteArray(windowhandlers);

            return data;
        }

        public List<Window> GetWindowByWindowHandler(WindowHandler windowHandler, List<Window> openedWindows)
        {
            List<Window> windows = new List<Window>();

            switch (windowHandler.windowTitleModifier)
            {
                case WindowCompareTemplate.Match:
                    if (!windowHandler.useWindowClass)
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().Equals(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().Equals(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
                    break;
                case WindowCompareTemplate.BeginWith:
                    if (!windowHandler.useWindowClass)
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().StartsWith(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().StartsWith(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
                    break;
                case WindowCompareTemplate.EndWith:
                    if (!windowHandler.useWindowClass)
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().EndsWith(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().EndsWith(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
                    break;
                case WindowCompareTemplate.Contains:
                    if (!windowHandler.useWindowClass)
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().Contains(windowHandler.windowTitle.ToLower())).ToList();
                    else
                        windows = openedWindows.Where(x => x.windowCaption.ToLower().Contains(windowHandler.windowTitle.ToLower()) && x.windowClass.ToLower().Equals(windowHandler.windowClass.ToLower())).ToList();
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

        private void SetWindowZOrder(WindowManager windowManager, Window window, WinApiEnums.InsertAfter insertAfter)
        {
            windowManager.SetWindowPos(window, (int)insertAfter, (uint)WinApiEnums.WindowSPFlags.SWP_FRAMECHANGED |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOMOVE |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOSIZE |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOACTIVATE
                            );
            if (!topMostWindows.Any(x => x.windowHandle.Equals(window.windowHandle)))
            {
                topMostWindows.Add(window);
            }
        }
        public void SetPositions(WindowManager windowManager)
        {
            foreach (var handler in windowHandlers.Where(x => x.handlerActive == true).ToList())
            {
                List<Window> windows = new List<Window>();

                windows = GetWindowByWindowHandler(handler, windowManager.GetAllOpenedWindows());

                foreach (var window in windows)
                {
                    IntPtr foregroundWindow = windowManager.GetForegroundWindow();
                    if (foregroundWindow == window.windowHandle && handler.alwaysOnTop && !windowManager.IsWindowTopMost(window))
                    {
                        SetWindowZOrder(windowManager, window, WinApiEnums.InsertAfter.HWND_TOPMOST);
                    }
                    if (handler.borderless)
                    {
                        long currentStyle = windowManager.GetWindowLongPtr(window, (int)WinApiEnums.Index.GWL_STYLE);
                        currentStyle &= ~((long)WinApiEnums.WindowStyle.WS_CAPTION |
                            (long)WinApiEnums.WindowStyle.WS_THICKFRAME |
                            (long)WinApiEnums.WindowStyle.WS_MINIMIZE |
                            (long)WinApiEnums.WindowStyle.WS_MAXIMIZE |
                            (long)WinApiEnums.WindowStyle.WS_SYSMENU
                        );
                        windowManager.SetWindowLongPtr(window, (int)WinApiEnums.Index.GWL_STYLE, currentStyle);

                        long currentExtStyle = windowManager.GetWindowLongPtr(window, (int)WinApiEnums.Index.GWL_EXSTYLE);
                        currentExtStyle &= ~((long)WinApiEnums.WindowExtStyle.WS_EX_DLGMODALFRAME |
                            (long)WinApiEnums.WindowExtStyle.WS_EX_CLIENTEDGE |
                            (long)WinApiEnums.WindowExtStyle.WS_EX_STATICEDGE);
                        windowManager.SetWindowLongPtr(window, (int)WinApiEnums.Index.GWL_EXSTYLE, currentExtStyle);

                        windowManager.SetWindowPos(window, 0, (uint)WinApiEnums.WindowSPFlags.SWP_FRAMECHANGED |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOMOVE |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOSIZE |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOZORDER |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOOWNERZORDER |
                            (uint)WinApiEnums.WindowSPFlags.SWP_NOACTIVATE
                            );
                    }

                    if (!handler.changePosition && !handler.changeSize)
                    {
                        return;
                    }
                    else if (handler.changePosition && !handler.changeSize)
                    {
                        windowManager.MoveWindowByWindowClass(window, handler.positionX, handler.positionY, window.sizeX, window.sizeY, true);
                    }
                    else if (!handler.changePosition && handler.changeSize)
                    {
                        windowManager.MoveWindowByWindowClass(window, window.positionX, window.positionY, handler.sizeX, handler.sizeY, true);
                    }
                    else if (handler.changePosition && handler.changeSize)
                    {
                        windowManager.MoveWindowByWindowClass(window, handler.positionX, handler.positionY, handler.sizeX, handler.sizeY, true);
                    }
                }
            }
        }

        public void RemoveTopMostStyleFromWindows(WindowManager windowManager)
        {
            foreach (Window window in topMostWindows)
            {
                SetWindowZOrder(windowManager, window, WinApiEnums.InsertAfter.HWND_NOTOPMOST);
            }
        }
    }
}
