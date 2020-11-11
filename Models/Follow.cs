using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_redsocial_aspnetcore.Models
{
    public class Follow
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FollowedId { get; set; }
        public virtual User User { get; set; }
        public virtual User Followed { get; set; }
    }
}
