using AirlineModelling;
using AirlineDLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBLss
{
    public class InfoBL
    {
        public readonly InfoDL infos;

        public InfoBL()
        {
            infos = new InfoDL();
        }
        public Info GetBookingInfo()
        {
            return infos.GetBookingInfo();
        }

        //public Info GetInfo()
        //{
        //    return infos.GetInfo();
        //}

        //public Info GetIdea()
        //{
        //    return infos.GetIdea();
        //}
        //public Info GetIwan()
        //{
        //    return infos.GetIwan();
        //}
        //public Info GetIda()
        //{
        //    return infos.GetIda();
        //}

        public Info SaveBookingInfo()
        {
            return new Info();
        }
    }
}
