using Microsoft.AspNetCore.Mvc;
using AirlineBLss;
using AirlineModelling;
using AirlineDLs;

namespace AirlineModelling.API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {
        BookingBL _bookingBL;
        UserTransactionServices _userTransactionServices;
        UserValidationServices _userValidationServices;
        UserData _userData;

        public UserController()
        {
            _bookingBL = new BookingBL();
            _userTransactionServices = new UserTransactionServices();
        }

        [HttpGet]
        public IEnumerable<AirlineModelling.API.User> GetUsers()
        {
            var activeusers = _bookingBL.GetUsersByStatus(1);

            List<AirlineModelling.API.User> users = new List<User>();

            foreach (var item in activeusers)
            {
                users.Add(new User { ticketnum = item.ticketnum, user = item.user, status = item.status });
            }

            return users;
        }

        [HttpPost]
        public JsonResult AddUser(User request)
        {
            var result = _userTransactionServices.CreateUser(request.ticketnum, request.user);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateUser(User request)
        {
            var result = _userTransactionServices.UpdateUser(request.ticketnum, request.user);

            return new JsonResult(result);
        }

        //[HttpDelete]

        //public void DeleteUser(User request)
        //{
        //    _userTransactionServices.DeleteUser(request.ticketnum);

           
        //}
    }
}
