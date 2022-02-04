using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    [Table("Sell")]
    public class Sell
    {
        [Key]
        public int SellId { get; set; }

        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Client Client { get; set; }
        public int ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Stock stock { get; set; }
    }
}
