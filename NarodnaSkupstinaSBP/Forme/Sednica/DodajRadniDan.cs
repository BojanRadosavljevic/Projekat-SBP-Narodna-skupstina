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
    public partial class DodajRadniDan : Form
    {
        public DodajRadniDan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajRadniDan_Click(object sender, EventArgs e)
        {
            RadniDanBasic rad = new RadniDanBasic();

            rad.BrojPoslanik = Int32.Parse(txtBrojPoslanika.Text);
            rad.PocetakRada = txtPocetakRada.Text;
            rad.KrajRada = txtKrajRada.Text;



            DTOManager.DodajRadniDan(rad,Int32.Parse(txtIDSednice.Text));
        }
    }
}
