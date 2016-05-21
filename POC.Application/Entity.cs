using System;

namespace POC.Application
{
    public abstract class Entity
    {
        protected Entity()
        {
            CreatedDate = DateTime.Now;
        }

        public int Id { get; }
        public DateTime CreatedDate { get; }
    }
}
