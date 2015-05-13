using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace JCarManager.Entity.Entities.Cars
{
    public class Car
    {

        public Car()
        {
            EngineDetails = new List<EngineDetails>();
            CarEquipment = new List<CarEquipment>();
        }
        
        public virtual int Id { get; set; }
        public virtual string Test2 { get; set; }
        public virtual string RegistrationNumber { get; set; }
        public virtual string VehicleNumber { get; set; }
        public virtual List<EngineDetails> EngineDetails { get; set; }
        public virtual string Description { get; set; }
        public virtual BodyTypeEnum BodyType { get; set; }
        public virtual List<CarEquipment> CarEquipment { get; set; }
        public virtual CarStatusEnum CarStatus { get; set; }
        public virtual CarGroupTypeEnum GroupTypeEnum { get; set; }

    }
}
