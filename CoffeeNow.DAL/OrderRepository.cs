using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class OrderRepository : Repository
    {
        public int Insert(Order order)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.AddOrder", order, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(Order order)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteOrder", order, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Order order)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateOrder", order, commandType: CommandType.StoredProcedure);
            }
        }

        public Order Get(int orderID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Order>("Team2.GetOrder", new { order_id = orderID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Order> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Order>("Team2.GetAllOrders", commandType: CommandType.StoredProcedure);
            }
        }
    }
}