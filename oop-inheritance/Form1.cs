namespace oop_inheritance
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {
            kalemler kalem1 = new kalemler();
            otherPencils kalem2 = new otherPencils();

            kalem1.price = 15;
            kalem1.setPen("Tükenmez Kalem");
            kalem1.brand = "Faber Castel";
            kalem1.pencilColor = "Blue";

            richTextBox1.Text = "Kalem1".ToUpper() +
                    "\nKalemin markasý : " + kalem1.brand +
                    "\nKalemin rengi : " + kalem1.pencilColor +
                    "\nKalemin Türü : " + kalem1.pencilType() +
                    "\nKalemin Fiyatý : " + kalem1.price + " " + kalem2.otherPencils1("yes");

        }
    }
}