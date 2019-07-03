using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels.Infrastructure
{
    public interface IHasId<T>
    {
        T Id { get; set; }
    }

    public interface IHasStringId : IHasId<string>
    {

    }
}