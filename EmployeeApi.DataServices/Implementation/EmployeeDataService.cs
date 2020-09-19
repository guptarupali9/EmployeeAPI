using EmployeeApi.DataServices.Interface;
using EmployeeApi.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.DataServices.Implementation
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly EmployeeDataContext _employeeDataContext;

        public EmployeeDataService(EmployeeDataContext employeeDataContext)
        {
            _employeeDataContext = employeeDataContext;
        }

        public IEnumerable<EmployeeModel> Get()
        {
            return new List<EmployeeModel> { new EmployeeModel { Id =1, Name ="Rupali" , Salary= 40000, Designation ="Senior Software Engineer", DepartmentName="IT"},
            new EmployeeModel { Id =1, Name ="Preethi" , Salary= 40000, Designation ="Admin Head", DepartmentName="Admin"},
            new EmployeeModel { Id =1, Name ="Aman" , Salary= 40000, Designation ="Manager", DepartmentName="IT"},
            };
        }
    }
}
