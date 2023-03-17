using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class PoslanickaGrupaMapiranja : ClassMap<PoslanickaGrupa>
    {
        public PoslanickaGrupaMapiranja()
        {
            Table("POSLANICKA_GRUPA");
            Id(x => x.Ime, "IME").CustomSqlType("varchar").GeneratedBy.Assigned();

            Map(x => x.IDPredsednika, "ID_PREDSEDNIKA");
            Map(x => x.IDZamenika, "ID_ZAMENIKA");
            HasMany(x => x.Poslanici).KeyColumn("IME_POSLANICKE_GRUPE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Prostorije).KeyColumn("IME_POSLANICKE_GRUPE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
