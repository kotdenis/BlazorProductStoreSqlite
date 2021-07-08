using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorProductStore.Shared.ViewModels
{
    public class CompletedOrder
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
        public bool Shipped { get; set; }
        public int OrderId { get; set; }

        public List<CartLineVM> CartLineVMs { get; set; }
    }
}
