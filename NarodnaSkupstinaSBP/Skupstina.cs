using NarodnaSkupstinaSBP.Forme.PoslanickaGrupa;
using NarodnaSkupstinaSBP.Forme.Poslanik;
using NarodnaSkupstinaSBP.Forme.PravniAkt;
using NarodnaSkupstinaSBP.Forme.RadnoTelo;
using NarodnaSkupstinaSBP.Forme.Sednica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarodnaSkupstinaSBP
{
    public partial class Skupstina : Form
    {
        public Skupstina()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void skupstinaPhoto_Click(object sender, EventArgs e)
        {

        }

        private void cmdPoslanici_Click(object sender, EventArgs e)
        {
            PrikaziPoslanike forma = new PrikaziPoslanike();
            forma.ShowDialog();
        }

        private void cmdPoslanickeGrupe_Click(object sender, EventArgs e)
        {
            PrikaziPoslanickeGrupe forma = new PrikaziPoslanickeGrupe();
            forma.ShowDialog();
        }

        private void cmdPravniAkti_Click(object sender, EventArgs e)
        {
            PrikaziPravneAkte forma = new PrikaziPravneAkte();
            forma.ShowDialog();
        }

        private void cmdSednice_Click(object sender, EventArgs e)
        {
            SveSednice forma = new SveSednice();
            forma.ShowDialog();
        }

        private void cmdRadnaTela_Click(object sender, EventArgs e)
        {
            DodajRadnoTel forma = new DodajRadnoTel();
            forma.ShowDialog();
        }
    }
}
