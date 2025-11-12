using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    [Table("Hostel Residents")]
    public class Hostel_Residents
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Students")]
        public int StudentId { get; set; }

        [Required]
        [ForeignKey("Hostel")]
        public int HostelId { get; set; }


        public string RoomNo { get; set; } = default!;


        [DisplayName("Check In Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckInDate { get; set; }


        //navigation link

        public Students Students { get; set; } = default!;
        public Hostel Hostel { get; set; } = default!;
    }
}
//id(PK)
//student_id(FK)
//hostel_id(FK)
//room_no
//check_in_date
