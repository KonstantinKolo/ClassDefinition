using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Name = "Konstantin";
            personOne.Age = 16;

            Person personTwo = new Person();
            personTwo.Name = "Vasko";
            personTwo.Age = 15;

            Person personThree = new Person();
            personThree.Name = "Aleks";
            personThree.Age = 19;

            personOne.IntroduceYourself();
            personTwo.IntroduceYourself();
            personThree.IntroduceYourself();
        }
    }
}
