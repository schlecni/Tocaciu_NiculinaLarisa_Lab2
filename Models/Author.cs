using System.ComponentModel.DataAnnotations;

namespace Tocaciu_NiculinaLarisa_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]

        // Proprietate de navigare (Un Autor -> Multe Car?i)
       
        public string FullName // proprietate read-only pentru a ob?ine numele complet al autorului
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }
        public ICollection<Book>? Books { get; set; }

    }
}
