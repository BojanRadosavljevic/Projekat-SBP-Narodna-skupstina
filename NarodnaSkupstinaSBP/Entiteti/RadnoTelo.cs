using System.Collections.Generic;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public abstract class RadnoTelo
    {
        public virtual int IDRadnogTela { get; set; }
        public virtual int Sprat { get; set; }
        public virtual int Broj { get; set; }
        public virtual int IDPredsednika { get; set; }
        public virtual int IDZamenika { get; set; }
        public virtual string TipRadnogTela { get; set; }
        public virtual IList<Poslanik> Poslanici { get; set; }

        public RadnoTelo()
        {
            Poslanici = new List<Poslanik>();
        }
    }
    public class Komisije : RadnoTelo { }
    public class StalniOdbor : RadnoTelo { }
    public class AnketniOdbor : RadnoTelo { }
    public class PrivremeniOdbor : RadnoTelo { }
}
