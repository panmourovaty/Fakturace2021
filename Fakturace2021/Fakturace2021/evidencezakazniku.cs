using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fakturace2021
{
    public partial class evidencezakazniku : Form
    {
        public evidencezakazniku()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void evidencezakazniku_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
            {
                pripojeni.Open();

                string jmenoprijmeni = textBox1.Text;
                string typ = (string)comboBox1.Text;
                string adresa = textBox2.Text;
                string ICO = numericUpDown1.Value.ToString();
                string email = textBox3.Text;
                string telcislo = textBox4.Text;

                string dotaz = "INSERT INTO dbo.zakaznici (jmenoprijmeni, typ, adresa, ICO, email, telcislo) VALUES (@jmenoprijmeni, @typ, @adresa, @ICO, @email, @telcislo)";
                using (SqlCommand sqlDotaz = new SqlCommand(dotaz, pripojeni))
                {
                    sqlDotaz.Parameters.AddWithValue("@jmenoprijmeni", jmenoprijmeni);
                    sqlDotaz.Parameters.AddWithValue("@typ", typ);
                    sqlDotaz.Parameters.AddWithValue("@adresa", adresa);
                    sqlDotaz.Parameters.AddWithValue("@ICO", ICO);
                    sqlDotaz.Parameters.AddWithValue("@email", email);
                    sqlDotaz.Parameters.AddWithValue("@telcislo", telcislo);
                    int radku = sqlDotaz.ExecuteNonQuery();
                    Console.WriteLine(radku);
                }
            }
            this.Close();
        }
    }
}
