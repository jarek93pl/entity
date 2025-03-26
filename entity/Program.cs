using DataModel;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

await FindByIndex(1);
Console.ReadLine();


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
