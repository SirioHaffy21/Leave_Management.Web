﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Leave_Management.Web.Data
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int? LeaveTypeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveType { get; set; }

        public DateTime DateRequested { get; set; }

        public string? RequestComments { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }

        public string RequestingEmployeeId { get; set; }
    }
}
