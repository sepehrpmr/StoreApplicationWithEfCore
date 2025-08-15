using System.Collections.Generic;
using System.Linq;
using StoreApplicationWithEfCore.Models.Contexts;

namespace StoreApplicationWithEfCore.Models.Services.GetProductList
{
    public interface IGetProductListService
    {
        List<ProductListDto> ExecuteGetProductList();
    }


    public class GetProductListService : IGetProductListService
    {
        private readonly Databasecontext context;
        public GetProductListService()
        {
            context = new Databasecontext();
        }
        public List<ProductListDto> ExecuteGetProductList()
        {
            var customers = context.Products.Select(p => new ProductListDto
            {
                Id = p.Id,
                Name = p.Name,
                Brand = p.Brand,
                Price = p.Price,
            }).ToList();
            return customers;
        }
    }

    public class ProductListDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }

    }
}
