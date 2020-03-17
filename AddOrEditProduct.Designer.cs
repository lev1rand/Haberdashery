namespace Haberdashery_course
{
    partial class AddOrEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productNameTextBx = new System.Windows.Forms.TextBox();
            this.categoryComboBx = new System.Windows.Forms.ComboBox();
            this.materialComboBx = new System.Windows.Forms.ComboBox();
            this.confirmProductInformationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва виробу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категорія, до якої належить виріб:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Матеріал, з якого виготовлений виріб:";
            // 
            // productNameTextBx
            // 
            this.productNameTextBx.Location = new System.Drawing.Point(282, 26);
            this.productNameTextBx.Name = "productNameTextBx";
            this.productNameTextBx.Size = new System.Drawing.Size(176, 20);
            this.productNameTextBx.TabIndex = 3;
            this.productNameTextBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productNameTextBx_KeyPress);
            // 
            // categoryComboBx
            // 
            this.categoryComboBx.BackColor = System.Drawing.Color.Teal;
            this.categoryComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryComboBx.ForeColor = System.Drawing.Color.White;
            this.categoryComboBx.FormattingEnabled = true;
            this.categoryComboBx.Location = new System.Drawing.Point(282, 64);
            this.categoryComboBx.Name = "categoryComboBx";
            this.categoryComboBx.Size = new System.Drawing.Size(176, 21);
            this.categoryComboBx.TabIndex = 4;
            this.categoryComboBx.SelectedIndexChanged += new System.EventHandler(this.categoryComboBx_SelectedIndexChanged);
            // 
            // materialComboBx
            // 
            this.materialComboBx.BackColor = System.Drawing.Color.Teal;
            this.materialComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialComboBx.ForeColor = System.Drawing.Color.White;
            this.materialComboBx.FormattingEnabled = true;
            this.materialComboBx.Location = new System.Drawing.Point(282, 106);
            this.materialComboBx.Name = "materialComboBx";
            this.materialComboBx.Size = new System.Drawing.Size(176, 21);
            this.materialComboBx.TabIndex = 5;
            this.materialComboBx.SelectedIndexChanged += new System.EventHandler(this.materialComboBx_SelectedIndexChanged);
            // 
            // confirmProductInformationButton
            // 
            this.confirmProductInformationButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmProductInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmProductInformationButton.Location = new System.Drawing.Point(444, 143);
            this.confirmProductInformationButton.Name = "confirmProductInformationButton";
            this.confirmProductInformationButton.Size = new System.Drawing.Size(50, 23);
            this.confirmProductInformationButton.TabIndex = 6;
            this.confirmProductInformationButton.Text = "OK";
            this.confirmProductInformationButton.UseVisualStyleBackColor = false;
            this.confirmProductInformationButton.Click += new System.EventHandler(this.confirmProductInformationButton_Click);
            // 
            // AddOrEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(506, 175);
            this.Controls.Add(this.confirmProductInformationButton);
            this.Controls.Add(this.materialComboBx);
            this.Controls.Add(this.categoryComboBx);
            this.Controls.Add(this.productNameTextBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrEditProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrEditProduct_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productNameTextBx;
        private System.Windows.Forms.ComboBox categoryComboBx;
        private System.Windows.Forms.ComboBox materialComboBx;
        private System.Windows.Forms.Button confirmProductInformationButton;
    }
}