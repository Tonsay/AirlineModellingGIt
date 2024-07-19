using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBLss
{
    public class UserValidationServices
    {
        BookingBL getservices = new BookingBL();

        public bool CheckIfUserNameExists(string ticketnum)
        {
            bool result = getservices.GetUser(ticketnum) != null;
            return result;
        }

        public bool CheckIfUserExists(string ticketnum, string user)
        {
            bool result = getservices.GetUser(ticketnum, user) != null;
            return result;
        }

    }
}
