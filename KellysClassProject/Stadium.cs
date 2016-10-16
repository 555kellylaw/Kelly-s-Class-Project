using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellysClassProject
{
    static class Stadium
    {
        #region Properties
        public static string Name { get; set; }
        public static string Location { get; set; }
        ///<summary>
        ///Collection of coaches
        ///</summary>
        
        public static List<Coach> Coaches { get; set; }
        #endregion

        #region Constructors
        static Stadium()
        {
            Coaches = new List<Coach>();
        }
        #endregion

        #region Methods
        public static void AddCoach(Coach coach)
        {
            using (var model = new StadiumModel())
            {
                model.Coaches.Add(coach);
            }
                
        }
        public static void PrintCoaches()
        {
            foreach (var coach in Coaches)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}, Sport: {3}",
                    coach.FirstName, coach.LastName, coach.Sport);

            }
        }
        #endregion
    }
}
