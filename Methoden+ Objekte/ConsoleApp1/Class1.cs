using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program 
{
    class Methoden
    {
        string name;
        string alt;
        string stadt;
        public void SetDaten(string name1, string alt1, string stadt1)
        {
            name = name1;
            alt = alt1;
            stadt = stadt1;
        }
        public void Methode1()
        {
            Console.WriteLine("Sehr geehrte Damen un Herren, \n");
            Console.WriteLine("ich heiße " + name + "\n");
            Console.WriteLine("Ich bin " + alt + " Jahre alt\n");
            Console.WriteLine("Ich wohne in " + stadt + " \n\n");
        }
    
        public void Methode2()
        {

            Console.WriteLine("Ich studiere Ingnieurwesen an der Jade hs und wohne in Deutschland seit mehr Jahren etc....\n");
            Console.WriteLine("********************************\n\n");
        }
        
    }

}
