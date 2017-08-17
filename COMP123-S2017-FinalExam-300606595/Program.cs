using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Nirojan Kalaimannan
 * Date: Aug 17,2017
 * StudentID: 300606595
 * Description: This is the driver class
 * Version: 0.1 - implemented splash form reference
 */

namespace COMP123_S2017_FinalExam_300606595
{
    public static class Program
    {
        public static PickHighestCardForm pickHighestCardForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
