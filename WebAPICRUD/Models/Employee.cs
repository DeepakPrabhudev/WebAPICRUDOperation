using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPICRUD.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Gender{ get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
    }
}