using Prototipo.Models;

namespace Prototipo.ViewModels
{
    public class ItemDetailVm : BaseVm
    {
        public Item Item { get; set; }
        public ItemDetailVm(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}