using System;

namespace Prototipo.ViewModels
{
    public class PreChaveVm : ObservableObject
    {
        int quantidadeParcelas;
        public int QuantidadeParcelas
        {
            get { return quantidadeParcelas; }
            set { SetProperty(ref quantidadeParcelas, value); }
        }

        decimal valor;
        public decimal Valor
        {
            get { return valor; }
            set { SetProperty(ref valor, value); }
        }

        DateTime primeiroVencimento;
        public DateTime PrimeiroVencimento
        {
            get { return primeiroVencimento; }
            set { SetProperty(ref primeiroVencimento, value); }
        }

        DateTime ultimoVencimento;
        public DateTime UltimoVencimento
        {
            get { return ultimoVencimento = CalcularUltimoVencimento(); }
            private set { SetProperty(ref ultimoVencimento, value); }
        }

        private DateTime CalcularUltimoVencimento()
        {
            return PrimeiroVencimento.AddMonths(QuantidadeParcelas);
        }
    }
}