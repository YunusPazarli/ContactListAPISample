using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Models.ORM.Entities
{
    public class Addresses : BaseEntity
    {
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int ContactID { get; set; }
        [ForeignKey ("ContactID")]
        public Contacts Contacts { get; set; }
    }
}
