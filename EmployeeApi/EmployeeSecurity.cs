using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApi
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            return true;
        }
    }
}