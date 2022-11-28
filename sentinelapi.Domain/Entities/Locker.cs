using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Domain.Entities
{
    public  class Locker
    {
        public int Id { get; set; }
     

        public int? LockerId { get; set; }

        public string? RowId { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        public bool? IsRented { get; set; }
        public string? Description { get; set; }
        public int? BookingId { get; set; }
        public int? Book { get; set; }

        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public bool? IsModified { get; set; }

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}
