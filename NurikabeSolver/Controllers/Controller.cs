using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurikabeSolver.Controllers
{
    public class Controller
    {
        readonly string ISLANDS_FILENAME = "BG.txt";
        readonly string SEA_FILENAME = "EG.txt";

        public void Solve()
        {

        }

        public void NewGame()
        {
            TestIslands();
            TestSea();
        }

        void TestIslands()
        {
            int[][] board = new int[][]
            {
                new int[] { 0, 0, 3 },
                new int[] { 0, 2, 1 },
                new int[] { 0, 0, 0 }
            };

            var islands = Islands.FromBoard(board);

            SaveToFile(islands.ToString(), ISLANDS_FILENAME);

            var file = ReadFromFile(ISLANDS_FILENAME);

            var islands2 = Islands.FromFile(file);
        }

        void TestSea()
        {
            int[][] board = new int[][]
            {
                new int[] { 0, 0, 1 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 1, 0 }
            };

            var sea = Sea.FromBoard(board);

            SaveToFile(sea.ToString(), SEA_FILENAME);

            var file = ReadFromFile(SEA_FILENAME);

            var sea2 = Sea.FromFile(file);
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
