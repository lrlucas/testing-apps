using System;

namespace API.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Email { get; set; }
        public long Credits { get; set; }
        public string Password { get; set; }
        public long TypeAccountId { get; set; }
    }
}