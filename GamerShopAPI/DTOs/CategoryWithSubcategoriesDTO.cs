namespace GamerShopAPI.DTOs
{
    public class CategoryWithSubcategoriesDTO : CategoryDTO
    {
        public List<SubcategoryDTO> Subcategories { get; set; }
    }
}
