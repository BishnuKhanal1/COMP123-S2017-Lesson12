using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Bishnu Khanal
 * StusentID: 300924228
 * Date: August 1, 2017
 * Description: Demo applcation to shocase windows forms and UI Controls
 * Version: 0.1- project was created
 */
namespace COMP123_S2017_Lesson12
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
            Application.Run(new DemoForm());
        }
    }
}
