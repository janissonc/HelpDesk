using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class Recurso
    {
        public int Id { get; set; }
        public string TipoDeEquipamento { get; set; }
        public string NomeEquipamento { get; set; }
        public string Secretaria { get; set; }
        public string Setor { get; set; }
        public string Patrimonio { get; set; }
        public string NumeroDeSerie { get; set; }
        public string ModeloEquipamento { get; set; }
        public string Configuracoes { get; set; }
        public string Etiqueta { get; set; }
    }
}
