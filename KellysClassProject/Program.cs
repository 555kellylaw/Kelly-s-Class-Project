﻿using System;
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
         //   var coach = new Coach ();
            Coach.ID = 001;
            Coach.LastName = "Habelow";
            Coach.FirstName = "Eileen";
            Coach.Sport = "Field Hockey";

            Stadium.AddCoach(coach);

            Stadium.PrintCoaches();

            


            Stadium.PrintCoaches();
        }
    }
}
