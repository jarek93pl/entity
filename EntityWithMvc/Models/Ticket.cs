using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityWithMvc.Models
{
    public class Ticket
    {
        //public static readonly string namezz = "ddd";
        [StringLength(100)]
        //
        [Display(Name = "namezz")]
        [MaxLength(),Column(TypeName ="varchar(15)")]
        public string MyProperty { get; set; }

        [Length(2,14)]
        [EmailAddress]
        public string Emile { get; set; }

        public int Id { get; set; }
    }
}
