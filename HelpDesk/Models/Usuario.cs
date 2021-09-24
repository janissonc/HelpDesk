using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public string DeletarTarefa { get; set; } // Response deve ser Y ou N
        public string CriarTarefa { get; set; } // Response deve ser Y ou N
        public string EditarTarefa { get; set; } // Response deve ser Y ou N
        public string RelatorioDeTarefa { get; set; } // Response deve ser Y ou N
        public string DeletarUsuario { get; set; } // Response deve ser Y ou N
        public string EditarUsuario { get; set; } // Response deve ser Y ou N
        public string CriarUsuario { get; set; } // Response deve ser Y ou N
        public string CriarRecurso { get; set; } // Response deve ser Y ou N
        public string EditarRecurso { get; set; } // Response deve ser Y ou N
        public string DeletarRecurso { get; set; } // Response deve ser Y ou N
        public string CriarIncidente { get; set; } // Response deve ser Y ou N
        public string EditarIncidente { get; set; } // Response deve ser Y ou N
        public string DeletarIncidente { get; set; } // Response deve ser Y ou N
        public string CancelarIncidente { get; set; } // Response deve ser Y ou N
        public string login { get; set;}
        public string senha { get; set; }
    }
}
