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

        private Sea(int[][] prolog)
        {
            for (int i = 0; i < prolog.Length; i++)
            {
                sea.Add(prolog[i]);
            }
        }

        private Sea(int size)
        {
            for (int i = 0; i < size; i++)
            {
                sea.Add(new int[size]);
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sea[i][j] = 1;
                }
            }
        }

        public static Sea Empty(int size)
        {
            return new Sea(size);
        }

        public static Sea FromProlog(int[][] prolog)
        {
            return new Sea(prolog);
        }

        public int[][] GetAll()
        {
            return sea.ToArray();
        }
    }
}
