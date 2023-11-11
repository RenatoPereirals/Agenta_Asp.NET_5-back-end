using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProEventos.Domain.Enum;

namespace ProEventos.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Titulo  Titulo { get; set; }
        public string Decricao { get; set; }
        public Funcao Funcao { get; set; }
        public string imagemURL { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}