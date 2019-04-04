using Prototipo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototipo.Services
{
    public class CarteiraMock : IDataStore<Carteira>
    {
        List<Carteira> items;

        public CarteiraMock()

        {
            items = new List<Carteira>
            {
                new Carteira
                {
                    AmountInits = 110,
                    AmountProposal = 1,
                    AmountProposalAproved = 40,
                    AmountProposalReproved = 10,
                    AmountProposalPeding = 40,
                    AmountProposalInRevision = 6,
                    TotalProposal = 7009.88m,
                    TotalBocked = 700m,
                    TotalProposalAproved = 4990.20m,
                    Balance = 700,
                    EndDate = DateTime.Now.AddDays(2),
                    StartDate = DateTime.Now,
                    StartValue = 700m,
                    EndValue = 750m
                }
            };
        }

        public async Task<bool> AddItemAsync(Carteira item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Carteira item)
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

        public async Task<Carteira> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault());
        }

        public async Task<IEnumerable<Carteira>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}