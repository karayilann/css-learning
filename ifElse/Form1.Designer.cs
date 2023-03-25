namespace ifElse
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
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            birinci = new TextBox();
            ikinci = new TextBox();
            sonucPrint = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(607, 37);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Geçme Kalma Hesaplama Uygulaması";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 127);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 190);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Birinci Sınav :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 228);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 3;
            label3.Text = "İkinci Sınav :";
            // 
            // birinci
            // 
            birinci.Location = new Point(231, 190);
            birinci.Multiline = true;
            birinci.Name = "birinci";
            birinci.Size = new Size(100, 20);
            birinci.TabIndex = 4;
            birinci.TextChanged += birinci_TextChanged;
            // 
            // ikinci
            // 
            ikinci.Location = new Point(231, 229);
            ikinci.Multiline = true;
            ikinci.Name = "ikinci";
            ikinci.Size = new Size(100, 20);
            ikinci.TabIndex = 5;
            // 
            // sonucPrint
            // 
            sonucPrint.BackColor = SystemColors.Window;
            sonucPrint.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            sonucPrint.Location = new Point(210, 308);
            sonucPrint.Multiline = true;
            sonucPrint.Name = "sonucPrint";
            sonucPrint.Size = new Size(149, 47);
            sonucPrint.TabIndex = 6;
            sonucPrint.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(258, 285);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Sonuç :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(360, 198);
            button1.Name = "button1";
            button1.Size = new Size(80, 39);
            button1.TabIndex = 8;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(644, 378);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(sonucPrint);
            Controls.Add(ikinci);
            Controls.Add(birinci);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Öğrenci Durumu Hesaplama";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox birinci;
        private TextBox ikinci;
        private TextBox sonucPrint;
        private Label label4;
        private Button button1;
    }
}