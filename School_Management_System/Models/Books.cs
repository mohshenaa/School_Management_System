using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = default!;


        public string Author { get; set; } = default!;

        public string ISBN { get; set; } = default!;

        [Required]
        public string Category { get; set; } = default!;

        [Required]
        public int TotalCopy { get; set; }
        public int AvailbleCpoy { get; set; }

    }
}
//book_id(PK)
//title
//author
//isbn
//category
//total_copies
//available_copies
