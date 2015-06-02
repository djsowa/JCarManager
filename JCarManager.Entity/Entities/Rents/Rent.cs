using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.Entity.Entities.Cars;
using JCarManager.Entity.Entities.Customers;

namespace JCarManager.Entity.Entities.Rents
{
    public class Rent
    {
        //[Key]
        public virtual int Id { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual DateTime LastChange { get; set; }
        //[ForeignKey("Id")]
        public virtual Customer Customer { get; set; }
        //[ForeignKey("Id")]
        public virtual RentType RentType { get; set; }

        public Car Car { get; set; }

        public int CoveredDistance { get; set; }

        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }

    }
}
