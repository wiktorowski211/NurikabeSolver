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

            var result = PrologCommunication.SendIslands(board.Size, islands);

            if (result == null)
                return null;

            var result_sea = Sea.FromProlog(result);

            return Board.FromProlog(board, result_sea);
        }
    }
}
