using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes
{
    [Serializable]
    public class Settings
    {
        private static Settings _instance;
        public static Settings Instance
        {
            get
            {
                if (_instance == null) { _instance = new Settings(); }
                return _instance;
            }
        }
                
        private bool settingsChanged { get; set; }

        private System.Drawing.Point windowSettingsLocation = new System.Drawing.Point();
        public System.Drawing.Point WindowSettingsLocation { get { return windowSettingsLocation; } set { windowSettingsLocation = value; settingsChanged = true; } }

        private System.Drawing.Size windowSettingsSize = new System.Drawing.Size();
        public System.Drawing.Size WindowSettingsSize { get { return windowSettingsSize; } set { windowSettingsSize = value; settingsChanged = true; } }

        private int timerFullscreenDetectionTimeout;
        public int TimerFullscreenDetectionTimeout { get { return timerFullscreenDetectionTimeout; } set { timerFullscreenDetectionTimeout = value; settingsChanged = true; } }

        private int timerSetPositionTimeout;
        public int TimerSetPositionTimeout { get { return timerSetPositionTimeout; } set { timerSetPositionTimeout = value; settingsChanged = true; } }

        //private bool workMode;
        //public bool WorkMode { get { return workMode; } set { workMode = value; settingsChanged = true; } }

        //private bool nightMode;
        //public bool NightMode { get { return nightMode; } set { nightMode = value; settingsChanged = true; } }

        private bool positioning;
        public bool Positioning { get { return positioning; } set { positioning = value; settingsChanged = true; } }

        //private bool workModeAffectsPositioning;
        //public bool WorkModeAffectsPositioning { get { return workModeAffectsPositioning; } set { workModeAffectsPositioning = value; settingsChanged = true; } }

        //private int dayMonitorBrightness;
        //public int DayMonitorBrightness { get { return dayMonitorBrightness; } set { dayMonitorBrightness = value; settingsChanged = true; } }

        //private int dayMonitorContrast;
        //public int DayMonitorContrast { get { return dayMonitorContrast; } set { dayMonitorContrast = value; settingsChanged = true; } }

        //private int nightMonitorBrightness;
        //public int NightMonitorBrightness { get { return nightMonitorBrightness; } set { nightMonitorBrightness = value; settingsChanged = true; } }

        //private int nightMonitorContrast;
        //public int NightMonitorContrast { get { return nightMonitorContrast; } set { nightMonitorContrast = value; settingsChanged = true; } }

        //private int contrastOffset;
        //public int ContrastOffset { get { return contrastOffset; } set { contrastOffset = value; settingsChanged = true; } }

        //private int brightnessOffset;
        //public int BrightnessOffset { get { return brightnessOffset; } set { brightnessOffset = value; settingsChanged = true; } }

        //private bool useOffsetForFirstMonitor;
        //public bool UseOffsetForFirstMonitor { get { return useOffsetForFirstMonitor; } set { useOffsetForFirstMonitor = value; settingsChanged = true; } }
        private Settings()
        {
            this.windowSettingsLocation = new System.Drawing.Point(0, 0);
            this.windowSettingsSize = new System.Drawing.Size(500, 500);
            this.timerFullscreenDetectionTimeout = 1500;
            this.timerSetPositionTimeout = 2500;
            //this.workMode = false;
            //this.nightMode = false;
            this.positioning = true;
            //this.workModeAffectsPositioning = false;
            //this.dayMonitorBrightness = 60;
            //this.dayMonitorContrast = 70;
            //this.nightMonitorBrightness = 60;
            //this.nightMonitorContrast = 70;
            //this.contrastOffset = 0;
            //this.brightnessOffset = 0;
            //this.useOffsetForFirstMonitor = true;
            this.settingsChanged = false;
        }

        public bool Save()
        {
            string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            byte[] arrayToSave = Helpers.ObjectToByteArray(_instance);
            bool done = Helpers.ByteArrayToFile(String.Format("{0}\\settings.dat", currentDirectory), arrayToSave);

            return done;
        }

        public bool Load()
        {
            string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            byte[] arrayToSave = Helpers.FileToByteArray(String.Format("{0}\\settings.dat", currentDirectory));
            if (arrayToSave != null)
                _instance = (Settings)Helpers.ByteArrayToObject(arrayToSave);
            else
                return false;

            return true;
        }

        public bool SettingsChanged()
        {
            return this.settingsChanged;
        }
    }
}
