namespace PearlBookstore.Shared.RequestsResponses.Responses
{
    public class AcceptBuyResponse
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public DateOnly Date { get; set; }

        public decimal Price { get; set; }

        public string Evidence { get; set; }
    }
}
