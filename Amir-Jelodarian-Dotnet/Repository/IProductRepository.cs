using System.Collections.Generic;
using Amir_Jelodarian_Dotnet.Models;

namespace Amir_Jelodarian_Dotnet.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
        Products GetProductById(int id);
        void AddProduct(Products product);
        void UpdateProduct(Products product);
        void DeleteProduct(int id);
    }
}