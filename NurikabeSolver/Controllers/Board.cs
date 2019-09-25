using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurikabeSolver.Controllers
{
    public class Board
    {
        public int Size;
        public Islands Islands;
        public Sea Sea;

        private Board(int size, Islands islands, Sea sea)
        {
            Size = size;
            Islands = islands;
            Sea = sea;
        }

        public static Board Empty(int size)
        {
            var islands = Islands.Empty();
            var sea = Sea.Empty(size);

            return new Board(size, islands, sea);
        }

        public static Board FromGrid(int size, Islands islands)
        {
            var sea = Sea.Empty(size);

            return new Board(size, islands, sea);
        }

        public static Board FromProlog(Board board, Sea sea)
        {
            return new Board(board.Size, board.Islands, sea);
        }

        public static Board FromFile(string file)
        {
            if (file == "")
                return Empty(5);

            var file_parts = file.Split(new[] { ',' }, 2).Select(x=> x.Trim()).ToArray();

            var size_string = file_parts[0];
            var islands_string = file_parts[1];

            var size = int.Parse(size_string);
            var islands = Islands.FromFile(islands_string);
            var sea = Sea.Empty(size);

            return new Board(size, islands, sea);
        }
    }
}
