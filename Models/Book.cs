using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Tocaciu_NiculinaLarisa_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; } // este cheie primara

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Book Title")] // eticheta pentru interfata utilizator "title = book title"
        public string Title { get; set; }
       
        [Column(TypeName = "decimal(6, 2)")] // specifica tipul de coloana in baza de date
        [Range(0.01, 500)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)] // adnotare pentru a stoca data si ora
        public DateTime PublishingDate { get; set; } // data publicarii
        public int? PublisherID { get; set; } // chsie straina
        public Publisher? Publisher { get; set; } // proprietate de navigare
        public int? AuthorID { get; set; } // cheie straina
        public Author? Author { get; set; }   // proprietate de navigare
        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }


}

