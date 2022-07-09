﻿using System.ComponentModel.DataAnnotations;

namespace GamerShopAPI.Entities
{
    public class Subcategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
