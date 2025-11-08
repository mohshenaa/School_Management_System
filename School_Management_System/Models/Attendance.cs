using Microsoft.EntityFrameworkCore;
using School_Management_System.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace School_Management_System.Models
{
    public class Attendance
    {
        [Key]

        public int AttendanceId { get; set; }


        [Required]
        [ForeignKey("Students")]
        public int StudentId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [EnumDataType(typeof(Status))]
        public Status Status { get; set; }

        [Required]
        public int MarkedBy { get; set; } //teachers id?   



        public Students Student { get; set; } = new();

    }
    public enum Status
    {
        Present,
        Absent,
        Late
    }   
}
//attendance_id(PK)
//student_id(FK)
//date
//status(Present / Absent / Late)
//marked_by(FK → Teachers)
