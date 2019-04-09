using System.Collections.Generic;
using Xamarin.Forms;

namespace Prototipo.Models
{
    public class Proposta
    {
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public string Empreendimento { get; set; }
        public string Torre { get; set; }
        public string Unidade { get; set; }
        public Conclusao Conclusao { get; set; }
        public string PenultimaMovimentacao => Movimentacoes[1];
        public string UltimaMovimentacao => Movimentacoes[0];

        public IList<string> Movimentacoes { get; set; }
    }

    public class Conclusao
    {
        public Color GetColor
        {
            get
            {
                if (PercentagemConclusao <= 49) return Color.FromHex("fc314b");
                if (PercentagemConclusao >= 50 && PercentagemConclusao <= 65) return Color.FromHex("ffb53e");
                if (PercentagemConclusao >= 66 && PercentagemConclusao <= 90) return Color.FromHex("1ebfae");
                if (PercentagemConclusao >= 91 && PercentagemConclusao <= 100) return Color.FromHex("219154");

                return Color.Black;
            }
        }

        public int PercentagemConclusao { get; set; }
    }
}