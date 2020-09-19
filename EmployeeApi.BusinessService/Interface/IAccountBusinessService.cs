using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.BusinessServices.Interface
{
    public interface IAccountBusinessService
    {
        bool AuthenticateUser(string username, string password);
    }
}
