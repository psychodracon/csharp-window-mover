using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes.Managers
{
    public static class ScreenManager
    {
        static System.Windows.Forms.Screen[] screens = System.Windows.Forms.Screen.AllScreens;
        static bool screenFaded = false;
        static int whatScreenFaded = -1;
        static int brightness = 60;
        static int contrast = 70;
        static int brightnessOffset = 0;
        static int contrastOffset = 0;
        static bool useOffsetForFirstMonitor = false;

        static ScreenManager()
        {
        }

        private static void GetCurrentMonitorSettings()
        {
            brightnessOffset = Settings.Instance.BrightnessOffset;
            contrastOffset = Settings.Instance.ContrastOffset;
            useOffsetForFirstMonitor = Settings.Instance.UseOffsetForFirstMonitor;

            if (Settings.Instance.NightMode)
            {
                brightness = Settings.Instance.NightMonitorBrightness;
                contrast = Settings.Instance.NightMonitorContrast;
            } else
            {
                brightness = Settings.Instance.DayMonitorBrightness;
                contrast = Settings.Instance.DayMonitorContrast;
            }
        }
        public static void ChangeScreenBrithness(System.Windows.Forms.Screen screen, bool fadeOut)
        {
            GetCurrentMonitorSettings();
            System.Windows.Forms.Screen opositeScreen = screens.Where(x => x.DeviceName != screen.DeviceName).FirstOrDefault();

            if (opositeScreen != null)
            {
                int whatScreen = opositeScreen.Primary ? 1 : 2;

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = String.Format("{0}\\Utils\\ClickMonitorDDC.exe", AppDomain.CurrentDomain.BaseDirectory);

                if (fadeOut && !screenFaded)
                { 
                    Console.WriteLine(String.Format("Fading out screen {0}", whatScreen));

                    startInfo.Arguments = String.Format("{0} b 0 c 0", whatScreen);
                    screenFaded = true;
                    whatScreenFaded = whatScreen;
                    Process.Start(startInfo);
                }
                else if(!fadeOut && screenFaded)
                {
                    Console.WriteLine(String.Format("Defading out screen {0}", whatScreenFaded));

                    int brightnessToUse = brightness;
                    int contrastToUse = contrast;

                    if (useOffsetForFirstMonitor && whatScreen == 1 || !useOffsetForFirstMonitor && whatScreen == 2)
                    {
                        brightnessToUse = brightness + brightnessOffset;
                        contrastToUse = contrast + contrastOffset;
                    }

                    startInfo.Arguments = String.Format("{0} b {1} c {2}", whatScreen, brightnessToUse, contrastToUse);
                    screenFaded = false;
                    Process.Start(startInfo);
                }
            }
        }

        public static void ChangeAllScreenBrithnessToDefault()
        {
            GetCurrentMonitorSettings();
            for (int i = 0; i < screens.Count(); i++)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = String.Format("{0}\\Utils\\ClickMonitorDDC.exe", AppDomain.CurrentDomain.BaseDirectory);

                int whatScreen = i + 1;

                int brightnessToUse = brightness;
                int contrastToUse = contrast;

                if (useOffsetForFirstMonitor && whatScreen == 1 || !useOffsetForFirstMonitor && whatScreen == 2)
                {
                    brightnessToUse = brightness + brightnessOffset;
                    contrastToUse = contrast + contrastOffset;
                }

                startInfo.Arguments = String.Format("{0} b {1} c {2}", whatScreen, brightnessToUse, contrastToUse);
                Process.Start(startInfo);
            }
        }
    }
}
