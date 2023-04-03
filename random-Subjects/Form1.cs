using System.IO;
namespace random_Subjects
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("L�tfen dosya olu�tururken �nce dosya ad�n� yaz�n�z aksi takdirde dosyan�z isimsiz olu�turulmaktad�r.",
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)        // A��lan pencerede e�er Tamam tu�una t�klan�rsa yap�lacak olanlar
            {
                belgeYolu = folderBrowserDialog1.SelectedPath;                // Belgenin adresini kaydettik.
                belgeAdi = textBox1.Text;
                textBox2.Text = belgeYolu;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(belgeYolu + "\\" + belgeAdi + ".txt");

            // En ba�ta verilecek mesaj, Ard�ndan gelen kutucu�un sol �stteki ismi, Kutucukta bulunan tu�, ve kutucu�un tipi
            MessageBox.Show($"{belgeAdi} isimli belgeniz ba�ar�yla olu�turuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();                 // Her bir sat�r� okumas�n� istedik.

                while (satir != null)                          // Sat�r say�s� bitene kadar oku ve listboxa yaz
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();

                    if (satir == null)                        // E�er sat�r biterse uyar� verecek dosyada yaz�l� olan �ok �ey olursa ba��nda beklemek s�k�nt� :)
                    {
                        MessageBox.Show("Okunacak Sat�r Kalmad�.", "OKU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Dosya Ad� |*.doc";        // Dosya ad�n� ve t�rlerini belirtmek i�in yazd�k.
            saveFileDialog1.ShowDialog();

            StreamWriter sw2 = new StreamWriter(saveFileDialog1.FileName);

            sw2.WriteLine(richTextBox1.Text);                  // Dosyaya nereden yazd�rmas� gerekti�ini belirttik.
            sw2.Close();                                        // bitince kapatmas�n� s�yledik.

            MessageBox.Show("Kay�t Ba�ar�l�!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);   // i�lem bitince gelen uyar� mesaj�n� yazd�k.

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}