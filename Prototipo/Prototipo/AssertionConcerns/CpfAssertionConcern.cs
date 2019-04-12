namespace Prototipo.AssertionConcerns
{
    public class CpfAssertionConcern
    {
        public static bool IsValid(long cpf)
        {
            var cpfString = cpf.ToString().PadLeft(11, '0');
            return IsValid(cpfString);
        }

        public static bool IsValid(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf)) return false;

            var valor = cpf.Replace(".", "").Replace("-", "");

            if (valor.Length < 11) valor = valor.PadLeft(11, '0');
            if (valor.Length > 11) return false;

            var igual = true;
            for (var i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0]) igual = false;

            if (igual || valor == "12345678909") return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++) numeros[i] = int.Parse(valor[i].ToString());

            var soma = 0;
            for (var i = 0; i < 9; i++) soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0) return false;
            }
            else if (numeros[9] != 11 - resultado) return false;

            soma = 0;
            for (var i = 0; i < 10; i++) soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0) return false;
            }
            else if (numeros[10] != 11 - resultado) return false;

            return true;
        }
    }
}