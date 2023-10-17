using InternetSales.DataAccess.Model;
using InternetSales.DataAccess.Repository;
using System.ComponentModel.DataAnnotations;

namespace InternetSales.Models
{
    public class InternetSalesViewModel
    {
        public List<InternetSalesModel>? CustomerList { get; set; }
        public InternetSalesModel? CurrentCustomer { get; set; }
        public bool IsActionSuccess { get; set; }
        public string ActionMessage { get; set; }

        public int CustomerId { get; set; }
        public string? BusinessOwner { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string BusinessAddress { get; set; }
        [Required]
        [MaxLength(12, ErrorMessage = "Phone number length to long.")]
        public string PhoneNumber { get; set; }
        [Required]
        public bool PurchasedInternet { get; set; }
        [Required]
        public bool PurchasedPhone { get; set; }
        [Required]
        public bool PurchasedCellService { get; set; }
        [Required]
        public bool TvService { get; set; }
    }
}
