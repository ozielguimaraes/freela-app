using Prototipo.Attributes;
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

        private EnumValueDataAttribute _escolaridade;
        public EnumValueDataAttribute Escolaridade
        {
            get { return _escolaridade; }
            set { SetProperty(ref _escolaridade, value); }
        }

        private EnumValueDataAttribute _genero;
        public EnumValueDataAttribute Genero
        {
            get { return _genero; }
            set { SetProperty(ref _genero, value); }
        }

        private EnumValueDataAttribute _estadoCivil;
        public EnumValueDataAttribute EstadoCivil
        {
            get { return _estadoCivil; }
            set { SetProperty(ref _estadoCivil, value); }
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

        private EnumValueDataAttribute _tipoDocumento;
        public EnumValueDataAttribute TipoDocumento
        {
            get { return _tipoDocumento; }
            set { SetProperty(ref _tipoDocumento, value); }
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

        string categoriaProfissional;
        public string CategoriaProfissional
        {
            get { return categoriaProfissional; }
            set { SetProperty(ref categoriaProfissional, value); }
        }

        int quantidadeDependentes;
        public int QuantidadeDependentes
        {
            get { return quantidadeDependentes; }
            set { SetProperty(ref quantidadeDependentes, value); }
        }
    }
}