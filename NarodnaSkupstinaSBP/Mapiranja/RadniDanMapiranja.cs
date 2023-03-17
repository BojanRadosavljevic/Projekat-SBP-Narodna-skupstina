using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class RadniDanMapiranja : ClassMap<RadniDan>
    {
        public RadniDanMapiranja()
        {
            Table("RADNI_DANI");

            CompositeId(x=>x.DanID)
                .KeyProperty(x => x.RadniDanID, "ID_RADNOG_DANA")
                .KeyReference(x => x.Sednica, "ID_SEDNICE");
            Map(x => x.PocetakRada, "POCETAK_RADA");
            Map(x => x.KrajRada, "KRAJ_RADA");
            Map(x => x.BrojPoslanika, "BROJ_POSLANIKA");
        }
    }
}
