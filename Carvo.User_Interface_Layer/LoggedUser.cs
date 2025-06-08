using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Enums;

namespace Carvo.User_Interface_Layer
{
    public static class LoggedUser
    {
        public static int loggedUserId = 0;
        public static string loggedUserName = "";
        public static Role Role = Role.None;
        public static MainWindowFrom mainWindowForm = null;
    }
}
