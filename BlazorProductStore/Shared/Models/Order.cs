using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorProductStore.Shared.Models
{
    public partial class Order
    {
        //public Order()
        //{
        //    Cartlines = new HashSet<Cartline>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public sbyte GiftWrap { get; set; }
        public sbyte Shipped { get; set; }
        public string Country { get; set; }

        //public virtual ICollection<Cartline> Cartlines { get; set; }
    }
}
