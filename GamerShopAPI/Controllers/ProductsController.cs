using AutoMapper;
using GamerShopAPI.DTOs;
using GamerShopAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerShopAPI.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductsController : CustomController
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public ProductsController(ApplicationDbContext dbContext,
            IMapper mapper) : base(dbContext, mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Subcategory)
                .AsQueryable();

            return await Get<Product, ProductDTO>(paginationDTO, queryable);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDTO>> Get(int id)
        {
            var productDB = await dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Subcategory)
                .FirstOrDefaultAsync(p => p.Id == id);

            if(productDB == null)
            {
                NotFound("Product doesn't exist");
            }

            return mapper.Map<ProductDTO>(productDB);
        }
    }
}
