using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screenshot_windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Disabled runner application window form
            //Application.Run(new Form1());

            //Start capture screenshot
            String filename = "img_" + DateTime.Now.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("hhmmss");
            ScreenCapturer.CaptureAndSave(filename);
        }
    }
}
