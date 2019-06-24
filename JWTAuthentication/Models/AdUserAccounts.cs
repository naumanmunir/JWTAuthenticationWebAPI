using System;
using System.Collections.Generic;

namespace JWTAuthentication.Models
{
    public partial class AdUserAccounts
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Samaccount { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Manager { get; set; }
        public string Ou { get; set; }
        public string Telephone { get; set; }
    }
}
