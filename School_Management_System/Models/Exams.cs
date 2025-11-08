using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace School_Management_System.Models
{
    public class Exams
    {
        [Key]
        public int ExamId { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string ExamName { get; set; } = default!;


        [Required]
        public int ClassId { get; set; }


        [Required]
    [EnumDataType(typeof(Term))]
        public Term Term { get; set; } 


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }


        [Required]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }


        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Type { get; set; } = default!;


        public Classes Class { get; set; } = new();
    }
    public enum Term
    {
        Midterm,
        Final
    }
}

//exam_id(PK)
//name
//class_id(FK)
//term
//start_date
//end_date
//type (Midterm/Final)
