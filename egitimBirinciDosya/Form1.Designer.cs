namespace egitimBirinciDosya
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
            butondeneme = new Button();
            textBoxDeneme = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // butondeneme
            // 
            butondeneme.Location = new Point(12, 12);
            butondeneme.Name = "butondeneme";
            butondeneme.Size = new Size(110, 26);
            butondeneme.TabIndex = 0;
            butondeneme.Text = "Kullanıcı Adı Yaz";
            butondeneme.UseVisualStyleBackColor = true;
            butondeneme.Click += butondeneme_Click;
            // 
            // textBoxDeneme
            // 
            textBoxDeneme.Location = new Point(128, 15);
            textBoxDeneme.Name = "textBoxDeneme";
            textBoxDeneme.Size = new Size(191, 23);
            textBoxDeneme.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BMW", "Mercedes - Benz", "Audi", "Volkswagen", "Tofaş", "TOGG", "Scania" });
            comboBox1.Location = new Point(128, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 349);
            Controls.Add(comboBox1);
            Controls.Add(textBoxDeneme);
            Controls.Add(butondeneme);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butondeneme;
        private TextBox textBoxDeneme;
        private ComboBox comboBox1;
    }
}