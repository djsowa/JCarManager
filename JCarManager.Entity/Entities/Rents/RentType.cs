using System.ComponentModel.DataAnnotations;

namespace JCarManager.Entity.Entities.Rents
{
    public class RentType
    {
        //[Key]
        public virtual int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsPernamentRent { get; set; }
        public virtual bool IsOneTimeRent { get; set; }
    }
}