using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurikabeSolver.Controllers
{
    public class Islands
    {
        private List<int[]> islands = new List<int[]>();

        private Islands(string file)
        {
            foreach (var line in file.Split(new[] { '\r', '\n' }).Where(x => x.Length > 0))
            {
                var deserializedList = line.FromPrologList();

                islands.Add(deserializedList);
            }
        }

        private Islands(int[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] > 0)
                    {
                        var island = new int[] { i, j, board[i][j] };

                        islands.Add(island);
                    }
                }
            }
        }

        public static Islands FromFile(string file)
        {
            return new Islands(file);
        }

        public static Islands FromBoard(int[][] board)
        {
            return new Islands(board);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (var row in islands)
            {
                builder.AppendLine(row.ToPrologList());
            }
            return builder.ToString();
        }
    }
}
