using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class ManipilateData
    {
        public static void Main(string[] args)
        {
            InsertTeam();
            Console.ReadLine();
        }
        public static void InsertTeam()
        {
            Console.WriteLine("podaj nazwe teamu");
            string nameTeam = Console.ReadLine();
            using var context = new DBContextMain();
            //context.AddRangeAsync
            context.AddAsync(new Team() { Name = nameTeam, CreatedTime = DateTime.Now });
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            context.SaveChanges();
        }
    }
}
