using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");









            //Declare and initialize a List of student names
            //List<string> studentNames = new List<string>();


            //Console.WriteLine("Give me a name");
            //string name = Console.ReadLine();

            //studentNames.Add(name);
            //studentNames.Add(name);



            //foreach (string names in studentNames)
            //{
            //    Console.WriteLine(names);
            //}


            List<string> groceryList = new List<string>();


            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Give me a grocery");
                string grocery = Console.ReadLine();

                groceryList.Add(grocery);

                Console.WriteLine("Would you like to add another item? (y)es or (n)o");
                string response = Console.ReadLine().ToLower().Trim();

                if (response == "n")
                {
                    keepGoing = false;
                }
            }


            foreach (string item in groceryList)
            {
                Console.WriteLine(item);
            }

            //or

            Console.WriteLine();

            for (int i = 0; i < groceryList.Count; i++)
            {
                Console.WriteLine(groceryList[i]);
            }




            Console.ReadLine();

        }
    }
}
