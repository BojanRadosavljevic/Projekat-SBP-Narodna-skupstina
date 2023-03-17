using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarodnaSkupstinaSBP.Forme.PoslanickaGrupa
{
    public partial class PrikaziPoslanickeGrupe : Form
    {
        public PrikaziPoslanickeGrupe()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {


            listaPoslanickihGrupa.Items.Clear();
            List<PoslanickaGrupaView> podaci = DTOManager.vratiSveGrupe();



            foreach (PoslanickaGrupaView p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ImeGrupe, p.IDPredsednika.ToString(), p.IDZamenika.ToString() });
                listaPoslanickihGrupa.Items.Add(item);

            }

            listaPoslanickihGrupa.Refresh();
        }

        private void DodavanjePoslanickeGrupe_Load(object sender, EventArgs e)
        {
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrikaziPoslanickeGrupe_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            List<PoslanickaGrupaView> p = DTOManager.vratiSveGrupe();
            //txtUkupanBrojGrupa.Text = p.Count.ToString();
        }
    }
}
