using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fakturace2021
{
    public partial class upravazbozi : Form
    {
        public upravazbozi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
            {
                pripojeni.Open();

                string ID = numericUpDown1.Value.ToString();
                string nazev = textBox1.Text;
                float cena = (float)numericUpDown2.Value;
                bool jenasklade = checkBox1.Checked;
                string dotaz = "UPDATE dbo.zbozi SET nazev = @nazev, cena = @cena, jenasklade = @jenasklade WHERE Id="+ID;
                using (SqlCommand sqlDotaz = new SqlCommand(dotaz, pripojeni))
                {
                    sqlDotaz.Parameters.AddWithValue("@nazev", nazev);
                    sqlDotaz.Parameters.AddWithValue("@cena", cena);
                    sqlDotaz.Parameters.AddWithValue("@jenasklade", jenasklade);
                    sqlDotaz.ExecuteNonQuery();

                }
            }

            this.Close();
        }
    }
}
