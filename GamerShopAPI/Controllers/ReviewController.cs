using AutoMapper;
using GamerShopAPI.DTOs;
using GamerShopAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GamerShopAPI.Controllers
{
    [ApiController]
    [Route("/api/products/{productId:int}/reviews")]
    public class ReviewController : CustomController
    {
        private readonly ApplicationDbContext dbContext;

        public ReviewController(ApplicationDbContext dbContext,
            IMapper mapper) : base(dbContext, mapper)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ReviewDTO>>> Get([FromRoute] int productId,
            [FromQuery] PaginationDTO paginationDTO)
        {
            var productDB = await dbContext.Products.FindAsync(productId);

            if(productDB == null)
            {
                return NotFound("Product doesn't exist");
            }

            var queryable = dbContext.Reviews
                .Where(r => r.ProductId == productId)
                .AsQueryable();

            return await Get<Review, ReviewDTO>(paginationDTO, queryable);
        }
    }
}
