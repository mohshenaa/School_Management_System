using School_Management_System.Models;
using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Sections
    {
        [Key]
        public int SectionId { get; set; }

        [Required]
        public int ClassId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string SectionName { get; set; }=default!;

        [Required]
        public Classes Class { get; set; }=new();
      

    }
}
//section_id(PK)
//class_id(FK → Classes)
//section_name

