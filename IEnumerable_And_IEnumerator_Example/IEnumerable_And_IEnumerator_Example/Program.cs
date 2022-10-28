using System;
using System.Collections;

namespace IEnumerableAndIEnumerator
{
    class Program
    {
        //IEnumerable <T> for generic collections
        //IEnumerable for non genecric collections





        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dogs in shelter)
            {
                if (!dogs.IsNaughrDog)
                {
                    dogs.GiveTreat(2);
                }
                else
                    dogs.GiveTreat(1);
            }
        }
    }

    class Dog
    {
        public string Name { get; set; }

        public bool IsNaughrDog { get; set; }

        public Dog(string name, bool isNaughrDog)
        {
            Name = name;
            IsNaughrDog = isNaughrDog;
        }

        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name, numberofTreats);
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Serval", true)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
