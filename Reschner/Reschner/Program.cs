using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RECHNER PROGRAMM !");
            Console.WriteLine("--------------------");
            string yo="";
            do
            {
                double n1 = 0;
            double n2 = 0;
            double result = 0;
            
                Console.Write("Enter First Number: ");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an Option:");
                Console.WriteLine("\t+\n\t-\n\t*\n\t/");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = n1 + n2;
                        break;
                    case "-":
                        result = n1 - n2;
                        break;
                    case "*":
                        result = n1 * n2;
                        break;
                    case "/":
                        if (n2 != 0){
                            result = n1 / n2;
                        }
                        else
                        {
                            Console.WriteLine("Dividing by 0 is not allowed.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        continue;
                }
                Console.WriteLine("Result = " + result);
                Console.WriteLine("Would You like to Continue?");
                yo = Console.ReadLine().ToLower();


            }
            while ( yo == "okay" || yo== "ok" || yo== "yes" || yo== "yeah" || yo == "ja" || yo== "yup"); 

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
