using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;
using System;

namespace CoffeeNow.DAL
{
    public class IngredientRepository : Repository
    {
        public int Insert(Ingredient ingredient)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                 var t = dbConnection.Query<InsertID>("Team2.AddIngredient", ingredient, commandType: CommandType.StoredProcedure).First().ID;
                Console.Write(t);
                return t;
            }
        }

        public void Delete(Ingredient ingredient)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteIngredient", ingredient, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Ingredient ingredient)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateIngredient", ingredient, commandType: CommandType.StoredProcedure);
            }
        }

        public Ingredient Get(int ingredientID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Ingredient>("Team2.GetIngredient", new { ingredient_id = ingredientID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Ingredient> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Ingredient>("Team2.GetAllIngredients", commandType: CommandType.StoredProcedure);
            }
        }
    }
}