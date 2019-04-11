using Prototipo.ViewModels;
using System;

namespace Prototipo.Models
{
    public class CompradorVm : BasePageModel
    {
        string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { SetProperty(ref cpf, value); }
        }

        string nomeCompleto;
        public string NomeCompleto
        {
            get { return nomeCompleto; }
            set { SetProperty(ref nomeCompleto, value); }
        }

        DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { SetProperty(ref dataNascimento, value); }
        }

        string nacionalidade;
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { SetProperty(ref nacionalidade, value); }
        }

        string naturalidade;
        public string Naturalidade
        {
            get { return naturalidade; }
            set { SetProperty(ref naturalidade, value); }
        }

        decimal valorFgts;
        public decimal ValorFgts
        {
            get { return valorFgts; }
            set { SetProperty(ref valorFgts, value); }
        }

        string nomePai;
        public string NomePai
        {
            get { return nomePai; }
            set { SetProperty(ref nomePai, value); }
        }

        string nomeMae;
        public string NomeMae
        {
            get { return nomeMae; }
            set { SetProperty(ref nomeMae, value); }
        }

        string numeroDocumento;
        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { SetProperty(ref numeroDocumento, value); }
        }

        string orgaoExpedidor;
        public string OrgaoExpedidor
        {
            get { return orgaoExpedidor; }
            set { SetProperty(ref orgaoExpedidor, value); }
        }

        string dataEmissao;
        public string DataEmissao
        {
            get { return dataEmissao; }
            set { SetProperty(ref dataEmissao, value); }
        }

        int quantidadeDependentes;
        public int QuantidadeDependentes
        {
            get { return quantidadeDependentes; }
            set { SetProperty(ref quantidadeDependentes, value); }
        }
    }
}