using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class UserComment: EntityInt, IAudited
    {
        public string Text { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int? ParentCommentId { get; set; }
        public UserComment ParentComment { get; set; }
    }
}
