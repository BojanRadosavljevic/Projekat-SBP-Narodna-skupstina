using System;
using System.Collections.Generic;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public abstract class Sednica
    {
        public virtual int IDSednice { get; set; }
        public virtual int BrojSaziva { get; set; }
        public virtual int BrojZasedanja { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime DatumZavrsetka { get; set; }
        public virtual string TipSednice { get; set; }
        public virtual IList<RadniDan> RadniDaniSednice { get; set; }
        public Sednica()
        {
            RadniDaniSednice = new List<RadniDan>();
        }
    }

    public class Redovna : Sednica { }
    public class Vanredna: Sednica
    {
        public virtual string ZahtevaociSednice { get; set; }
        public Vanredna()
        {
        }
    }
    public class VladaS : Vanredna { }
    public class PoslaniciS : Vanredna
    {
        public virtual IList<Poslanik> JeZahtevao { get; set; }
        public PoslaniciS()
        {
            JeZahtevao = new List<Poslanik>();
        }
    }

}
