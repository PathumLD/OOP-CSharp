using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student : Person
    {
        public int stuID;
        public int uniID;
    }

    public void study()
    {

    }

    //method overriding
    public void sleep(int bedSize)
    {
        Console.WriteLine("This is the child");
    }
}

