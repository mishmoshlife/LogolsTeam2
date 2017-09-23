using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class ProductIngredientRepository : Repository
    {
        public int Insert(ProductIngredient product_ingredient)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.AddProductIngredient", product_ingredient, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(ProductIngredient product_ingredient)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteProductIngredient", product_ingredient, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(ProductIngredient product_ingredient)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateProductIngredient", product_ingredient, commandType: CommandType.StoredProcedure);
            }
        }

        public ProductIngredient Get(int productIngredientID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<ProductIngredient>("Team2.GetProductIngredient", new { product_ingredient_id = productIngredientID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<ProductIngredient> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<ProductIngredient>("Team2.GetProductIngredients", commandType: CommandType.StoredProcedure);
            }
        }
    }
}