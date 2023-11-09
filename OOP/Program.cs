using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            // ENCAPSULATION

            //Creating object person1
            Person person1 = new Person();

            //Creating object person2
            Person person2 = new Person();


            //Accessing properties
            person1.name = "Pathum";
            person1.age = 26;

            person2.name = "Michelle";
            person2.age = 23;

            person1.Mobile = "Samsung";
            person2.Gender = "Female";

            //Accessing methods
            person2.eating();

            Console.WriteLine("Name is " + person1.name);
            Console.WriteLine("Age is " + person1.age);
            Console.WriteLine("Name is " + person2.name);
            Console.WriteLine("Age is " + person2.age);
            Console.WriteLine("Mobile is " + person1.Mobile);
            Console.WriteLine("Gender is " + person2.Gender);


            ---------------------------------------------------------------------------------------------------------------------------


            //Object stu1 with default constructor
            Student stu1 = new Student();

            //Object stu2 with overloaded constructor
            Student stu2 = new Student(8, "Maths");

            Console.ReadLine();
        }


        --------------------------------------------------------------------------------------------------


            //INHERITANCE

            Student student1 = new Student();
            student1.study();


            ---------------------------------------------------------------------------------------------------------------------------


            //POLYMORPHISM

            Person person1 = new Person();
            person1.sleep(20);


            ----------------------------------------------------------------------------------------------



            //INHERITANCE
            Student student1 = new Student();
            student1.sleep(bedSize);



            ----------------------------------------------------------------------------------------------------


            //ABSTRACTION

    }
}
