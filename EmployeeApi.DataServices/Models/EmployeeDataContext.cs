using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.DataServices.Models
{
    public class EmployeeDataContext
    {
        public EmployeeDataContext()
        {
            Employees = new List<EmployeeModel>();
        }
        public List<EmployeeModel> Employees { get; set; }
    }
}
