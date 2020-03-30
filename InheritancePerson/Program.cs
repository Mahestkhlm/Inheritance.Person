using System;

namespace InheritancePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Person Details using Encapsulation");
                Console.WriteLine("-----------------------------------");
                //new object for the personhandlar and 
                Personhandlar handler = new Personhandlar();

                Person person = handler.CreatePerson(8, "ANANYA", "MOHAN", 1.40, 20);
                Person person1 = handler.CreatePerson(3, "AHALYA", "MOHAN", 1.10, 10);

                //setting age and weigth using setAge and setWeight for the person 1,2
                handler.SetAge(person, 9);
                handler.SetWeight(person, 29);
                handler.SetAge(person1, 4);
                handler.SetWeight(person1, 16);


                // Adding the person to the list
                Console.WriteLine(" The Person List:");
                Console.WriteLine(" -----------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"Name:{person.Fname}{person.Lname} , Age: {person.Age} years old, Weight: {person.Weight}  kg,Length:{person.Height}meter");
                Console.WriteLine($"Name:{person1.Fname}{person1.Lname},Age: {person1.Age} years old,weight: {person1.Weight} kg,Length:{person1.Height}meter");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n\n Press Any key to exit");
                Console.ReadKey();

            }

        }
    }
}
