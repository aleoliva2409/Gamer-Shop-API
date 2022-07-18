using AutoMapper;
using GamerShopAPI.DTOs;
using GamerShopAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerShopAPI.Controllers
{
    [ApiController]
    [Route("/api/categories")]
    public class CategoryController : CustomController
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryController(ApplicationDbContext dbContext,
            IMapper mapper) : base(dbContext, mapper)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryWithSubcategoriesDTO>>> Get
            ([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = dbContext.Categories.Include(c => c.Subcategory).AsQueryable();
            return await Get<Category, CategoryWithSubcategoriesDTO>(paginationDTO, queryable);
        }
    }
}
