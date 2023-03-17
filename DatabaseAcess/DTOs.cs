using NarodnaSkupstinaSBP.Entiteti;
using System;
using System.Collections.Generic;
using static DatabaseAccess.DTOs;

namespace DatabaseAccess
{
    public class DTOs
    {
    #region Poslanik
        public class PoslanikBasic
        {
            public virtual int IDPoslanika { get; protected set; }
            public virtual string JMBG { get; set; }
            public virtual string LicnoIme { get; set; }
            public virtual string Prezime { get; set; }
            public virtual string ImeRoditelja { get; set; }
            public virtual string Adresa { get; set; }
            public virtual string MestoStanovanja { get; set; }
            public virtual string IzbornaLista { get; set; }
            public virtual DateTime DatumRodjenja { get; set; }
            public virtual string MestoRodjenja { get; set; }
            public PoslanickaGrupaBasic PoslanickaGrupa { get; set; }

            public virtual IList<RadnoTeloBasic> JeDeo { get; set; }
            public virtual IList<PoslaniciBasic> PredlazeAkt { get; set; }
            public virtual IList<PoslaniciSBasic> ZahtevaoSednicu { get; set; }
            public PoslanikBasic()
            {
                JeDeo = new List<RadnoTeloBasic>();
                PredlazeAkt = new List<PoslaniciBasic>();
                ZahtevaoSednicu = new List<PoslaniciSBasic>();
            }

            public PoslanikBasic(int IDPoslanika, string JMBG, string LicnoIme, string Prezime,
                string ImeRoditelja, string AdresaStanovanja, string MestoStanovanja, string IzbornaLista, DateTime DatumRodjenja, string MestoRodjenja)
            {
                this.IDPoslanika = IDPoslanika;
                this.JMBG = JMBG;
                this.LicnoIme = LicnoIme;
                this.Prezime = Prezime;
                this.ImeRoditelja = ImeRoditelja;
                this.Adresa= AdresaStanovanja;
                this.MestoStanovanja = MestoStanovanja;
                this.IzbornaLista = IzbornaLista;
                this.DatumRodjenja = DatumRodjenja;
                this.MestoRodjenja = MestoRodjenja;

            }
        }
        public class PoslanikView
        {
            public virtual int IDPoslanika { get; protected set; }
            public virtual string JMBG { get; set; }
            public virtual string LicnoIme { get; set; }
            public virtual string Prezime { get; set; }
            public virtual string ImeRoditelja { get; set; }
            public virtual string MestoRodjenja { get; set; }
            public virtual DateTime DatumRodjenja { get; set; }
            public virtual string Adresa { get; set; }
            public virtual string MestoStanovanja { get; set; }
            public virtual string IzbornaLista { get; set; }
           
            
            public PoslanikView()
            {
            }
            public PoslanikView(int IDPoslanika, string JMBG, string LicnoIme, string Prezime,
                string ImeRoditelja, string Adresa, string MestoStanovanja, string IzbornaLista, DateTime DatumRodjenja, string MestoRodjenja)
            {
                this.IDPoslanika = IDPoslanika;
                this.JMBG = JMBG;
                this.LicnoIme = LicnoIme;
                this.Prezime = Prezime;
                this.ImeRoditelja = ImeRoditelja;
                this.Adresa = Adresa;
                this.MestoStanovanja = MestoStanovanja;
                this.IzbornaLista = IzbornaLista;
                this.DatumRodjenja = DatumRodjenja;
                this.MestoRodjenja = MestoRodjenja;
            }
        }
    }
    #endregion
    #region PoslanickaGrupa
    public class PoslanickaGrupaBasic
    {
        public string ImeGrupe;
        public int IDPredsednika;
        public int IDZamenika;

        public IList<PoslanikBasic> Poslanici { get; set; }
        //public IList<SluzbenaProstorija> Prostorije { get; set; }

        public PoslanickaGrupaBasic()
        {
            Poslanici = new List<PoslanikBasic>();
            //Prostorije = new List<SluzbenaProstorija>();

        }

        public PoslanickaGrupaBasic(string ImeGrupe, int IDPredsednika, int IDZamenika)
        {
            this.ImeGrupe = ImeGrupe;
            this.IDPredsednika = IDPredsednika;
            this.IDZamenika = IDZamenika;
        }

    }

    public class PoslanickaGrupaView
    {

        public string ImeGrupe;
        public int IDPredsednika;
        public int IDZamenika;
        public PoslanickaGrupaView()
        {
        }
        public PoslanickaGrupaView(string ImeGrupe)
        {
            this.ImeGrupe = ImeGrupe;
        }
        public PoslanickaGrupaView(string ImeGrupe, int IDPredsednika, int IDZamenika)
        {
            this.ImeGrupe = ImeGrupe;
            this.IDPredsednika = IDPredsednika;
            this.IDZamenika = IDZamenika;
        }

    }

