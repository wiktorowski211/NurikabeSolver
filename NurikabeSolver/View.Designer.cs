using System.Drawing;

namespace NurikabeSolver
{
    partial class View
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
            this.gameGrid = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
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
            this.gameGrid.RowsDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gameGrid.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            this.gameGrid.RowsDefaultCellStyle.Font = new Font("Tahoma", 15);
            this.gameGrid.ColumnHeadersVisible = false;
            this.gameGrid.Location = new System.Drawing.Point(12, 62);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.ReadOnly = true;
            this.gameGrid.RowHeadersVisible = false;
            this.gameGrid.RowTemplate.Height = 24;
            this.gameGrid.Size = new System.Drawing.Size(576, 576);
            this.gameGrid.TabIndex = 0;
            this.gameGrid.CellClick += GameGrid_CellClick;
            // 
            // buttonInformation
            // 
            this.buttonInformation.Location = new System.Drawing.Point(557, 12);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(31, 44);
            this.buttonInformation.TabIndex = 1;
            this.buttonInformation.Text = "i";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(187, 44);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(205, 12);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(190, 44);
            this.buttonSolve.TabIndex = 3;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.gameGrid);
            this.Name = "View";
            this.Text = "Nurikabe Solver";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gameGrid;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Button buttonSolve;
    }
}
