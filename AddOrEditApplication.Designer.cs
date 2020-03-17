namespace Haberdashery_course
{
    partial class AddOrEditApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseClientComBx = new System.Windows.Forms.ComboBox();
            this.chooseProductComBx = new System.Windows.Forms.ComboBox();
            this.descriptionRichTextBx = new System.Windows.Forms.RichTextBox();
            this.confirmAddAplButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.choosetypeComBx = new System.Windows.Forms.ComboBox();
            this.costTrackBar = new System.Windows.Forms.TrackBar();
            this.costTextBx = new System.Windows.Forms.TextBox();
            this.toolTipService = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.costTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Замовник:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва виробу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Опис несправностей:";
            // 
            // chooseClientComBx
            // 
            this.chooseClientComBx.BackColor = System.Drawing.Color.Teal;
            this.chooseClientComBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseClientComBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseClientComBx.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseClientComBx.ForeColor = System.Drawing.Color.White;
            this.chooseClientComBx.FormattingEnabled = true;
            this.chooseClientComBx.Location = new System.Drawing.Point(209, 19);
            this.chooseClientComBx.Name = "chooseClientComBx";
            this.chooseClientComBx.Size = new System.Drawing.Size(226, 24);
            this.chooseClientComBx.Sorted = true;
            this.chooseClientComBx.TabIndex = 4;
            this.chooseClientComBx.SelectedIndexChanged += new System.EventHandler(this.chooseClientComBx_SelectedIndexChanged);
            // 
            // chooseProductComBx
            // 
            this.chooseProductComBx.BackColor = System.Drawing.Color.Teal;
            this.chooseProductComBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseProductComBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseProductComBx.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseProductComBx.ForeColor = System.Drawing.Color.White;
            this.chooseProductComBx.FormattingEnabled = true;
            this.chooseProductComBx.Location = new System.Drawing.Point(209, 55);
            this.chooseProductComBx.Name = "chooseProductComBx";
            this.chooseProductComBx.Size = new System.Drawing.Size(226, 24);
            this.chooseProductComBx.Sorted = true;
            this.chooseProductComBx.TabIndex = 5;
            this.chooseProductComBx.SelectedIndexChanged += new System.EventHandler(this.chooseProductComBx_SelectedIndexChanged);
            // 
            // descriptionRichTextBx
            // 
            this.descriptionRichTextBx.Location = new System.Drawing.Point(209, 91);
            this.descriptionRichTextBx.Name = "descriptionRichTextBx";
            this.descriptionRichTextBx.Size = new System.Drawing.Size(226, 96);
            this.descriptionRichTextBx.TabIndex = 7;
            this.descriptionRichTextBx.Text = "";
            this.descriptionRichTextBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriptionRichTextBx_KeyPress);
            // 
            // confirmAddAplButton
            // 
            this.confirmAddAplButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmAddAplButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmAddAplButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.confirmAddAplButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.confirmAddAplButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmAddAplButton.Location = new System.Drawing.Point(422, 296);
            this.confirmAddAplButton.Name = "confirmAddAplButton";
            this.confirmAddAplButton.Size = new System.Drawing.Size(61, 28);
            this.confirmAddAplButton.TabIndex = 8;
            this.confirmAddAplButton.Text = "ОК";
            this.confirmAddAplButton.UseVisualStyleBackColor = false;
            this.confirmAddAplButton.Click += new System.EventHandler(this.confirmAddAplButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип послуги:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вартість послуги";
            // 
            // choosetypeComBx
            // 
            this.choosetypeComBx.BackColor = System.Drawing.Color.Teal;
            this.choosetypeComBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choosetypeComBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosetypeComBx.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosetypeComBx.ForeColor = System.Drawing.Color.White;
            this.choosetypeComBx.FormattingEnabled = true;
            this.choosetypeComBx.Location = new System.Drawing.Point(209, 206);
            this.choosetypeComBx.Name = "choosetypeComBx";
            this.choosetypeComBx.Size = new System.Drawing.Size(226, 24);
            this.choosetypeComBx.Sorted = true;
            this.choosetypeComBx.TabIndex = 11;
            this.choosetypeComBx.SelectedIndexChanged += new System.EventHandler(this.choosetypeComBx_SelectedIndexChanged);
            this.choosetypeComBx.MouseEnter += new System.EventHandler(this.choosetypeComBx_MouseEnter);
            // 
            // costTrackBar
            // 
            this.costTrackBar.Location = new System.Drawing.Point(209, 255);
            this.costTrackBar.Name = "costTrackBar";
            this.costTrackBar.Size = new System.Drawing.Size(186, 45);
            this.costTrackBar.TabIndex = 12;
            this.costTrackBar.Scroll += new System.EventHandler(this.costTrackBar_Scroll);
            this.costTrackBar.Enter += new System.EventHandler(this.costTrackBar_Enter);
            // 
            // costTextBx
            // 
            this.costTextBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costTextBx.Location = new System.Drawing.Point(401, 255);
            this.costTextBx.Name = "costTextBx";
            this.costTextBx.Size = new System.Drawing.Size(51, 20);
            this.costTextBx.TabIndex = 23;
            this.costTextBx.TextChanged += new System.EventHandler(this.costTextBx_TextChanged);
            this.costTextBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBx_KeyPress);
            // 
            // AddOrEditApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(495, 341);
            this.Controls.Add(this.costTextBx);
            this.Controls.Add(this.costTrackBar);
            this.Controls.Add(this.choosetypeComBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmAddAplButton);
            this.Controls.Add(this.descriptionRichTextBx);
            this.Controls.Add(this.chooseProductComBx);
            this.Controls.Add(this.chooseClientComBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrEditApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrEditApplication_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.costTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chooseClientComBx;
        private System.Windows.Forms.ComboBox chooseProductComBx;
        private System.Windows.Forms.RichTextBox descriptionRichTextBx;
        private System.Windows.Forms.Button confirmAddAplButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox choosetypeComBx;
        private System.Windows.Forms.TrackBar costTrackBar;
        private System.Windows.Forms.TextBox costTextBx;
        private System.Windows.Forms.ToolTip toolTipService;
    }
}