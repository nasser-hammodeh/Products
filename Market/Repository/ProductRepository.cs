using Market.Data;
using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddOrUpdate(ProductDto product)
        {
            try
            {
                var _product = new Product()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price
                };
                _context.Products.Add(_product);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void Delete(Guid Id)
        {
            try
            {
                var _product = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
                if(_product != null)
                {
                    _context.Remove(_product);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public Product GetById(Guid Id)
        {
            try
            {
                var _product = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
                if(_product != null)
                {
                    return _product;
                }
                else
                {
                    return new Product();
                }
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
