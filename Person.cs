using System;

namespace si1
{
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

        public String Name { get; set; }

        public int Age {get; set; }

        public Genders Gender {get; set; }
        

        // Method that overrides the base class (System.Object) implementation.
        public override String ToString()
        {
            return this.name + " a neve " + this.age + " éves " + this.gender + " nemű";
        }
    }
}
