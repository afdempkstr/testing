using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class DatabaseManager
    {
        private static string _connectionString = "Server=localhost;Database=bank;Trusted_Connection=True;";

        public Customer FindCustomerById(int cid)
        {
            //TODO: using dapper, select the customer with the given id and return it
            return null;
        }


    }
}
