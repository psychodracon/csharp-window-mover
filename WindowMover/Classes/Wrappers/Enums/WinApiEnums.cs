namespace WindowMover.Classes.Wrappers.Enums
{
    public enum KeyStrokes : long
    {
        KF_EXTENDED = 0x0100,
        KF_ALTDOWN = 0x2000
    }

    public enum KeyboardKeys : long
    {
        VK_TAB = 0x09,
        VK_LWIN = 0x5B,
        VK_RWIN = 0x5C
    }

    public enum KeyboardInput : long
    {
        WM_KEYDOWN = 0x0100,
        WM_SYSKEYDOWN = 0x0104
    }

    public enum KeyboardFlags : long
    {
        LLKHF_EXTENDED = KeyStrokes.KF_EXTENDED >> 8,
        LLKHF_ALTDOWN = KeyStrokes.KF_ALTDOWN >> 8
    }
    public enum Cmd : uint
    {
        GW_HWNDFIRST = 0,
        GW_HWNDLAST = 1,
        GW_HWNDNEXT = 2,
        GW_HWNDPREV = 3,
        GW_OWNER = 4,
        GW_CHILD = 5,
        GW_ENABLEDPOPUP = 6
    }

    public enum ShellEvents : int
    {
        HSHELL_WINDOWCREATED = 1,
        HSHELL_WINDOWDESTROYED = 2,
        HSHELL_ACTIVATESHELLWINDOW = 3,
        HSHELL_WINDOWACTIVATED = 4,
        HSHELL_GETMINRECT = 5,
        HSHELL_REDRAW = 6,
        HSHELL_TASKMAN = 7,
        HSHELL_LANGUAGE = 8,
        HSHELL_ACCESSIBILITYSTATE = 11,
        HSHELL_APPCOMMAND = 12,
        HSHELL_RUDEAPPACTIVATED = 32772
    }

    public enum Hooks : int
    {
        WH_KEYBOARD_LL = 13
    }
    public enum Events : long
    {
        EVENT_SYSTEM_FOREGROUND = 0x0003,
        EVENT_SYSTEM_SWITCHSTART = 0x0014,
        EVENT_SYSTEM_SWITCHEND = 0x0015
    }

    public enum WinEvents : int
    {
        WINEVENT_INCONTEXT = 4,
        WINEVENT_OUTOFCONTEXT = 0,
        WINEVENT_SKIPOWNPROCESS = 2,
        WINEVENT_SKIPOWNTHREAD = 1
    }

    public enum Index : int
    {
        GWL_EXSTYLE = -20,
        GWLP_HINSTANCE = -6,
        GWLP_HWNDPARENT = -8,
        GWLP_ID = -12,
        GWL_STYLE = -16,
        GWLP_USERDATA = -21,
        GWLP_WNDPROC = -4
    }

    public enum InsertAfter : int
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
}
