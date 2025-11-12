using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace School_Management_System.Models
{
    public class Exams
    {
        [Key]
        public int ExamId { get; set; }


        [Required]
        [ForeignKey("Classes")]
        public int ClassId { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Exam")]
        public string ExamName { get; set; } = default!;


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
        [EnumDataType(typeof(Type))]
        public Type Type { get; set; } 


        //navigation link

        public IList<Classes> Class { get; set; } = [];
    }
    public enum Term
    {
        Midterm,
        Final
    }

    public enum Type
    {
        Written,
        Mcq,
        Practical,
        Viva
    }
}

//exam_id(PK)
//name
//class_id(FK)
//term
//start_date
//end_date
//type (Midterm/Final)
