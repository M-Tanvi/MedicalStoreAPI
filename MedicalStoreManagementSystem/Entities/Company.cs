using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }


        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string CompanyName { get; set; }


        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string Address { get; set; }


        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string ContactPerson { get; set; }


        [Required]
        [Phone]
        public string MobileNo { get; set; }

    }
}
