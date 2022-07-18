using AutoMapper;
using GamerShopAPI.DTOs;
using GamerShopAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GamerShopAPI.Controllers
{
    [ApiController]
    [Route("/api/orders")]
    public class OrderController : CustomController
    {
        private readonly ApplicationDbContext dbContext;

        public OrderController(ApplicationDbContext dbContext,
            IMapper mapper) : base(dbContext, mapper)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<List<OrderDTO>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = dbContext.Orders
                .AsQueryable();

            return await Get<Order, OrderDTO>(paginationDTO, queryable);
        }
    }
}
