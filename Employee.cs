using System;

namespace csharp_1si
{
    public class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;

        public Employee(string name, int age, Genders gender, int salary, string profession, Room room)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Salary = salary;
            Profession = profession;
            Room = room;

        }
        public int Salary { get; set; }

        public string Profession { get; set; }

        public Room Room { get; set; }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }

        public override string ToString()
        {
            return Name + "the name " + Age + " age " + Gender + " gender " + Salary + " salary " + Profession + " profession " + Room + " in room";
        }

    }

}