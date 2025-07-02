using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EzzyBillApiDemo.Models
{
    public class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("fullName")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Column("phone")]
        [StringLength(100)]
        public string Phone { get; set; }

        [Required]
        [Column("city")]
        [StringLength(100)]
        public string City { get; set; }
    }
}
