using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Fakturace2021
{
    public partial class vyhledavanizbozi : Form
    {
        public vyhledavanizbozi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
            {
                pripojeni.Open();

                string nazev = textBox1.Text;
                label4.Text = nazev;
                SqlDataAdapter SqlData2 = new SqlDataAdapter("SELECT * FROM dbo.zbozi WHERE nazev = '"+nazev+"'", pripojeni);
                DataTable tabulkazbozi = new DataTable();
                SqlData2.Fill(tabulkazbozi);
                dataGridView2.DataSource = tabulkazbozi;
            }
        }
    }
}
