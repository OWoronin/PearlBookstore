using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlBookstore.Shared.RequestsResponses.Requests
{
    public class ModifyPriceOfItemInBucketRequest
    {
        public int ItemId { get; set; }
        public decimal Price { get; set; }
    }
}
