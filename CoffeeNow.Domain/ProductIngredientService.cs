using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class ProductIngredientService
    {
        private ProductIngredientRepository _repository;

        public ProductIngredientService()
        {
            _repository = new ProductIngredientRepository();
        }

        public int Insert(ProductIngredient productIngredient)
        {
            return _repository.Insert(productIngredient);
        }

        public void Delete(ProductIngredient productIngredient)
        {
            _repository.Delete(productIngredient);
        }

        public void Update(ProductIngredient productIngredient)
        {
            _repository.Update(productIngredient);
        }

        public ProductIngredient Get(int productIngredientID)
        {
            return _repository.Get(productIngredientID);
        }

        public IEnumerable<ProductIngredient> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
