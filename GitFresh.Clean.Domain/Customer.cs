using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFresh.Clean.Domain
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string? UserName { get; set; }
        public string? PasswordHash { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateOnly DOB { get; set; }
        public string? Address { get; set; }
        public int Phone { get; set; }

    }
}
