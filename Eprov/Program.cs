using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Program
    {
        
        static void Main(string[] args,)
        {
          
           Console.WriteLine("Welcome to superhero academy, your super power is : " + Superpowergenerator());
           
            Console.WriteLine("Choose your characters name");
            Console.ReadLine();

           
        }


        static string Superpowergenerator()
        {
            string characterpower = "";
            Random generator = new Random();
            int superpower = generator.Next(1, 3);
            if (superpower == 1)
            {
                characterpower = "water";
                Water w1 = new Water();
                w1.name = Console.ReadLine();
              
                Console.WriteLine(w1.name + " casted the spell" + );
                Console.ReadLine();

            }
            else if (superpower == 2)
            {
                characterpower = "fire";
                Fire f1 = new Fire();
                f1.name = Console.ReadLine();
            }
            else
            {
                Air a1 = new Air();
                a1.name = Console.ReadLine();
            }

            return characterpower;

        }

        

        


    }





}
  