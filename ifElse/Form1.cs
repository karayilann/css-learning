namespace ifElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void birinci_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int not1 = Convert.ToInt32(birinci.Text);
            int not2 = Convert.ToInt32(ikinci.Text);

            float ortalama = (not1 + not2) / 2;
            //float not = 50f;

            if (ortalama >= 50f)
            {
                sonucPrint.BackColor = Color.Green;
                sonucPrint.Text = " GEÇER ";
            }
            else
            {
                sonucPrint.BackColor = Color.Red;
                sonucPrint.Text = " GEÇEMEZ ";
            }
        }
    }
}