using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApp.Data;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    [ApiController]
    [Route("")]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly ProductDbContext _context;

        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> GetProduct()
        {
            if (_context.Product == null)
            {
                return NotFound();
            }
            return await _context.Product.ToListAsync();
        }
    }
}
