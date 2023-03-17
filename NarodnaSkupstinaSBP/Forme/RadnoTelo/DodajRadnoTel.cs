using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarodnaSkupstinaSBP.Forme.RadnoTelo
{
    public partial class DodajRadnoTel : Form
    {
        public DodajRadnoTel()
        {
            InitializeComponent();
        }

        private void btnDodajRadnoTelo_Click(object sender, EventArgs e)
        {
            RadnoTeloBasic rad = new RadnoTeloBasic
            {
                Sprat = Int32.Parse(txtSprat.Text),
                Broj = Int32.Parse(txtBroj.Text),
                IDPredsednika = Int32.Parse(txtIDPredsednika.Text),
                IDZamenika=Int32.Parse(txtIDZamenika.Text),          
            };
            DTOManager.DodajRadnoTelo(rad, cmbTipRadnogTela.SelectedItem.ToString());
        }

        private void DodajRadnoTel_Load(object sender, EventArgs e)
        {
            String[] tipSednice = { "KOMISIJE", "STALNI ODBOR","ANKETNI ODBOR","PRIVREMENI ODBOR"};
            foreach (String item in tipSednice)
            {
                cmbTipRadnogTela.Items.Add(item);
            }
        }
    }
}
