using System;
using System.Collections.Generic;

namespace Bangazon_Method
{
    class Program
    {
        public static List<Employee> Employees { get; private set; } = new List<Employee>();

        static void Main(string[] args)
        {

            Employee kate = new Employee("Kate", "Middleton");
            Employee meghan = new Employee("Meghan", "Markle");
            Employee harry = new Employee("Harry", "Whales");
            Employee william = new Employee("William", "Whales");

            Employees.Add(kate);
            Employees.Add(meghan);
            Employees.Add(harry);
            Employees.Add(william);
            
            // Method Overload #1
            kate.Eat();

            // Method Overload #2
            kate.Eat("Cheeseburger");

            // Method Overload #3
            kate.Eat(Employees);

            // Method Overload #4
            kate.Eat("Pizza", Employees);

            Console.ReadLine();
        }
    }
}
