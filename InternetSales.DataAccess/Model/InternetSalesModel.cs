using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public bool PurchasedInternet { get; set; }
        [Required]
        public bool PurchasedPhone { get; set; }
        [Required]
        public bool PurchasedCellService { get; set; }
        [Required]
        public bool TvService { get; set; }

        public InternetSalesModel(string businessOwner, string businessName, string businessAddress, string phoneNumber, bool purchasedInternet, bool purchasedPhone, bool purchasedCellService, bool tvService)
        {
            BusinessOwner = businessOwner;
            BusinessName = businessName;
            BusinessAddress = businessAddress;
            PhoneNumber = phoneNumber;
            PurchasedInternet = purchasedInternet;
            PurchasedPhone = purchasedPhone;
            PurchasedCellService = purchasedCellService;
            TvService = tvService;
        }

        public InternetSalesModel(int customerId, string businessOwner, string businessName, string businessAddress, string phoneNumber, bool purchasedInternet, bool purchasedPhone, bool purchasedCellService, bool tvService)
        {
            CustomerId = customerId;
            BusinessOwner = businessOwner;
            BusinessName = businessName;
            BusinessAddress = businessAddress;
            PhoneNumber = phoneNumber;
            PurchasedInternet = purchasedInternet;
            PurchasedPhone = purchasedPhone;
            PurchasedCellService = purchasedCellService;
            TvService = tvService;
        }

        public InternetSalesModel()
        {
            
        }
    }
}
