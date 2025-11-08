using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Class_Subjects
    {
        [Key]
        public int Id { get; set; }

       
     
        public int ClassId { get; set; }
   
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public Classes Class { get; set; } = new();
        public Subjects Subject { get; set; } = new();
        public Teachers Teacher { get; set; } = new();
    }
}
//id(PK)
//class_id(FK)
//subject_id(FK)
//teacher_id(FK)
