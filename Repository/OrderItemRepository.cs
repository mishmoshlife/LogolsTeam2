using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class OrderItemRepository : Repository
    {
        public int Insert(OrderItem order_item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.AddOrderItem", order_item, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(OrderItem order_item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteOrderItem", order_item, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(OrderItem order_item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateOrderItem", order_item, commandType: CommandType.StoredProcedure);
            }
        }

        public OrderItem Get(int orderItemID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<OrderItem>("Team2.GetOrderItem", new { order_item_id = orderItemID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<OrderItem> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<OrderItem>("Team2.GetAllOrderItemss", commandType: CommandType.StoredProcedure);
            }
        }
    }
}