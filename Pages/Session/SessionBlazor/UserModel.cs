using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationDemo.Pages.Session.SessionBlazor
{
    public class UserModel
    {
        public int User_id { get; set; }
        public string UserName { get; set; }
        public string CompanySelected { get; set; }
        public string YearSelected { get; set; }
    }
}
