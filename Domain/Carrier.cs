using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Carrier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email{ get; set; }

        public long MobileNumber { get; set; }

        public IEnumerable<Product> products { get; set; }
    }
}
