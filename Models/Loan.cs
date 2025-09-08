using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    [Table("Loans")]
    public class Loan
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Book")]
        [Column("BookId")]
        public int BookId { get; set; }
        public Book? Book { get; set; }

        [Display(Name = "Author")]
        [Column("AuthorId")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        [Display(Name = "LoanDate")]
        [Column("LoanDate")]
        public DateTime LoanDate { get; set; }

        [Display(Name = "ReturnDate")]
        [Column("ReturnDate")]
        public DateTime ReturnDate { get; set; }
    }
}
