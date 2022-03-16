using System;

namespace SEDC.Oop.Class04.Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHello();
            int result = Sum(1, 2);
            Console.WriteLine(result);
            string strResult = WelcomeUser("Aleksandar", 27, true);
            Console.WriteLine(strResult);
            int res = MultiplyDivide("/", 10, 5);
            Console.WriteLine(res);

            Console.ReadLine();

        }

        static void SayHello()
        {
            Console.WriteLine("Hello SEDC!");
        }
        private static int Sum(int a, int b)
        {
            //int result = a + b;
            //return result;

            return a + b;
        }

        internal static string WelcomeUser(string userName, int age, bool shouldBeColored)
        {
            if (shouldBeColored)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            string str = string.Empty;
            if (age > 30)
            {
                str = "Welcome mr." + userName;
            }
            else
            {
                str = "Welcome " + userName;
            }
            return str;
        }

        static int MultiplyDivide(string askToMultyOrSub, int firstNum, int secondNum)
        {
            int res = 0;
            if (askToMultyOrSub == "*")
            {
                res = firstNum * secondNum;
            }
            else if (askToMultyOrSub == "/") 
            {
                res = firstNum / secondNum;
            }
            else
            {
                Console.WriteLine("Error");
            }
            return res;
        }





    }
}
