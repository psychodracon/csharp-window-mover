using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowMover.Classes;
using WinApiEnums = WindowMover.Classes.Wrappers.Enums;

namespace WindowMover.Forms
{
    using Classes.Managers;
    using Classes.Wrappers;
    using System.Collections;
    using System.Runtime.InteropServices;
    using HWND = IntPtr;

    public partial class WindowHandlerForm : Form
    {
        public EditorMode editorMode;
        private WindowMover.Classes.WindowHandler currentItem;
        private WindowMover.Classes.WindowHandler backupItem;

        public enum GetSystem_Metrics : int
        {
            SM_CXBORDER = 5,
            SM_CXFULLSCREEN = 16,
            SM_CYFULLSCREEN = 17
        }
        [DllImport("USER32.dll")]
        public static extern int GetSystemMetrics(int smIndex);

        private HWND LastWindow = HWND.Zero;

        public WindowHandlerForm(string header, EditorMode editorMode, WindowMover.Classes.WindowHandler item)
        {
            this.editorMode = editorMode;

            if (editorMode == EditorMode.New)
            {
                currentItem = new WindowMover.Classes.WindowHandler();
            }
            else if (item != null)
            {
                currentItem = item;
            }

            backupItem = new WindowHandler();
            currentItem.CopyProperties(backupItem);

            InitializeComponent();

            this.Text = header;

            //DataSource    
            cbWindowTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWindowTitle.DisplayMember = "Key";
            cbWindowTitle.ValueMember = "Value";
            cbWindowTitle.DataSource = new BindingSource(Dictionaries.windowCompareTemplateDictionary, null);

            cbParentWindowTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParentWindowTitle.DisplayMember = "Key";
            cbParentWindowTitle.ValueMember = "Value";
            cbParentWindowTitle.DataSource = new BindingSource(Dictionaries.windowCompareTemplateDictionary, null);

            //Binding
            tbHandlerName.DataBindings.Add(new Binding("Text", currentItem, "handlerName"));

            tbWindowTitle.DataBindings.Add(new Binding("Text", currentItem, "windowTitle"));
            cbWindowTitle.DataBindings.Add(new Binding("SelectedValue", currentItem, "windowTitleModifier"));
            tbWindowClass.DataBindings.Add(new Binding("Text", currentItem, "windowClass"));
            chkWindowClass.DataBindings.Add(new Binding("Checked", currentItem, "useWindowClass"));

            tbProcessName.DataBindings.Add(new Binding("Text", currentItem, "processName"));
            chkProcessName.DataBindings.Add(new Binding("Checked", currentItem, "useProcessName"));

            chkParent.DataBindings.Add(new Binding("Checked", currentItem, "useParent"));

            tbParentWindowTitle.DataBindings.Add(new Binding("Text", currentItem, "parentWindowTitle"));
            cbParentWindowTitle.DataBindings.Add(new Binding("SelectedValue", currentItem, "parentWindowTitleModifier"));
            tbParentWindowClass.DataBindings.Add(new Binding("Text", currentItem, "parentWindowClass"));
            chkParentWindowClass.DataBindings.Add(new Binding("Checked", currentItem, "useParentWindowClass"));

            tbParentProcessName.DataBindings.Add(new Binding("Text", currentItem, "parentProcessName"));
            chkParentProcessName.DataBindings.Add(new Binding("Checked", currentItem, "useParentProcessName"));

            chkSetPosition.DataBindings.Add(new Binding("Checked", currentItem, "changePosition"));
            tbPositionX.DataBindings.Add(new Binding("Text", currentItem, "positionX"));
            tbPositionY.DataBindings.Add(new Binding("Text", currentItem, "positionY"));

            chkSetSize.DataBindings.Add(new Binding("Checked", currentItem, "changeSize"));
            tbSizeX.DataBindings.Add(new Binding("Text", currentItem, "sizeX"));
            tbSizeY.DataBindings.Add(new Binding("Text", currentItem, "sizeY"));

            chkAlwaysOnTop.DataBindings.Add(new Binding("Checked", currentItem, "alwaysOnTop"));
            chkBorderless.DataBindings.Add(new Binding("Checked", currentItem, "borderless"));

            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseUp += pictureBox_MouseUp;
            pictureBox.MouseMove += pictureBox_MouseMove;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (editorMode == EditorMode.Edit)
            {
            }
            else
            {
                string message = Classes.Managers.WindowHandlerManager.Add(currentItem);
                if (message != String.Empty)
                    MessageBox.Show(message);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backupItem.CopyProperties(currentItem);

            this.Close();
        }

        static void ShowInvertRectTracker(HWND window)
        {
            if (window != HWND.Zero)
            {
                Rectangle WindowRect = WindowManager.GetWindowRect(window);
                HWND dc = WinApiWrapper.GetWindowDC(window);

                GdiApiWrapper.SetROP2(dc, (int)GdiApiWrapper.RopMode.R2_NOT);

                Color color = Color.FromArgb(0, 255, 0);
                HWND Pen = GdiApiWrapper.CreatePen((int)GdiApiWrapper.PenStyles.PS_INSIDEFRAME, 3 * GetSystemMetrics((int)GetSystem_Metrics.SM_CXBORDER), (uint)color.ToArgb());

                HWND OldPen = GdiApiWrapper.SelectObject(dc, Pen);
                HWND OldBrush = GdiApiWrapper.SelectObject(dc, GdiApiWrapper.GetStockObject((int)GdiApiWrapper.StockObjects.NULL_BRUSH));
                GdiApiWrapper.Rectangle(dc, 0, 0, WindowRect.Width, WindowRect.Height);

                GdiApiWrapper.SelectObject(dc, OldBrush);
                GdiApiWrapper.SelectObject(dc, OldPen);

                WinApiWrapper.ReleaseDC(window, dc);
                GdiApiWrapper.DeleteObject(Pen);
            }
        }

        static HWND ChildWindowFromPoint(Point point)
        {
            HWND WindowPoint = WinApiWrapper.WindowFromPoint(point);
            if (WindowPoint == HWND.Zero)
                return HWND.Zero;

            if (WinApiWrapper.ScreenToClient(WindowPoint, ref point) == false)
                throw new Exception("ScreenToClient failed");

            HWND Window = WinApiWrapper.ChildWindowFromPointEx(WindowPoint, point, 0);
            if (Window == HWND.Zero)
                return WindowPoint;

            if (WinApiWrapper.ClientToScreen(WindowPoint, ref point) == false)
                throw new Exception("ClientToScreen failed");

            if (WinApiWrapper.IsChild(WinApiWrapper.GetParent(Window), Window) == false)
                return Window;

            ArrayList WindowList = new ArrayList();
            while (Window != HWND.Zero)
            {
                Rectangle rect = WindowManager.GetWindowRect(Window);
                if (rect.Contains(point))
                    WindowList.Add(Window);
                Window = WinApiWrapper.GetWindow(Window, (uint)WinApiEnums.Cmd.GW_HWNDNEXT);
            }

            int MinPixel = GetSystemMetrics((int)GetSystem_Metrics.SM_CXFULLSCREEN) * GetSystemMetrics((int)GetSystem_Metrics.SM_CYFULLSCREEN);
            for (int i = 0; i < WindowList.Count; ++i)
            {
                Rectangle rect = WindowManager.GetWindowRect((IntPtr)WindowList[i]);
                int ChildPixel = rect.Width * rect.Height;
                if (ChildPixel < MinPixel)
                {
                    MinPixel = ChildPixel;
                    Window = (HWND)WindowList[i];
                }
            }
            return Window;
        }

        private void DisplayWindowInfo(HWND window)
        {
            if (window != HWND.Zero)
            {
                tbWindowTitle.Text = Classes.Managers.WindowManager.GetCaptionOfWindow(window);
                tbWindowClass.Text = Classes.Managers.WindowManager.GetClassNameOfWindow(window);
                tbProcessName.Text = Classes.Managers.WindowManager.GetProcessPathOfWindow(window);

                currentItem.windowTitle = Classes.Managers.WindowManager.GetCaptionOfWindow(window);
                currentItem.windowClass = Classes.Managers.WindowManager.GetClassNameOfWindow(window);
                currentItem.processName = Classes.Managers.WindowManager.GetProcessPathOfWindow(window);

                Rectangle rectangle = WindowManager.GetWindowRect(window);

                tbPositionX.Text = rectangle.X.ToString();
                tbPositionY.Text = rectangle.Y.ToString();
                tbSizeX.Text = rectangle.Width.ToString();
                tbSizeY.Text = rectangle.Height.ToString();

                currentItem.positionX = rectangle.X;
                currentItem.positionY = rectangle.Y;
                currentItem.sizeX = rectangle.Width;
                currentItem.sizeY = rectangle.Height;

                HWND hWndParent = WinApiWrapper.GetParent(window);
                if (hWndParent.ToInt64() > 0)
                {
                    tbParentWindowTitle.Text = Classes.Managers.WindowManager.GetCaptionOfWindow(hWndParent);
                    tbParentWindowClass.Text = Classes.Managers.WindowManager.GetClassNameOfWindow(hWndParent);
                    tbParentProcessName.Text = Classes.Managers.WindowManager.GetProcessPathOfWindow(hWndParent);

                    currentItem.parentWindowTitle = Classes.Managers.WindowManager.GetCaptionOfWindow(hWndParent);
                    currentItem.parentWindowClass = Classes.Managers.WindowManager.GetClassNameOfWindow(hWndParent);
                    currentItem.parentProcessName = Classes.Managers.WindowManager.GetProcessPathOfWindow(hWndParent);
                }
                else
                {
                    tbParentWindowTitle.Text = "";
                    tbParentWindowClass.Text = "";
                    tbParentProcessName.Text = "";

                    currentItem.parentWindowTitle = "";
                    currentItem.parentWindowClass = "";
                    currentItem.parentProcessName = "";
                }
            }
        }

        private void pictureBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
            }
        }

        private void pictureBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Cursor != Cursors.Default)
            {
                HWND FoundWindow = ChildWindowFromPoint(Cursor.Position);

                if (Control.FromHandle(FoundWindow) == null)
                {
                    if (FoundWindow != LastWindow)
                    {
                        ShowInvertRectTracker(LastWindow);
                        LastWindow = FoundWindow;
                        ShowInvertRectTracker(LastWindow);
                    }
                    DisplayWindowInfo(LastWindow);
                }
            }
        }

        private void pictureBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Cursor != Cursors.Default)
            {
                ShowInvertRectTracker(LastWindow);
                LastWindow = IntPtr.Zero;

                Cursor = Cursors.Default;
            }
        }
    }
}
