using System.Data;
using System.Data.Common;

namespace Testing
{
    public class CustomerManager
    {
        private IDatabaseManager _databaseManager;

        public CustomerManager(IDatabaseManager manager)
        {
            _databaseManager = manager;
        }

        public bool IsFromAthens(int cid)
        {
            Customer customer = null;
            try
            {
                customer = _databaseManager.FindCustomerById(cid);
            }
            catch (DBConcurrencyException)
            {
            }

            if (customer?.City == "Αθήνα")
            {
                return true;
            }

            return false;
        }
    }
}
