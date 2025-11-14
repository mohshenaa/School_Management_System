using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    [Table("Transport Assignments ")]
    public class TransportAssignments
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [ForeignKey("Students")]
        public int StudentId { get; set; }

        [Required]
        [ForeignKey("TransportRoutes")]
        public int RouteId { get; set; }


        [Required]
        [DisplayName("Pickup Point")]
        public string PickupPoint { get; set; } = default!;


        public List<Students> Students { get; set; } = new();
        public List<TransportRoutes> TransportRoutes { get; set; } = new();

    }
}
//id(PK)
//student_id(FK)
//    route_id(FK)
//pickup_point