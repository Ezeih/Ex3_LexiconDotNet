using MiNET.Entities.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_LexiconDotNet
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }

        

        public class Horse : Animal
        {
            public string Breed { get; set; }

            public Horse(string name, double weight, int age, string breed) : base(name, weight, age)
            {
                Breed = breed;
            }

            public Horse(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Horse sounds: Neigh!");
            }
        }

        public class Dog : Animal
        {
            public string Breed { get; set; }

            public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
            {
                Breed = breed;
            }

            public Dog(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Dog sounds: Woof!");
            }
        }

        public class Hedgehog : Animal
        {
            public string Breed { get; set; }

            public Hedgehog(string name, double weight, int age, string breed) : base(name, weight, age)
            {
                Breed = breed;
            }
            public Hedgehog(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Hedgehog sounds: Quacking!");
            }
        }


        public class Worm : Animal
        {
            public string Breed { get; set; }

            public Worm(string name, double weight, int age, string breed) : base(name, weight, age)
            {
                Breed = breed;
            }

            public Worm(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Worm sounds: Hiss!");
            }
        }


        public class Bird : Animal
        {
            public string Breed { get; set; }

            public Bird(string name, double weight, int age, string breed) : base(name, weight, age)
            {
                Breed = breed;
            }

            public Bird(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Bird sounds: Tweet!");
            }
        }

        public class Wolf : Animal
        {
            public string Breed { get; set; }

            public Wolf(string name, double weight, int age, string breed) : base(name, weight, age)
            {
                Breed = breed;
            }

            public Wolf(string name, double weight, int age) : base(name, weight, age)
            {
            }

            public override void DoSound()
            {
                Console.WriteLine("Wolf sounds: Howl!");
            }
        }

        public class Pelican : Bird
        {
            public double BeakLength { get; set; }

            public Pelican(string name, double weight, int age, double beakLength) : base(name, weight, age)
            {
                BeakLength = beakLength;
            }
        }


        public class Flamingo : Bird
        {
            public double BeakLength { get; set; }

            public Flamingo(string name, double weight, int age, double beakLength) : base(name, weight, age)
            {
                BeakLength = beakLength;
            }
        }

        public class Swan : Bird
        {
            public double BeakLength { get; set; }

            public Swan(string name, double weight, int age, double beakLength) : base(name, weight, age)
            {
                BeakLength = beakLength;
            }
        }
        public class Wolfman : Wolf, IPerson
        {
            public Wolfman(string name, double weight, int age, string breed) : base(name, weight, age, breed)
            {
            }

            public static void Dosound()
            {
                Console.WriteLine("Wolfman says: Howl!");
            }

            

          
        }

        
    }
}
       
    
