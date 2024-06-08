using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlBookstore.Shared.RequestsResponses
{
	public class ChangeOrderStatusRequest
	{
		public int OrderId { get; set; }
		public int OrderStatus { get; set; } 

	}
}
