using EmployeeApi.DataServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.DataServices.Implementation
{
    public class AccountDataService: IAccountDataService
    {
        public bool CheckUser(string username, string password)
        {
            string validUsername = "rupaligupta";
            string validPassword = "rupali@123";
            bool status = false;

            if (username.Equals(validUsername, StringComparison.OrdinalIgnoreCase)
                && password.Equals(validPassword, StringComparison.OrdinalIgnoreCase))
                status = true;

            return status;
        }
    }
}
