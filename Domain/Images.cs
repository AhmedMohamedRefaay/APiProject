using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Images
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Product product { get; set; }
    }
}
