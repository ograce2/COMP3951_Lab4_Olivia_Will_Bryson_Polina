using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 2: Scientific Calculator
/// Include here the authors: Jason Peacock and Olivia Grace
/// Include here date/revisions: January 21, 2025
/// </summary>
namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
