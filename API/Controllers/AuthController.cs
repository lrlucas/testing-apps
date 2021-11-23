using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AuthController: BaseApiController
    {
        private readonly DataContext _context;

        public AuthController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(AccountRegister accountRegister)
        {
            using var hmac = new HMACSHA512();
            var user = new User
            {
                Email = accountRegister.Email,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(accountRegister.Password)),
                PasswordSalt = hmac.Key,
                TypeAccountId = 1
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }


    }
}