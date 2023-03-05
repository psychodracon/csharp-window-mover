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

        private bool positioning;
        public bool Positioning { get { return positioning; } set { positioning = value; settingsChanged = true; } }

        private Settings()
        {
            this.windowSettingsLocation = new System.Drawing.Point(0, 0);
            this.windowSettingsSize = new System.Drawing.Size(500, 500);
            this.timerFullscreenDetectionTimeout = 1500;
            this.timerSetPositionTimeout = 2500;
            this.positioning = true;
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
