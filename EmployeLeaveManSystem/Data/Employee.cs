using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeLeaveManSystem.Data
{
    public class Employee : IdentityUser
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        //public DateTime DateCreated { get; set; }
        

    }
}
