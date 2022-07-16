using AutoMapper;
using GamerShopAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerShopAPI.Controllers
{
    [ApiController]
    [Route("/api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public CategoriesController(ApplicationDbContext dbContext,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDTO>>> Get()
        {
            var categoriesDB = await dbContext.Categories.Include(c => c.Subcategory).ToListAsync();

            return mapper.Map<List<CategoryDTO>>(categoriesDB);
        }
    }
}
