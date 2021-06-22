using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JIProject.Models
{
    public class Usuario : IdentityUser
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime birthday { get; set; }
    }
}
