using PearlBookstore.Shared.Dtos;

namespace PearlBookstore.WEB.Client.Services
{
    public class BuyItemsService
    {
        private readonly List<ItemDto> items;

        public BuyItemsService()
        {
            items = [];
        }

        public void Add(ItemDto item)
        {
            items.Add(item);
        }

        public void Remove(ItemDto item)
        {
            items.Remove(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public void Accept()
        {
            Clear();
        }
    }
}
