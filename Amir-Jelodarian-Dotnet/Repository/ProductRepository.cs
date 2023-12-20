using System.Collections.Generic;
using Amir_Jelodarian_Dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace Amir_Jelodarian_Dotnet.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContext _dbContext;

        public ProductRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _dbContext.Set<Products>().ToList();
        }

        public Products GetProductById(int id)
        {
            return _dbContext.Set<Products>().Find(id);
        }

        public void AddProduct(Products product)
        {
            _dbContext.Set<Products>().Add(product);
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Products product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _dbContext.Set<Products>().Find(id);
            if (product != null)
            {
                _dbContext.Set<Products>().Remove(product);
                _dbContext.SaveChanges();
            }
        }
    }
}