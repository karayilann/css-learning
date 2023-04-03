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
                        textBox1.Text += $"Öðrenci Adý : {adi} \nNot Ortalamasý : {ort} \nDurumu : GEÇTÝ\n";
                    }
                    else
                    {
                        textBox1.Text += $"Öðrenci Adý : {adi} \nNot Ortalamasý : {ort} \nDurumu : KALDI";
                    }

                    
                    richTextBox1.Text += "Öðrenci ID'si : " + id + "\nÖðrenci Adý : " + adi + "\nBirinci Not : " + not1 + "\nÝkinci Not : " + not2 + "\n\n";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL query sýrasýnda hata oluþtu !" + ex.ToString());
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