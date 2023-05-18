using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/**
*	Purpouse: Importing the C++ functions from the Setting object and translating them into a C# object with properties.
*	@author Ricky Da Silva Marques 
*/

namespace GUI_layer
{
    public class Settings
    {   
        //Import the Dll of Data_layer where the function is situated
        [DllImport("Data_layer.dll")]
        //Function name with return type
        private static extern IntPtr CreateSettings();

        [DllImport("Data_layer.dll")]
        private static extern void DeleteSettings(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern int GetStudeerTijd(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetStudeerTijd(IntPtr settingsPointer, int studeertijd);
        [DllImport("Data_layer.dll")]
        //Letting C# know that it the returned variable will be an unmanaged BStr.
        [return: MarshalAs(UnmanagedType.BStr)]
        private static extern string GetPathImage(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetPathImage(IntPtr settingsPointer, string path);
        [DllImport("Data_layer.dll")]
        //Letting C# know that it the returned variable will be an unmanaged BStr.
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

        //Variabele where the object pointer gets saved into
        private readonly IntPtr _settingsPointer;

        //Constructor for Settings object that gets a object pointer in return from C++
        public Settings()
        {
            _settingsPointer = CreateSettings();
        }

        //Destructor that gets called when closing application
        ~Settings()
        {
            DeleteSettings(_settingsPointer);
        }

        //Property for Studeertijd
        public int StudeerTijd
        {
            get
            {
                //Getting the studeertijd using the object pointer, this way c++ knows where to look
                return GetStudeerTijd(_settingsPointer);
            }
            set
            {
                //Setting the studeertijd with a specific value using the object pointer.
                SetStudeerTijd(_settingsPointer, value);
            }
        }

        //Property for the Pauzetijd
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

        //Property for the PathImage
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

        //Property for the PathSound
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

        //Property for the AutoStartBreak
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

        //Property for the AutoStartStudy
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
