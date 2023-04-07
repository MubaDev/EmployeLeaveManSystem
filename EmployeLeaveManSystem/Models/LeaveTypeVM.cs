using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeLeaveManSystem.Models
{
    public class LeaveTypeVM
    {       
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        [Display(Name = "Default Number of Days")]
        [Range(1,25,ErrorMessage = "Please Enter A valid Number")]
        public int DefaultDays { get; set; }
        [Display(Name ="Date Created")]
        public DateTime? DateCreated { get; set; }
    }    
}
