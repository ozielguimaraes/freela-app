using System.Collections.Generic;

namespace Prototipo.Models
{
    public class Empreendimento
    {
        public Empreendimento()
        {
            Torres = new List<Torre>();
            Unidades = new List<Unidade>();
        }

        public int Id { get; set; }
        public string Imagem { get; set; }
        public string Nome { get; set; }

        public List<Torre> Torres { get; set; }
        public List<Unidade> Unidades { get; set; }
    }
}