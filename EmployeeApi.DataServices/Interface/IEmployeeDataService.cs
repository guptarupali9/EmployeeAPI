using EmployeeApi.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.DataServices.Interface
{
    public interface IEmployeeDataService
    {
        IEnumerable<EmployeeModel> Get();
    }
}
