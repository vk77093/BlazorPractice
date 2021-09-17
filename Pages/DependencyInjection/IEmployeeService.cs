using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationDemo.Pages.DependencyInjection
{
   public interface IEmployeeService
    {
        // EmployeeModelsdep employeeModel;
        EmployeeModelsdep GetEmployeeById(int id);
        public string Uid { get; set; }
    }
}
