using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Models.ORM.Entities
{
    public class ContactList : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int AddressID { get; set; }

        [ForeignKey("AddressID")]
        public Addresses Addresses { get; set; }


    }
}
