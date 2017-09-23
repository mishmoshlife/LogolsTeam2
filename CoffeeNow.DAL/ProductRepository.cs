using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class ProductRepository : Repository
    {
        /*                 Product is data type  answer is variable  */   
        public int Insert(Product product)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.InsertProduct", product, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(Product product)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteProduct", product, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Product product)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateProduct", product, commandType: CommandType.StoredProcedure);
            }
        }

        public Product Get(int productID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Product>("Team2.GetProduct", new { product_id = productID}, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Product>("Team2.GetAllProducts", commandType: CommandType.StoredProcedure);
            }
        }
    }
}