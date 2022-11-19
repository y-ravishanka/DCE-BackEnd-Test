﻿namespace DCE_BackEnd_Test.Models
{
    public class Customer
    {
        public string? UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
