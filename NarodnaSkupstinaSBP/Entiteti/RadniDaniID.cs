using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstinaSBP.Entiteti
{
    public class RadniDaniID
    {
        public virtual int RadniDanID { get; set; }
        public virtual Sednica Sednica { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(RadniDaniID))
                return false;

            RadniDaniID recievedObject = (RadniDaniID)obj;

            if ((RadniDanID == recievedObject.RadniDanID) &&
                (Sednica.IDSednice == recievedObject.Sednica.IDSednice))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
