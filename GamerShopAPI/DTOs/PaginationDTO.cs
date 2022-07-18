namespace GamerShopAPI.DTOs
{
    public class PaginationDTO
    {

        private int pageSize = 10;
        private readonly int maxPageSize = 50;

        public int Page { get; set; } = 1;
        public int PageSize
        {
            get => pageSize;
            set
            {
                pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
