using School_Management_System.Models;
using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }


        [Required]
        public int ClassId { get; set; }


        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string SubjectName { get; set; } = default!;


        [Required]
        [StringLength(20, MinimumLength = 1)]   
        public string SubjectCode { get; set; } = default!;


        [Required]
        public bool IsOptional { get; set; }


        [Required]
        public Classes Class { get; set; } = new();
       

    }
}

//subject_id(PK)
//class_id(FK → Classes)
//subject_name
//subject_code
//is_optional (boolean)

