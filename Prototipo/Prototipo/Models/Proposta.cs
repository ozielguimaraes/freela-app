using System.Collections.Generic;

namespace Prototipo.Models
{
    public class Proposta
    {
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public string Empreendimento { get; set; }
        public string Torre { get; set; }
        public string Unidade { get; set; }
        public int PercentagemConclusao { get; set; }
        public ICollection<string> Movimentacoes { get; set; }
    }
}