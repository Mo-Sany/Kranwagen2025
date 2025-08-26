
using System;
using System.Net.Mail;

namespace Program
{

    class MyClass
    {
        static double Methode1(double x, double y )
        {
            return x * y;

        }
        static void Main(string[] args)
        {

            
           
            Console.WriteLine("Gib bitte Zwei Zahlen ein:\n");

            Console.WriteLine("Erste Zahl:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zweite Zahl:");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = Methode1(x,y);
            Console.WriteLine("Das Ergebnis der Multiplikation=\n" + z);


            Console.ReadLine(); 

        }
    }
}