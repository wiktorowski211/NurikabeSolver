using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NurikabeSolver.Controllers;

namespace NurikabeSolver.Views
{
    public partial class NewGameForm : Form
    {
        public Board Board;

        public NewGameForm()
        {
            InitializeComponent();
        }

        private void fromUserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            openButton.Text = Strings.CREATE;
            SetSizeVisibility(true);
        }

        private void fromFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            openButton.Text = Strings.OPEN;
            SetSizeVisibility(false);
        }

        private void SetSizeVisibility(bool visible)
        {
            sizeTextBox.Visible = visible;
            sizeLabel.Visible = visible;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (fromFileRadioButton.Checked)
                Board = BoardFromFile();
            else if (fromUserRadioButton.Checked)
                Board = BoardFromUserInput();

            DialogResult = DialogResult.OK;
            Close();
        }

        private Board BoardFromFile()
        {
            var file = GetFile();
            return Board.FromFile(file);
        }

        private Board BoardFromUserInput()
        {
            int board_size = GetBoardSize();
            return Board.Empty(board_size);
        }

        private int GetBoardSize()
        {
            return int.Parse(sizeTextBox.Text);
        }

        private string GetFile()
        {
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            return fileContent;
        }
    }
}
