using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string ClientName { get; set; }


       [Required]
        [Phone] 
        public string MobileNo { get; set; }


        [Required]
        [StringLength(100)]
        [Column(TypeName = ("varchar"))]
        public string Address { get; set; }


        [Required]
        [StringLength(20)]
        [Column(TypeName = ("varchar"))]
        public string City { get; set; }
    }
}
