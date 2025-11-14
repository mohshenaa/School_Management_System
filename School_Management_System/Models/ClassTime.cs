using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    [Table("Class Time")]
    public class ClassTime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Classes")]
        public int ClassId { get; set; }
        public Classes Classes { get; set; } = default!;


        [Required]
        [ForeignKey("Sections")]
        public int SectionId { get; set; }
        public Sections Sections { get; set; } = default!;

        public string Day { get; set; } = default!;//weeks day


        [Required]
        public TimeOnly Start { get; set; }//class start time 

        [Required]
        public TimeOnly End { get; set; }//class end time 

        public string Period { get; set; } = default!; //1st,2nd.... period

        [DisplayName("Room Num")]
        public string Room { get; set; } = default!;

        [Required]
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }

        public Teachers Teachers { get; set; } = default!;


        [Required]
        [ForeignKey("Subjects")]
        public int SubjectId { get; set; }

        public Subjects Subjects { get; set; } = default!;


    }
}
//id(PK)
//class_id(FK)
//section_id(FK)
//day
//period
//subject_id (FK)
//teacher_id (FK)
//room