using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    [Table("Books")]
    public class Book
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Column("Title")]
        public string ? Title { get; set; }

        [Display(Name = "PublicationYear")]
        [Column("PublicationYear")]
        public int PublicationYear { get; set; }

        [Display(Name = "Available ")]
        [Column("Available ")]
        public bool Available { get; set; }

        [Display(Name = "Author")]
        [Column("AuthorId")]
        public int AuthorId { get; set; }

        public Author ? Author { get; set; }
        }
}
