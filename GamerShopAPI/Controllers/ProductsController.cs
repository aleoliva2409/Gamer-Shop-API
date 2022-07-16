using AutoMapper;
using GamerShopAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerShopAPI.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public ProductsController(ApplicationDbContext dbContext,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> Get()
        {
            var productsDB = await dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Subcategory)
                .ToListAsync();

            return mapper.Map<List<ProductDTO>>(productsDB);
        }
    }
}
