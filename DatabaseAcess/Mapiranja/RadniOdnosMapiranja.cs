using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class RadniOdnosMapiranja: SubclassMap<RadniOdnos>
    {
        public RadniOdnosMapiranja()
        {
            Table("STALNI_RADNI_ODNOS");
            KeyColumn("ID_POSLANIKA");
            Map(x => x.BrojRadneKnjizice, "BROJ_RADNE_KNJIŽICE");
            Map(x => x.Godine, "GODINE");
            Map(x => x.Meseci, "MESECI");
            Map(x => x.Dani, "DANI");
            Map(x => x.PrethodnaFirma, "PRETHODNA_FIRMA");
        }
    }
}
