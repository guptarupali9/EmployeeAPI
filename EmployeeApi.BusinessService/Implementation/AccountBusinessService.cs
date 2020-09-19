using EmployeeApi.BusinessServices.Interface;
using EmployeeApi.DataServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.BusinessServices.Implementation
{
    public class AccountBusinessService: IAccountBusinessService
    {
        private readonly IAccountDataService _accountDataService;

        public AccountBusinessService(IAccountDataService accountDataService)
        {
            _accountDataService = accountDataService;
        }

        public bool AuthenticateUser(string username, string password)
        {
            return _accountDataService.CheckUser(username, password);
        }
    }
}
