using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fakturace2021
{
    public partial class evidencezbozi : Form
    {
        public evidencezbozi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\GitHub\Fakturace2021\Fakturace2021\Fakturace2021\Databasefakturace.mdf;Integrated Security=True";
            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();
                string nazev = textBox1.Text;
                float cena = (float)numericUpDown1.Value;
                bool jenasklade = checkBox1.Checked;
                string dotaz = "INSERT INTO dbo.zbozi (nazev, cena, jenasklade) VALUES (@nazev, @cena, @jenasklade)";
                using (SqlCommand sqlDotaz = new SqlCommand(dotaz, pripojeni))
                {
                    sqlDotaz.Parameters.AddWithValue("@nazev", nazev);
                    sqlDotaz.Parameters.AddWithValue("@cena", cena);
                    sqlDotaz.Parameters.AddWithValue("@jenasklade", jenasklade);
                    int radku = sqlDotaz.ExecuteNonQuery();
                    Console.WriteLine(radku);
                }
            }

            this.Close();
        }
    }
}
