namespace Haberdashery_course
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBx = new System.Windows.Forms.TextBox();
            this.cofirmButton = new System.Windows.Forms.Button();
            this.showPasswordCheckBx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sowjetschablone", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизуйтесь в системі, будь ласка!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Користувач:";
            // 
            // userComboBox
            // 
            this.userComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userComboBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(40, 76);
            this.userComboBox.MaxDropDownItems = 2;
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(299, 25);
            this.userComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // passwordTextBx
            // 
            this.passwordTextBx.Location = new System.Drawing.Point(40, 126);
            this.passwordTextBx.Name = "passwordTextBx";
            this.passwordTextBx.Size = new System.Drawing.Size(299, 20);
            this.passwordTextBx.TabIndex = 4;
            this.passwordTextBx.UseSystemPasswordChar = true;
            // 
            // cofirmButton
            // 
            this.cofirmButton.BackColor = System.Drawing.Color.Transparent;
            this.cofirmButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cofirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cofirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cofirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cofirmButton.Font = new System.Drawing.Font("Sowjetschablone", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cofirmButton.Location = new System.Drawing.Point(104, 190);
            this.cofirmButton.Name = "cofirmButton";
            this.cofirmButton.Size = new System.Drawing.Size(171, 28);
            this.cofirmButton.TabIndex = 5;
            this.cofirmButton.Text = "Авторизуватися";
            this.cofirmButton.UseVisualStyleBackColor = false;
            this.cofirmButton.Click += new System.EventHandler(this.cofirmButton_Click);
            // 
            // showPasswordCheckBx
            // 
            this.showPasswordCheckBx.AutoSize = true;
            this.showPasswordCheckBx.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordCheckBx.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordCheckBx.ForeColor = System.Drawing.SystemColors.Control;
            this.showPasswordCheckBx.Location = new System.Drawing.Point(40, 152);
            this.showPasswordCheckBx.Name = "showPasswordCheckBx";
            this.showPasswordCheckBx.Size = new System.Drawing.Size(184, 15);
            this.showPasswordCheckBx.TabIndex = 7;
            this.showPasswordCheckBx.Text = "показати пароль";
            this.showPasswordCheckBx.UseVisualStyleBackColor = false;
            this.showPasswordCheckBx.CheckedChanged += new System.EventHandler(this.showPasswordCheckBx_CheckedChanged);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = global::Haberdashery_course.Properties.Resources.BD_157_Teal_1_550x5505;
            this.ClientSize = new System.Drawing.Size(377, 238);
            this.Controls.Add(this.showPasswordCheckBx);
            this.Controls.Add(this.cofirmButton);
            this.Controls.Add(this.passwordTextBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBx;
        private System.Windows.Forms.Button cofirmButton;
        private System.Windows.Forms.CheckBox showPasswordCheckBx;
    }
}

