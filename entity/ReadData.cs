using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class ReadData
    {
        /*
        public static void Main(string[] args)
        {
            ReadData r = new ReadData();
            Console.WriteLine("program started");
            r.StartWithQuereble(null);
            r.StartWithQuereble("l");

            Console.WriteLine("program sie skonczyl");
            Console.ReadLine();
        }
        */
        //https://github.com/trevoirwilliams/EntityFrameworkCoreFullTour/tree/02aa80b3dd979525ebcbd5013248bdac7aeeafcc
        void StartWithQuereble(string s)
        {

            using var context = new DBContextMain();
            //var ts = context.Teams.Where(X => X.Name.Contains(s));
            var ts = context.Teams.AsQueryable();
            if (s != null)
            {
                ts = ts.Where(X => EF.Functions.Like(X.Name, $"%{s}%"));
            }
            foreach (var item in ts)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(item.Name);
                Console.ResetColor();
            }
        }
        async Task SelectNoTracking()
        {// is not requried to make invocation to db

            using var context = new DBContextMain();
            //var ts = context.Teams
            var ts = context.Teams.AsNoTracking().Select(X => new { X.Name, X.ID });
            foreach (var item in ts.ToList())
            {
                Console.WriteLine();
                Console.WriteLine(">>>>>>>>>>>>>>>>   " + item);
            }

        }

        async Task Select()
        {

            using var context = new DBContextMain();
            //var ts = context.Teams
            var ts = context.Teams.Select(X => new { X.Name, X.ID });
            foreach (var item in ts.ToList())
            {
                Console.WriteLine();
                Console.WriteLine(">>>>>>>>>>>>>>>>   " + item);
            }

        }

        async Task OrderBy()
        {

            using var context = new DBContextMain();
            //var ts = context.Teams.Where(X => X.Name.Contains(s));
            var ts = context.Teams.OrderBy(X => X.Name);
            foreach (var item in ts.ToList())
            {
                Console.WriteLine();
                Console.WriteLine(">>>>>>>>>>>>>>>>   " + item.Name);
            }

        }

        async void GroupBy()
        {

            using var context = new DBContextMain();
            //var ts = context.Teams.Where(X => X.Name.Contains(s));
            var ts = context.Teams.GroupBy(X => X.MyProperty);

            foreach (var item in ts.ToList())
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine(item.Key + " " + item.Count());
            }

        }
        async Task<int> CountTeams(string s)
        {

            using var context = new DBContextMain();
            //var ts = context.Teams.Where(X => X.Name.Contains(s));
            var ts = context.Teams.CountAsync(X => EF.Functions.Like(X.Name, $"%{s}%"));
            return ts.Result;

        }
        void StartWith(string s)
        {

            using var context = new DBContextMain();
            //var ts = context.Teams.Where(X => X.Name.Contains(s));
            var ts = context.Teams.Where(X => EF.Functions.Like(X.Name, $"%{s}%"));
            foreach (var item in ts)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(item.Name);
                Console.ResetColor();
            }
        }
        async Task GetOneTime()
        {

            using var context = new DBContextMain();
            Team t = await context.Teams.FirstAsync();
            Console.WriteLine(t);
        }
        async Task FindByIndex(int id)
        {

            using var context = new DBContextMain();
            var t = await context.Teams.FindAsync(id);
            Console.WriteLine(t);
        }
        void AddTeam()
        {
            using var context = new DBContextMain();
            Console.WriteLine("get time name");
            context.Teams.Add(new Team() { Name = Console.ReadLine(), CreatedTime = DateTime.Now });
            context.SaveChanges();
        }
        void GetAllTeams()
        {
            var context = new DBContextMain();

            foreach (var item in context.Teams)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}