using AutoMapper;
using GamerShopAPI.DTOs;
using GamerShopAPI.Entities;

namespace GamerShopAPI.Utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<Category, CategoryWithSubcategoriesDTO>()
                .ForMember(c => c.Subcategories, opt => opt.MapFrom(MapSubcategories));

            CreateMap<Subcategory, SubcategoryDTO>();

            CreateMap<Review, ReviewDTO>();

            CreateMap<Product, ProductDTO>();
        }

        private List<SubcategoryDTO> MapSubcategories(Category category, CategoryDTO categoryDTO)
        {
            var result = new List<SubcategoryDTO>();

            if (category.Subcategory == null)
            {
                return result;
            }

            foreach (var subcategory in category.Subcategory)
            {
                result.Add(new SubcategoryDTO
                {
                    Id = subcategory.Id,
                    Name = subcategory.Name
                });
            }

            return result;
        }
    }
}
