using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public Company? Company { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        
        public string? Phone { get; set; }
         public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsModified { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public ICollection<Addresses>? Addresses { get; set; }

    }
}
