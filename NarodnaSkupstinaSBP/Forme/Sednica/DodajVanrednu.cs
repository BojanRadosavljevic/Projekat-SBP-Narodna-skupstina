using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarodnaSkupstinaSBP.Forme.Sednica
{
    public partial class DodajVanrednu : Form
    {
        public DodajVanrednu()
        {
            InitializeComponent();
        }

        private void btnDodajSednicu_Click(object sender, EventArgs e)
        {
            VanrednaBasic sednica = new VanrednaBasic
            {
                DatumPocetka = dtDatumPocekta.Value,
                DatumZavrsetka = dtDatumZavrsetka.Value,
                BrojSaziva = Int32.Parse(txtBrSaziva.Text),
                BrojZasedanja = Int32.Parse(txtBrZasedanja.Text),
                
            };


            DTOManager.DodajSednicuVandrednu(sednica, cmbTipSednice.SelectedItem.ToString(), cmbInicijativaSazivanja.SelectedItem.ToString(),Int32.Parse(txtIdRadnogTela.Text));
            this.Close();

        }

        private void DodajVanrednu_Load(object sender, EventArgs e)
        {

                String[] tipSednice = { "REDOVNA", "VANREDNA" };
                foreach (String item in tipSednice)
                {
                    cmbTipSednice.Items.Add(item);
                }

                String[] inicijativaSazivanja = { "VLADA", "POSLANICI", "REDOVNA" };
                foreach (String item in inicijativaSazivanja)
                {
                    cmbInicijativaSazivanja.Items.Add(item);
                }
            }

        
    }
}
