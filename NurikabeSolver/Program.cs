using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurikabeSolver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(/*int size, int[,] island_list, int[,] result_list*/)
        {
            var controller = new Controller();

            // ------ to delete
            var size =  5;
            var island_list = new int[4, 3] { { 1, 3, 3 }, { 2, 2, 3 }, { 5, 1, 2 }, { 5, 5, 4 } };
            var result_list = new int[5, 5] { { 0, 0, 1, 1, 1 }, { 0, 1, 0, 0, 0 }, { 0, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 }, { 1, 1, 0, 1, 1 } };
            // ------

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View(controller, size, island_list, result_list));
        }
    }
}
