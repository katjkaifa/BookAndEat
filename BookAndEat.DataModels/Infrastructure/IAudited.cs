using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels.Infrastructure
{
    public interface IAudited : IHasCreationTime, IHasModificationTime
    {
        
    }
}
