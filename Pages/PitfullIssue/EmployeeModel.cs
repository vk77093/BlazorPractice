using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationDemo.Pages.PitfullIssue
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string emp_name { get; set; }
        [Required]
        public string emp_departmemt { get; set; }
        public string emp_sallery { get; set; }

        public void LoadEmployee()
        {

        }
    }
}
