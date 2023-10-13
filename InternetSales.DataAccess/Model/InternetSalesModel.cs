using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSales.DataAccess.Model
{
    public class InternetSalesModel
    {
        [Key]
        public int CustomerId { get; set; }
        public string? BusinessOwner { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string BusinessAddress { get; set; }
        public int PhoneNumber { get; set; }
        public bool PurchasedInternet { get; set; }
        public bool PurchasedPhone { get; set; }
        public bool PurchasedCellService { get; set; }
        public bool TvService { get; set; }

        public InternetSalesModel()
        {
            
        }
    }
}
