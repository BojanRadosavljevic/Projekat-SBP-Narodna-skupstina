using NarodnaSkupstinaSBP.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace NarodnaSkupstinaSBP
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPoslanikShow_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Poslanik p = s.Load<Entiteti.Poslanik>(1);
                MessageBox.Show(p.LicnoIme + ' ' + p.ImeRoditelja + ' ' + p.Prezime);

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPoslanickaGrupaShow_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.PoslanickaGrupa pg = s.Load<Entiteti.PoslanickaGrupa>("Js");

                MessageBox.Show(pg.Ime + ' ' + pg.IDPredsednika + ' ' + pg.IDZamenika);

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSednicaShow_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Sednica sed = s.Load<Entiteti.Sednica>(1);
                
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRadnoTeloSHow_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.RadnoTelo rt = s.Load<Entiteti.RadnoTelo>(1);

                MessageBox.Show(rt.IDRadnogTela + " Tip: " + rt.TipRadnogTela);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPravniAktShow_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.PravniAkt pa = s.Load<Entiteti.PravniAkt>(1);
                MessageBox.Show(pa.TipAkta + " Predlozo/li: " + pa.PredlagaciAkta);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBrTelShow_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.BrojTelefona brtel = s.Load<Entiteti.BrojTelefona>(1);

                Entiteti.Poslanik pos = s.Load<Entiteti.Poslanik>(brtel.IDPoslanika);

                MessageBox.Show(pos.LicnoIme + ' ' + brtel.BrTel);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBrMobShow_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.BrojMobilnog brmob = s.Load<Entiteti.BrojMobilnog>(4);
                Entiteti.Poslanik pos = s.Load<Entiteti.Poslanik>(brmob.IDPoslanika);

                MessageBox.Show(pos.LicnoIme + ' ' + brmob.BrMob);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdJeClan_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Poslanik p = s.Load<Poslanik>(1);

                MessageBox.Show(p.LicnoIme);
                MessageBox.Show(p.JeClanGrupe.Ime);

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPoslaniciGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PoslanickaGrupa pos = s.Load<PoslanickaGrupa>("Js");
                foreach (Poslanik p in pos.Poslanici)
                {
                    MessageBox.Show(p.LicnoIme);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajPoslanika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PoslanickaGrupa p = s.Load<PoslanickaGrupa>("Js");
                MessageBox.Show(p.Ime);

                Poslanik pos = new Poslanik()
                {
                    LicnoIme = "proba",
                    Prezime = "proba",
                    JMBG = 111111156,
                    ImeRoditelja = "proba",
                    MestoRodjenja = "proba",
                    DatumRodjenja = new DateTime(1999, 12, 12),
                    Adresa = "proba",
                    MestoStanovanja = "proba",
                    IzbornaLista = "proba"
                };
                pos.JeClanGrupe = p;
                s.SaveOrUpdate(pos);
                p.Poslanici.Add(pos);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdJeDeo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Poslanik posl = s.Load<Poslanik>(2);
                foreach (RadnoTelo rt in posl.JeDeo)
                {
                    MessageBox.Show(posl.LicnoIme + " /" + rt.TipRadnogTela);
                }

                RadnoTelo radt = s.Load<RadnoTelo>(1);
                foreach (Poslanik p in radt.Poslanici)
                {
                    MessageBox.Show(p.LicnoIme);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdProstorijProba_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PoslanickaGrupa p = s.Load<PoslanickaGrupa>("Js");
                foreach (Prostorija pros in p.Prostorije)
                {
                    MessageBox.Show(pros.Sprat + " " + pros.Broj + " " + pros.Dodeljena.Ime);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPredlozio_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Poslanici pr = s.Load<Poslanici>(2);
                foreach (Poslanik pos in pr.Predlozili)
                {
                    MessageBox.Show(pos.LicnoIme);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRadniOdnos_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RadniOdnos ro = s.Load<RadniOdnos>(2);
                Poslanik pos = s.Load<Poslanik>(ro.IDPoslanika);
                MessageBox.Show("ajde");

                MessageBox.Show(pos.LicnoIme);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRadniDan_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sednica sed = s.Load<Sednica>(1);
                foreach(RadniDan rd in sed.RadniDaniSednice)
                {
                    MessageBox.Show(rd.DanID.RadniDanID + "Pocetak:  " + rd.PocetakRada + "; Kraj: " + rd.KrajRada);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Skupstina skupstina = new Skupstina();
            skupstina.ShowDialog();
        }
    }
}
