using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NurikabeSolver;

namespace NurikabeSolver.Controllers
{
    public class Controller
    {
        public Board Solve(Board board)
        {
            PrologCommunication.InitializeProlog();

            var islands = board.Islands.ToString();

            var result = PrologCommunication.SendIslands(5, islands);

            if (result == null)
                return null;

            var result_sea = Sea.FromProlog(result);

            return Board.FromProlog(board, result_sea);
        }

        void SaveToFile(string text, string filename)
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                file.Write(text);
            }
        }

        string ReadFromFile(string filename)
        {
            using (StreamReader file = new StreamReader(filename))
            {
                return file.ReadToEnd();
            }
        }
    }
}
