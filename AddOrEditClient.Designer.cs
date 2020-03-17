namespace Haberdashery_course
{
    partial class AddOrEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameTextBx = new System.Windows.Forms.TextBox();
            this.nameTextBx = new System.Windows.Forms.TextBox();
            this.fathernameTextBx = new System.Windows.Forms.TextBox();
            this.mailTextBx = new System.Windows.Forms.TextBox();
            this.confirmAddClientButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBx = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ім\'я:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "По-батькові:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Номер телефону:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Електронна пошта:";
            // 
            // surnameTextBx
            // 
            this.surnameTextBx.Location = new System.Drawing.Point(192, 34);
            this.surnameTextBx.MaxLength = 45;
            this.surnameTextBx.Name = "surnameTextBx";
            this.surnameTextBx.Size = new System.Drawing.Size(139, 20);
            this.surnameTextBx.TabIndex = 4;
            this.surnameTextBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBx_KeyPress);
            // 
            // nameTextBx
            // 
            this.nameTextBx.Location = new System.Drawing.Point(192, 72);
            this.nameTextBx.MaxLength = 45;
            this.nameTextBx.Name = "nameTextBx";
            this.nameTextBx.Size = new System.Drawing.Size(139, 20);
            this.nameTextBx.TabIndex = 5;
            this.nameTextBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBx_KeyPress);
            // 
            // fathernameTextBx
            // 
            this.fathernameTextBx.Location = new System.Drawing.Point(192, 112);
            this.fathernameTextBx.MaxLength = 45;
            this.fathernameTextBx.Name = "fathernameTextBx";
            this.fathernameTextBx.Size = new System.Drawing.Size(139, 20);
            this.fathernameTextBx.TabIndex = 6;
            this.fathernameTextBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fathernameTextBx_KeyPress);
            // 
            // mailTextBx
            // 
            this.mailTextBx.Location = new System.Drawing.Point(192, 185);
            this.mailTextBx.MaxLength = 125;
            this.mailTextBx.Name = "mailTextBx";
            this.mailTextBx.Size = new System.Drawing.Size(139, 20);
            this.mailTextBx.TabIndex = 8;
            // 
            // confirmAddClientButton
            // 
            this.confirmAddClientButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.confirmAddClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.confirmAddClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmAddClientButton.Location = new System.Drawing.Point(319, 225);
            this.confirmAddClientButton.Name = "confirmAddClientButton";
            this.confirmAddClientButton.Size = new System.Drawing.Size(51, 23);
            this.confirmAddClientButton.TabIndex = 9;
            this.confirmAddClientButton.Text = "OK";
            this.confirmAddClientButton.UseVisualStyleBackColor = true;
            this.confirmAddClientButton.Click += new System.EventHandler(this.confirmAddClientButton_Click);
            // 
            // phoneNumberTextBx
            // 
            this.phoneNumberTextBx.Location = new System.Drawing.Point(192, 150);
            this.phoneNumberTextBx.Mask = "+38 (\\000) 000-0000";
            this.phoneNumberTextBx.Name = "phoneNumberTextBx";
            this.phoneNumberTextBx.Size = new System.Drawing.Size(139, 20);
            this.phoneNumberTextBx.TabIndex = 10;
            this.phoneNumberTextBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBx_KeyPress);
            // 
            // AddOrEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(382, 260);
            this.Controls.Add(this.phoneNumberTextBx);
            this.Controls.Add(this.confirmAddClientButton);
            this.Controls.Add(this.mailTextBx);
            this.Controls.Add(this.fathernameTextBx);
            this.Controls.Add(this.nameTextBx);
            this.Controls.Add(this.surnameTextBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrChangeClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrEditClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTextBx;
        private System.Windows.Forms.TextBox nameTextBx;
        private System.Windows.Forms.TextBox fathernameTextBx;
        private System.Windows.Forms.TextBox mailTextBx;
        private System.Windows.Forms.Button confirmAddClientButton;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBx;
    }
}