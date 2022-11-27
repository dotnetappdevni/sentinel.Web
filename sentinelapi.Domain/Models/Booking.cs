using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Domain.Models
{
    public  class Booking
    {
        public int Id { get; set; }
        

        public int? PersonId { get; set; }
        public Person? Person { get; set; }
        
        public string? Description { get; set; }

        public string? Notes { get; set; }
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public  Locker?  Lockers { get; set; }
        public bool? IsModified { get; set;}

        public string? CreatedBy { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get;set; }


    }
}
