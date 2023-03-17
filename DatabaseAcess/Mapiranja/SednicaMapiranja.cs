using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class SednicaMapiranja : ClassMap<Sednica>
    {
        public SednicaMapiranja()
        {
            Table("SEDNICA");

            DiscriminateSubClassesOnColumn("TIP_SEDNICE");

            Id(x => x.IDSednice, "ID_SEDNICE").GeneratedBy.Increment();//.GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            
            Map(x => x.BrojSaziva, "BROJ_SAZIVA");
            Map(x => x.BrojZasedanja, "BROJ_ZASEDANJA");
            Map(x => x.DatumPocetka, "DATUM_POCETKA");
            Map(x => x.DatumZavrsetka, "DATUM_ZAVRŠETKA");
            //Map(x => x.TipSednice, "TIP_SEDNICE");

            HasMany(x=>x.RadniDaniSednice).KeyColumn("ID_SEDNICE").LazyLoad().Cascade.All().Inverse();
        }
    }
    public class RedovnaMapiranja : SubclassMap<Redovna>
    {
        public RedovnaMapiranja()
        {
            DiscriminatorValue("REDOVNA");
        }
    }
    public class VanrednaMapiranja: SubclassMap<Vanredna>
    {
        public VanrednaMapiranja()
        {
            DiscriminatorValue("VANREDNA");
            Map(x => x.ZahtevaociSednice, "ZAHTEVAOCI_SEDNICE");
        }
    }
    public class VladaSMapiranja : SubclassMap<VladaS>
    {
        public VladaSMapiranja()
        {
            DiscriminatorValue("VLADA");
        }

    }
    public class PoslaniciSMapiranja : SubclassMap<PoslaniciS>
    {
        public PoslaniciSMapiranja()
        {
            DiscriminatorValue("POSLANICI");
            HasManyToMany(x=>x.JeZahtevao).Table("JE_ZAHTEVAO").ParentKeyColumn("ID_SEDNICE").ChildKeyColumn("ID_POSLANIKA");
        }
    }
}
