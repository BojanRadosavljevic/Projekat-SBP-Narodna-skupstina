using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarodnaSkupstinaSBP.Forme.PravniAkt
{
    public partial class PrikaziPravneAkte : Form
    {
        public PrikaziPravneAkte()
        {
            InitializeComponent();
        }
        private void PrikaziPravneAkte_Load(object sender, EventArgs e)
        {
            //popuniPravnimAktima();
        }
       /* public void popuniPravnimAktima()
        {
            listaPravnihAkta.Items.Clear();
            List<PravniAktView> podaci = DTOManager.VratiSveAkte();



            foreach (PravniAktView p in podaci)
            {
                int br = 0;
                string tip = "";
                string predlagaci = "";
                if(p.GetType()==typeof(BiraciView))
                {
                    BiraciView b = (BiraciView)p;
                    br = b.BrojBiraca;
                    predlagaci = "Biraci";
                }
                if (p.GetType() == typeof(PoslaniciView))
                {
                    predlagaci = "Poslanici";
                }
                if (p.GetType() == typeof(VladaView))
                {
                    predlagaci = "Vlada";
                }
                if (p.GetType() == typeof(ZakonView))
                {
                    tip = "Zakon";
                }
                if (p.GetType() == typeof(DeklaracijaView))
                {
                    tip = "Deklaracija";
                }
                if (p.GetType() == typeof(PreporukaView))
                {
                    tip = "Preporuka";
                }
                if (p.GetType() == typeof(OdlukaView))
                {
                    tip = "Odluka";
                }
                if (p.GetType() == typeof(TumacenjeView))
                {
                    tip = "Tumacenje";
                }
                ListViewItem item = new ListViewItem(new string[] {

                   p.IDPravnogAkta.ToString(),
                   tip,
                   predlagaci,
                   br.ToString()
                    });
                listaPravnihAkta.Items.Add(item);

            }
            listaPravnihAkta.Refresh();
        }*/

        private void btnZakon_Click(object sender, EventArgs e)
        {
            PrikaziZakon forma = new PrikaziZakon();
            forma.ShowDialog();
        }

        private void btnDeklaracija_Click(object sender, EventArgs e)
        {

        }

        private void btnPreporuka_Click(object sender, EventArgs e)
        {

        }

        private void btnOdluka_Click(object sender, EventArgs e)
        {

        }

        private void btnTumacenje_Click(object sender, EventArgs e)
        {

        }

        private void listaPravnihAkta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
