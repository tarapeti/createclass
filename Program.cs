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


            Employee Kovacs = new Employee("Gizi", 50, Genders.Female, 100, "takarító", new Room(1));
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
