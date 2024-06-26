﻿using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class ItemType
    {
        [Key]

        public int Id { get; set; } //useless, needed in library 

        public int TypeId { get; set; }

        public int ItemId { get; set; }
        public Type Type { get; set; } = null!;
        public Item Item { get; set; } = null!;

        public decimal Price { get; set; }

        public int Counter { get; set; }
    }
}
