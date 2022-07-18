using Microsoft.EntityFrameworkCore;

namespace GamerShopAPI.Utils
{
    public static class HttpContextExtensions
    {
        public async static Task InsertPaginationParameters<T>(this HttpContext httpContext,
            IQueryable<T> queryable, int pageSize)
        {
            double totalCount = await queryable.CountAsync();
            double pages = Math.Ceiling(totalCount / pageSize);
            httpContext.Response.Headers.Add("totalPages", pages.ToString());
        }
    }
}
