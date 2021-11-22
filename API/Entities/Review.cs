using System;

namespace API.Entities
{
    public class Review
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long ReviewsAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public long ApproximateAmount { get; set; }
        public long ProjectType { get; set; }
        public long UserId { get; set; }
        public long TypeReviewRequired { get; set; }
        public long ReviewReceived { get; set; }
    }
}