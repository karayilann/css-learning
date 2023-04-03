using System.Data.SqlClient;

namespace sql_And_Css
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = null;
            try
            {
                baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sql_And_Css;Integrated Security=True");
                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("SELECT OgrenciID, OgrenciAdi, Not1, Not2 FROM TableOgrenci", baglanti);
                SqlDataReader sqlDR = sqlKomut.ExecuteReader();

                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string adi = sqlDR[1].ToString();
                    int not1 = Convert.ToInt32(sqlDR[2].ToString());
                    int not2 = Convert.ToInt32(sqlDR[2].ToString());

                    float ort = (not1 + not2) / 2;

                    if(ort >= 50f)
                    {
                        textBox1.Text += $"��renci Ad� : {adi} \nNot Ortalamas� : {ort} \nDurumu : GE�T�\n";
                    }
                    else
                    {
                        textBox1.Text += $"��renci Ad� : {adi} \nNot Ortalamas� : {ort} \nDurumu : KALDI";
                    }

                    
                    richTextBox1.Text += "��renci ID'si : " + id + "\n��renci Ad� : " + adi + "\nBirinci Not : " + not1 + "\n�kinci Not : " + not2 + "\n\n";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL query s�ras�nda hata olu�tu !" + ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
    }
}