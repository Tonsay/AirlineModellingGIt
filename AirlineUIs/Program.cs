using AirlineBLss;
using AirlineDLs;
using AirlineModelling;
using System.Security.Cryptography.X509Certificates;

namespace AirlineUIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookingBL getServices = new BookingBL();

            var users = getServices.GetUsersByStatus(1);

            foreach (var item in users)
            {
                Console.WriteLine(item.ticketnum);
                Console.WriteLine(item.user);
            }
        }
    }
}

            // SqlDbData.AddUser("0007", "Jennie Kim");

            //SqlDbData.UpdateUser("testing", "test123");

            //SqlDbData.DeleteUser("testing");

            //GetUsers();           

            //Console.WriteLine("TONSAY AIRLINES!");


            //Console.WriteLine("Enter your Ticket Number:");
            //string ticketnum = Console.ReadLine();
            //Console.WriteLine("Enter your Name:");
            //string user = Console.ReadLine();

            //Console.WriteLine("_______________________________________");


            //BookingBL details = new BookingBL();
            //bool result = details.VerifyBookings(ticketnum, user);


            //if (result)
            //{
            //    Console.WriteLine("USER FOUND");
            //    Console.WriteLine("________________________________________");
            //    Console.WriteLine("Booking Details");

            //    InfoBL service = new InfoBL();

            //    Info passenger1 = service.GetBookingInfo();
            //    Console.WriteLine("Ticket Number: 0001");
            //    Console.WriteLine($"Passenger: {passenger1.passenger}");
            //    Console.WriteLine($"Type of Class: {passenger1.classtype}");
            //    Console.WriteLine($"Seat Number: {passenger1.seatnum}");
            //    Console.WriteLine($"Origin: {passenger1.origin}");
            //    Console.WriteLine($"Destination: {passenger1.destination}");
            //    Console.WriteLine($"Date of Flight: {passenger1.flightdate}");
            //    Console.WriteLine("________________________________________");

            //    Info passenger2 = service.GetInfo();
            //    Console.WriteLine("Ticket Number: 0002");
            //    Console.WriteLine($"Passenger: {passenger2.passenger}");
            //    Console.WriteLine($"Type of Class: {passenger2.classtype}");
            //    Console.WriteLine($"Seat Number: {passenger2.seatnum}");
            //    Console.WriteLine($"Origin: {passenger2.origin}");
            //    Console.WriteLine($"Destination: {passenger2.destination}");
            //    Console.WriteLine($"Date of Flight: {passenger2.flightdate}");
            //    Console.WriteLine("________________________________________");

            //    Info passenger3 = service.GetIdea();
            //    Console.WriteLine("Ticket Number: 0003");
            //    Console.WriteLine($"Passenger: {passenger3.passenger}");


            //    Console.WriteLine($"Origin: {passenger3.origin}");
            //    Console.WriteLine($"Destination: {passenger3.destination}");
            //    Console.WriteLine($"Date of Flight: {passenger3.flightdate}");
            //    Console.WriteLine("________________________________________");

            //    Info passenger4 = service.GetIwan();
            //    Console.WriteLine("Ticket Number: 0004");
            //    Console.WriteLine($"Passenger: {passenger4.passenger}");
            //    Console.WriteLine($"Type of Class: {passenger4.classtype}");
            //    Console.WriteLine($"Seat Number: {passenger4.seatnum}");
            //    Console.WriteLine($"Origin: {passenger4.origin}");
            //    Console.WriteLine($"Destination: {passenger4.destination}");
            //    Console.WriteLine($"Date of Flight: {passenger4.flightdate}");
            //    Console.WriteLine("________________________________________");

            //    Info passenger5 = service.GetIda();
            //    Console.WriteLine("Ticket Number: 0005");
            //    Console.WriteLine($"Passenger: {passenger5.passenger}");
            //    Console.WriteLine($"Type of Class: {passenger5.classtype}");
            //    Console.WriteLine($"Seat Number: {passenger5.seatnum}");
            //    Console.WriteLine($"Origin: {passenger5.origin}");
            //    Console.WriteLine($"Destination: {passenger5.destination}");
            //    Console.WriteLine($"Date of Flight: {passenger5.flightdate}");
            //    Console.WriteLine("________________________________________");
            //}

            //else
            //{
            //    Console.WriteLine("USER IS NOT IDENTIFIED");
            //}

        //}

        //public static void GetUsers()
        //{
        //    List<Booking> BookingFromDB = SqlDbData.GetDetails();
        //    foreach (var item in BookingFromDB)
        //    {
        //        Console.WriteLine(item.ticketnum);
        //        Console.WriteLine(item.user);
        //    }
    //}
    //}
