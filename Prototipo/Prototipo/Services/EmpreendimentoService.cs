using Prototipo.Models;
using Prototipo.Services.Mocks;
using System.Linq;
using System.Threading.Tasks;

namespace Prototipo.Services
{
    public class EmpreendimentoService
    {
        public async Task<Empreendimento> ObterPorIdAsync(int id)
        {
            var mock = new EmpreendimentoMock();
            var items = await mock.GetItemsAsync();

            return items.FirstOrDefault(f => f.Id == id);
        }
    }
}