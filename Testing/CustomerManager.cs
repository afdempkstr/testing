using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class CustomerManager
    {
        private DatabaseManager _databaseManager = new DatabaseManager();

        public bool IsFromAthens(int cid)
        {
            var customer = _databaseManager.FindCustomerById(5);

            if (customer.City == "Αθήνα")
            {
                return true;
            }

            return false;
        }
    }
}
