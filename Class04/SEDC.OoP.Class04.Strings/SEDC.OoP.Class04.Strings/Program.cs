using System;

namespace SEDC.OoP.Class04.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Aleksandar";
            string hello1 = "Hello " + name;
            string hello2 = string.Format("Hello {0}", name); // Hello Aleksandar
            string hello3 = $"Hello {name}";


            Console.WriteLine("Hello1: "+ hello1);
            Console.WriteLine(string.Format("Hello: {0}", hello2));
            Console.WriteLine($"Hello3: {hello3}");

            string path = "Check your c:\\ drive";
            string a = "We will have \"fair\" elections";
            string b = "The \\n \n sign means : new line";
            Console.WriteLine(path);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string path1 = @"Check your c:\ drive";
            string aa = @"We will have ""fair"" elections";
            string bb = @"The \n sign means: new line";

            Console.WriteLine(path1);
            Console.WriteLine(aa);
            Console.WriteLine(bb);

            string filePath = @"system\windows";
            string cc = $@"Check your c:\{filePath} drive";

            Console.WriteLine(cc);
            Console.WriteLine("================================");
            string myStringCurrency = string.Format("{0:C}",105.5);
            Console.WriteLine(myStringCurrency);

            int phoneNumber = 077132123;
            // 077-132-123
            string formatedNumber = string.Format("{0:0##-###-###}", phoneNumber);
            Console.WriteLine(formatedNumber);

            string formatWithMultiplieStrings = string.Format("{0} {1} {2} {3} {4} {5}","Hello","my","name","is","Slim","Shady");
            Console.WriteLine(formatWithMultiplieStrings);

            string ourString = "              We are learning C# and it is FUN and EZ, Okay maybe just FUN.             ";
            Console.WriteLine(ourString);
            string lowerLetters = ourString.ToLower();
            Console.WriteLine(lowerLetters);
            string upperLetters = lowerLetters.ToUpper();
            Console.WriteLine(upperLetters);

            string[] splited = ourString.Trim().Split(' ');
            Console.WriteLine("The length is: "+ splited.Length);
            
            foreach(string word in splited)
            {
                Console.WriteLine(word);
            }

            string subString = ourString.Substring(30, 50);

            Console.WriteLine(subString);


            string testIt = SubString(20);
            Console.WriteLine(testIt);



            Console.ReadLine();
        }

        static string SubString(int userInput) {

            string helloSedc = "Hello from SEDC Codeacademy 2021";
            string newHelloSedc = helloSedc.Substring(0, userInput);
            return newHelloSedc;
        }




    }
}
