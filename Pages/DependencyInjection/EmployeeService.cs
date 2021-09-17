using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationDemo.Pages.DependencyInjection
{
    public class EmployeeService : IEmployeeService
    {
        private List<EmployeeModelsdep> employees;
        public string Uid { get; set; }
        public EmployeeService()
        {
            Uid = Guid.NewGuid().ToString();
            employees = new List<EmployeeModelsdep>()
            {
                new EmployeeModelsdep{Id=1,emp_name="ravi",emp_details="some details about that"},
                 new EmployeeModelsdep{Id=2,emp_name="vijay",emp_details="some details about that"},
                  new EmployeeModelsdep{Id=3,emp_name="test user",emp_details="some details about that"},
            };
        }
        public EmployeeModelsdep GetEmployeeById(int id)
        {
            return employees.Find(x => x.Id == id);
        }
    }
}
