using System.ComponentModel.DataAnnotations;

namespace JCarManager.Entity.Entities.Cars
{
    public class CarEquipment
    {
        public virtual int Id { get; set; }
        public virtual Car Car { get; set; }
        public virtual int CarId { get; set; }
        public virtual int WheelSize { get; set; }
        public virtual int AirbagsCount { get; set; }

        public virtual bool HasBlackWindows { get; set; }
        public virtual bool HasAlloyWheels { get; set; }
        public virtual bool HasLeatherUpholstery { get; set; }
        public virtual bool HasAutomaticAirConditioning { get; set; }
        public virtual bool HasManualAirConditioning { get; set; }
        public virtual bool HasBuildinNavigation { get; set; }
        public virtual bool HasExternalNavigation { get; set; }
        public virtual bool HasCruiseControl { get; set; }
        public virtual bool HasTractionControl { get; set; }
    }
}