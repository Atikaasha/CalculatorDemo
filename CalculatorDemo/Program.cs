using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Chowdhury Atika Parvin
 * ID# 301007336
 * Description: Calculator Demo
 * Date: July 09, 2019
 * Version: 0.1 - Created the project
 */
namespace CalculatorDemo
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
            Application.Run(new CalculatorForm());
        }
    }
}
