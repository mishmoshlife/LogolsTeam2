using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class IngredientService
    {
        private IngredientRepository _repository;

        public IngredientService()
        {
            _repository = new IngredientRepository();
        }

        public int Insert(Ingredient ingredient)
        {
            return _repository.Insert(ingredient);
        }

        public void Delete(Ingredient ingredient)
        {
            _repository.Delete(ingredient);
        }

        public void Update(Ingredient ingredient)
        {
            _repository.Update(ingredient);
        }

        public Ingredient Get(int ingredientID)
        {
            return _repository.Get(ingredientID);
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
