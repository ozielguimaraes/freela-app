using Prototipo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Prototipo.Services.Mocks
{
    [Preserve(AllMembers = true)]
    public class EmpreendimentoMock : IDataStore<Empreendimento>
    {
        List<Empreendimento> items;

        public EmpreendimentoMock()
        {
            items = new List<Empreendimento>
            {
                new Empreendimento
                {
                    Id = 1,
                    Nome = "Perdizes",
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                    Torres = new List<Torre>
                    {
                        new Torre{
                        Id=1,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        }
                    }
                },
                new Empreendimento
                {
                    Id = 2,
                    Nome = "Skyline",
                    Imagem = "https://img.olx.com.br/thumbs256x256/10/101914009663215.jpg",
                    Torres = new List<Torre>
                    {
                        new Torre{
                        Id=1,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        }
                    }
                },
                new Empreendimento
                {
                    Id = 3,
                    Nome = "Morata",
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg"
                },
                new Empreendimento
                {
                    Id = 4,
                    Nome = "Milenium",
                    Imagem = "https://abrilexame.files.wordpress.com/2018/08/cubo02.jpg"
                },
                new Empreendimento
                {
                    Id = 5,
                    Nome = "Angélica",
                    Imagem = "https://abrilexame.files.wordpress.com/2018/08/cubo02.jpg"
                },
                new Empreendimento
                {
                    Id = 6,
                    Nome = "América",
                    Imagem = "http://www.grupopugen.com.br/assets/images/icon-empreendimento.png"
                },
                new Empreendimento
                {
                    Id = 7,
                    Nome = "Furgões",
                    Imagem = "https://img.olx.com.br/thumbs256x256/65/656822030387045.jpg",
                    Torres = new List<Torre>
                    {
                        new Torre{
                        Id=1,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        },
                        new Torre{
                        Id=2,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        }
                    }
                },
                new Empreendimento
                {
                    Id = 8,
                    Nome = "Barganha",
                    Imagem = "https://img.olx.com.br/thumbs256x256/10/101914009663215.jpg"
                },
                new Empreendimento
                {
                    Id = 9,
                    Nome = "Canadá",
                    Imagem = "https://lh3.googleusercontent.com/-P9pxzZFJhKI/WH88qhMu_oI/AAAAAAAABJw/YLiocAtuqYkwjbjhabv36VdfESqwiFGjACLIB/w128-h128-n-k-no-v1/",                   Torres = new List<Torre>
                    {
                        new Torre{
                        Id=9,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        },
                        new Torre{
                        Id=4,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        }
                    }
                },
                new Empreendimento
                {
                    Id = 10,
                    Nome = "Pedroso",
                    Imagem = "http://anagro.com.br/wp-content/uploads/2017/09/diurno-7-min-256x256.jpg",
                    Torres = new List<Torre>
                    {
                        new Torre{
                        Id=1,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        },
                        new Torre{
                        Id=2,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        }
                    }
                },
                new Empreendimento
                {
                    Id = 11,
                    Nome = "Arranha-céu",
                    Imagem = "http://anagro.com.br/wp-content/uploads/2017/09/diurno-7-min-256x256.jpg",
                    Torres = new List<Torre>
                    {
                        new Torre{
                        Id=10,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        },
                        new Torre{
                        Id=2,
                    Imagem = "https://img.olx.com.br/thumbs256x256/24/245819099634883.jpg",
                        Nome="Recanto Ararucaia"
                        }
                    }
                }
            };
        }

        public async Task<bool> AddItemAsync(Empreendimento item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Empreendimento> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault());
        }

        public async Task<IEnumerable<Empreendimento>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<bool> UpdateItemAsync(Empreendimento item)
        {
            var oldItem = items.FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }
    }
}