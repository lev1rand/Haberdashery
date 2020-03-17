namespace Haberdashery_course
{
    partial class CategoryOrMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryOrMaterial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteCorM = new System.Windows.Forms.ToolStripMenuItem();
            this.addCorM = new System.Windows.Forms.ToolStripMenuItem();
            this.cormGrid = new System.Windows.Forms.DataGridView();
            this.cormIDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cormNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cormGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCorM,
            this.addCorM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteCorM
            // 
            this.deleteCorM.Name = "deleteCorM";
            this.deleteCorM.Size = new System.Drawing.Size(71, 20);
            this.deleteCorM.Text = "Видалити";
            this.deleteCorM.Click += new System.EventHandler(this.deleteCorM_Click);
            // 
            // addCorM
            // 
            this.addCorM.Name = "addCorM";
            this.addCorM.Size = new System.Drawing.Size(58, 20);
            this.addCorM.Text = "Додати";
            this.addCorM.Click += new System.EventHandler(this.addCorM_Click);
            // 
            // cormGrid
            // 
            this.cormGrid.AllowUserToAddRows = false;
            this.cormGrid.AllowUserToDeleteRows = false;
            this.cormGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cormGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cormGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cormGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cormGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cormIDcol,
            this.cormNameCol});
            this.cormGrid.Location = new System.Drawing.Point(69, 30);
            this.cormGrid.MultiSelect = false;
            this.cormGrid.Name = "cormGrid";
            this.cormGrid.ReadOnly = true;
            this.cormGrid.Size = new System.Drawing.Size(153, 269);
            this.cormGrid.TabIndex = 1;
            this.cormGrid.SelectionChanged += new System.EventHandler(this.cormGrid_SelectionChanged);
            // 
            // cormIDcol
            // 
            this.cormIDcol.HeaderText = "ID";
            this.cormIDcol.Name = "cormIDcol";
            this.cormIDcol.ReadOnly = true;
            this.cormIDcol.Visible = false;
            this.cormIDcol.Width = 43;
            // 
            // cormNameCol
            // 
            this.cormNameCol.HeaderText = "Назва";
            this.cormNameCol.Name = "cormNameCol";
            this.cormNameCol.ReadOnly = true;
            this.cormNameCol.Width = 64;
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(174, 305);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(89, 20);
            this.newNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть нову назву:";
            // 
            // CategoryOrMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(287, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.cormGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CategoryOrMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryOrMaterial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CategoryOrMaterial_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cormGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteCorM;
        private System.Windows.Forms.ToolStripMenuItem addCorM;
        private System.Windows.Forms.DataGridView cormGrid;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cormIDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cormNameCol;
    }
}