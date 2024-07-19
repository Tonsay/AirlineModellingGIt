
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AirlineModelling;

namespace AirlineDLs
{
    public class UserData
    {

        List<Booking> users;
        SqlDbData sqlData;
        
        public UserData()
        {
            users = new List<Booking>();
            sqlData = new SqlDbData();

            //InfoDL _userFactory = new InfoDl();
            //users = _userFactory.GetDummysDetail();
        }

        public List<Booking> GetDetails()
        {
           users = sqlData.GetDetails();
           return users;
        }

        public int AddUser(Booking user)
        {
            return sqlData.AddUser(user.ticketnum, user.user);
        }

        public int UpdateUser(Booking user)
        {
            return sqlData.UpdateUser(user.ticketnum, user.user);
        }

        public int DeleteUser(Booking user)
        {
            return sqlData.DeleteUser(user.ticketnum);
        }
    }
}
