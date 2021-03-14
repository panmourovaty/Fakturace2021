﻿using System;
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
            using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
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

            comboBox1.Text = "Vše";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string polozka = comboBox1.Text;
            if (polozka.Contains("Firma"))
            {
                using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
                {
                    pripojeni.Open();

                    SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.zakaznici WHERE typ='firma'", pripojeni);
                    DataTable tabulkazakaznici = new DataTable();
                    SqlData.Fill(tabulkazakaznici);
                    dataGridView1.DataSource = tabulkazakaznici;
                }
            }
            else if (polozka.Contains("Živnostník"))
            {
                using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
                {
                    pripojeni.Open();

                    SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.zakaznici WHERE typ='živnostník'", pripojeni);
                    DataTable tabulkazakaznici = new DataTable();
                    SqlData.Fill(tabulkazakaznici);
                    dataGridView1.DataSource = tabulkazakaznici;
                }
            }
            else
            {
                using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
                {
                    pripojeni.Open();

                    SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.zakaznici", pripojeni);
                    DataTable tabulkazakaznici = new DataTable();
                    SqlData.Fill(tabulkazakaznici);
                    dataGridView1.DataSource = tabulkazakaznici;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
            {
                pripojeni.Open();

                SqlDataAdapter SqlData2 = new SqlDataAdapter("SELECT * FROM dbo.zbozi WHERE jenasklade='True'", pripojeni);
                DataTable tabulkazbozi = new DataTable();
                SqlData2.Fill(tabulkazbozi);
                dataGridView2.DataSource = tabulkazbozi;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection pripojeni = new SqlConnection(pripojenikdatabazi.connectionString))
            {
                pripojeni.Open();

                SqlDataAdapter SqlData2 = new SqlDataAdapter("SELECT * FROM dbo.zbozi", pripojeni);
                DataTable tabulkazbozi = new DataTable();
                SqlData2.Fill(tabulkazbozi);
                dataGridView2.DataSource = tabulkazbozi;
            }
        }
    }
}
