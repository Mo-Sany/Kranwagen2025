
using System;
using System.Net.Mail;

namespace Program
{
    
    class Program
    {
         static void Main(string[] args)
        {
            string name1 = "Mohamed";
            string alt1 = "21";
            string stadt1 = "Wilhelmshaven";
           
            string name2 = "Abu";
            string alt2 = "26";
            string stadt2 = "Wilhelmshaven";
            
            string name3 = "Havila";
            string alt3 = "21";
            string stadt3 = "Wilhelmshaven";

            Methoden.Methode1(name1, alt1, stadt1);
            Methoden.Methode2();
            Methoden.Methode1(name2, alt2, stadt2);
            Methoden.Methode2();
            Methoden.Methode1(name3, alt3, stadt3);
            Methoden.Methode2();

            Console.ReadLine();

        }
    }
}