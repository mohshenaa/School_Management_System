using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Classes
    {
        [Key]
        public int ClassId { get; set; }


        [Required]
        public string Name { get; set; }=default!;

        [Required]
        public string SessionYear { get; set; } = default!;



    }
}
//class_id(PK)
//class_name
//session_year