    #endregion
    #region PravniAkt
    public class PravniAktBasic
    {
        public virtual int IDPravnogAkta { get; set; }
        public PravniAktBasic()
        {
        }

        public PravniAktBasic(int IDPravnogAkta)
        {
            this.IDPravnogAkta = IDPravnogAkta;
        }
    }
    public class ZakonBasic: PravniAktBasic
    {
        public ZakonBasic()
        {
        }
        public ZakonBasic(int IDPravnogAkta) : base(IDPravnogAkta)
        { }
    }
    public class DeklaracijaBasic: PravniAktBasic
    {
        public DeklaracijaBasic() { }
        public DeklaracijaBasic(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class PreporukaBasic: PravniAktBasic
    {
        public PreporukaBasic() { }
        public PreporukaBasic(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class OdlukaBasic: PravniAktBasic
    {
        public OdlukaBasic() { }
        public OdlukaBasic(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class TumacenjaBasic:PravniAktBasic
    {
        public TumacenjaBasic() { }
        public TumacenjaBasic(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class BiraciBasic: PravniAktBasic
    {
        public int BrojBiraca { get; set; }
        public BiraciBasic() { }
        public BiraciBasic(int IDPravnogAkta,int brojBiraca) : base(IDPravnogAkta) 
        {
            this.BrojBiraca = brojBiraca;
        }
    }
    public class VladaBasic:PravniAktBasic
    {
        public VladaBasic() { }
        public VladaBasic(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class PoslaniciBasic:PravniAktBasic
    {
        public IList<PoslanikBasic> Predlozili { get; set; }
        public PoslaniciBasic() 
        {
            Predlozili = new List<PoslanikBasic>();
        }
        public PoslaniciBasic(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class PravniAktView
    {
        public virtual int IDPravnogAkta { get; set; }
        public PravniAktView()
        {
        }
        public PravniAktView(int IDPravnogAkta)
        {
            this.IDPravnogAkta = IDPravnogAkta;
        }
    }
    public class ZakonView:PravniAktView
    {
        public ZakonView(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class DeklaracijaView : PravniAktView
    {
        public DeklaracijaView(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class PreporukaView : PravniAktView
    {
        public PreporukaView(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class OdlukaView:PravniAktView
    {
        public OdlukaView(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class TumacenjeView: PravniAktView
    {
        public TumacenjeView(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class BiraciView:PravniAktView
    {
        public int BrojBiraca { get; set; }
        public BiraciView( int IDPravnogAkta,int brBiraca) :base(IDPravnogAkta)
        {
            this.BrojBiraca = brBiraca;
        }
    }
    public class VladaView:PravniAktView
    {
        public VladaView(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    public class PoslaniciView:PravniAktView
    {
        public PoslaniciView(int IDPravnogAkta) : base(IDPravnogAkta) { }
    }
    #endregion
    #region BrojMobilnog
    public class BrojMobilnogBasic
    {
        public int IDPoslanika { get; set; }
        public int BrMob { get; set; }
        public BrojMobilnogBasic() { }
        public BrojMobilnogBasic(int idpos,int brmob)
        {
            this.IDPoslanika = idpos;
            this.BrMob = brmob;
        }
    }
    public class BrojMobilnogView
    {
        public int IDPoslanika { get; set; }
        public int BrMob { get; set; }
        public BrojMobilnogView() { }
        public BrojMobilnogView(int idpos,int brmob)
        {
            this.IDPoslanika = idpos;
            this.BrMob = brmob;
        }
    }
    #endregion
    #region BrojTelefona
    public class BrojTelefonaBasic
    {
        public int IDPoslanika { get; set; }
        public int BrTel { get; set; }
        public BrojTelefonaBasic() { }
        public BrojTelefonaBasic(int idpos,int brtel)
        {
            this.IDPoslanika = idpos;
            this.BrTel = brtel;
        }
    }
    public class BrojTelefonaView
    {
        public int IDPoslanika { get; set; }
        public int BrTel { get; set; }
        public BrojTelefonaView() { }
        public BrojTelefonaView(int idpos, int brtel)
        {
            this.IDPoslanika = idpos;
            this.BrTel = brtel;
        }
    }
    #endregion
    #region Prostorija
    public class ProstorijaBasic
    {
        public int ProstorijaID { get; set; }
        public int Sprat { get; set; }
        public int Broj { get; set; }
        public PoslanickaGrupaBasic Dodeljena { get; set; }
        public ProstorijaBasic() { }
        public ProstorijaBasic(int id,int sprat,int broj, PoslanickaGrupaBasic dod)
        {
            this.ProstorijaID = id;
            this.Sprat = sprat;
            this.Broj = broj;
            this.Dodeljena = dod;
        }
    }
    public class ProstorijaView
    {
        public int ProstorijaID { get; set; }
        public int Sprat { get; set; }
        public int Broj { get; set; }
        public PoslanickaGrupaBasic Dodeljena { get; set; }
        public ProstorijaView() { }
        public ProstorijaView(int id, int sprat, int broj, PoslanickaGrupaBasic dod)
        {
            this.ProstorijaID = id;
            this.Sprat = sprat;
            this.Broj = broj;
            this.Dodeljena = dod;
        }
    }
    #endregion
    #region RadniDan
    public class RadniDanBasic
    {
        public RadniDaniID DanID { get; set; }
        public int BrojPoslanik { get; set; }
        public string PocetakRada { get; set; }
        public string KrajRada { get; set; }
        public RadniDanBasic() { }
        public RadniDanBasic(RadniDaniID id, int brpos, string pocetak,string kraj)
        {
            this.DanID = id;
            this.BrojPoslanik = brpos;
            this.PocetakRada = pocetak;
            this.KrajRada = kraj;
        }
    }
    public class RadniDanView
    {
        public RadniDaniID DanID { get; set; }
        public int BrojPoslanik { get; set; }
        public string PocetakRada { get; set; }
        public string KrajRada { get; set; }
        public RadniDanView() { }
        public RadniDanView(RadniDaniID id, int brpos, string pocetak, string kraj)
        {
            this.DanID = id;
            this.BrojPoslanik = brpos;
            this.PocetakRada = pocetak;
            this.KrajRada = kraj;
        }
    }
    #endregion
    #region RadniOdnos
    public class RadniOdnosBasic: PoslanikBasic
    {
        public int BrojRadneKnjizice { get; set; }
        public int Godine { get; set; }
        public int Meseci { get; set; }
        public int Dani { get; set; }
        public string PrethodnaFirma { get; set; }
        public RadniOdnosBasic() { }
        public RadniOdnosBasic(int IDPoslanika, string JMBG, string LicnoIme, string Prezime,string ImeRoditelja, 
                               string AdresaStanovanja, string MestoStanovanja, string IzbornaLista, DateTime DatumRodjenja,
                               string MestoRodjenja,int brradneknjizice,int godine,int meseci,int dani,string prethodna): 
            base(IDPoslanika,JMBG,LicnoIme,Prezime,ImeRoditelja,AdresaStanovanja,MestoStanovanja,IzbornaLista,DatumRodjenja,MestoRodjenja)
        {
            this.BrojRadneKnjizice = brradneknjizice;
            this.Godine = godine;
            this.Meseci = meseci;
            this.Dani = dani;
            this.PrethodnaFirma = prethodna;
        }
    }
    public class RadniOdnosView:PoslanikView
    {
        public int BrojRadneKnjizice { get; set; }
        public int Godine { get; set; }
        public int Meseci { get; set; }
        public int Dani { get; set; }
        public string PrethodnaFirma { get; set; }
        public RadniOdnosView() { }
        public RadniOdnosView(int IDPoslanika, string JMBG, string LicnoIme, string Prezime, string ImeRoditelja,
                               string AdresaStanovanja, string MestoStanovanja, string IzbornaLista, DateTime DatumRodjenja,
                               string MestoRodjenja, int brradneknjizice, int godine, int meseci, int dani, string prethodna) :
            base(IDPoslanika, JMBG, LicnoIme, Prezime, ImeRoditelja, AdresaStanovanja, MestoStanovanja, IzbornaLista, DatumRodjenja, MestoRodjenja)
        {
            this.BrojRadneKnjizice = brradneknjizice;
            this.Godine = godine;
            this.Meseci = meseci;
            this.Dani = dani;
            this.PrethodnaFirma = prethodna;
        }
    }
    #endregion
    #region RadnoTelo
    public class RadnoTeloBasic
    {
        public int IDRadnogTela { get; set; }
        public int Sprat { get; set; }
        public int Broj { get; set; }
        public int IDPredsednika { get; set; }
        public int IDZamenika { get; set; }
        public IList<PoslanikBasic> Poslanici { get; set; }

        public RadnoTeloBasic()
        {
            Poslanici = new List<PoslanikBasic>();
        }
        public RadnoTeloBasic(int idtela,int sprat,int broj,int idpred,int idzam)
        {
            this.IDRadnogTela = idtela;
            this.Sprat = sprat;
            this.Broj = broj;
            this.IDPredsednika = idpred;
            this.IDZamenika = idzam;
        }
    }
    public class RadnoTeloView
    {
        public int IDRadnogTela { get; set; }
        public int Sprat { get; set; }
        public int Broj { get; set; }
        public int IDPredsednika { get; set; }
        public int IDZamenika { get; set; }

        public RadnoTeloView() { }
        public RadnoTeloView(int idtela, int sprat, int broj, int idpred, int idzam)
        {
            this.IDRadnogTela = idtela;
            this.Sprat = sprat;
            this.Broj = broj;
            this.IDPredsednika = idpred;
            this.IDZamenika = idzam;
        }
    }
    public class KomisijeBasic : RadnoTeloBasic 
    { 
        public KomisijeBasic() { }
        public KomisijeBasic(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela,sprat,broj,idpred,idzam) { }
    }
    public class StalniOdborBasic : RadnoTeloBasic
    {
        public StalniOdborBasic() { }
        public StalniOdborBasic(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela, sprat, broj, idpred, idzam) { }
    }
    public class AnketniOdborBasic : RadnoTeloBasic
    {
        public AnketniOdborBasic() { }
        public AnketniOdborBasic(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela, sprat, broj, idpred, idzam) { }
    }
    public class PrivremeniOdborBasic : RadnoTeloBasic
    {
        public PrivremeniOdborBasic() { }
        public PrivremeniOdborBasic(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela, sprat, broj, idpred, idzam) { }
    }
    public class KomisijeView : RadnoTeloView
    {
        public KomisijeView() { }
        public KomisijeView(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela, sprat, broj, idpred, idzam) { }
    }
    public class StalniOdborView : RadnoTeloView
    {
        public StalniOdborView() { }
        public StalniOdborView(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela, sprat, broj, idpred, idzam) { }
    }
    public class AnketniOdborView : RadnoTeloView
    {
        public AnketniOdborView() { }
        public AnketniOdborView(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela, sprat, broj, idpred, idzam) { }
    }
    public class PrivremeniOdborView : RadnoTeloView
    {
        public PrivremeniOdborView() { }
        public PrivremeniOdborView(int idtela, int sprat, int broj, int idpred, int idzam) : base(idtela, sprat, broj, idpred, idzam) { }
    }
    #endregion
    #region Sednica
    public class SednicaBasic
    {
        public int IDSednice { get; set; }
        public int BrojSaziva { get; set; }
        public int BrojZasedanja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public IList<RadniDanBasic> RadniDaniSednice { get; set; }
        public SednicaBasic()
        {
            RadniDaniSednice = new List<RadniDanBasic>();
        }
        public SednicaBasic(int idsed,int brsaz,int brzas,DateTime pocetak,DateTime zavrsetak)
        {
            this.IDSednice = idsed;
            this.BrojSaziva = brsaz;
            this.BrojZasedanja = brzas;
            this.DatumPocetka = pocetak;
            this.DatumZavrsetka = zavrsetak;
        }
    }
    public class SednicaView
    {
        public virtual int IDSednice { get; protected set; }
        public virtual int BrojSaziva { get; set; }
        public virtual int BrojZasedanja { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime DatumZavrsetka { get; set; }
        public SednicaView() { }
        public SednicaView(int idsed, int brsaz, int brzas, DateTime pocetak, DateTime zavrsetak)
        {
            this.IDSednice = idsed;
            this.BrojSaziva = brsaz;
            this.BrojZasedanja = brzas;
            this.DatumPocetka = pocetak;
            this.DatumZavrsetka = zavrsetak;
        }
    }
    public class RedovnaBasic : SednicaBasic
    {
        public RedovnaBasic() { }
        public RedovnaBasic(int idsed, int brsaz, int brzas, DateTime pocetak, DateTime zavrsetak) : base(idsed, brsaz, brzas, pocetak, zavrsetak) { }
    }
    public class VanrednaBasic : SednicaBasic
    {
        public VanrednaBasic() { }
        public VanrednaBasic(int idsed, int brsaz, int brzas, DateTime pocetak, DateTime zavrsetak) : base(idsed, brsaz, brzas, pocetak, zavrsetak) { }
    }
    public class VladaSBasic : VanrednaBasic
    {
        public VladaSBasic() { }
        public VladaSBasic(int idsed, int brsaz, int brzas, DateTime pocetak, DateTime zavrsetak) : base(idsed,brsaz,brzas,pocetak,zavrsetak) { }
    }
    public class PoslaniciSBasic : VanrednaBasic
    {
        public virtual IList<PoslanikBasic> JeZahtevao { get; set; }
        public PoslaniciSBasic()
        {
            JeZahtevao = new List<PoslanikBasic>();
        }
        public PoslaniciSBasic(int idsed, int brsaz, int brzas, DateTime pocetak, DateTime zavrsetak) : base(idsed, brsaz, brzas, pocetak, zavrsetak) { }
    }
    #endregion
}
