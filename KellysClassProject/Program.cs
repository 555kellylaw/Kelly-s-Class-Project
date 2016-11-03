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
            var coach = new coach();
            coach.ID = 001;
            coach.LastName = "Habelow";
            coach.FirstName = "Eileen";
            coach.Sport = "Field Hockey";

            Stadium.AddCoach(coach);

            Stadium.PrintCoaches();

           
            Stadium.PrintCoaches();
        }
    }
}
