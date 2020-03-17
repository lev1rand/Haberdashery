namespace Haberdashery_course
{
    partial class AddOrEditService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditService));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicetextBox = new System.Windows.Forms.TextBox();
            this.minCosttextBox = new System.Windows.Forms.TextBox();
            this.maxCosttextBox = new System.Windows.Forms.TextBox();
            this.confirmServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва послуги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Діапазон вартості від:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Діапазон вартості до:";
            // 
            // servicetextBox
            // 
            this.servicetextBox.Location = new System.Drawing.Point(215, 25);
            this.servicetextBox.Name = "servicetextBox";
            this.servicetextBox.Size = new System.Drawing.Size(119, 20);
            this.servicetextBox.TabIndex = 4;
            this.servicetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.servicetextBox_KeyPress);
            // 
            // minCosttextBox
            // 
            this.minCosttextBox.Location = new System.Drawing.Point(215, 67);
            this.minCosttextBox.Name = "minCosttextBox";
            this.minCosttextBox.Size = new System.Drawing.Size(119, 20);
            this.minCosttextBox.TabIndex = 5;
            this.minCosttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minCosttextBox_KeyPress);
            // 
            // maxCosttextBox
            // 
            this.maxCosttextBox.Location = new System.Drawing.Point(215, 109);
            this.maxCosttextBox.Name = "maxCosttextBox";
            this.maxCosttextBox.Size = new System.Drawing.Size(119, 20);
            this.maxCosttextBox.TabIndex = 6;
            this.maxCosttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxCosttextBox_KeyPress);
            // 
            // confirmServiceButton
            // 
            this.confirmServiceButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.confirmServiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.confirmServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmServiceButton.Location = new System.Drawing.Point(324, 147);
            this.confirmServiceButton.Name = "confirmServiceButton";
            this.confirmServiceButton.Size = new System.Drawing.Size(56, 23);
            this.confirmServiceButton.TabIndex = 7;
            this.confirmServiceButton.Text = "OK";
            this.confirmServiceButton.UseVisualStyleBackColor = false;
            this.confirmServiceButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // AddOrEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(392, 182);
            this.Controls.Add(this.confirmServiceButton);
            this.Controls.Add(this.maxCosttextBox);
            this.Controls.Add(this.minCosttextBox);
            this.Controls.Add(this.servicetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrEditService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrEditService";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrEditService_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox servicetextBox;
        private System.Windows.Forms.TextBox minCosttextBox;
        private System.Windows.Forms.TextBox maxCosttextBox;
        private System.Windows.Forms.Button confirmServiceButton;
    }
}