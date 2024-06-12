using PearlBookstore.Shared.Dtos;

namespace PearlBookstore.WEB.Client.Services
{
    public class OrderItemsService
    {
        private readonly List<ItemDto> items;

        public OrderItemsService()
        {
            items = [];
        }

        public List<ItemDto> GetItemDtos()
        {
            return items;
        }

        public void Add(ItemDto item)
        {
            items.Add(item);
        }

        public void Remove(int ID, int typeId)
        {
            items.RemoveAll(x => x.Id == ID && x.TypeDto.Id == typeId);
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
