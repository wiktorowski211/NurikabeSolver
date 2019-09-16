using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurikabeSolver.Controllers
{
    public class Sea
    {
        private List<int[]> sea = new List<int[]>();

        private Sea(string file)
        {
            foreach (var line in file.Split(new[] { '\r', '\n' }).Where(x => x.Length > 0))
            {
                var deserializedList = line.FromPrologList();

                sea.Add(deserializedList);
            }
        }

        private Sea(int[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                sea.Add(board[i]);
            }
        }

        public static Sea FromFile(string file)
        {
            return new Sea(file);
        }

        public static Sea FromBoard(int[][] board)
        {
            return new Sea(board);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (var row in sea)
            {
                builder.AppendLine(row.ToPrologList());
            }
            return builder.ToString();
        }
    }
}
