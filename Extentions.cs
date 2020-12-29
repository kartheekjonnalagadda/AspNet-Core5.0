using Catalog.Entities;
using Catalog.Dtos;

namespace Catalog
{
    public static class Extentions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id=item.Id,
                Name=item.Name,
                CreatedDate=item.CreatedDate,
                Price=item.Price
            };
        }
    }

}