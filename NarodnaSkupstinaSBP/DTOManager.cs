using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NarodnaSkupstinaSBP.Entiteti;
using NHibernate;
using static NarodnaSkupstinaSBP.DTOs;

namespace NarodnaSkupstinaSBP
{
    public class DTOManager
    {
        public static List<PoslanikView> vratiSvePoslanike()
        {
            List<PoslanikView> poslanici = new List<PoslanikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Poslanik> sviPoslanici = from o in s.Query<Poslanik>() select o;

                foreach (Poslanik p in sviPoslanici)
                {
                    poslanici.Add(new PoslanikView(p.IDPoslanika,
                        p.JMBG.ToString(),
                        p.LicnoIme,
                        p.Prezime,
                        p.ImeRoditelja,
                        p.Adresa,
                        p.MestoStanovanja,
                        p.IzbornaLista,
                        p.DatumRodjenja,
                        p.MestoRodjenja));

                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }

            return poslanici;
        }

        public static List<PoslanickaGrupaView> vratiSveGrupe()
        {
            List<PoslanickaGrupaView> grupe = new List<PoslanickaGrupaView>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<PoslanickaGrupa> sveGrupe = from o in s.Query<PoslanickaGrupa>()
                                                        select o;

                foreach (PoslanickaGrupa p in sveGrupe)
                {
                    grupe.Add(new PoslanickaGrupaView(p.Ime, p.IDPredsednika, p.IDZamenika));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }

            return grupe;
        }
        public static List<PravniAktView> VratiSveAkte()
        {
            List<PravniAktView> listaAkta = new List<PravniAktView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<PravniAkt> akti = from o in s.Query<PravniAkt>()
                                                        select o;
                foreach (PravniAkt a in akti)
                {
                    listaAkta.Add(new PravniAktView(a.IDPravnogAkta
                        ));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Doslo je do greske: " + ec.Message);
            }
            return listaAkta;
        }
        public static List<ZakonView> VratiSveZakone()
        {
            List<ZakonView> listaAkta = new List<ZakonView>();
            try
            {
                ISession s = DataLayer.GetSession();
                
                IList<PravniAkt> pravniakt = s.QueryOver<PravniAkt>()
                                                .List<PravniAkt>();

                foreach (PravniAkt o in pravniakt)
                {
                    if (o.GetType() == typeof(Vlada))
                    {
                        Vlada o5 = (Vlada)o;
                    }
                    else if (o.GetType() == typeof(Poslanici))
                    {
                        Poslanici o615 = (Poslanici)o;
                    }
                    else
                    {
                        Biraci oo = (Biraci)o;
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Doslo je do greske: " + ec.Message);
            }
            return listaAkta;
        }
        public static List<SednicaView> VratiSveSednice()
        {
            List<SednicaView> sednice = new List<SednicaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Sednica> sveSednice = from o in s.Query<Sednica>() select o;

                foreach (Sednica p in sveSednice)
                {
                    sednice.Add(new SednicaView(
                        p.IDSednice,
                        p.BrojSaziva,
                        p.BrojZasedanja,
                        p.DatumPocetka,
                        p.DatumZavrsetka
                        ));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Doslo je do greske: " + ec.Message);
            }

            return sednice;
        }
        public static void DodajSednicu(SednicaBasic sed)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Sednica novaS = new Redovna
                {
                    //novaS.IDSednice = 11;
                    DatumPocetka = sed.DatumPocetka,
                    DatumZavrsetka = sed.DatumZavrsetka,
                    BrojSaziva = sed.BrojSaziva,
                    BrojZasedanja = sed.BrojZasedanja,
                    //ZahtevaociSednice = "redovna"

                    };
                    s.SaveOrUpdate(novaS);
                
                
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }
        public static void DodajSednicuVandrednu(SednicaBasic sed,string tip,string inicijativa,int broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (inicijativa != "REDOVNA")
                {
                    Sednica novaS = new Vanredna
                    {

                        DatumPocetka = sed.DatumPocetka,
                        DatumZavrsetka = sed.DatumZavrsetka,
                        BrojSaziva = sed.BrojSaziva,
                        BrojZasedanja = sed.BrojZasedanja,
                        TipSednice = tip,
                        ZahtevaociSednice = inicijativa
                        //RadnoTelo = broj
                        //ZahtevaociSednice = "redovna"

                    };
                    s.SaveOrUpdate(novaS);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }
        public static void DodajRadniDan(RadniDanBasic sed,int dan)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadniDan novaS = new RadniDan
                {
                    BrojPoslanika = sed.BrojPoslanik,
                    PocetakRada = sed.PocetakRada,
                    KrajRada = sed.KrajRada,
                };
                Sednica seda = s.Load<Sednica>(dan);

                seda.RadniDaniSednice.Add(novaS);
                s.SaveOrUpdate(seda);
                s.SaveOrUpdate(novaS);



                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }
        public static void DodajRadnoTelo(RadnoTeloBasic sed, string dan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dan == "KOMISIJE")
                {
                    RadnoTelo novaS = new Komisije
                    {
                        Sprat = sed.Sprat,
                        Broj = sed.Broj,
                        IDPredsednika = sed.IDPredsednika,
                        IDZamenika = sed.IDZamenika,
                        TipRadnogTela = dan
                    };
                    s.SaveOrUpdate(novaS);
                }
                else if(dan=="ANKETNI ODBOR")
                {
                    RadnoTelo novaS = new AnketniOdbor
                    {
                        Sprat = sed.Sprat,
                        Broj = sed.Broj,
                        IDPredsednika = sed.IDPredsednika,
                        IDZamenika = sed.IDZamenika,
                        TipRadnogTela = dan
                    };
                    s.SaveOrUpdate(novaS);
                }
                else if(dan=="STALNI ODBOR")
                {
                    RadnoTelo novaS = new StalniOdbor
                    {
                        Sprat = sed.Sprat,
                        Broj = sed.Broj,
                        IDPredsednika = sed.IDPredsednika,
                        IDZamenika = sed.IDZamenika,
                        TipRadnogTela = dan
                    };
                    s.SaveOrUpdate(novaS);
                }
                else if(dan=="PRIVREMENI ODBOR")
                {
                    RadnoTelo novaS = new PrivremeniOdbor
                    {
                        Sprat = sed.Sprat,
                        Broj = sed.Broj,
                        IDPredsednika = sed.IDPredsednika,
                        IDZamenika = sed.IDZamenika,
                        TipRadnogTela = dan
                    };
                    s.SaveOrUpdate(novaS);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }
    }
}
