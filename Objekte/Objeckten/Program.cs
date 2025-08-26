
using System;
using System.Net.Mail;
using System.Threading.Channels;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();

            human1.Name = "Mohamed";
            human1.age = 21;


            human1.TheAge();
            human1.Eat();
            human1.Sleep();

            WHV whv = new WHV ("Wilhelmshaven");
            Console.WriteLine(whv.NameDerStadt);


            Console.ReadLine();
        }
    }
    class Human
    {
        public string Name;
        public int age;
        public void TheAge()
        {
            Console.WriteLine( Name+" is "+ age + " years Old" );

        }
        public void Eat() 
        {
            Console.WriteLine( Name+ " is Eating");
            
        }
        public void Sleep()
        {
            Console.WriteLine(Name+ " is Sleeping" );
        }
    }
    class WHV
    {
        public string NameDerStadt { get; set; }

        public WHV(String Stadt)
        {
            NameDerStadt = Stadt;
        }
    }
}