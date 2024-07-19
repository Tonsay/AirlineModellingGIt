using AirlineModelling;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace AirlineDLs
{
    public class BookingDL
    {
        internal readonly string ticketnum;
        private List<Booking> dummys = new List<Booking>();

        public List<Booking> GetDummysDetail()
        {
            dummys.Add(CreateDummysDetail("0001", "Jeff Satur"));
            dummys.Add(CreateDummysDetail("0002", "John Stamos"));
            dummys.Add(CreateDummysDetail("0003", "Jihoon Lee"));
            dummys.Add(CreateDummysDetail("0004", "Mingyu Kim"));
            dummys.Add(CreateDummysDetail("0005", "Wonwoo Jeon"));
            dummys.Add(CreateDummysDetail("0006","Jeonghan Yoon"));
            dummys.Add(CreateDummysDetail("0007", "Jennie Kim"));


            return dummys;

        }

        private Booking CreateDummysDetail(string ticketnum, string user)
        {
            Booking usersinfo = new Booking
            {
                ticketnum  = ticketnum,
                user = user,
                dateUpdated = DateTime.Now,
                dateVerified = DateTime.Now.AddDays(1),
                status = 1
            };

            return usersinfo;
        }


        //List<Booking> details = new List<Booking>();

        //public BookingDL()
        //{
        //    CreateDetails();
        //}

        //private void CreateDetails()
        //{

        //    Booking kings = new Booking { ticketnum = "0001", user = "Jeff Satur"};
        //    details.Add(kings);

        //    Booking kingsman = new Booking { ticketnum = "0002", user = "John Stamos "};
        //    details.Add(kingsman);

        //    Booking kingkong = new Booking { ticketnum = "0003", user = "Jihoon Lee" };
        //    details.Add(kingkong);

        //    Booking kongkong = new Booking { ticketnum = "0004", user = " Mingyu Kim " };
        //    details.Add(kongkong);

        //    Booking kungkung = new Booking { ticketnum = "0005", user= "Wonwoo Jeon" };
        //    details.Add(kungkung);
        //}

        //public Booking GetBookings(string ticketnum, string user)
        //{
        //    Booking foundDetail = new Booking();
        //    foreach (var king in details)
        //    {
        //        if (king.ticketnum == ticketnum)
        //        {
        //            foundDetail = king;
        //        }
        //        else if (king.user == user)
        //        {
        //            foundDetail = king;
        //        }

        //    }
        //    return foundDetail;
        //}
    }
}
