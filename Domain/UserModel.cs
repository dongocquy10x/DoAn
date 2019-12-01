using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserData userData = new UserData();
        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }

    }

}