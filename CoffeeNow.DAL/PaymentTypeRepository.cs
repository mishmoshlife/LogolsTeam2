using System.Collections.Generic;
using System.Data;
using System.Linq;
using CoffeeNow.Entities;
using Dapper;

namespace CoffeeNow.DAL
{
    public class PaymentTypeRepository : Repository
    {
        public int Insert(PaymentType payment_type)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Team2.AddPaymentType", payment_type, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(PaymentType payment_type)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeletePaymentType", payment_type, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(PaymentType payment_type)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdatePaymentType", payment_type, commandType: CommandType.StoredProcedure);
            }
        }

        public PaymentType Get(int paymentTypeID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<PaymentType>("Team2.GetPaymentType", new { payment_type_id = paymentTypeID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<PaymentType> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<PaymentType>("Team2.GetAllPaymentTypes", commandType: CommandType.StoredProcedure);
            }
        }
    }
}