using Microsoft.AspNetCore.Identity;
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Entities
{
    public class ApplicationUser : IdentityUser
    {

        public Guid? TennantId { get; set; }

        public bool? PasswordChangeReuqired { get; set; }

        public DateTime? LastPasswordChangedDate { get; set; }

        public DateTime? PasswordExpiryDate { get; set; }

        public bool? FirstPasswordChange { get; set; }

        public bool? ForcePasswordChange { get; set; }

        public bool? IsBlocked { get; set; }
        public bool? IsParent { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public bool? IsAdmin { get; set; }

        public int? PlayerId { get; set; } // Foreign key

    }
}
