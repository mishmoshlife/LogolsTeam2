using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class ProductService
    {
        private ProductRepository _repository;

        public ProductService()
        {
            _repository = new ProductRepository();
        }

        public int Insert(Product product)
        {
            return _repository.Insert(product);
        }

        public void Delete(Product product)
        {
            _repository.Delete(product);
        }

        public void Update(Product product)
        {
            _repository.Update(product);
        }

        public Product Get(int productID)
        {
            return _repository.Get(productID);
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }




        
    }
}
