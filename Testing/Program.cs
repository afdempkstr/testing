using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 5));
            

            var customerManager = new CustomerManager(new DatabaseManager());
            if (customerManager.IsFromAthens(5))
            {
                Console.WriteLine("Γκαγκαρος");
            }
            else
            {
                Console.Write("!Γκαγκαρος");
            }

            Console.Read();
        }

        static void PrintCustomer(Customer customer)
        {
            Console.WriteLine($"{customer.Cid}: {customer.FirstName} {customer.LastName}");
        }
    }
}
