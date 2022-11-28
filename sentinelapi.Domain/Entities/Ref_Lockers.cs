using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Domain.Entities
{
    public class Ref_Lockers
    {
        public int Id { get; set; }

        public int? LockerId { get; set; }

        public string? DisplayName { get; set; }
        
        public int? LockerGroupId { get; set; }


        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsModified { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

    }
}
