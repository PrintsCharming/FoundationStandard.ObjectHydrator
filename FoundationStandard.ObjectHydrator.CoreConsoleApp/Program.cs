using System;

namespace FoundationStandard.ObjectHydrator.CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hydrator = new Hydrator<Customer>();
            var customers = hydrator.GetList(5);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }
}
