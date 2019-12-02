using System;

namespace si1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Béla", 45, Genders.Férfi);
            Console.WriteLine(p.ToString());
        }
    }
}
