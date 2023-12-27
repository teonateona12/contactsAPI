using contactsAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace contactsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;

        public ContactController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await dbContext.Contacts.ToListAsync());
        }
    }
}
