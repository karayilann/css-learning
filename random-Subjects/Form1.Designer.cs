namespace random_Subjects
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
            saveFile = new Button();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            openfile = new Button();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnKonum = new Button();
            btnCreate = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // saveFile
            // 
            saveFile.Location = new Point(12, 12);
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(165, 23);
            saveFile.TabIndex = 0;
            saveFile.Text = "Folder Browser Dialog";
            saveFile.UseVisualStyleBackColor = true;
            saveFile.Click += saveFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openfile
            // 
            openfile.Location = new Point(12, 69);
            openfile.Name = "openfile";
            openfile.Size = new Size(165, 23);
            openfile.TabIndex = 2;
            openfile.Text = "Open File Dialog";
            openfile.UseVisualStyleBackColor = true;
            openfile.Click += openfile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // btnKonum
            // 
            btnKonum.Location = new Point(450, 12);
            btnKonum.Name = "btnKonum";
            btnKonum.Size = new Size(165, 23);
            btnKonum.TabIndex = 4;
            btnKonum.Text = "Konum Seç";
            btnKonum.UseVisualStyleBackColor = true;
            btnKonum.Click += btnKonum_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(450, 77);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(165, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Oluştur";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(450, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 51);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Belge Adı : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 16);
            label4.Name = "label4";
            label4.Size = new Size(178, 15);
            label4.TabIndex = 8;
            label4.Text = "Belgenin kaydedileceği konum : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 115);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Belge Yolu : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(450, 152);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 11;
            button1.Text = "OKU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 156);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 12;
            label6.Text = "Yazdığın belgeyi oku";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(450, 194);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 124);
            listBox1.TabIndex = 13;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 156);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 166);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(32, 127);
            button2.Name = "button2";
            button2.Size = new Size(165, 23);
            button2.TabIndex = 15;
            button2.Text = "YAZDIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 333);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnCreate);
            Controls.Add(btnKonum);
            Controls.Add(label2);
            Controls.Add(openfile);
            Controls.Add(label1);
            Controls.Add(saveFile);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveFile;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button openfile;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnKonum;
        private Button btnCreate;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Button button1;
        private Label label6;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Button button2;
        private SaveFileDialog saveFileDialog1;
    }
}