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
        private static extern int GetDay(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetDay(IntPtr settingsPointer, int day);
        [DllImport("Data_layer.dll")]
        private static extern int GetMonth(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetMonth(IntPtr settingsPointer, int month);
        [DllImport("Data_layer.dll")]
        private static extern int GetYear(IntPtr settingsPointer);
        [DllImport("Data_layer.dll")]
        private static extern void SetYear(IntPtr settingsPointer, int year);
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

        public int Day
        {
            get
            {
                return GetDay(_statisticsPointer);
            }
            set
            {
                SetDay(_statisticsPointer, value);
            }
        }

        public int Month
        {
            get
            {
                return GetMonth(_statisticsPointer);
            }
            set
            {
                SetMonth(_statisticsPointer, value);
            }
        }

        public int Year
        {
            get
            {
                return GetYear(_statisticsPointer);
            }
            set
            {
                SetYear(_statisticsPointer, value);
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
