using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_redsocial_aspnetcore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {get;set;}
        public string Nick { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Image { get; set; }

    }
}
