﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeLeaveManSystem.Models
{
    public class LeaveAllocationVM
    {
        
        public int Id { get; set; }
      
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public DateTime DateCreated { get; set; }
    
        public EmployeeVM Employee { get; set; }
        public String EmployeeId { get; set; }
      
        public LeaveTypeVM leaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public IEnumerable<SelectListItem> Employees { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
    public class CreateLeaveAllocationVM
    {
        public int NumberUpdated { get; set; }
        public List<LeaveTypeVM> LeaveTypes { get; set; }
    }
}
