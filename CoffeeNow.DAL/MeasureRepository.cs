using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class MeasureRepository : Repository
    {
        public int Insert(Measure measure)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.AddMeasure", measure, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(Measure measure)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteMeasure", measure, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Measure measure)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateMeasure", measure, commandType: CommandType.StoredProcedure);
            }
        }

        public Measure Get(int measureID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Measure>("Team2.GetMeasure", new { measure_id = measureID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Measure> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Measure>("Team2.GetAllMeasaures", commandType: CommandType.StoredProcedure);
            }
        }
    }
}