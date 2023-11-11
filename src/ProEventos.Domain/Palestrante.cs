using System;
using System.Collections.Generic;
using ProEventos.Domain.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Domain
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string MiniCurriculo { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }

        public string NOmeCompleto { get; set; }
        
    }
}