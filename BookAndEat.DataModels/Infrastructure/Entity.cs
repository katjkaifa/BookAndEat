using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels.Infrastructure
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
    }

    public abstract class EntityInt: Entity<int>
    {

    }
}
