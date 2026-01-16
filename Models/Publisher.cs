namespace Tocaciu_NiculinaLarisa_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; } // primary key
        public string PublisherName { get; set; } // numea editurii
        public ICollection<Book>? Books { get; set; } // proprietate de navigare pentru colectia de carti publicate

    }
}

