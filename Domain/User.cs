using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class User
    {
        public int Id { get; set; }

        public string  Fname { get; set; }
        public string Lname { get; set; }

        public string Password { get; set; }

        public string Email { set; get; }

        public long MobileNumber { get; set; }

        public string UserType { get; set; }//????????????????????

        public IEnumerable<ContactDetails> contactDetails { get; set; }
    }
}
