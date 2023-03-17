using System.Collections.Generic;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public class PoslanickaGrupa
    {
        public virtual string Ime { get; set; }
        public virtual int IDPredsednika { get; set; }
        public virtual int IDZamenika { get; set; }
        public virtual IList<Poslanik> Poslanici { get; set; }
        public virtual IList<Prostorija> Prostorije { get; set; }
        public PoslanickaGrupa()
        {
            Poslanici = new List<Poslanik>();
            Prostorije = new List<Prostorija>();
        }
    }
}
