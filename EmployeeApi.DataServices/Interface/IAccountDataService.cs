using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.DataServices.Interface
{
    public interface IAccountDataService
    {
        bool CheckUser(string username, string password);
    }
}
