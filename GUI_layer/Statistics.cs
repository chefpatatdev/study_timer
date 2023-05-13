using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI_layer
{
    public class Statistics
    {
        [DllImport("Data_layer.dll")]
        private static extern IntPtr CreateStatistics();

        [DllImport("Data_layer.dll")]
        private static extern void DeleteStatistics(IntPtr statisticsPointer);
        [DllImport("Data_layer.dll")]
        private static extern int GetDate(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetDate(IntPtr settingsPointer, int date);
        [DllImport("Data_layer.dll")]
        private static extern int GetBlocks(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetBlocks(IntPtr settingsPointer, int blocks);

        private readonly IntPtr _statisticsPointer;

        public Statistics()
        {
            _statisticsPointer = CreateStatistics();
        }

        ~Statistics()
        {
            DeleteStatistics(_statisticsPointer);
        }

        public int Date
        {
            get
            {
                return GetDate(_statisticsPointer);
            }
            set
            {
                SetDate(_statisticsPointer, value);
            }
        }

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
