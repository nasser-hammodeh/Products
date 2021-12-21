using Market.Data;
using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
        public Product GetById(Guid Id);
        public void AddOrUpdate(ProductDto product);
        public void Delete(Guid Id);


    }
}
