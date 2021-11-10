using System;

namespace CleanArchMvc.Domain.Entity
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        //DateTime CreatedDate { get; set; }
        //DateTime? ModifiedDate { get; set; }
        //string CreatedBy { get; set; }
        //public string ModifiedBy { get; set; }
    }
}
