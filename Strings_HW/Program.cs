using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Teresa";
            //Console.WriteLine(firstName.Length);

            //string lastName = "Johnson";
            //Console.WriteLine(lastName.Length);


            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();


            //if (firstName.Length > lastName.Length)
            //{
            //    Console.WriteLine("First is longer!");
            //}

            //else if (firstName == lastName)
            //{
            //    Console.WriteLine("Samesies!");
            //}

            //else
            //    {
            //    Console.WriteLine("Last must be LONGER!");
            //    }

            string name1 = "Julie";
            string name2 = "Tracy";

            Console.WriteLine("Please enter your first name.");
            Console.ReadLine();

            Console.WriteLine("Please enter another first name.");
            Console.ReadLine();

            if (name1 == name2) 
            { Console.WriteLine("The names are the same.");
            }

            else
                {
                Console.WriteLine("The names are different.");
            }




                }
    }
}
