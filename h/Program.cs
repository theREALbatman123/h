using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Age = 28 },
            new Employee { Name = "Bob", Age = 35 },
            new Employee { Name = "Charlie", Age = 42 },
            new Employee { Name = "David", Age = 24 },
            new Employee { Name = "Jeremiah", Age = -5},
            new Employee {Name = "Uvuvwevwevwe Onyetrnyevwem Ossas", Age = 846311984}
        };

        var prumerVek = employees
            .Where(e => e.Age > 25)
            .Average(e => e.Age);

        Console.WriteLine("Průměrný věk lidí starších než 5 a 20 je:" + prumerVek);
        Console.WriteLine("pořád voda 💀💀💀 + adranelin + ti co ví");
    }
}