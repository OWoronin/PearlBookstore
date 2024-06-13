namespace PearlBookstore.Shared.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int YearPublication { get; set; }
        public int Counter { get; set; }

        public int ActionCounter { get; set; }

        public int ReturnCounter { get; set; }

        public AuthorDto AuthorDto { get; set; }

        public List<GenreDto> GenresDtos { get; set; }

        public TypeDto TypeDto { get; set; }
    }
}
