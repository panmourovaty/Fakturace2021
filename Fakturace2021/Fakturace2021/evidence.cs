using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fakturace2021
{
    public partial class evidence : Form
    {
        public evidence()
        {
            InitializeComponent();
        }

        private void evidence_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\GitHub\Fakturace2021\Fakturace2021\Fakturace2021\Databasefakturace.mdf;Integrated Security=True";
            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();

                SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.zakaznici",pripojeni);
                DataTable tabulkazakaznici = new DataTable();
                SqlData.Fill(tabulkazakaznici);
                dataGridView1.DataSource = tabulkazakaznici;

                SqlDataAdapter SqlData2 = new SqlDataAdapter("SELECT * FROM dbo.zbozi", pripojeni);
                DataTable tabulkazbozi = new DataTable();
                SqlData2.Fill(tabulkazbozi);
                dataGridView2.DataSource = tabulkazbozi;
            }

        }
    }
}
