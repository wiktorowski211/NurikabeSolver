using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NurikabeSolver.Controllers
{
    public class Islands
    {
        private List<int[]> islands = new List<int[]>();

        private Islands(string file)
        {
            string pattern = @"\[\d,\d,\d\]";
            Regex rgx = new Regex(pattern);

            foreach (Match match in rgx.Matches(file))
            {
                var deserializedList = match.Value.FromPrologList();

                islands.Add(deserializedList);
            }
        }

        private Islands(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] > 0)
                    {
                        var island = new int[] { i + 1, j + 1, grid[i][j] };

                        islands.Add(island);
                    }
                }
            }
        }

        private Islands()
        {
        }

        public static Islands FromFile(string file)
        {
            return new Islands(file);
        }

        public static Islands FromGrid(int[][] grid)
        {
            return new Islands(grid);
        }

        public static Islands Empty()
        {
            return new Islands();
        }

        public int[][] GetAll()
        {
            return islands.ToArray();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("[");
            builder.Append(string.Join(",", islands.Select(x => x.ToPrologList())));
            builder.Append("]");
            return builder.ToString();
        }
    }
}
