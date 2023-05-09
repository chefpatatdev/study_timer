using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI_layer
{
    public class Settings
    {


        [DllImport("Data_layer.dll")]
        private static extern IntPtr CreateSettings();

        [DllImport("Data_layer.dll")]
        private static extern void DeleteSettings(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern int GetStudeerTijd(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetStudeerTijd(IntPtr settingsPointer, int studeertijd);
        [DllImport("Data_layer.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        private static extern string GetPathImage(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetPathImage(IntPtr settingsPointer, string path);
        [DllImport("Data_layer.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        private static extern string GetPathSound(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetPathSound(IntPtr settingsPointer, string path);
        [DllImport("Data_layer.dll")]
        private static extern int GetPauzeTijd(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetPauzeTijd(IntPtr settingsPointer, int pauzetijd);
        [DllImport("Data_layer.dll")]
        private static extern bool GetAutoStartBreak(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetAutoStartBreak(IntPtr settingsPointer, bool autoStartBreak);
        [DllImport("Data_layer.dll")]
        private static extern bool GetAutoStartStudy(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetAutoStartStudy(IntPtr settingsPointer, bool autoStartStudy);

        private readonly IntPtr _settingsPointer;
        public Settings()
        {
            _settingsPointer = CreateSettings();
        }

        ~Settings()
        {
            DeleteSettings(_settingsPointer);
        }

        public int StudeerTijd
        {
            get
            {
                return GetStudeerTijd(_settingsPointer);
            }
            set
            {
                SetStudeerTijd(_settingsPointer, value);
            }
        }

        public int PauzeTijd
        {
            get
            {
                return GetPauzeTijd(_settingsPointer);
            }
            set
            {
                SetPauzeTijd(_settingsPointer, value);
            }
        }

        public string PathImage
        {
            get
            {
                return GetPathImage(_settingsPointer);
            }
            set
            {
                SetPathImage(_settingsPointer, value);
            }
        }

        public string PathSound
        {
            get
            {
                return GetPathSound(_settingsPointer);
            }
            set
            {
                SetPathSound(_settingsPointer, value);
            }
        }

        public bool AutoStartBreak
        {
            get
            {
                return GetAutoStartBreak(_settingsPointer);
            }
            set
            {
                SetAutoStartBreak(_settingsPointer, value);
            }
        }
        public bool AutoStartStudy
        {
            get
            {
                return GetAutoStartStudy(_settingsPointer);
            }
            set
            {
                SetAutoStartStudy(_settingsPointer, value);
            }
        }
    }
}
