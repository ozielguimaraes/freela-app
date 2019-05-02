namespace Prototipo.ViewModels
{
    public class AbaPropostaVm : ObservableObject
    {
        private string empreendimento;
        public string Empreendimento
        {
            get { return empreendimento; }
            set { SetProperty(ref empreendimento, value); }
        }

        private string torre;
        public string Torre
        {
            get { return torre; }
            set { SetProperty(ref torre, value); }
        }

        private string unidade;
        public string Unidade
        {
            get { return unidade; }
            set { SetProperty(ref unidade, value); }
        }

        private decimal valorVenda;
        public decimal ValorVenda
        {
            get { return valorVenda; }
            set { SetProperty(ref valorVenda, value); }
        }
    }
}