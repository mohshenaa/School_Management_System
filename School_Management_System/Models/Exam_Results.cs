using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Exam_Results
    {
        [Key]
        public int ResultId { get; set; }

        [Required]
        public int ExamId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [Required]
        public float MarksObtained { get; set; }

        [Required]
        public string Grade { get; set; } = default!;

        public string? Remarks { get; set; }   //what is remarks?


        [Required]
        public Exams Exam { get; set; } = new();

        [Required]           
        public Students Student { get; set; } = new();

        [Required]
        public Subjects Subject { get; set; } = new();

        //public static string GetGrade(float marks)
        //{
        //    if (marks >= 90)
        //        return "A+";
        //    else if (marks >= 80)
        //        return "A";
        //    else if (marks >= 70)
        //        return "B+";
        //    else if (marks >= 60)
        //        return "B";
        //    else if (marks >= 50)
        //        return "C";
        //    else if (marks >= 40)
        //        return "D";
        //    else
        //        return "F";
        //}
    }
}
//result_id(PK)
//exam_id(FK)
//    student_id(FK)
//subject_id(FK)
//marks_obtained
//grade
//remarks
