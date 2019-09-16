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
            CreateGrid();

            GetCell(0, 0).SetValue(1);
            GetCell(2, 0).SetValue(3);
            GetCell(4, 0).SetValue(5);
            GetCell(0, 2).SetValue(5);
        }

        private void CreateGrid()
        {
            controller.NewGame();

            for (int i = 0; i < 5; i++)
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
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (gameGrid.ReadOnly)
                buttonEdit.Text = "Save";
            else
                buttonEdit.Text = "Edit";

            gameGrid.ReadOnly = !gameGrid.ReadOnly;
        }
    }
}
