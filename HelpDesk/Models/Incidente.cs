using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class Incidente
    {
        public int Id{ get; set; }
        public Usuario Usuario { get; set; }
        public string Problema { get; set; }
        public string Descricao { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Secretaria { get; set; }
        public string Unidade { get; set; }
        public string NumeroDePatrimonio { get; set; }
        public Prioridade Prioridade { get; set; }
        public DateTime DataDeAbertura { get; set; }
        public DateTime DataDeFechamento { get; set; }
        public double QuantidadeDeHorasGastas { get; set; }
    }
}
