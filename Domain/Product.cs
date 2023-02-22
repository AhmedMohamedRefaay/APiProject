using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
   public class Product
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Discription  { get; set; }
        public float Discount { get; set; }
        public int AvaiUnit { get; set; }
        public string Size { get; set; }

        
        public Category category { get; set; }
        public Carrier carrier { get; set; }
        public Seller seller { get; set; }

         public Order order { get; set; }

        public IEnumerable<Review> reviews { set; get; }
        public WishList wishList { get; set; }

     //Relation between it and shoppingcard ???????????????
 

        public ShoppingCart shoppingCart { get; set; }

        public IEnumerable<Color> colors { get; set; }

        public IEnumerable<Images> images { get; set; }

    }
}
