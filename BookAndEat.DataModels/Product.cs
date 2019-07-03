using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Product: IHasStringId, IHasCreationTime
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Mesurement Mesurement { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
