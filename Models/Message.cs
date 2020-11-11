using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_redsocial_aspnetcore.Models
{
    public class Message
    {
        public int Id { get; set; }
        public bool Viewed { get; set; }
        public DateTime CreatedAt { get; set; }

        public int EmitterId { get; set; }
        public int ReceiverId { get; set; }
        public virtual User Emitter { get; set; }
        public virtual User Receiver { get; set; }
    }
}
