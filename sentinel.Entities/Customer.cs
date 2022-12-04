using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Entities
{
    public class Customer
    {
        public int Id { get; set; }

 
        public int? PersonType { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Dob { get; set; }

        public string? Email { get; set; }

        public string? Mobile { get; set; }

        public string? Description { get; set; }
 
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
     
         public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsModified { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

 

        public DateTime? LastModifiedDate { get; set; }

        public ICollection<Addresses>? Addresses { get; set; }

    }
}
