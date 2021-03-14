using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fakturace2021
{
    public partial class odstranenizbozi : Form
    {
        public odstranenizbozi()
        {
            InitializeComponent();
        }

        private void odstranenizbozi_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jste si jisti ?", "Smazání položky", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
                {
                    pripojeni.Open();

                    string ID = numericUpDown1.Value.ToString();
                    string dotaz = "DELETE FROM dbo.zbozi WHERE Id=" + ID;
                    using (SqlCommand sqlDotaz = new SqlCommand(dotaz, pripojeni))
                    {
                        sqlDotaz.ExecuteNonQuery();
                    }
                }
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
