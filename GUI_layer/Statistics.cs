using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/**
*	Purpouse: Importing the C++ functions from the Statistics object and translating them into a C# object with properties.
*	@author Ricky Da Silva Marques 
*/

namespace GUI_layer
{
    public class Statistics
    {
        //Import the Dll of Data_layer where the function is situated
        [DllImport("Data_layer.dll")]
        //Function name with return type
        private static extern IntPtr CreateStatistics();

        [DllImport("Data_layer.dll")]
        private static extern void DeleteStatistics(IntPtr statisticsPointer);
        [DllImport("Data_layer.dll")]
        private static extern int GetBlocks(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetBlocks(IntPtr settingsPointer, int blocks);

        //Variabele where the object pointer gets saved into
        private readonly IntPtr _statisticsPointer;

        //Constructor for Settings object that gets a object pointer in return from C++
        public Statistics()
        {
            _statisticsPointer = CreateStatistics();
        }

        //Destructor that gets called when closing application
        ~Statistics()
        {
            DeleteStatistics(_statisticsPointer);
        }

        //Property for Blocks
        public int Blocks
        {
            get
            {
                return GetBlocks(_statisticsPointer);
            }
            set
            {
                SetBlocks(_statisticsPointer, value);
            }
        }
    }
}
