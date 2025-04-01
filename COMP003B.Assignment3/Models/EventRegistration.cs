using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace COMP003B.Assignment3.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public string EventCode { get; set; } 

        [Range(1, 10)]
        public int Tickets { get; set; }

        public string? ReferralCode { get; set; }

    }
}
