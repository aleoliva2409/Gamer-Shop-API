using AutoMapper;
using GamerShopAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerShopAPI.Controllers
{
    [ApiController]
    [Route("/api/products/{productId:int}/reviews")]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public ReviewsController(ApplicationDbContext dbContext,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ReviewDTO>>> Get([FromRoute] int productId)
        {
            var productDB = await dbContext.Products.FindAsync(productId);

            if(productDB == null)
            {
                return BadRequest();
            }

            var reviewsDB = await dbContext.Reviews
                .Where(r => r.ProductId == productId)
                .ToListAsync();

            return mapper.Map<List<ReviewDTO>>(reviewsDB);
        }
    }
}
