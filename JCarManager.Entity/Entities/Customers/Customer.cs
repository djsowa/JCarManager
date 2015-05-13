using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCarManager.Entity.Entities.Customers
{
    public class Customer
    {
        public Customer()
        {
            DateAdded = DateTime.UtcNow;
        }

        //[Key]
        public virtual int Id { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string Country { get; set; }
    }
}
