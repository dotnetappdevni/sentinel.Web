using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Domain.Entities
{
    public  class Ref_LockerSizes
    {
        public int Id { get; set; }

        public int? LockerSizeId { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
       
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsModified { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}
