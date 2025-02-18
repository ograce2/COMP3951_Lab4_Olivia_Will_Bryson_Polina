using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 4: Calculator Application Unit Testing
/// Version 2 Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Version 1 Authors: Jason Peacock and Olivia Grace
/// Revised: February 17, 2025
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
