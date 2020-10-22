using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
      class User
    {

       public static void SetUserName(string userName)
        {
         User.userName = userName;
        }

        public static string GetUserName()
        {
            return User.userName;
        }

    }
}
