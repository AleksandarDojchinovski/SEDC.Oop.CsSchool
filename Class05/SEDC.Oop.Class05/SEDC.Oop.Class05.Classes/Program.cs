using SEDC.Oop.Class05.Classes.Models;
using System;

namespace SEDC.Oop.Class05.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 27;
            person.Name = "Aleksandar";
            person.Talk("Hello world!");
            Person person1 = new Person()
            {
                Age = 26,
                Name = "Martin"
            };
            person1.Talk("Hello Students!");
            Person person2 = new Person("Bob", 23);
            person2.Talk("Bob is my name");

            Human aleksandar = new Human("Aleksandar", "Dojchinovski", 27);

            aleksandar.GetPersonStats();

            Human alek = new Human("Martin", "Gonev", 26);
            HumanInfoResult result = alek.GetHumanInfo();
            Console.WriteLine(string.Format("{0} {1}", result.FullName, result.Age));
            Console.ReadLine();
        }
    }
}
