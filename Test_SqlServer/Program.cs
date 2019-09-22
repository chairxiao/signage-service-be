using InfoplayDB.Models;
using System;
using System.Linq;

namespace Test_SqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vars = new int[] { 1, 2, 3, 4, 5, 6 };
            var q1 = from i in vars
                     where i > 5
                     select i;
            using (var db = new InfoplayContext())
            {
                var q2 = db.PlayerStatus.Where(p => p.PlayerId > 0);

                var counter = q2.Count();
           
                Console.WriteLine($"counter:{counter}");
                Console.ReadLine();
            }
        }
    }
}
