using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Classes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   //classId jate auto generate na hoy
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

