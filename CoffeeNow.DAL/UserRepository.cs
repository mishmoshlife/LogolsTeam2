using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class UserRepository : Repository
    {
        public int Insert(User user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.AddUser", user, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(User user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteUser", user, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(User user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateUser", user, commandType: CommandType.StoredProcedure);
            }
        }

        public User Get(int userID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<User>("Team2.GetUser", new { user_id = userID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<User>("Team2.GetAllUsers", commandType: CommandType.StoredProcedure);
            }
        }
    }
}