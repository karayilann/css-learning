namespace geometrikSekilHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            // Kare alan� hesaplama
            int kenar = Convert.ToInt32(textBox1.Text);
            int alan = kenar * kenar;
            textBox5.Text = alan.ToString();

            // Dikd�rtgen alan� hesaplama
            int k�saKenar = Convert.ToInt32(textBox2.Text);
            int uzunKenar = Convert.ToInt32(textBox3.Text);
            int sonuc = k�saKenar * uzunKenar;
            textBox6.Text = sonuc.ToString();

            // Daire Alan� Hesaplama
            int yaricap = Convert.ToInt32(textBox4.Text);
            double daireAlan = Math.PI * (Math.Pow(yaricap, yaricap));
            textBox7.Text = daireAlan.ToString();
        }
    }
}