using System;

namespace OOP
{

	class Student
	{

        public string name;
        public int age;

        public int grade;
        public string subject;

        //Default constructor

        public Student()
        {

        }

        //Overloaded constructor

        public Student(int grade, string subject)
        {
            this grade = grade;
            this subject = subject;
        }
    }

}
