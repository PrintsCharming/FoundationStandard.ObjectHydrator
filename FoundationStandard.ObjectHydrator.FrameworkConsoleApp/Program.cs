using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationStandard.ObjectHydrator.FrameworkConsoleApp
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
