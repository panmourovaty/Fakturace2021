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

        private void button3_Click(object sender, EventArgs e)
        {
            evidence evidence = new evidence();
            evidence.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Před použitím tohoto programu si přečtěte EULA" + Environment.NewLine + "https://github.com/panmourovaty/Fakturace2021", "EULA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
