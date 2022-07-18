using AutoMapper;
using GamerShopAPI.DTOs;
using GamerShopAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerShopAPI.Controllers
{
    public class CustomController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public CustomController(ApplicationDbContext dbContext,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        protected async Task<List<TDTO>> Get<TEntity, TDTO>() where TEntity : class
        {
            var entities = await dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
            var dtos = mapper.Map<List<TDTO>>(entities);

            return dtos;
        }

        protected async Task<List<TDTO>> Get<TEntity, TDTO>
            (PaginationDTO paginationDTO) where TEntity : class
        {
            var queryable = dbContext.Set<TEntity>().AsQueryable();
            return await Get<TEntity, TDTO>(paginationDTO, queryable);
        }

        protected async Task<List<TDTO>> Get<TEntity, TDTO>
            (PaginationDTO paginationDTO, IQueryable<TEntity> queryable)
            where TEntity : class
        {
            await HttpContext.InsertPaginationParameters(queryable, paginationDTO.PageSize);
            var entities = await queryable.ToPaginate(paginationDTO).ToListAsync();

            return mapper.Map<List<TDTO>>(entities);
        }

        protected async Task<ActionResult<TDTO>> Get<TEntity, TDTO>
            (int id) where TEntity : class, IId
        {
            var entity = await dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                return NotFound();
            }

            return mapper.Map<TDTO>(entity);
        }
    }
}
