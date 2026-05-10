using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RachaAíBlazor.Models
{
    public class Grupo
    {
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public decimal ValorPendente { get; set; }
        public bool NoVermelho { get; set; }
    }
}