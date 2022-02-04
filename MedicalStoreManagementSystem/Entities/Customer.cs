using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string Address { get; set; }
    }
}
