using Prototipo.Attributes;

namespace Prototipo.Models
{
    public enum EstadoCivil
    {
        [EnumValueData(1, "Solteiro(a)")]
        Solteiro,
        [EnumValueData(2, "Casado(a)")]
        Casado,
        [EnumValueData(3, "Separado(a)")]
        Separado,
        [EnumValueData(4, "Divorciado(a)")]
        Divorciado,
        [EnumValueData(5, "Viúvo(a)")]
        Viuvo
    }

    public enum TipoDocumento
    {
        [EnumValueData(1, "RG")]
        Rg,
        [EnumValueData(2, "CPF")]
        Cpf,
        [EnumValueData(2, "CNH")]
        Cnh
    }

    public enum Escolaridade
    {
        [EnumValueData(1, "Fundamental incompleto")]
        FundamentalIncompleto,
        [EnumValueData(2, "Fundamental completo")]
        FundamentalCompleto,
        [EnumValueData(3, "Superior incompleto")]
        SuperiorIncompleto,
        [EnumValueData(4, "Superior completo")]
        Superiorcompleto,
        [EnumValueData(5, "Pós graduação")]
        PosGraduacao
    }

    public enum Genero
    {
        [EnumValueData(1, "Masculino")]
        Masculino,
        [EnumValueData(2, "Feminino")]
        Feminino,
        [EnumValueData(3, "Outro")]
        Outro
    }
}