namespace timer_progressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 90)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)  // start
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)  // stop
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)  //clear
        {
            progressBar1.Value = 0;
            timer1.Stop();
        }
    }
}