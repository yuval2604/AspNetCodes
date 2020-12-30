using System;
using System.ComponentModel.DataAnnotations;

namespace RestApiCourceTurorial.Domain
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizeEmail { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        
        public string ConcurrencyStamp { get; set; }

        public string PhoneNumber { get; set; }

        public string PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string LockoutEnd { get; set; }
        public bool LockoutEndEnable { get; set; }
        public string AccessFailedCount { get; set; }

    }
}
