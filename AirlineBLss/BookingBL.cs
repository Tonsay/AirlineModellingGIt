using AirlineDLs;
using AirlineModelling;
using System.Data;

namespace AirlineBLss
{
    public class BookingBL
    {
            public List<Booking> GetAllUsers()
            {
             SqlDbData userData = new SqlDbData();

                return userData.GetDetails();

            }

        public List<Booking> GetUsersByStatus(int userStatus)
        {
            List<Booking> usersByStatus = new List<Booking>();

            foreach (var user in GetAllUsers())
            {
                if (user.status == userStatus)
                {
                    usersByStatus.Add(user);
                }
            }

            return usersByStatus;
        }

        public Booking GetUser(string ticketnum, string user)
            {
                Booking foundUser = new Booking();

                foreach (var users in GetAllUsers())
                {
                    if (users.ticketnum == ticketnum && users.user == user)
                    {
                        foundUser = users;
                    }
                }

                return foundUser;
            }

            public Booking GetUser(string ticketnum)
            {
                Booking foundUser = new Booking();

                foreach (var user in GetAllUsers())
                {
                    if (user.ticketnum == ticketnum)
                    {
                        foundUser = user;
                    }
                }

                return foundUser;
            }
        }
    }


    //public bool VerifyBookings(string ticketnum, string user)
    //{
    //    bool yoo = new bool();
    //    BookingDL dataService = new BookingDL();
    //    var result = dataService.GetBookings(ticketnum, user);

    //    if (result.ticketnum != null)
    //    { 
    //        yoo = true;
    //    }
    //    else if (result.user != null) 
    //    {
    //        yoo = true;
    //    }
    //    else 
    //    {
    //        yoo = false;
    //    }
    //    return yoo;
    //}

