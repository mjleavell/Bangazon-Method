using System;
using System.Collections.Generic;
using System.Text;

namespace Bangazon_Method
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> _restaurants = new List<string>
        {
            "Burger Up",
            "Kayne Prime",
            "City House",
            "Frothy Monkey",
            "Etch"
        };

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // eat() Will select a random restaurant name from a list of strings, 
        //print to console that the employee is at that restaurant, 
        //and also return the restaurant.
        public string RandomRestaurant()
        {
            var rnd = new Random();
            int randomNum = rnd.Next(_restaurants.Count);
            return _restaurants[randomNum];
        }

        public void Eat()
        {
            var restaurant = RandomRestaurant();
            Console.WriteLine($"I'm eating at {restaurant}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I ate {food} at the office and it was really tasty.");
        }

        //eat(List<Employee> companions) - Will select a random restaurant name 
        //from a list of strings, print to console that the employee is at that restaurant, 
        //and also output the first name of each employee in the specified list.
        public void Eat(List<Employee> companions)
        {
            Eat();
            foreach (var employee in companions)
            {
                Console.WriteLine($"with {employee.FirstName}");
            }
        }

        //eat(string food, List<Employee> companions) selects a random restaurant name
        //from a list of strings, print to console that the employee at that restaurant,
        //and ordered the specified food, with the first name of the teammates specified in the list.
        public void Eat(string food, List<Employee> companions)
        {
            Eat(companions);
            Console.WriteLine($"and I'm eating {food}");
        }
    }
}
