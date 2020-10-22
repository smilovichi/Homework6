using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
      class User
    {
     private static string userName;

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
