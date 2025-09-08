using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    [Table("Authors")]
    public class Author
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Column("Name")]
        public string? Name { get; set; }

        [Display(Name = "Nationality")]
        [Column("Nationality")]
        public string ? Natiolality { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
