using System;

namespace SEDC.Oop.Class03.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[4] = 5;


            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[4]);

            // numbers[5] = 10;

            string[] names = new string[]
            {
                "Aleksandar",
                    "Martin",
                    "Trajan",
                    "Maja",
                    "Ilija"
            };

            //names[4] = "Bob";

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            bool[] booleans = new[] { true, false, true };

            double[] doubles = { 1.1, 2.2, 3.3, 4.4 };

            //int[] test = new int[] { };  CANNOT 

            //    test[1] = 10;            DO

            //Console.WriteLine(test[1]);

            string[] names1 = new string[]
            {
                "Aleksandar",
                    "Martin",
                    "Trajan",
                    "Maja",
                    "Ilija"
            };

            int lengthOfArray = names1.Length;

            for(int i = 0; i < names1.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }

            int indexOnAleksandar = Array.IndexOf(names1, "Aleksandar");

            Console.WriteLine("The index is " +indexOnAleksandar);
            Console.WriteLine("The value is " + names1[indexOnAleksandar]);

            Array.Resize(ref names1, 6);

            names1[4] = "Bob";
            names1[5] = "Jill";

            Array.Sort(names1);

            for (int i = 0; i < names1.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }

            foreach(string element in names1)
            {
                Console.WriteLine("Foreach with names: "+ element);
            }

            foreach (string name in names1)
            {
                if (name == "Aleksandar")
                {
                    continue;
                }
                if (name == "Ilija")
                {
                    break;
                }
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
