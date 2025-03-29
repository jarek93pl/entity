using FiszkiDataBase;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace entity
{
    public class RawSql
    {

        public static void Main(string[] args)
        {
            RawSql r = new RawSql();
            Console.WriteLine("program started");
            r.UseSqlDataBase();
            Console.WriteLine("program sie skonczyl");
            Console.ReadLine();
        }

        public void UseSql()
        {
            Foryoutube2Context foryoutube = new Foryoutube2Context();
            var z = foryoutube.TeachSetsFiches.ToList();
            var blogNames = foryoutube.NextFiche.FromSqlRaw("NextFicheToTeach 10").ToList().First();// property are very inportnet, need add entity 
            Console.WriteLine($"IdTeachSet {blogNames.IdTeachSet} idfich {blogNames.IdFiche}");

        }
        public void UseSqlDataBase()
        {
            var formattableString = FormattableStringFactory.Create("NextFicheToTeach 10");

            Foryoutube2Context foryoutube = new Foryoutube2Context();
            var z = foryoutube.TeachSetsFiches.ToList();
            var blogNames = foryoutube.Database.SqlQuery<NextFiche>(formattableString).ToList().First();// property are very inportnet
            Console.WriteLine($"IdTeachSet {blogNames.IdTeachSet} idfich {blogNames.IdFiche}");

        }
    }
}
