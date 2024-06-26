﻿using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class OrderStatus
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Order> Orders { get; } = new List<Order>();

	}
}
