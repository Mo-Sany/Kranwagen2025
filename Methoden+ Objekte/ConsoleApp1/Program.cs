
using System;
using System.Net.Mail;

namespace Program
{
    
    class Program
    {
         static void Main(string[] args)
         {
            Methoden person1 = new Methoden();
            Methoden person2 = new Methoden();
            Methoden person3 = new Methoden();

            person1.SetDaten("Mohamed", "21", "Wilhelmshaven");
            person2.SetDaten("Abdu", "26", "Wilhelmshaven");
            person3.SetDaten("Havila", "21", "Wilhelmshaven");

            person1.Methode1();
            person1.Methode2();
            person2.Methode1();
            person2.Methode2();
            person3.Methode1();
            person3.Methode2();


            Console.ReadLine();

         }
    }
}