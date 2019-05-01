using Prototipo.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Prototipo.Services.Mocks
{
    [Preserve(AllMembers = true)]
    public class PropostaMock : IDataStore<PropostaVm>
    {
        List<PropostaVm> items;

        public PropostaMock()
        {
            items = new List<PropostaVm>
            {
                new PropostaVm
                {
                    Numero = 98898,
                    Cliente = "Oziel Guimarães de Paula",
                    Empreendimento = "Jd America",
                    Torre = "Norte",
                    Unidade = "833",
                    Conclusao = new Conclusao{
                     PercentagemConclusao = 84
                    },
                    Movimentacoes = new List<string>{
                        "Montar Pasta - Análise de Documentos",
                        "Montar Pasta - Entrar em Contato"
                    }
                },
                new PropostaVm
                {
                    Numero = 123456,
                    Cliente = "João Felipe Júnior",
                    Empreendimento = "Itaim Bibi",
                    Torre = "Centro",
                    Unidade = "658",
                    Conclusao = new Conclusao{
                     PercentagemConclusao = 38
                    },
                    Movimentacoes = new List<string>{
                        "Montar Pasta - Análise de Documentos",
                        "Montar Pasta - Entrar em Contato"
                    }
                },
                new PropostaVm
                {
                    Numero = 123456,
                    Cliente = "João Felipe Júnior",
                    Empreendimento = "Itaim Bibi",
                    Torre = "Centro",
                    Unidade = "658",
                    Conclusao = new Conclusao{
                     PercentagemConclusao = 82
                    },
                    Movimentacoes = new List<string>{
                        "Montar Pasta - Análise de Documentos",
                        "Montar Pasta - Entrar em Contato"
                    }
                },
                new PropostaVm
                {
                    Numero = 937163,
                    Cliente = "Mário de Souza Costa",
                    Empreendimento = "Itaim Bibi",
                    Torre = "Centro",
                    Unidade = "658",
                    Conclusao = new Conclusao{
                     PercentagemConclusao = 50
                    },
                    Movimentacoes = new List<string>{
                        "Montar Pasta - Análise de Documentos",
                        "Montar Pasta - Entrar em Contato"
                    }
                },
                new PropostaVm
                {
                    Numero = 123456,
                    Cliente = "João Felipe Júnior",
                    Empreendimento = "Itaim Bibi",
                    Torre = "Centro",
                    Unidade = "658",
                    Conclusao = new Conclusao{
                     PercentagemConclusao = 38
                    },
                    Movimentacoes = new List<string>{
                        "Montar Pasta - Análise de Documentos",
                        "Montar Pasta - Entrar em Contato"
                    }
                }
            };
        }

        public async Task<bool> AddItemAsync(PropostaVm item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(PropostaVm item)
        {
            var oldItem = items.FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<PropostaVm> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault());
        }

        public async Task<IEnumerable<PropostaVm>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}