using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Domain.Entities
{
    public  class Addresses
    {
        public int Id { get; set; }

        public int? GroupId { get; set; }
        public string? Name { get; set; }

        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }

        public string? AddressLine3 { get; set; }

        public string? AddressLine4 { get; set; }

        public string? Country { get; set; }

        public string? PostCode { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsModified { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}
