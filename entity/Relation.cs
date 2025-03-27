using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class Relation
    {
        public static void Main(string[] args)
        {
            ShowTeamWithPerson();
            Console.ReadLine();
        }
        public static void InsertPersonFor1()
        {
            Console.WriteLine("podaj nazwe osoboy");
            string name = Console.ReadLine();
            using var context = new DBContextMain();
            //context.AddRangeAsync
            context.Playeres.Add(new Player() { Name = name, CreatedTime = DateTime.Now, team = context.Teams.Find(1) });
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            context.SaveChanges();
        }
        public static void ShowTeamWithPerson()
        {

            using var context = new DBContextMain();
            var data = context.Teams.Include(Y => Y.Playeres).ToList();
            //theninclude
            foreach (var item in data)
            {
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Playeres)
                {
                    Console.WriteLine($"{item.Name}>>{item2.Name}");
                }
            }
        }
        public static void ShowTeamWithPersonLazy()
        {

            using var context = new DBContextMain();
            var data = context.Teams.Include(Y => Y.Playeres);
            //theninclude
            foreach (var item in data)
            {
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Playeres)
                {
                    Console.WriteLine($">>{item2.Name}");
                }
            }
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);

        }
    }
}
