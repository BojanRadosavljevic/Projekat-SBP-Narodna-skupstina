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
    public partial class DodajSednicu : Form
    {
        public DodajSednicu()
        {
            InitializeComponent();
        }

        private void btnDodajSednicu_Click(object sender, EventArgs e)
        {
                RedovnaBasic sednica = new RedovnaBasic();
                sednica.DatumPocetka = dtDatumPocetka.Value;
                sednica.DatumZavrsetka = dtDatumZavrsetka.Value;
                sednica.BrojSaziva = Int32.Parse(txtBrSaziva.Text);
                sednica.BrojZasedanja = Int32.Parse(txtBrZasedanja.Text);               
                DTOManager.DodajSednicu(sednica);
        }

        private void txtIdRadnogTela_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbInicijativaSazivanja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipSednice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBrZasedanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrSaziva_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtDatumZavrsetka_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtDatumPocekta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DodajSednicu_Load(object sender, EventArgs e)
        {

        }
    }
}
