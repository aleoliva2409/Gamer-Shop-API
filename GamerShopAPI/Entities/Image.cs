using GamerShopAPI.Utils;

namespace GamerShopAPI.Entities
{
    public class Image : IId
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
