using GamerShopAPI.DTOs;

namespace GamerShopAPI.Utils
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ToPaginate<T>(this IQueryable<T> queryable,
            PaginationDTO paginationDTO)
        {
            return queryable
                .Skip((paginationDTO.Page - 1) * paginationDTO.PageSize)
                .Take(paginationDTO.PageSize);
        }
    }
}
