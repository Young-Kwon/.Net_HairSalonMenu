/* Name: Young Sang Kwon
 * Student Number: 000847777
 * Date: 2022 Nov 3
 * Programming in .NET - COMP-10204-01 (Professor: Peter Basl)
 * Purpose: Makes use of altermate GUI interface that determines pricing for a hair salon
 * 
 * Statement of Authorship:
 * I, Young Sang Kwon, 000847777 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lab3B());            
        }
    }
}
