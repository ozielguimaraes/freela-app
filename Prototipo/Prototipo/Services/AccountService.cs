using System.Threading.Tasks;

namespace Prototipo.Services
{
    public class AccountService
    {
        public async Task<bool> AutenticarAsync(string login, string senha)
        {
            await Task.Delay(1);
            var acessoValido = ValidarAcesso(login, senha);

            if (!acessoValido) return false;

            //TODO Fazer consulta no webservice....

            return acessoValido;
        }

        private bool ValidarAcesso(string login, string senha)
        {
            //TODO Adicionar validações
            return true;
        }
    }
}