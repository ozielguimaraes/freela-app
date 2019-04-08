using Prototipo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Prototipo.Services.Mocks
{
    [Preserve(AllMembers = true)]
    public class PropostaMock : IDataStore<Proposta>
    {
        List<Proposta> items;

        public PropostaMock()
        {
            items = new List<Proposta>
            {
                new Proposta
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
                new Proposta
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
                new Proposta
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
                new Proposta
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
                new Proposta
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

        public async Task<bool> AddItemAsync(Proposta item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Proposta item)
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

        public async Task<Proposta> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault());
        }

        public async Task<IEnumerable<Proposta>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}