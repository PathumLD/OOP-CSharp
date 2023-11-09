using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
        public String name;
        public int age;

        private String mobile;
        private String gender;


        //Access mutators - Long method | Mobile
        public String Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }

        //Access mutators - Long method | Gender
        public String Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        //Access mutators - Short method | Mobile
        public String moblile { get; set; }

        //Access mutators - Short method | Gender
        public String gender { get; set; }

        //Removing set can be protected of change value


        public void eating()
        {
            Console.WriteLine("Hey, I am eating");
        }

        public void sleeping()
        {
            Console.WriteLine("Hey, I am sleeping");
        }
    }
}
