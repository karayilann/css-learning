namespace form_islemleri
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
            components = new System.ComponentModel.Container();
            captchaTxt = new TextBox();
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            captchaTxt2 = new TextBox();
            login = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // captchaTxt
            // 
            captchaTxt.Location = new Point(165, 151);
            captchaTxt.Name = "captchaTxt";
            captchaTxt.Size = new Size(100, 23);
            captchaTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(165, 113);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(206, 23);
            passwordTxt.TabIndex = 1;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(165, 76);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(206, 23);
            usernameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 76);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adınız :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 113);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Şifrenizi Giriniz :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 159);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 6;
            label3.Text = "Güvenlik Doğrulaması :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(98, 9);
            label4.Name = "label4";
            label4.Size = new Size(282, 40);
            label4.TabIndex = 7;
            label4.Text = "Admin Login Paneli";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(165, 223);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(276, 194);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // captchaTxt2
            // 
            captchaTxt2.Location = new Point(271, 151);
            captchaTxt2.Name = "captchaTxt2";
            captchaTxt2.ReadOnly = true;
            captchaTxt2.Size = new Size(100, 23);
            captchaTxt2.TabIndex = 9;
            // 
            // login
            // 
            login.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(165, 186);
            login.Name = "login";
            login.Size = new Size(100, 31);
            login.TabIndex = 4;
            login.Text = "Giriş Yap";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 250;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AcceptButton = login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(442, 266);
            Controls.Add(login);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(captchaTxt2);
            Controls.Add(usernameTxt);
            Controls.Add(passwordTxt);
            Controls.Add(captchaTxt);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox captchaTxt;
        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private TextBox captchaTxt2;
        private Button login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}