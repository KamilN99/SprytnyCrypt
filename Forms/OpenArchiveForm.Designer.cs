namespace projektPKIK.Forms
{
    partial class OpenArchiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenArchiveForm));
            this.DearchiveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DearchiveButton
            // 
            this.DearchiveButton.Location = new System.Drawing.Point(98, 281);
            this.DearchiveButton.Name = "DearchiveButton";
            this.DearchiveButton.Size = new System.Drawing.Size(75, 23);
            this.DearchiveButton.TabIndex = 21;
            this.DearchiveButton.Text = "Dearchiwizuj";
            this.DearchiveButton.UseVisualStyleBackColor = true;
            this.DearchiveButton.Click += new System.EventHandler(this.DearchiveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasło";
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(89, 230);
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(100, 20);
            this.password1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ścieżka wyjściowa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ścieżka wejściowa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 20);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(89, 119);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(100, 20);
            this.outputPath.TabIndex = 12;
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(89, 61);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(100, 20);
            this.inputPath.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rodzaj kompresji";
            // 
            // OpenArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DearchiveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.inputPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenArchiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SprytnyCrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DearchiveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}