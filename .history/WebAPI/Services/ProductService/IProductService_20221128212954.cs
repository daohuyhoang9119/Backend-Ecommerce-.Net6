using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.ProductService
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetSingleProductById(int id);
        List<Product> AddProduct(Product newProduct);
    }
}