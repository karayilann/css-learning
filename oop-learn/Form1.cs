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

            otomobil1.renk = "F�me";   // Bu y�ntem ile constructora verdi�imiz de�i�keni tekrardan d�zenleyebiliriz.

            // otomobil1.setMarka("Merso");      // Bu methot ile private olan marka de�i�kenini de�i�tirdik.

            richTextBox1.Text = "Otomobil1'in �zellikleri : \nRenk : " + otomobil1.renk + " \nPaket Ad� : " + otomobil1.PaketAdi + "\nMarkas� : " + otomobil1.showMarka();
        }
    }
}