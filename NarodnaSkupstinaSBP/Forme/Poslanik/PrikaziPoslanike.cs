using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NarodnaSkupstinaSBP.DTOs;

namespace NarodnaSkupstinaSBP.Forme.Poslanik
{
    public partial class PrikaziPoslanike : Form
    {
        public PrikaziPoslanike()
        {
            InitializeComponent();
           // popuniPoslanicima();
        }
        public void popuniPoslanicima()
        {


            listaPoslanika.Items.Clear();
            List<PoslanikView> podaci = DTOManager.vratiSvePoslanike();



            foreach (PoslanikView p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    p.IDPoslanika.ToString(),
                    p.LicnoIme,
                    p.ImeRoditelja,
                    p.Prezime,
                    p.JMBG,
                    p.MestoStanovanja,
                    p.Adresa,
                    p.MestoRodjenja,
                    p.DatumRodjenja.Date.ToString("d"),
                    p.IzbornaLista
                    });
                listaPoslanika.Items.Add(item);

            }
            listaPoslanika.Refresh();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrikaziPoslanike_Load(object sender, EventArgs e)
        {
            popuniPoslanicima();
            List<PoslanikView> p = DTOManager.vratiSvePoslanike();
            txtUkupanBrojPoslanika.Text = p.Count.ToString();
            txtUkupanBrojPoslanika.Enabled = false;
        }
    }
}
