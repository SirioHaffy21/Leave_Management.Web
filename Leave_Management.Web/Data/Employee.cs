﻿using Microsoft.AspNetCore.Identity;

namespace Leave_Management.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? EmployeeId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }
    }
}
