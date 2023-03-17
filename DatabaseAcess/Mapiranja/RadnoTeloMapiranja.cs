using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class RadnoTeloMapiranja : ClassMap<RadnoTelo>
    {
        public RadnoTeloMapiranja()
        {
            Table("RADNO_TELO");
            Id(x => x.IDRadnogTela, "ID_RADNOG_TELA").GeneratedBy.Increment();//.GeneratedBy.TriggerIdentity();
            DiscriminateSubClassesOnColumn("TIP_RADNOG_TELA");
            Map(x => x.Sprat, "SPRAT");
            Map(x => x.Broj, "BROJ");
            Map(x => x.IDPredsednika, "ID_PREDSEDNIKA");
            Map(x => x.IDZamenika, "ID_ZAMENIKA");
            //Map(x => x.TipRadnogTela, "TIP_RADNOG_TELA");

            HasManyToMany(x => x.Poslanici).Table("JE_DEO").ParentKeyColumn("ID_RADNOG_TELA").ChildKeyColumn("ID_POSLANIKA").Inverse().Cascade.All();
        }
    }
    public class KomisijeMapiranja : SubclassMap<Komisije>
    {
        public KomisijeMapiranja()
        {
            DiscriminatorValue("KOMISIJE");
        }
    }
    public class StalniOdborMapiranja : SubclassMap<StalniOdbor>
    {
        public StalniOdborMapiranja()
        {
            DiscriminatorValue("STALNI ODBOR");
        }
    }
    public class AnketniOdborMapiranja : SubclassMap<AnketniOdbor>
    {
        public AnketniOdborMapiranja()
        {
            DiscriminatorValue("ANKETNI ODBOR");
        }
    }
    public class PrivremeniOdborMapiranja : SubclassMap<Entiteti.PrivremeniOdbor>
    {
        public PrivremeniOdborMapiranja()
        {
            DiscriminatorValue("PRIVREMENI ODBOR");
        }
    }

}
