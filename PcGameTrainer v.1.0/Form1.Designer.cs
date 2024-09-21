namespace PcGameTrainer_v._1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            toggleButton1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            toggleButton2 = new Button();
            toggleButton3 = new Button();
            toggleButton4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(37, 64);
            label1.Name = "label1";
            label1.Size = new Size(168, 41);
            label1.TabIndex = 4;
            label1.Text = "God mode:";
            // 
            // toggleButton1
            // 
            toggleButton1.BackColor = Color.Red;
            toggleButton1.BackgroundImageLayout = ImageLayout.Stretch;
            toggleButton1.FlatAppearance.BorderSize = 0;
            toggleButton1.FlatStyle = FlatStyle.Flat;
            toggleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toggleButton1.ForeColor = Color.White;
            toggleButton1.Location = new Point(255, 64);
            toggleButton1.Name = "toggleButton1";
            toggleButton1.Size = new Size(65, 41);
            toggleButton1.TabIndex = 5;
            toggleButton1.Text = "OFF";
            toggleButton1.UseVisualStyleBackColor = false;
            toggleButton1.Click += toggleButton1_Click_1;
            toggleButton1.Paint += toggleButton1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(37, 153);
            label2.Name = "label2";
            label2.Size = new Size(162, 41);
            label2.TabIndex = 4;
            label2.Text = "Infinite HP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(37, 236);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 4;
            label3.Text = "Infinite Rage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(37, 326);
            label4.Name = "label4";
            label4.Size = new Size(113, 41);
            label4.TabIndex = 4;
            label4.Text = "No CD:";
            // 
            // toggleButton2
            // 
            toggleButton2.BackColor = Color.Red;
            toggleButton2.BackgroundImageLayout = ImageLayout.Stretch;
            toggleButton2.FlatAppearance.BorderSize = 0;
            toggleButton2.FlatStyle = FlatStyle.Flat;
            toggleButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toggleButton2.ForeColor = Color.White;
            toggleButton2.Location = new Point(255, 153);
            toggleButton2.Name = "toggleButton2";
            toggleButton2.Size = new Size(65, 41);
            toggleButton2.TabIndex = 5;
            toggleButton2.Text = "OFF";
            toggleButton2.UseVisualStyleBackColor = false;
            toggleButton2.Click += toggleButton2_Click;
            // 
            // toggleButton3
            // 
            toggleButton3.BackColor = Color.Red;
            toggleButton3.BackgroundImageLayout = ImageLayout.Stretch;
            toggleButton3.FlatAppearance.BorderSize = 0;
            toggleButton3.FlatStyle = FlatStyle.Flat;
            toggleButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toggleButton3.ForeColor = Color.White;
            toggleButton3.Location = new Point(255, 236);
            toggleButton3.Name = "toggleButton3";
            toggleButton3.Size = new Size(65, 41);
            toggleButton3.TabIndex = 5;
            toggleButton3.Text = "OFF";
            toggleButton3.UseVisualStyleBackColor = false;
            toggleButton3.Click += toggleButton3_Click;
            // 
            // toggleButton4
            // 
            toggleButton4.BackColor = Color.Red;
            toggleButton4.BackgroundImageLayout = ImageLayout.Stretch;
            toggleButton4.FlatAppearance.BorderSize = 0;
            toggleButton4.FlatStyle = FlatStyle.Flat;
            toggleButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toggleButton4.ForeColor = Color.White;
            toggleButton4.Location = new Point(255, 326);
            toggleButton4.Name = "toggleButton4";
            toggleButton4.Size = new Size(65, 41);
            toggleButton4.TabIndex = 5;
            toggleButton4.Text = "OFF";
            toggleButton4.UseVisualStyleBackColor = false;
            toggleButton4.Click += toggleButton4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.God_of_War_1080_Main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 484);
            Controls.Add(toggleButton4);
            Controls.Add(toggleButton3);
            Controls.Add(toggleButton2);
            Controls.Add(toggleButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button toggleButton1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button toggleButton2;
        private Button toggleButton3;
        private Button toggleButton4;
    }
}
