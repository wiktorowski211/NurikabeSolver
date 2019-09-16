using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurikabeSolver
{
    public partial class View : Form
    {
        Controller controller;
        int size;
        int[,] islandList;
        int[,] resultList;

        public View(Controller controller, int size, int[,] island_list, int[,] result_list)
        {
            InitializeComponent();

            this.controller = controller;
            this.size = size;
            this.islandList = island_list;
            this.resultList = result_list;
        }

        private bool CheckIfSolvedCorrectly()
        {
            var celltbl = new List<bool>();
            var resultcelltbl = new List<bool>();
            for (var row = 0; row < size; row++)
            {
                for (var column = 0; column < size; column++)
                {
                    var cell = GetCell(row, column);
                    var resultCell = resultList[row, column];
                    celltbl.Add(cell.GetBool());
                    resultcelltbl.Add(resultCell.GetBool());
                    if (cell.GetBool() != resultCell.GetBool())
                    {
                        return false; // solved incorrectly; game does not match result from prolog
                    }
                }
            }
            return true; //solved correctly
        }

        private void FillTheGrid()
        {
            for (var i = 0; i < islandList.GetLength(0); i++)
            {
                var row = islandList[i, 0] - 1;
                var column = islandList[i, 1] - 1;
                var value = islandList[i, 2];
                GetCell(row, column).SetValue(value);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateGrid(size);
            FillTheGrid();
        }

        private void CreateGrid(int size)
        {
            controller.NewGame();

            for (int i = 0; i < size; i++)
            {
                gameGrid.Columns.Add("", "");
                gameGrid.Rows.Add();
            }

            StrechRows();
        }

        private void StrechRows()
        {
            int rowHeight = gameGrid.Size.Height / gameGrid.RowCount;

            for (int i = 0; i < gameGrid.Rows.Count; i++)
            {
                gameGrid.Rows[i].Height = rowHeight;
            }
        }

        private DataGridViewCell GetCell(int row, int column)
        {
            return gameGrid.Rows[row].Cells[column];
        }

        private void GameGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = GetCell(e.RowIndex, e.ColumnIndex);

            if (gameGrid.ReadOnly && cell.IsEmpty())
                if (cell.GetColor() == Color.Black)
                    cell.SetColor(Color.White);
                else
                    cell.SetColor(Color.Black);
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            controller.NewGame();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            controller.Solve();
            if (CheckIfSolvedCorrectly())
            {
                ShowDialogBox("Congratulations! You have solved the Nurikabe game!", "Congratulations");
            }
            else
            {
                ShowDialogBox("You are almost there! Try again!", "Failed");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (gameGrid.ReadOnly)
                buttonEdit.Text = "Save";
            else
                buttonEdit.Text = "Edit";

            gameGrid.ReadOnly = !gameGrid.ReadOnly;
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            var message = "You have a grid of squares Some cells of the grid start containing numbers. The goal is to determine whether each of the cells of the grid is black or white (Islands in the Stream calls these water and land respectively). The black cells form the nurikabe (Islands in the Stream calls it the stream): they must all be orthogonally contiguous (form a single polyomino), number-free, and contain no 2x2 or larger solid rectangles (Islands in the Stream calls such illegal blocks pools). The white cells form islands (which is where Islands in the Stream got its name): each number n must be part of an n-omino composed only of white cells. All white cells must belong to exactly one island; islands must have exactly one numbered cell. Solvers will typically shade in cells they have deduced to be black and dot (non-numbered) cells deduced to be white. ";
            ShowDialogBox(message, "Rules");
        }

        private void ShowDialogBox(String message, String caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Cancel)
            {
                // clicks a button
            }

        }
    }


    public static class Extensions
    {
        public static void SetValue(this DataGridViewCell cell, int value)
        {
            cell.Value = value;
        }

        public static void SetColor(this DataGridViewCell cell, Color color)
        {
            cell.Style.BackColor = color;
            cell.Style.SelectionBackColor = color;
        }

        public static object GetValue(this DataGridViewCell cell)
        {
            return cell.Value;
        }

        public static Color GetColor(this DataGridViewCell cell)
        {
            return cell.Style.BackColor;
        }

        public static bool GetBool(this DataGridViewCell cell)
        {
            var color = cell.GetColor();
            return (color == Color.Black) ? true : false;
        }

        public static bool GetBool(this int cell)
        {
            return (cell == 0) ? true : false;
        }

        public static bool IsEmpty(this DataGridViewCell cell)
        {
            return cell.Value == null;
        }
    }
}
