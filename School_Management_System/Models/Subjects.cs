using School_Management_System.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Subjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   //SubjectId jate auto generate na hoy
        public int SubjectId { get; set; }


        [Required]
        [ForeignKey("Classes")]
        public int ClassId { get; set; }


        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name ="Subject")]
        public string SubjectName { get; set; } = default!;


        
        [StringLength(20, MinimumLength = 1)]   
        public string SubjectCode { get; set; } = default!;


        [Required]
        public bool IsOptional { get; set; }


        //navigation links

        [Required]
        public Classes Classes { get; set; } = new();
       

    }
}

//subject_id(PK)
//class_id(FK → Classes)
//subject_name
//subject_code
//is_optional (boolean)

