using System.Drawing;

namespace NurikabeSolver.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gameGrid = new System.Windows.Forms.DataGridView();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.messageText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gameGrid
            // 
            this.gameGrid.AllowDrop = true;
            this.gameGrid.AllowUserToAddRows = false;
            this.gameGrid.AllowUserToDeleteRows = false;
            this.gameGrid.AllowUserToResizeColumns = false;
            this.gameGrid.AllowUserToResizeRows = false;
            this.gameGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gameGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gameGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gameGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.gameGrid.Location = new System.Drawing.Point(12, 62);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.ReadOnly = false;
            this.gameGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gameGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gameGrid.RowTemplate.Height = 24;
            this.gameGrid.Size = new System.Drawing.Size(576, 576);
            this.gameGrid.TabIndex = 0;
            this.gameGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(12, 12);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(287, 44);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "New game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(301, 12);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(287, 44);
            this.buttonSolve.TabIndex = 3;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageText.Location = new System.Drawing.Point(12, 649);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(0, 20);
            this.messageText.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 678);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.gameGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Nurikabe Solver";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameGrid;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label messageText;
    }
}

