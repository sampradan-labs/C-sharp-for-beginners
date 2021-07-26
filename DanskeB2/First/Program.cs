using System;

namespace First
{
    class Program
    {
        static int initBalance = 0;
        static void Main(string[] args)
        {
            //PlayingWithConsole();
            //FunWithDataTypes();
            //WithConditions();
            //UseContinue();
            Register();
            Credit(100);
            Debit(50);
            // if
            // switch
            Console.ReadKey();  //Waits until a keyboard key is pressed
        }

        private static void Debit(int v)
        {
            initBalance -= v;
            Console.WriteLine($"New balance after debit: {initBalance}");
        }

        private static void Credit(int v)
        {
            initBalance += v;
            Console.WriteLine($"New balance after credit: {initBalance}");
        }

        private static void Register()
        {
            Console.WriteLine("Enter details for registration");
            Console.WriteLine("Name:");
            string name =Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Balance:");
            initBalance = Convert.ToInt32(Console.ReadLine());  //Type conversion - Has a algorithm for conversion
            decimal formattedBalance = (decimal)initBalance;      //Typecasting - There should be something in common between the 2 datatypes
            formattedBalance += 2000.75m;
            Console.WriteLine($"Balance: {formattedBalance}");
        }

        private static void UseContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    continue;
                }
                Console.WriteLine($"Printing numbers using continue: {i}");
            }
        }

        private static void WithConditions()
        {
            #region Using if-then-else
            int i = 99;
            if (i <= 100)
            {
                Console.WriteLine("Condition fulfilled");
            }
            else if(i > 100)
            {
                Console.WriteLine("i > 100 fulfilled");
            }
            else
            {
                Console.WriteLine("Condition failed");
            }
            #endregion

            #region Using ternary if
            //ternary operator ?, :
            string output = (i <= 100) ? "Condition fulfilled" : "Condition failed";
            //String interpolation
            Console.WriteLine($"Printing output by using ternary if operator: {output}");
            #endregion
            
            UseSwitch(i);
        }

        private static void UseSwitch(int i)
        {
            switch (i)
            {
                case 100:
                    Console.WriteLine($"i== 100");
                    break;

                case 98:
                case 97:
                case 99:
                    Console.WriteLine($"i== 99");
                    break;
                default:
                    break;
            }

        }

        private static void FunWithDataTypes()
        {
            var determineType = 2000d;    //double
            int i = 200;
            double d = 2000;
            string s = "Hello";
            char[] cArray = { 'H', 'e', 'l', 'l', 'o' };
            char c = 'H';
            Console.WriteLine($"Value={determineType}, Datatype={determineType.GetType()}");

            //Arrays
            int[] iArray = new int[3];
            iArray[0] = 100;
            iArray[1] = 100;
            iArray[2] = 100;

            string[] sArray = {"Eena", "Meena", "Deeka" };
            double[] dArray = { 100d,200d,300d};

            Console.WriteLine("### Using For ###");
            UseFor(sArray);

            Console.WriteLine("### Using ForEach ###");
            UseForEach(dArray);

            Console.WriteLine("### Using While ###");
            UseWhile(iArray);
        }

        private static void UseWhile(int[] iArray)
        {
            int index = 0;
            bool isComplete = false;
            while (isComplete == false)
            {
                Console.WriteLine(iArray[index]);
                index++;
                if (index == iArray.Length)
                {
                    isComplete = true;
                }
            }
        }

        private static void UseForEach(double[] dArray)
        {
            foreach (var item in dArray)
            {
                Console.WriteLine(item);
            }
        }

        private static void UseFor(string[] sArray)
        {
            for (int i = 0; i < sArray.Length; i++)
            {
                Console.WriteLine(sArray[i]);
            }
        }

        //<access-spec> <[static]> <return-type> <method-name> (<[p1]>, <[p2]>)
        static void PlayingWithConsole()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Meena. Its " + 10.59 + "am now");
            Console.WriteLine("Keep watching...");

            Console.WriteLine("##################################");
            Console.WriteLine("What's your name? ");
            var input = Console.ReadLine(); //Reads a line
            Console.WriteLine("Technique 1: Welcome " + input); //Technique 1: Welcome Deeksha
            Console.WriteLine("Technique 2: Welcome {0}!Thanks for supporting us {1}", input, input); //Technique 2: Welcome Deeksha
            Console.WriteLine($"Technique 3: Welcome {input}"); //Technique 3: Welcome Deeksha
        }
    }
}
