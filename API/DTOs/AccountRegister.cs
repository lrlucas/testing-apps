namespace API.DTOs
{
    public class AccountRegister
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public long TypeAccountId { get; set; }
    }
}