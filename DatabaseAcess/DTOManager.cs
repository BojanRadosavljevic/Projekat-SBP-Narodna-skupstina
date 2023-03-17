using System;
using System.Collections.Generic;
using System.Linq;
using NarodnaSkupstinaSBP.Entiteti;
using NHibernate;
using static DatabaseAccess.DTOs;

namespace DatabaseAccess
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

        public static void dodajPoslanika(Poslanik poslanik)
        {
            try 
            { 
                ISession s = DataLayer.GetSession();

                Poslanik p = new Poslanik
                {
                    JMBG = poslanik.JMBG,
                    LicnoIme = poslanik.LicnoIme,
                    Prezime = poslanik.Prezime,
                    ImeRoditelja = poslanik.ImeRoditelja,
                    MestoRodjenja = poslanik.MestoRodjenja,
                    DatumRodjenja = poslanik.DatumRodjenja,
                    Adresa = poslanik.Adresa,
                    MestoStanovanja = poslanik.MestoStanovanja,
                    IzbornaLista = poslanik.IzbornaLista
                };
                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }
        }

        public static void obrisiPoslanika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Poslanik p = s.Load<Poslanik>(id);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Doslo je do greske: " + e.Message);
            }
        }

        public static void IzmeniAdresuPoslanika(int id, string adresa, string mestoSatnovanja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Poslanik p = s.Load<Poslanik>(id);

                p.Adresa = adresa;
                p.MestoStanovanja = mestoSatnovanja;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Doslo je do greske: " + e.Message);
            }
        }

        public static void IzmeniIzbornuListuPoslanika(int id, string izbornaLista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Poslanik p = s.Load<Poslanik>(id);

                p.IzbornaLista = izbornaLista;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Doslo je do greske: " + e.Message);
            }
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
        
        public static void dodajGrupu(PoslanickaGrupa pg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslanickaGrupa p = new PoslanickaGrupa
                {
                    Ime = pg.Ime,
                    IDPredsednika = pg.IDPredsednika,
                    IDZamenika = pg.IDZamenika
                };
                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }
        }

        public static void izmeniImePoslanickeGrupe(int id, string ime)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslanickaGrupa p = s.Load<PoslanickaGrupa>(id);

                p.Ime = ime;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }
        }

        public static void izbrisiPoslanickeGrupe(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslanickaGrupa p = s.Load<PoslanickaGrupa>(id);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }
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
                    listaAkta.Add(new PravniAktView(a.IDPravnogAkta));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Doslo je do greske: " + ec.Message);
            }
            return listaAkta;
        }

        public static void DodajBiraca(Biraci birac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Biraci a = new Biraci
                {
                    TipAkta = birac.TipAkta,
                    PredlagaciAkta = birac.PredlagaciAkta,
                    BrojBiraca=birac.BrojBiraca
                };

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }
        }

        public static void izbrisiAkt(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravniAkt a = s.Load<PravniAkt>(id);

                s.Delete(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }
        }

        public static void izmeniTipAkt(int id, string tip)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravniAkt a = s.Load<PravniAkt>(id);
                a.TipAkta = tip;

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske: " + ex.Message);
            }
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

        public static void izmeniTipSednice(int id, string tip)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Sednica sednica = s.Load<Sednica>(id);
                sednica.TipSednice = tip;

                s.SaveOrUpdate(sednica);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }

        public static void izmeniBrojSazivaSednice(int id, int bsaziva)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Sednica sednica = s.Load<Sednica>(id);
                sednica.BrojSaziva = bsaziva;

                s.SaveOrUpdate(sednica);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }

        public static void izmeniBrojZasedanjaSednice(int id, int bzasedanja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Sednica sednica = s.Load<Sednica>(id);
                sednica.BrojZasedanja = bzasedanja;

                s.SaveOrUpdate(sednica);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }

        public static void izbrisiSednicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Sednica sednica = s.Load<Sednica>(id);

                s.Delete(sednica);
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

        public static void izmeniPocetakRadaRadniDan(string prada, int dan)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadniDan r = s.Load<RadniDan>(dan);
                r.PocetakRada = prada;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }

        public static void izbrisiRadniDan(int dan)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadniDan r = s.Load<RadniDan>(dan);

                s.Delete(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Doslo je do greske: " + ec.Message);
            }
        }

        public static List<RadniDanView> vratiSveRadneDane()
        {
            List<RadniDanView> radniDani = new List<RadniDanView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<RadniDan> sviRadniDani = from o in s.Query<RadniDan>()
                                                        select o;

                foreach (RadniDan rd in sviRadniDani)
                {
                    radniDani.Add(new RadniDanView(rd.DanID, rd.BrojPoslanika, rd.PocetakRada, rd.KrajRada));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Doslo je do greske: " + ec.Message);
            }

            return radniDani;
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

        public static void izmeniSpratRadnoTelo(int sprat, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnoTelo r = s.Load<RadnoTelo>(id);
                r.Sprat = sprat;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }

        public static void izmeniBrojRadnoTelo(int broj, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnoTelo r = s.Load<RadnoTelo>(id);
                r.Broj = broj;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }

        public static void izbrisiRadnoTelo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnoTelo r = s.Load<RadnoTelo>(id);

                s.Delete(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                Console.WriteLine("Doslo je do greske: " + ec.Message);

            }
        }

        public static List<RadnoTeloView> vratiSvaRadnaTela()
        {
            List<RadnoTeloView> radnaTela = new List<RadnoTeloView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<RadnoTelo> svaRadnaRela= from o in s.Query<RadnoTelo>()
                                                     select o;

                foreach (RadnoTelo rt in svaRadnaRela)
                {
                    radnaTela.Add(new RadnoTeloView(rt.IDRadnogTela, rt.Sprat, rt.Broj, rt.IDPredsednika, rt.IDZamenika));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Doslo je do greske: " + ec.Message);
            }

            return radnaTela;
        }
    }
}
