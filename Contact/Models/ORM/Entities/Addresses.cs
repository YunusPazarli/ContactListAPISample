using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Models.ORM.Entities
{
    public class Addresses
    {
        public int UID { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
