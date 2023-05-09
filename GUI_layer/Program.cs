using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_layer
{
    internal static class Program
    {
        /*[DllImport("Buisness_layer.dll")]
        public static extern void HelloWorld(string test);
        [DllImport("Buisness_layer.dll")]
        public static extern void GetalPrint(int getal);
        */
        [STAThread]
        static void Main()
        {
            //HelloWorld("Running..\n");
            //GetalPrint(50);
            Settings settings1 = new Settings();
            Statistics stats = new Statistics();
            Console.WriteLine(stats.Blocks);
            settings1.StudeerTijd = 60;
            settings1.PathImage = "C/Ricky";
            Console.WriteLine(settings1.StudeerTijd);
            Console.WriteLine(settings1.PathImage);
            Console.ReadLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_studytimer());
            
            
        }
    }
}
