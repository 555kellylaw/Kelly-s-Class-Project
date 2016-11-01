using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellysClassProject
{
    public static class Stadium
    {
        private static object coach;
        #region Properties
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Sport { get; set; }
        ///<summary>
        ///Collection of coaches
        ///</summary>

        public static List<Coach>Coaches { get; set; }
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
                model.SaveChanges();
            }

        }
        public static void PrintCoaches()
        {
            using (var model = new StadiumModel())
            {
                foreach (var coach in model.Coaches)
                {
                    Console.WriteLine("First Name: {0}, Last Name: {1}, Sport: {3}",
                        coach.FirstName, coach.LastName, coach.Sport);

                }
            }
            #endregion
        }
    }
}

