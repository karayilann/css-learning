using System.Windows.Forms.VisualStyles;

namespace form_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void kodOlustur()
        {
            Random random = new Random();                       // Random methodunundan nesne türettik.
            int captcha = random.Next(1000, 10000);             // belirlenecek sayýnýn aralýðýný yazdýk.
            captchaTxt2.Text = captcha.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodOlustur();
            timer1.Start();
        }

        string username = "admin";
        string password = "1234";

        private void login_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == username && passwordTxt.Text == password && captchaTxt.Text == captchaTxt2.Text)
            {
                Form2 form2 = new Form2();
                form2.user = usernameTxt.Text;
                this.Hide();
                form2.Show();
            }
            else
            {
                timer2.Start();
                MessageBox.Show("Lütfen girdiðiniz bilglierin doðruluðunu kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                label4.BackColor = Color.Yellow;
            }
            else
            {
                label4.BackColor = Color.Blue;
            }
            if (sayac == 10)
            {
                sayac = 0;
            }
        }

        void colorer()
        {
            
        }

        void backColorer()
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            usernameTxt.BackColor = Color.Red;
            passwordTxt.BackColor = Color.Red;
            captchaTxt.BackColor = Color.Red;
            login.BackColor = Color.Red;

            if (timer2.Interval == 250)
            {
                usernameTxt.BackColor = Color.White;
                passwordTxt.BackColor = Color.White;
                captchaTxt.BackColor = Color.White;
                login.BackColor = Color.White;
            }
        }
    }
}