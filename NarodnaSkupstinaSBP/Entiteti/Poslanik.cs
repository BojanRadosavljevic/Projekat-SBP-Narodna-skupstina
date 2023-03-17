using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public class Poslanik
    {
        public virtual int IDPoslanika { get; protected set; }
        public virtual Int64 JMBG { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string MestoRodjenja { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string MestoStanovanja { get; set; }
        public virtual string IzbornaLista { get; set; }
        public virtual PoslanickaGrupa JeClanGrupe { get; set; }
        public virtual IList<RadnoTelo> JeDeo { get; set; }
        public virtual IList<Poslanici> PredlazeAkt { get; set; }
        public virtual IList<PoslaniciS> ZahtevaoSednicu { get; set; }
        public Poslanik()
        {
            JeDeo = new List<RadnoTelo>();
            PredlazeAkt = new List<Poslanici>();
            ZahtevaoSednicu = new List<PoslaniciS>();
        }
    }
}
