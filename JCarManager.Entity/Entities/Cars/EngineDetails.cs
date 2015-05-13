using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCarManager.Entity.Entities.Cars
{
    public class EngineDetails
    {
        public virtual int Id { get; set; }
        public virtual Car Car { get; set; }
        public virtual string EngineNumber { get; set; }
        public virtual FuelTypeEnum FuelType { get; set; }
        public virtual decimal Capacity { get; set; }
        public virtual decimal DeclaredAverageFuelConsumptionMixed { get; set; }
        public virtual decimal DeclaredAverageFuelConsumptionUrban { get; set; }
        public virtual decimal DeclaredAverageFuelConsumptionHighway { get; set; }
        public virtual decimal DeclaredCO2Creation { get; set; }
        public virtual EngineEcologyClassEnum EcologyClass { get; set; }
        public virtual int HorsePower { get; set; }
    }
}