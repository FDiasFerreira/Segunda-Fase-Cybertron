using System;


namespace SegundaFase.Business.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime InsertDate { get; private set; }
        public DateTime? UpdateDate { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
