using AirlineDLs;
using AirlineModelling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBLss
{
    public class UserTransactionServices
    {
        UserValidationServices validationServices = new UserValidationServices();
        UserData userData = new UserData();

        public bool CreateUser(Booking user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.ticketnum))
            {
                result = userData.AddUser(user) > 0;
            }

            return result;
        }

        public bool CreateUser(string ticketnum, string user)
        {
            Booking users = new Booking { ticketnum = ticketnum, user = user };

            return CreateUser(users);
        }

        public bool UpdateUser(Booking user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.ticketnum))
            {
                result = userData.UpdateUser(user) > 0;
            }

            return result;
        }

        public bool UpdateUser(string ticketnum, string user)
        {
            Booking users = new Booking { ticketnum = ticketnum, user = user };

            return UpdateUser(users);
        }

        public bool DeleteUser(Booking user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.ticketnum))
            {
                result = userData.DeleteUser(user) > 0;
            }

            return result;
        }
    }
}
