﻿using System.ComponentModel.DataAnnotations;

namespace Leave_Management.Web.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Date Requested")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }

        public string RequestingEmployeeId { get; set; }

        public EmployeeListVM Employee { get; set; }
    }
}