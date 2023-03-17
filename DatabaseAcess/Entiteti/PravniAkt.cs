using System.Collections.Generic;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public abstract class PravniAkt
    {
        public virtual int IDPravnogAkta { get; set; }
        public virtual string TipAkta { get; set; }
        public virtual string PredlagaciAkta { get; set; }

        public PravniAkt()
        {

        }
    }
    public class Zakon : PravniAkt { }

    public class Deklaracija : PravniAkt { }
    public class Preporuka : PravniAkt { }
    public class Odluka : PravniAkt { }
    public class Tumacenje : PravniAkt { }
    public class Biraci : PravniAkt
    {
        public virtual int BrojBiraca { get; set; }
        public Biraci() { }
    }
    public class Vlada : PravniAkt { }
    public class Poslanici : PravniAkt
    {
        public virtual IList<Poslanik> Predlozili { get; set; }
        public Poslanici()
        {
            Predlozili = new List<Poslanik>();
        }
    }
}
