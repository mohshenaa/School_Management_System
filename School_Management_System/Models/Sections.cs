using School_Management_System.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Sections
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   //SectionId jate auto generate na hoy
        public int SectionId { get; set; }

        [Required]
        [ForeignKey("Classes")]
        public int ClassId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1)]
        [Display(Name ="Section")]
        public string SectionName { get; set; }=default!;

        //navigation links

        [Required]
        public Classes Class { get; set; }=new();
      

    }
}
//section_id(PK)
//class_id(FK → Classes)
//section_name

