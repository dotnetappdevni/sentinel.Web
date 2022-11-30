using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinel.APP.ViewModel
{
    public class BookingViewModelForm
    {
        [Required]
        public int? CustomerId { get; set; }


 
        public string LockerId { get; set; }

        [Required]        
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public string? Notes { get; set; }

        public bool? IsRented { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }

        public int? PinCode { get; set; }

        [Required]
        public string Email { get; set; }

        

    }
}
