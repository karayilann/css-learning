namespace oop_learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil otomobil1 = new Otomobil("Mat Siyah", "Prestige");
            Otomobil otomobil2 = new Otomobil("Beyaz","S Line");

            /*otomobil1.renk = "Mat Siyah";
            otomobil2.renk = "Beyaz";
            otomobil1.PaketAdi = "Prestige";
            otomobil2.PaketAdi = "S Line";*/

            otomobil1.renk = "Füme";   // Bu yöntem ile constructora verdiðimiz deðiþkeni tekrardan düzenleyebiliriz.

            // otomobil1.setMarka("Merso");      // Bu methot ile private olan marka deðiþkenini deðiþtirdik.

            richTextBox1.Text = "Otomobil1'in özellikleri : \nRenk : " + otomobil1.renk + " \nPaket Adý : " + otomobil1.PaketAdi + "\nMarkasý : " + otomobil1.showMarka();
        }
    }
}