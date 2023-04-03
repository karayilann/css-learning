using System.IO;
namespace random_Subjects
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Lütfen dosya oluþtururken önce dosya adýný yazýnýz aksi takdirde dosyanýz isimsiz oluþturulmaktadýr.",
                            "UYARI",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label2.Text = openFileDialog1.FileName;
        }


        string belgeYolu, belgeAdi;
        private void btnKonum_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)        // Açýlan pencerede eðer Tamam tuþuna týklanýrsa yapýlacak olanlar
            {
                belgeYolu = folderBrowserDialog1.SelectedPath;                // Belgenin adresini kaydettik.
                belgeAdi = textBox1.Text;
                textBox2.Text = belgeYolu;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(belgeYolu + "\\" + belgeAdi + ".txt");

            // En baþta verilecek mesaj, Ardýndan gelen kutucuðun sol üstteki ismi, Kutucukta bulunan tuþ, ve kutucuðun tipi
            MessageBox.Show($"{belgeAdi} isimli belgeniz baþarýyla oluþturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();                 // Her bir satýrý okumasýný istedik.

                while (satir != null)                          // Satýr sayýsý bitene kadar oku ve listboxa yaz
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();

                    if (satir == null)                        // Eðer satýr biterse uyarý verecek dosyada yazýlý olan çok þey olursa baþýnda beklemek sýkýntý :)
                    {
                        MessageBox.Show("Okunacak Satýr Kalmadý.", "OKU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Dosya Adý |*.doc";        // Dosya adýný ve türlerini belirtmek için yazdýk.
            saveFileDialog1.ShowDialog();

            StreamWriter sw2 = new StreamWriter(saveFileDialog1.FileName);

            sw2.WriteLine(richTextBox1.Text);                  // Dosyaya nereden yazdýrmasý gerektiðini belirttik.
            sw2.Close();                                        // bitince kapatmasýný söyledik.

            MessageBox.Show("Kayýt Baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);   // iþlem bitince gelen uyarý mesajýný yazdýk.

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}