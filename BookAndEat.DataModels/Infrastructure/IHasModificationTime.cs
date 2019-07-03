using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels.Infrastructure
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}
