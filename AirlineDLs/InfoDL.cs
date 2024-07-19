using AirlineModelling;
using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
namespace AirlineDLs
{
    public class InfoDL
    {
        private List<Info> dummyDetails = new List<Info>();

        public Info GetBookingInfo()
        {
            throw new NotImplementedException();
        }

        public List<Info> GetDummyDetails()
        {
            dummyDetails.Add(CreateDummyDetails ("Jeff Satur", "First Class","01","Thailand","Philippines", "DateTime.Now"));
            dummyDetails.Add(CreateDummyDetails("John Stamos", "Economy Class", "02", "America", "Philippines", "DateTime.Now"));
            dummyDetails.Add(CreateDummyDetails("Jihoon Lee", "Business Class", "03", "South Korea", "Philippines", "DateTime.Now"));
            dummyDetails.Add(CreateDummyDetails("Mingyu Kim", "First Class", "04", "South Korea", "Philippines", "DateTime.Now"));
            dummyDetails.Add(CreateDummyDetails("Wonwoo Jeon", "Economy Class", "05", "Japan", "Philippines", "DateTime.Now"));



            return dummyDetails;
        }

        private Info CreateDummyDetails(string passenger, string classtype, string seatnum, string origin, string destination, string flightDate)
        {
            Info userinfo = new Info
            {
                passenger = passenger,
                classtype = classtype,
                seatnum = seatnum,
                origin = origin,
                destination = destination,
                flightdate = DateTime.Now
            };

            return userinfo;
        }

        //public string passenger;

        //public Info GetBookingInfo()
        //{
        //    return new Info { passenger = "Jeff Satur", classtype = "First Class", seatnum = "01", origin = "Thailand", destination = "Philippines", flightdate = DateTime.Now };

        //}
        //public Info GetInfo()
        //{
        //    return new Info { passenger = "John Stamos", classtype = "Economy Class", seatnum = "02", origin = "Los Angeles", destination = "Philippines", flightdate = DateTime.Now };
        //}

        //public Info GetIdea()
        //{
        //    return new Info { passenger = "Jihoon Lee", classtype = "Business Class", seatnum = "03", origin = "South Korea", destination = "Philippines", flightdate = DateTime.Now };
        //}

        //public Info GetIwan()
        //{
        //    return new Info { passenger = "Mingyu Kim", classtype = "First Class", seatnum = "04", origin = "South Korea", destination = "Philippines", flightdate = DateTime.Now };
        //}

        //public Info GetIda()
        //{
        //    return new Info { passenger = "Wonwoo Jeon", classtype = "Economy Class", seatnum = "05", origin = "South Korea", destination = "Philippines", flightdate = DateTime.Now };
        //}
    }
}
