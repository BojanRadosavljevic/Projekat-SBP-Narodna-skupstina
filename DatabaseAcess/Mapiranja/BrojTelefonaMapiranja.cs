using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class BrojTelefonaMapiranja : ClassMap<BrojTelefona>
    {
        public BrojTelefonaMapiranja()
        {
            Table("BROJ_TELEFONA");
            Id(x => x.IDPoslanika, "ID_POSLANIKA").GeneratedBy.Assigned();
            Map(x => x.BrTel, "BR_TEL");
        }
    }
}
