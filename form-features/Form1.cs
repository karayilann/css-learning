namespace form_features
{
    public partial class Form1 : Form
    {

        string username = "karayilann";
        string password = "karayilann";

        public Form1()
        {
            InitializeComponent();
            label4.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/muhammetkarayilan");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)
            {
                Form2 succes = new Form2();
                this.Hide();
                succes.Show();  // Bu kod ile ayrý pencere açarak form2'yi görüntüler.

                //succes.ShowDialog(); // Bu kod ile ayrý ve zorunlu pencere açýlýr.

            }
            else
            {
                label4.Show();

                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;

                textBox1.Clear();
                textBox2.Clear();

                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 logged = new Form3();
            this.Hide();
            logged.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}