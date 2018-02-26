using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W01Boodschap
{
    public partial class FrmMessagebox : Form
    {
        public FrmMessagebox()
        {
            InitializeComponent();
        }

        private void btnVenster1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uw verzoek zal behandeld worden." + Environment.NewLine + 
                "Wil je verder werken?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1);
        }

        private void btnVenster2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dit artikel is niet meer op voorraad!", "Voorraadcontrole", MessageBoxButtons.OK,
                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
        }

        private void btnVenster3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dit is niet gelukt!" + Environment.NewLine + "Opnieuw?",
                "Pas op!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}
