using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TypeAccountController : BaseApiController
    {
        private readonly DataContext _context;

        public TypeAccountController(DataContext context)
        {
            _context = context;
        }


        [HttpPost]
        public ActionResult Create([FromBody]TypeAccountDto typeAccountDto)
        {
            if (typeAccountDto.Name == null) return BadRequest();
            var typeAccount = new TypeAccount
            {
                Name = typeAccountDto.Name.ToLower()
            };
            _context.TypeAccounts.Add(typeAccount);
            _context.SaveChangesAsync();

            return Ok();
        }

    }
}