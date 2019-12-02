using System;

namespace csharp_1si
{
    public enum Genders { Male, Female };

    public class Person
    {
        private String name;
        private int age;
        private Genders gender;

        public Person(String name, int age, Genders gender){
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person(){}

        public String Name { get; set; }

        public int Age {get; set; }

        public Genders Gender {get; set; }
        

       public override String ToString()
        {
            return Name + " the name " + Age + " age " + Gender + " gender";
        }
    }
}
