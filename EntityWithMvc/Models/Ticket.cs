using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityWithMvc.Models
{
    public class Ticket
    {
        [MaxLength(),Column(TypeName ="varchar(15)")]
        public string MyProperty { get; set; }

        public int Id { get; set; }
    }
}
