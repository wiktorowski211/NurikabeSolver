using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NurikabeSolver.Controllers;

namespace NurikabeSolver.Views
{
    public partial class MainForm : Form
    {
        Controller controller;

        public MainForm(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewGame(Board.Empty(5));
        }

        private void NewGame(Board board)
        {
            SetMessage(Strings.EMPTY);

            InitializeGrid(board);
        }

        private void InitializeGrid(Board board)
        {
            ClearGrid();
            CreateGrid(board);
            StrechRows();
            FillGrid(board);
            RedrawGrid();
        }

        private void ClearGrid()
        {
            gameGrid.Columns.Clear();
            gameGrid.Rows.Clear();
        }

        private void CreateGrid(Board board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                gameGrid.Columns.Add("", "");
                gameGrid.Rows.Add();
            }
        }

        private void StrechRows()
        {
            int rowHeight = gameGrid.Size.Height / gameGrid.RowCount;

            for (int i = 0; i < gameGrid.Rows.Count; i++)
            {
                gameGrid.Rows[i].Height = rowHeight;
            }
        }

        private void FillGrid(Board board)
        {
            FillIslands(board.Islands);
            FillSea(board.Sea);
        }

        private void FillIslands(Islands islands)
        {
            foreach (var island in islands.GetAll())
            {
                var row = island[0] - 1;
                var column = island[1] - 1;
                var size = island[2];

                gameGrid.Rows[row].Cells[column].Value = size;
            }
        }

        private void FillSea(Sea sea)
        {
            var sea_array = sea.GetAll();

            for (int i = 0; i < sea_array.Length; i++)
            {
                for (int j = 0; j < sea_array.Length; j++)
                {
                    if (sea_array[i][j] == 0)
                        gameGrid.Rows[i].Cells[j].SetColor(Color.Black);
                }
            }
        }

        private void RedrawGrid()
        {
            gameGrid.Invalidate();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            OpenNewGameForm();
        }

        private void OpenNewGameForm()
        {
            using (var form = new NewGameForm())
            {
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    InitializeGrid(form.Board);
                    SetMessage(Strings.FILL_ISLANDS_SIZE);
                }
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            Solve();
        }

        private Board BoardFromGrid()
        {
            int board_size = gameGrid.Rows.Count;

            int[][] grid = GetGrid(board_size);

            var islands = Islands.FromGrid(grid);

            return Board.FromGrid(board_size, islands);
        }

        private int[][] GetGrid(int board_size)
        {
            int[][] grid = new int[board_size][];

            for (int i = 0; i < board_size; i++)
            {
                grid[i] = new int[board_size];
            }

            for (int i = 0; i < gameGrid.Rows.Count; i++)
            {
                for (int j = 0; j < gameGrid.Columns.Count; j++)
                {
                    var island_size_object = gameGrid.Rows[i].Cells[j].Value;

                    if (island_size_object != null)
                        grid[i][j] = int.Parse(island_size_object.ToString());
                }
            }
            return grid;
        }

        private void Solve()
        {
            SetMessage(Strings.SOLVING);

            var board_from_grid = BoardFromGrid();

            var result_board = controller.Solve(board_from_grid);

            if(result_board != null)
            {
                InitializeGrid(result_board);

                SetMessage(Strings.SOLVED);
            }
            else
            {
                SetMessage(Strings.NOT_SOLVED);
            }
        }

        private void SetMessage(string message)
        {
            messageText.Text = message;
        }
    }
}
