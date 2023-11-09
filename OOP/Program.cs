using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object person1
            Person person1 = new Person();

            //Creating object person2
            Person person2 = new Person();


            //Accessing properties
            person1.name = "Pathum";
            person1.age = 26;

            person2.name = "Michelle";
            person2.age = 23;

            Console.WriteLine("Name is " + person1.name);
            Console.WriteLine("Age is " + person1.age);
            Console.WriteLine("Name is " + person2.name);
            Console.WriteLine("Age is " + person2.age);

            Console.ReadLine();
        }
    }
}
