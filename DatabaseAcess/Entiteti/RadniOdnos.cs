using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public class RadniOdnos: Poslanik
    {
            public virtual int BrojRadneKnjizice { get; set; }
            public virtual int Godine { get; set; }
            public virtual int Meseci { get; set; }
            public virtual int Dani { get; set; }
            public virtual string PrethodnaFirma { get; set; }
            public RadniOdnos()
            {

            }
    }
}
