using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public class RadniDan
    {
        public virtual RadniDaniID DanID { get; set; }
        public virtual int BrojPoslanika { get; set; }
        public virtual string PocetakRada { get; set; }
        public virtual string KrajRada { get; set; }
        public RadniDan()
        {
            DanID = new RadniDaniID();
        }
    }
}
