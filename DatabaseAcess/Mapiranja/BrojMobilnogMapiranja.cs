using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class BrojMobilnogMapiranja : ClassMap<BrojMobilnog>
    {
        public BrojMobilnogMapiranja()
        {
            Table("BROJ_MOBILNOG");
            Id(x => x.IDPoslanika, "ID_POSLANIKA").GeneratedBy.Assigned();
            Map(x => x.BrMob, "BR_MOB");
        }

    }
}
