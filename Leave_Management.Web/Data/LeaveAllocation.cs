﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Leave_Management.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {

        public int NumberOfDays { get; set; }

        public int? LeaveTypeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveType { get; set; }

        public string? EmployeeId { get; set; }

        public int Period { get; set; }
    }
}
