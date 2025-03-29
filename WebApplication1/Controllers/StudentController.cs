using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentController(NzWalksDbContext nz)
        {

        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            string[] strings = new string[] { "jarek", "Kamil", "Beata" };
            return Ok(strings);
        }

        public class z
        {
            public string type { get; set; }
            public string username { get; set; }
            public string password { get; set; }
        }
        [HttpPost]
        public IActionResult Px1([FromBody] z a)
        {
            string[] strings = new string[] { a.type, a.username, a.password };
            return Ok(strings);
        }
    }
}
