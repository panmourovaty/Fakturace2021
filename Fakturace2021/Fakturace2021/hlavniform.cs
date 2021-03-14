using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace2021
{
    public partial class hlavniform : Form
    {
        public hlavniform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evidencezakazniku evidencezakazniku = new evidencezakazniku();
            evidencezakazniku.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evidencezbozi evidencezbozi = new evidencezbozi();
            evidencezbozi.Show();
        }
    }
}
