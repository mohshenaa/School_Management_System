using School_Management_System.SecurityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{

    [Table("Books Issued")]
    public class Issued_Books
    {

        [Key]
        public int Id { get; set; }


        [ForeignKey("Books")]
        public int BookId { get; set; }

        [ForeignKey("Students")]
        public int StudentId { get; set; }


        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime IssueDate { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }

        public decimal Fine {  get; set; }

        //navigation link

        public Students Students { get; set; } = default!;


        public Teachers Teachers { get; set; } = default!;

        //[NotMapped]
        //public string? StudentName => Students?.StudentName.ToString(); // to show role name


        //[NotMapped]
        //public string? TeacherName => Teachers?.TeacherName.ToString(); // jate j book niche tar nam input dile database id jabe ar display hbe name

    }
}

//id(PK)
//book_id(FK)
//issued_to(FK → Users)    ?? userid  ....student ar teacher id kno hbe na
//issue_date
//return_date
//fine
