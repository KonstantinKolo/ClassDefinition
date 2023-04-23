using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefinition
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine("This is {0} and he is {1}", name, age);
        }
    }
}
