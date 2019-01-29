using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace Testing
{
    public class DatabaseManager : IDatabaseManager
    {
        private static string _connectionString = "Server=localhost;Database=bank;User Id=dbuser;Password=dbpass";

        public Customer FindCustomerById(int cid)
        {
            var dbcon = new SqlConnection(_connectionString);
            string query = "select * from customer where cid=@cid";
            using (dbcon)
            {
                dbcon.Open();
                return dbcon.Query<Customer>(query, new {cid = cid}).FirstOrDefault();
            }
        }


    }
}
