using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_redsocial_aspnetcore.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Text { get; set; }
        public string File { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; }
    }
}
