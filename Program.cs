using System;

namespace csharp_1si
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Béla", 45, Genders.Male);
            Console.WriteLine(p.ToString());
            Employee e = new Employee("Gizi", 50, Genders.Female, 100, "takarító", new Room(1));
            Console.WriteLine(e.ToString());
        }
    }
}
