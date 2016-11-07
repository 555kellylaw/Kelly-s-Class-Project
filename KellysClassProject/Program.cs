using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellysClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to STADIUM COACH & Team FINDER");
            int choice = -1;
            bool invalidChoice = false;
            while (choice != 0 || invalidChoice )
            {
                Console.WriteLine("1. Add a coach to Stadium");
                Console.WriteLine("2. Add a sport to Stadium");
                Console.WriteLine("3. Add a team to Stadium");
                Console.WriteLine("0. Exit");
                Console.Write("Please choose an option:  ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    invalidChoice = true;
                    Console.WriteLine("Invalid choice.  Try again...");
                    continue;
                }
                invalidChoice = false;
                switch (choice)
                {
                    case 1:
                        Console.Write("Last Name: ");
                        var LastName = Console.ReadLine();
                        Console.Write("First Name: ");
                        var FirstName = Console.ReadLine();
                        Console.Write("Sport: ");
                        var coach = Console.ReadLine();

                        var Coach = new Coach();
                        Coach.LastName = LastName;
                        Coach.FirstName = FirstName;
                        
                        Coach.ID = 1;
                        break;
                        
                }
            Stadium.PrintCoaches();
            }
        }
    }
}
