using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Testing.UnitTests
{
    class MonkeyDatabaseManager : IDatabaseManager
    {
        public Customer FindCustomerById(int cid)
        {
            if(cid == 5)
                throw new DBConcurrencyException("error");

            if (cid == 10)
            {
                return new Customer()
                {
                    Cid = 10,
                    FirstName = "a",
                    LastName = "b",
                    City = "Αθήνα"
                };
            }

            return null;
        }
    }
}
