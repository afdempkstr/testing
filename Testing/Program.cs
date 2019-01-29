using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 5));
            

            var customerManager = new CustomerManager();
            if (customerManager.IsFromAthens(5))
            {
                Console.WriteLine("Γκαγκαρος");
            }

            Console.Read();
        }

        static void PrintCustomer(Customer customer)
        {
            Console.WriteLine($"{customer.Cid}: {customer.FirstName} {customer.LastName}");
        }
    }
}
