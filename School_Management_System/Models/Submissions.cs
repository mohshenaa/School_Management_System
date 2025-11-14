using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Submissions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Students")]
        public int StudentId { get; set; }
      
        [Required]
        [ForeignKey("Assignments")]
        public int AssignmentId { get; set; }
      
        public string FileLink { get; set; } = default!;

        public DateOnly SubmittedDate { get; set; }

        public decimal Marks { get; set; }

        public string FeedBack { get; set; } = default!;

        public List<Students> Students { get; set; } = new();


        public List<Assignments> Assignments { get; set; } = new();

    }
}
//submission_id(PK)
//assignment_id(FK)
//student_id(FK)
//file_link
//submitted_at
//marks
//feedback