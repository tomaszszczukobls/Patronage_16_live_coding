using System;

namespace Patronage_16.Model
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Person(String First, String Last)
        {
            FirstName = First;
            LastName = Last;
        }

    }
}
