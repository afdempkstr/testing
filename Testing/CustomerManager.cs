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
            var customer = _databaseManager.FindCustomerById(cid);

            if (customer.City == "Αθήνα")
            {
                return true;
            }

            return false;
        }
    }
}
