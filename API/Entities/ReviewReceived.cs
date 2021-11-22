namespace API.Entities
{
    public class ReviewReceived
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ReviewId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}