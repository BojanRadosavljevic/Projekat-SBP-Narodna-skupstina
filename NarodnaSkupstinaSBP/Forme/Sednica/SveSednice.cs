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
    public partial class SveSednice : Form
    {
        public SveSednice()
        {
            InitializeComponent();
        }
        public void popuniSednicama()
        {


            listaSednica.Items.Clear();
            List<SednicaView> podaci = DTOManager.VratiSveSednice();


            foreach (SednicaView p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   p.IDSednice.ToString(),
                   p.BrojSaziva.ToString(),
                   p.BrojZasedanja.ToString(),
                   p.DatumPocetka.ToString(),
                   p.DatumZavrsetka.ToString()
                    });
                listaSednica.Items.Add(item);

            }
            listaSednica.Refresh();
        }
        private void SveSednice_Load(object sender, EventArgs e)
        {
            popuniSednicama();
        }

        private void btnDodajSednicu_Click(object sender, EventArgs e)
        {
            DodajSednicu forma= new DodajSednicu();
            forma.ShowDialog();
        }

        private void btnDodajRadniDan_Click(object sender, EventArgs e)
        {
            DodajRadniDan forma = new DodajRadniDan();
            forma.ShowDialog();
        }

        private void cmdVanredna_Click(object sender, EventArgs e)
        {
            DodajVanrednu forma = new DodajVanrednu();
            forma.ShowDialog();
        }
    }
}
