namespace PearlBookstore.Shared.RequestsResponses.Responses
{
    public class PriceOfBucketReponse
    {
        public bool IsSuccess { get; set; }

        public decimal Price { get; set; }

        public string Message { get; set; }
    }
}
