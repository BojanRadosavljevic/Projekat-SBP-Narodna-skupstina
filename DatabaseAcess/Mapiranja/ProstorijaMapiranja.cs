using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class ProstorijaMapiranja : ClassMap<Prostorija>
    {
        public ProstorijaMapiranja()
        {
            Table("PROSTORIJA");
            Id(x => x.ProstorijaID, "PROSTORIJA_ID").GeneratedBy.Assigned();
            Map(x => x.Sprat, "SPRAT");
            Map(x => x.Broj, "BROJ");
            References(x => x.Dodeljena).Column("IME_POSLANICKE_GRUPE").LazyLoad();
        }
    }
}
