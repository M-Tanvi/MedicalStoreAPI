using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    [Table("Stock")]
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string ItemName { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = ("varchar"))]
        public string ItemDetail { get; set; }
        public double ItemPrice { get; set; }
        public long Quantity { get; set; }
        public string Location { get; set; }
        public DateTime ExpiryDate { get; set; }

        
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
        
}
