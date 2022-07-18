using GamerShopAPI.Entities;
using System.ComponentModel.DataAnnotations;
using static GamerShopAPI.Utils.EnumUtils;

namespace GamerShopAPI.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        public string ShippingName { get; set; }
        public string ShippingLastname { get; set; }
        public string ShippingStatus { get; set; }
        public string ShippingCost { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingZip { get; set; }
        public string ShippingComments { get; set; }
    }
}
