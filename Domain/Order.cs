using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
   public class Order
    {
        public int Id { get; set; }
        public float TotalPrice { get; set; }

        public DateTime DateOrder { get; set; }

        public bool OrderStatus { get; set; }

        public DateTime DeliveryDate { get; set; }

        public float ShippingPrice { get; set; }

        public float Tax { get; set; }

        public int Quantity { get; set; }

        public IEnumerable<Product> products { get; set; }

       
        public Card card { get; set; }

 
        public ContactDetails contactDetails { get; set;}

       
        public Buyer buyer { get; set; }
    }
}
