using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Classes.Models
{
    public class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public void GetPersonStats()
        {
           Console.WriteLine($"{Name} {LastName} is {Age} years old");
        }

        public Human(string firstName, string lastName, int age)
        {
            Name = firstName;
            LastName = lastName;
            Age = age;
        }

        public HumanInfoResult GetHumanInfo()
        {
            HumanInfoResult hir = new HumanInfoResult
            {
                Age = Age,
                FullName = string.Format("{0} {1}", Name, LastName)
            };
            return hir;
        }
    }
}
