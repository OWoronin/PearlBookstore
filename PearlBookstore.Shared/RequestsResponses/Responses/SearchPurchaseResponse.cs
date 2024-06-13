using PearlBookstore.Shared.Dtos;

namespace PearlBookstore.Shared.RequestsResponses.Responses
{
    public class SearchPurchaseResponse
    {
        public List<ItemDto> Items { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}
