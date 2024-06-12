﻿using PearlBookstore.Shared.Dtos;

namespace PearlBookstore.WEB.Client.Services
{
    public class ReturnItemsService
    {
        private readonly List<ItemDto> items;

        public ReturnItemsService()
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

        public void Remove(int ID)
        {
            items.RemoveAll(x => x.Id == ID);
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