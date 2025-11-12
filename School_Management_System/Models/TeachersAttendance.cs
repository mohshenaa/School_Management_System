using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace School_Management_System.Models
{
    public class TeachersAttendance
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        public Status Status { get; set; } = default!;


    }
  
}
//id(PK)
//teacher_id(FK)
//date
//status
