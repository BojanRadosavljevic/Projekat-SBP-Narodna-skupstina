using NarodnaSkupstinaSBP.Entiteti;
using NHibernate;
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
    public partial class PrikaziZakon : Form
    {
        public PrikaziZakon()
        {
            InitializeComponent();
        }

        private void PrikaziZakon_Load(object sender, EventArgs e)
        {
            popuniZakonima();
        }
        public void popuniZakonima()
        {
            listaZakona.Items.Clear();
            List<ZakonView> podaci = DTOManager.VratiSveZakone();



            foreach (ZakonView p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {

                   p.IDPravnogAkta.ToString()
                    });
                listaZakona.Items.Add(item);

            }
            listaZakona.Refresh();
        }
        
    }
}
