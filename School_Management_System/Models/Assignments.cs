using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Assignments
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Classes")]
        public int ClassId { get; set; }
     
        [Required]
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
     
        [Required]
        [ForeignKey("Subjects")]
        public int SubjectId { get; set; }
       

        public string Title { get; set; } = default!;

        public string Description { get; set;} = default!;

        public DateOnly DueDate { get; set; }


        //neviagtion
        public Teachers Teachers { get; set; } = default!;

        public List<Classes> Classes { get; set; } = new();

        public List<Subjects> Subjects { get; set; } = new();

    }
}
//assignment_id(PK)
//class_id(FK)
//subject_id(FK)
//teacher_id(FK)
//title
//description
//due_date
