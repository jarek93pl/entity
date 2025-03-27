using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class ManipilateData
    {/*
        public static void Main(string[] args)
        {
            UpdateRange();
            Console.ReadLine();
        }
        */
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
        public static void Update()
        {
            Console.WriteLine("podaj nazwe teamu");
            string nameTeam = Console.ReadLine() ?? "";
            using var context = new DBContextMain();
            //context.AddRangeAsync
            var team = context.Teams.Find(1);
            team.Name = nameTeam;//chenge only if you need
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            context.SaveChanges();
        }
        public static void UpdateRange()
        {
            Console.WriteLine("podaj nazwe teamu");
            string nameTeam = Console.ReadLine() ?? "";
            using var context = new DBContextMain();
            //context.AddRangeAsync
            context.Teams.Where(X => X.ID == 1).ExecuteUpdateAsync(X => X.SetProperty(Y => Y.Name, nameTeam));
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            context.SaveChanges();
        }
        public static void UpdateNotTracking()
        {
            Console.WriteLine("podaj nazwe teamu");
            string nameTeam = Console.ReadLine() ?? "";
            using var context = new DBContextMain();
            //context.AddRangeAsync
            var team = context.Teams.AsNoTracking().FirstOrDefault(X => X.ID == 1);
            team.Name = nameTeam;//chenge only if you need
            context.Update(team);
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            context.SaveChanges();
        }
        public static void Delete()
        {
            Console.WriteLine("podaj id");
            int id = Convert.ToInt32(Console.ReadLine());
            using var context = new DBContextMain();
            //context.AddRangeAsync
            var team = context.Teams.Find(id);
            context.Entry(team).State = EntityState.Deleted;
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            context.SaveChanges();
        }
        public static void DeleteRange()
        {
            Console.WriteLine("podaj id");
            int id = Convert.ToInt32(Console.ReadLine());
            using var context = new DBContextMain();
            //context.AddRangeAsync
            context.Teams.Where(X => X.ID == id).ExecuteDelete();
            Console.WriteLine(context.ChangeTracker.DebugView.LongView);
            context.SaveChanges();
        }
    }
}
