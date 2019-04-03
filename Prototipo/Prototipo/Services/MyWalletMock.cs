using Prototipo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototipo.Services
{
    public class MyWalletMock : IDataStore<MyWallet>
    {
        List<MyWallet> items;

        public MyWalletMock()
        {
            items = new List<MyWallet>
            {
                new MyWallet
                {
                    AmountProposal = 110,
                    AmountProposalAproved = 40,
                    AmountProposalReproved = 10,
                    AmountProposalPeding = 40,
                    AmountProposalInRevision = 6,
                    TotalProposal=7009.88m,
                    TotalProposalAproved=4990.20m,
                    Balance=700,
                    EndDate=DateTime.Now.AddDays(2),
                    StartDate=DateTime.Now,
                    StartValue=700m,
                    EndValue=750m
                }
            };
        }

        public async Task<bool> AddItemAsync(MyWallet item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(MyWallet item)
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

        public async Task<MyWallet> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault());
        }

        public async Task<IEnumerable<MyWallet>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}