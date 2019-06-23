using EmployeeFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSecurity
{
    public class EmployeeSecurity
    {
        public static bool Login(string user, string password)
        {
            using (TharEntities con = new TharEntities())
            {
                return con.Users.Any(x => x.User1.Equals(user,StringComparison.OrdinalIgnoreCase)
                && x.Password == password);
            }
        }
    }
}