using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snaccident_Dog_attempt_one_06_January_2025
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Written on Wednesday, 12th February 2025.
            // After finding a possible solution for allowing the progress bar to take on any foreground colour and background colour just like it used to be able to do, I commented out the line of code below.
            
            // Oh my god, it worked!
            // Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            // Written on Wednesday, 12th February 2025.
            // Here we are! I tried to find this line of code below. It turns out Program.cs was the file I was looking for.
            Application.Run(new splashScreenSD()); // Replaced Form1 which contains the code for SD with the splash screen class file.
                                                   //
                                                   //Form1());
        }
    }
}
