using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_LexiconDotNet
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        //Skapa ny person
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person newPerson = new Person
            {
                Age = age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight
            };

            return newPerson;
        }

        public void ChangeAge(Person person, int newAge)
        {
            person.Age = newAge;
        }

        public void ChangeFirstName(Person person, string newFirstName)
        {
            person.FName = newFirstName;
        }

        public void ChangeLastName(Person person, string newLastName)
        {
            person.LName = newLastName;
        }

        public void ChangeHeight(Person person, double newHeight)
        {
            person.Height = newHeight;
        }

        public void ChangeWeight(Person person, double newWeight)
        {
            person.Weight = newWeight;
        }

        public void DisplayPersonInfo(string label,Person person)
        {
            Console.WriteLine($"{label}: {person.FName} {person.LName}, Age: {person.Age}, Height: {person.Height} cm, Weight: {person.Weight} kg");
        }
    }
}


