using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Models.ORM.VM
{
    public class AddAddressVM
    {
        public int ID { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
