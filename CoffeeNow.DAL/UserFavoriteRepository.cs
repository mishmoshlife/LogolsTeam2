using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class UserFavoriteRepository : Repository
    {
        public int Insert(UserFavorite user_favorite)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.AddUserFavorite", user_favorite, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(UserFavorite user_favorite)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteOrderUserFavorite", user_favorite, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(UserFavorite user_favorite)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateUserFavorite", user_favorite, commandType: CommandType.StoredProcedure);
            }
        }

        public UserFavorite Get(int userID, int productID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<UserFavorite>("Team2.GetUserFavorite", new { user_id = userID, productID = product_id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<UserFavorite> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<UserFavorite>("Team2.GetAllUserFavorites", commandType: CommandType.StoredProcedure);
            }
        }
    }
}